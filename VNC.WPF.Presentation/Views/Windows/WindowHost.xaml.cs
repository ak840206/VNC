using System;
using System.Windows;
using System.Windows.Controls;

using VNC.Core.Presentation;

namespace VNC.WPF.Presentation.Views
{
    public partial class WindowHost : Window
    {
        public string LoadTimeInfo { get; set; }

        public WindowHost()
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
            // TODO(crhodes)
            // Do we need to move the bootstrapper earlier?
            // What happens if have multiple of these?

            //try
            //{
            //    //var bootstrapper = new Application.Bootstrapper();
            //    //bootstrapper.Run();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            InitializeComponent();

            this.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            this.VerticalAlignment = System.Windows.VerticalAlignment.Center;

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        // TODO: Maybe take size and position parameters
        public WindowHost(string title, string userControlFullyQualifiedName)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            //try
            //{
            //    //var bootstrapper = new Application.Bootstrapper();
            //    //bootstrapper.Run();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            try
            {
                InitializeComponent();

                this.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                this.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                this.Title = title;
                LoadUserControl(userControlFullyQualifiedName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public void LoadUserControl(string userControlName)
        {
            long startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

            Type ucType = Type.GetType(userControlName); 

            try
            {
                var uc = Activator.CreateInstance(ucType);
                LoadUserControl((UserControl)uc);

                //if (uc.GetType().BaseType.Name == "wucDX_Base")
                //{
                //    //ShowUserControl((User_Interface.User_Controls.wucDX_Base)uc);
                //    ShowUserControl((UserControl)uc);
                //}
                //else
                //{
                //    ShowUserControl((UserControl)uc);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Incorrect Tag Name.  Cannot load type:{userControlName} Exception: {ex}");
            }

            Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
        }

        //public void ShowUserControl(User_Interface.User_Controls.wucDX_Base control)
        //{
        //    Log.Trace("Enter", Common.LOG_CATEGORY);
        //    //UnhookTitleEvent(_currentControl);
        //    g_UserControlContainer.Children.Clear();

        //    if (control != null)
        //    {
        //        g_UserControlContainer.Children.Add(control);

        //        if (control.MinWidth > 0)
        //        {
        //            this.Width = control.MinWidth + Common.WINDOW_HOSTING_USER_CONTROL_WIDTH_PAD;
        //            this.MinWidth = this.Width;
        //        }

        //        if (control.MinHeight > 0)
        //        {
        //            this.Height = control.MinHeight + Common.WINDOW_HOSTING_USER_CONTROL_HEIGHT_PAD;
        //            this.MinHeight = this.Height;
        //        }
        //        //_currentControl = control;
        //    }

        //    //HookTitleEvent(_currentControl);
        //    Log.Trace("Exit", Common.LOG_CATEGORY);
        //}

        public void LoadUserControl(UserControl control)
        {
            long startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);
            //UnhookTitleEvent(_currentControl);
            g_UserControlContainer.Children.Clear();

            if (control != null)
            {
                g_UserControlContainer.Children.Add(control);

                if (control.MinWidth > 0)
                {
                    this.Width = control.MinWidth + Common.WINDOW_HOSTING_USER_CONTROL_WIDTH_PAD;
                    this.MinWidth = this.Width;
                }

                if (control.MinHeight > 0)
                {
                    this.Height = control.MinHeight + Common.WINDOW_HOSTING_USER_CONTROL_HEIGHT_PAD;
                    this.MinHeight = this.Height;
                }
                //_currentControl = control;
            }

            //HookTitleEvent(_currentControl);
            Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);

            this.Hide();
            e.Cancel = true;

            Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY);
        }

        public static void DisplayUserControlInHost(
            ref WindowHost host,
            string title,
            int width, int height,
            ShowWindowMode mode,
            System.Windows.Controls.UserControl userControl)
        {
            long startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

            if (host is null)
            {
                host = new WindowHost();

                if (!(userControl is null))
                {
                    host.LoadUserControl(userControl);
                }
            }

            DisplayHost(host, title, width, height, mode, startTicks);
        }

        public static void DisplayUserControlInHost(
            ref WindowHost host,
            string title,
            int width, int height,
            ShowWindowMode mode,
            string userControlName = null)
        {
            long startTicks = Log.PRESENTATION("Enter", Common.LOG_CATEGORY);

            if (host is null)
            {
                host = new WindowHost();

                if (!(userControlName is null))
                {
                    host.LoadUserControl(userControlName);
                }
            }

            DisplayHost(host, title, width, height, mode, startTicks);
        }

        public static void DisplayHost(
            Window host,
            string title,
            int width, int height,
            ShowWindowMode mode,
            long startTicks)
        {
            host.Title = title;
            host.Width = width;
            host.Height = height;

            if (mode == ShowWindowMode.Modal_ShowDialog)
            {
                long endTicks2 = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);

                host.Title = $"{host.GetType()} loadtime: {Log.GetDuration(startTicks, endTicks2)}";

                host.ShowDialog();
            }
            else
            {
                host.Show();
            }

            long endTicks = Log.PRESENTATION("Exit", Common.LOG_CATEGORY, startTicks);

            host.Tag = $"{host.GetType()} loadtime: {Log.GetDuration(startTicks, endTicks)}";
        }
    }
}
