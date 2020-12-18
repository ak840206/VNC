using System;
using System.Collections.ObjectModel;
using System.Linq;

using Prism.Events;

using VNC.Core.Events;
using VNC.Core.Services;

namespace VNC.Core.Mvvm
{
    public abstract class EventViewModelBase : ViewModelBase
    {
        protected readonly IEventAggregator EventAggregator;
        protected readonly IMessageDialogService MessageDialogService;

         public EventViewModelBase(
            IEventAggregator eventAggregator,
            IMessageDialogService messageDialogService)
        {
            //long startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            EventAggregator = eventAggregator;
            MessageDialogService = messageDialogService;

            //Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        public void AfterDetailSaved(ObservableCollection<NavigationItemViewModel> items,
            AfterDetailSavedEventArgs args)
        {
            Int64 startTicks = Log.VIEWMODEL_LOW($"Enter Id:({args.Id})", Common.LOG_APPNAME);

            var lookupItem = items.SingleOrDefault(l => l.Id == args.Id);

            if (lookupItem == null)
            {
                items.Add(new NavigationItemViewModel(args.Id, args.DisplayMember,
                    args.ViewModelName,
                    EventAggregator, MessageDialogService));
            }
            else
            {
                lookupItem.DisplayMember = args.DisplayMember;
            }

            Log.VIEWMODEL_LOW("Exit", Common.LOG_APPNAME, startTicks);
        }

        public void AfterDetailDeleted(ObservableCollection<NavigationItemViewModel> items,
            AfterDetailDeletedEventArgs args)
        {
            Int64 startTicks = Log.VIEWMODEL_LOW($"Enter Id:({args.Id})", Common.LOG_APPNAME);

            var lookupItem = items.SingleOrDefault(f => f.Id == args.Id);

            if (lookupItem != null)
            {
                items.Remove(lookupItem);
            }

            Log.VIEWMODEL_LOW("Exit", Common.LOG_APPNAME, startTicks);
        }
    }
}
