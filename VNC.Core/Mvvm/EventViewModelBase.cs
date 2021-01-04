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
        public readonly IEventAggregator EventAggregator;
        public readonly IMessageDialogService MessageDialogService;

         public EventViewModelBase(
            IEventAggregator eventAggregator,
            IMessageDialogService messageDialogService)
        {
#if LOGGING
            long startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);
#endif

            EventAggregator = eventAggregator;
            MessageDialogService = messageDialogService;

#if LOGGING
            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        public void AfterDetailSaved(ObservableCollection<NavigationItemViewModel> items,
            AfterDetailSavedEventArgs args)
        {
#if LOGGING
            Int64 startTicks = Log.VIEWMODEL_LOW($"Enter Id:({args.Id})", Common.LOG_APPNAME);
#endif

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
#if LOGGING
            Log.VIEWMODEL_LOW("Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        public void AfterDetailDeleted(ObservableCollection<NavigationItemViewModel> items,
            AfterDetailDeletedEventArgs args)
        {
#if LOGGING
            Int64 startTicks = Log.VIEWMODEL_LOW($"Enter Id:({args.Id})", Common.LOG_APPNAME);
#endif

            var lookupItem = items.SingleOrDefault(f => f.Id == args.Id);

            if (lookupItem != null)
            {
                items.Remove(lookupItem);
            }
#if LOGGING
            Log.VIEWMODEL_LOW("Exit", Common.LOG_APPNAME, startTicks);
#endif
        }
    }
}
