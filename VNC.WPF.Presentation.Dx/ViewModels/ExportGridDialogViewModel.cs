using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using DevExpress.Xpf.Grid;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace VNC.Core.Presentation.ViewModels
{
    public class ExportGridDialogViewModel : BindableBase, IDialogAware
    {
        

        private DelegateCommand<string> _closeDialogCommand;
        public DelegateCommand<string> CloseDialogCommand =>
            _closeDialogCommand ?? (_closeDialogCommand = new DelegateCommand<string>(CloseDialog));

        private GridControl _activeGridControl = null;

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private string _cancelContent = "Cancel";
        public string CancelContent
        {
            get { return _cancelContent; }
            set { SetProperty(ref _cancelContent, value); }
        }

        private string _okContent = "Save";
        public string OKContent
        {
            get { return _okContent; }
            set { SetProperty(ref _okContent, value); }
        }

        private string _title = "Save Grid";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _fileNameAndPath = @"C:\temp\GridExport";
        public string FileNameAndPath
        {
            get => _fileNameAndPath;
            set
            {
                if (_fileNameAndPath == value)
                    return;
                _fileNameAndPath = value;
                RaisePropertyChanged();
            }
        }

        private List<string> _selectedFileFormats;
        public List<string> SelectedFileFormats
        {
            get => _selectedFileFormats;
            set
            {
                if (_selectedFileFormats == value)
                    return;
                _selectedFileFormats = value;
                RaisePropertyChanged();
            }
        }
        
        public event Action<IDialogResult> RequestClose;

        protected virtual void CloseDialog(string parameter)
        {
            ButtonResult result = ButtonResult.None;

            if (parameter?.ToLower() == "true")
            {
                result = ButtonResult.OK;

                foreach (var fileFormat in SelectedFileFormats)
                {
                    switch (fileFormat)
                    {
                        case ".docx":
                            _activeGridControl.View.ExportToDocx($"{FileNameAndPath}{fileFormat}");
                            break;

                        case ".html":
                            _activeGridControl.View.ExportToHtml($"{FileNameAndPath}{fileFormat}");
                            break;

                        case ".pdf":
                            _activeGridControl.View.ExportToPdf($"{FileNameAndPath}{fileFormat}");
                            break;

                        case ".xlsx":
                            _activeGridControl.View.ExportToXlsx($"{FileNameAndPath}{fileFormat}");
                            break;
                    }
                }
            }
            else if (parameter?.ToLower() == "false")
                result = ButtonResult.Cancel;

            RaiseRequestClose(new DialogResult(result));
        }

        public virtual void RaiseRequestClose(IDialogResult dialogResult)
        {
            RequestClose?.Invoke(dialogResult);
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
            if (parameters.ContainsKey("filenameandpath"))
            {
                FileNameAndPath = parameters.GetValue<string>("filenameandpath");
            }

            if (parameters.ContainsKey("gridcontrol"))
            {
                _activeGridControl = parameters.GetValue<GridControl>("gridcontrol");
            }
            else
            {
                
            }
        }

        private ObservableCollection<string> FileFormats { get; set; }

        #region Constructors, Initialization, and Load


        #endregion

        #region Enums (None)


        #endregion

        #region Structures (None)


        #endregion

        #region Fields and Properties (None)


        #endregion

        #region Event Handlers (None)


        #endregion

        #region Commands (None)

        #endregion

        #region Public Methods (None)


        #endregion

        #region Protected Methods (None)


        #endregion

        #region Private Methods (None)


        #endregion
    }
}