using System.Windows;


namespace VNC.Core.Xaml
{
    public static class Helper
    {
        public static void DisableAndHide(System.Windows.Controls.Control control)
        {
            control.IsEnabled = false;
            control.Visibility = Visibility.Hidden;
        }
        public static void EnableAndShow(System.Windows.Controls.Control control)
        {
            control.IsEnabled = true;
            control.Visibility = Visibility.Visible;
        }
    }
}