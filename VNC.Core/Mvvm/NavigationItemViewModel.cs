using System;
using System.Windows.Input;

using Prism.Commands;
using Prism.Events;

using VNC.Core.Events;
using VNC.Core.Services;

namespace VNC.Core.Mvvm
{
    public class NavigationItemViewModel : EventViewModelBase
    {
        private string _displayMember;
        private string _detailViewModelName;

        // TODO(crhodes)
        // Decide if we will every need the messageDialogService.
        // This was not in Claudius.

        public NavigationItemViewModel(
            int id,
            string displayMember,
            string detailViewModelName,
            IEventAggregator eventAggregator,
            IMessageDialogService messageDialogService) : base(eventAggregator, messageDialogService)
        {
#if LOGGING
            Int64 startTicks = Log.CONSTRUCTOR($"Enter id:({id}) displayMember:({displayMember}) detailViewModelName:({detailViewModelName})", Common.LOG_CATEGORY);
#endif
            Id = id;
            DisplayMember = displayMember;
            _detailViewModelName = detailViewModelName;

            OpenDetailViewCommand = new DelegateCommand(OpenDetailViewExecute);
#if LOGGING
            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public int Id { get; set; }

        public string DisplayMember
        {
            get { return _displayMember; }
            set
            {
                if (_displayMember == value)
                    return;
                _displayMember = value;
                OnPropertyChanged();
            }
        }

        public ICommand OpenDetailViewCommand { get; }

        // TODO(crhodes)
        // Maybe this should be protected virtual

        private void OpenDetailViewExecute()
        {
#if LOGGING
            Int64 startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);
#endif

            PublishOpenDetailViewEvent();

#if LOGGING
            Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        private void PublishOpenDetailViewEvent()
        {
#if LOGGING
            Int64 startTicks = Log.EVENT($"Enter Id:({Id})", Common.LOG_CATEGORY);
#endif

            EventAggregator.GetEvent<OpenDetailViewEvent>()
              .Publish
                (
                    new OpenDetailViewEventArgs
                    {
                        Id = Id,
                        ViewModelName = _detailViewModelName
                    }
                );

#if LOGGING
            Log.EVENT("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }
    }
}

