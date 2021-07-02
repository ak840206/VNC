using System;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace VNC.Core.Presentation.ViewModels
{
    public class OkCancelDialogViewModel : BindableBase, IDialogAware
    {
        private string _cancelContent = "Cancel";
        private DelegateCommand<string> _closeDialogCommand;
        private string _message;

        private string _okContent = "OK";

        private string _title = "Proceed?";

        public event Action<IDialogResult> RequestClose;

        public string CancelContent
        {
            get { return _cancelContent; }
            set { SetProperty(ref _cancelContent, value); }
        }

        public DelegateCommand<string> CloseDialogCommand =>
               _closeDialogCommand ?? (_closeDialogCommand = new DelegateCommand<string>(CloseDialog));

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public string OKContent
        {
            get { return _okContent; }
            set { SetProperty(ref _okContent, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public virtual bool CanCloseDialog()
        {
            return true;
        }

        public virtual void OnDialogClosed()
        {
        }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        {
            if (parameters.ContainsKey("message"))
            {
                Message = parameters.GetValue<string>("message");
            }

            if (parameters.ContainsKey("title"))
            {
                Title = parameters.GetValue<string>("title");
            }

            if (parameters.ContainsKey("okcontent"))
            {
                OKContent = parameters.GetValue<string>("okcontent");
            }

            if (parameters.ContainsKey("cancelcontent"))
            {
                CancelContent = parameters.GetValue<string>("cancelcontent");
            }
        }

        public virtual void RaiseRequestClose(IDialogResult dialogResult)
        {
            RequestClose?.Invoke(dialogResult);
        }

        protected virtual void CloseDialog(string parameter)
        {
            ButtonResult result = ButtonResult.None;

            if (parameter?.ToLower() == "true")
                result = ButtonResult.OK;
            else if (parameter?.ToLower() == "false")
                result = ButtonResult.Cancel;

            RaiseRequestClose(new DialogResult(result));
        }
    }
}