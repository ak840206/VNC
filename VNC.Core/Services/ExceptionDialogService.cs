using System;

using Prism.Services.Dialogs;

namespace VNC.Core.Services
{
    public static class ExceptionDialogService
    {
        public static void DisplayExceptionDialog(IDialogService dialogService, Exception ex)
        {
            var dialogParameters = new DialogParameters();
            dialogParameters.Add("message", $"Error ({ex})");
            dialogParameters.Add("title", "Exception");

            dialogService.Show("NotificationDialog", dialogParameters, r =>
            {
            });
        }
    }
}
