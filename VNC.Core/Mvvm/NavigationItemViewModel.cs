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
        // This was not in Cladius.

        public NavigationItemViewModel(
            int id,
            string displayMember,
            string detailViewModelName,
            IEventAggregator eventAggregator,
            IMessageDialogService messageDialogService) : base(eventAggregator, messageDialogService)
        {
            //Int64 startTicks = Log.CONSTRUCTOR($"Enter id:({id}) displayMember:({displayMember}) detailViewModelName:({detailViewModelName})", Common.LOG_APPNAME);

            Id = id;
            DisplayMember = displayMember;
            _detailViewModelName = detailViewModelName;

            OpenDetailViewCommand = new DelegateCommand(OnOpenDetailViewExecute);

            //Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
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

        private void OnOpenDetailViewExecute()
        {
            Int64 startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_APPNAME);

            PublishOpenDetailViewEvent();

            Log.EVENT_HANDLER("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void PublishOpenDetailViewEvent()
        {
            Int64 startTicks = Log.EVENT($"Enter Id:({Id})", Common.LOG_APPNAME);

            EventAggregator.GetEvent<OpenDetailViewEvent>()
              .Publish
                (
                    new OpenDetailViewEventArgs
                    {
                        Id = Id,
                        ViewModelName = _detailViewModelName
                    }
                );

            Log.EVENT("Exit", Common.LOG_APPNAME, startTicks);
        }
    }
}

