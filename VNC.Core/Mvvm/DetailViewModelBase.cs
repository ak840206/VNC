using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using Prism.Commands;
using Prism.Events;

using VNC.Core.Events;
using VNC.Core.Services;

namespace VNC.Core.Mvvm
{
    public abstract class DetailViewModelBase : EventViewModelBase, IDetailViewModel
    {
        private string _title;
        private int _id;

        private bool _hasChanges;

        public ICommand SaveCommand { get; }

        public ICommand DeleteCommand { get; }

        public ICommand CloseDetailViewCommand { get; }

        public DetailViewModelBase(
            IEventAggregator eventAggregator,
            IMessageDialogService messageDialogService) : base(eventAggregator, messageDialogService)
        {
            //long startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            SaveCommand = new DelegateCommand(
                OnSaveExecute, OnSaveCanExecute);

            DeleteCommand = new DelegateCommand(
                OnDeleteExecute, OnDeleteCanExecute);

            CloseDetailViewCommand = new DelegateCommand(
                OnCloseDetailViewExecute);

            //Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        protected virtual void PublishAfterCollectionSavedEvent()
        {
            long startTicks = Log.EVENT("Enter", Common.LOG_APPNAME);

            EventAggregator.GetEvent<AfterCollectionSavedEvent>()
                .Publish(new AfterCollectionSavedEventArgs
                {
                    ViewModelName = this.GetType().Name
                });

            Log.EVENT("Exit", Common.LOG_APPNAME, startTicks);
        }

        protected virtual void OnCloseDetailViewExecute()
        {
            long startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            if (HasChanges)
            {
                var result = MessageDialogService.ShowOkCancelDialog(
                    "You've made changes.  Close this item?", "Question");

                if (result == MessageDialogResult.Cancel)
                {
                    return;
                }
            }

            PublishAfterDetailClosedEvent();

            Log.VIEWMODEL("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void PublishAfterDetailClosedEvent()
        {
            long startTicks = Log.EVENT("Enter", Common.LOG_APPNAME);

            EventAggregator.GetEvent<AfterDetailClosedEvent>()
                .Publish(new AfterDetailClosedEventArgs
                {
                    Id = this.Id,
                    ViewModelName = this.GetType().Name
                });

            Log.EVENT("Exit", Common.LOG_APPNAME, startTicks);
        }

        public int Id
        {
            get { return _id; }
            protected set
            {
                if (_id == value)
                    return;
                _id = value;
                OnPropertyChanged();
            }
        }
     
        public string Title
        {
            get { return _title; }
            protected set
            {
                if (_title == value)
                    return;
                _title = value;
                OnPropertyChanged();
            }
        }

        public bool HasChanges
        {
            get { return _hasChanges; }
            set
            {
                if (_hasChanges != value)
                {
                    _hasChanges = value;
                    OnPropertyChanged();
                    ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
                }
            }
        }

        public abstract Task LoadAsync(int id);

        protected abstract bool OnDeleteCanExecute();

        protected abstract void OnDeleteExecute();

        protected abstract bool OnSaveCanExecute();

        protected abstract void OnSaveExecute();

        protected virtual void PublishAfterDetailDeletedEvent(int modelId)
        {
            long startTicks = Log.EVENT("Enter", Common.LOG_APPNAME);

            EventAggregator.GetEvent<AfterDetailDeletedEvent>()
                .Publish
                (
                    new AfterDetailDeletedEventArgs
                    {
                        Id = modelId,
                        ViewModelName = this.GetType().Name
                    }
                );

            Log.EVENT("Exit", Common.LOG_APPNAME, startTicks);
        }

        protected virtual void PublishAfterDetailSavedEvent(int modelId, string displayMember)
        {
            long startTicks = Log.EVENT("Enter", Common.LOG_APPNAME);

            EventAggregator.GetEvent<AfterDetailSavedEvent>()
                .Publish
                (
                    new AfterDetailSavedEventArgs
                    {
                        Id = modelId,
                        DisplayMember = displayMember,
                        ViewModelName = this.GetType().Name
                    }
                );

            Log.EVENT("Exit", Common.LOG_APPNAME, startTicks);
        }

        protected virtual async Task SaveWithOptimisticConcurrencyAsync(Func<Task> saveFunc, Action afterSaveAction)
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            try
            {
                await saveFunc();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var databaseValues = ex.Entries.Single().GetDatabaseValues();

                if (databaseValues == null)
                {
                    MessageDialogService.ShowInfoDialog(
                        "The entity has been deleted by another user.  Cannot continue.");
                    PublishAfterDetailDeletedEvent(Id);
                    return;
                }

                var result = MessageDialogService.ShowOkCancelDialog(
                    "The entity has been changed by someone else." +
                    " Click OK to save your changes anyway; Click Cancel" +
                    " to reload the entity from the database.", "Question");

                if (result == MessageDialogResult.OK)   // Client Wins
                {
                    // Update the original values with database-values
                    var entry = ex.Entries.Single();
                    entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                    await saveFunc();
                }
                else  // Database Wins
                {
                    // Reload entity from database
                    await ex.Entries.Single().ReloadAsync();
                    await LoadAsync(Id);
                }
            }

            // Do anything that needs to occur after saving

            afterSaveAction();

            Log.VIEWMODEL("Exit", Common.LOG_APPNAME, startTicks);
        }
    }
}
