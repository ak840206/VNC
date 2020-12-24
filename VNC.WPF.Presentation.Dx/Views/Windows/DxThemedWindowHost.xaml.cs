using System;
using System.Windows;
using System.Windows.Controls;

using DevExpress.Xpf.Core;

using VNC;
using VNC.Core.Mvvm;

namespace VNC.WPF.Presentation.Dx.Views
{
    /// <summary>
    /// Interaction logic for DxThemedWindowHost.xaml
    /// </summary>
    public partial class DxThemedWindowHost : ThemedWindow
    {
        public string LoadTimeInfo { get; set; }

        public DxThemedWindowHost()
        {
            Log.Trace("Enter", Common.PROJECT_NAME);
            // TODO(crhodes)
            // Do we need to move the bootstrapper earlier?
            // What happens if have multiple of these?

            try
            {
                //var bootstrapper = new Application.Bootstrapper();
                //bootstrapper.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            InitializeComponent();

            this.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            this.VerticalAlignment = System.Windows.VerticalAlignment.Center;

            Log.Trace("Exit", Common.PROJECT_NAME);
        }

        // TODO: Maybe take size and position parameters
        public DxThemedWindowHost(string title, string userControlFullyQualifiedName)
        {
            Log.Trace("Enter", Common.PROJECT_NAME);
            try
            {
                //var bootstrapper = new Application.Bootstrapper();
                //bootstrapper.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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

            }
            Log.Trace("Exit", Common.PROJECT_NAME);
        }

        public DxThemedWindowHost(string title, UserControl userControl)
        {
            Log.Trace("Enter", Common.PROJECT_NAME);
            try
            {
                //var bootstrapper = new Application.Bootstrapper();
                //bootstrapper.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                InitializeComponent();

                this.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                this.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                this.Title = title;
                LoadUserControl(userControl);
            }
            catch (Exception ex)
            {

            }
            Log.Trace("Exit", Common.PROJECT_NAME);
        }

        public void LoadUserControl(string userControlName)
        {
            Log.Trace("Enter", Common.PROJECT_NAME);
            //string typeName = string.Format("SupportTools_Visio.User_Interface.User_Controls.{0}",
            //                ((Button)sender).Tag.ToString());

            Type ucType = Type.GetType(userControlName);
            //Type ucType = Type.GetType(typeName);

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
                MessageBox.Show("Incorrect Tag Name.  Cannot load type:{0}", userControlName);
            }
            Log.Trace("Exit", Common.PROJECT_NAME);
        }

        //public void ShowUserControl(User_Interface.User_Controls.wucDX_Base control)
        //{
        //    Log.Trace("Enter", Common.PROJECT_NAME);
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
        //    Log.Trace("Exit", Common.PROJECT_NAME);
        //}

        public void LoadUserControl(UserControl control)
        {
            Log.Trace("Enter", Common.PROJECT_NAME);
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
            Log.Trace("Exit", Common.PROJECT_NAME);
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Log.Trace("Enter", Common.PROJECT_NAME);
            this.Hide();
            e.Cancel = true;
            Log.Trace("Exit", Common.PROJECT_NAME);
        }

        public enum ShowWindowMode
        {
            Modeless,
            Modal
        }

        public static void DisplayUserControlInHost(
            ref DxThemedWindowHost host,
            string title,
            int width, int height,
            ShowWindowMode mode,
            System.Windows.Controls.UserControl userControl)
        {
            long startTicks = Log.Trace("Enter", Common.PROJECT_NAME);

            if (host is null)
            {
                host = new VNC.WPF.Presentation.Dx.Views.DxThemedWindowHost();

                if (!(userControl is null))
                {
                    host.LoadUserControl(userControl);
                }
            }

            DisplayHost(host, title, width, height, mode, startTicks);
        }

        public static void DisplayUserControlInHost(
            ref DxThemedWindowHost host,
            string title,
            int width, int height,
            ShowWindowMode mode,
            ViewModelBase viewModel)
        {
            long startTicks = Log.Trace("Enter", Common.PROJECT_NAME);

            if (host is null)
            {
                host = new VNC.WPF.Presentation.Dx.Views.DxThemedWindowHost();

                if (!(viewModel.View is null))
                {
                    host.LoadUserControl((UserControl)viewModel.View);
                }
            }

            DisplayHost(host, title, width, height, mode, startTicks);
        }

        public static void DisplayUserControlInHost(
            ref DxThemedWindowHost host,
            string title,
            int width, int height,
            ShowWindowMode mode,
            string userControlName = null)
        {
            long startTicks = Log.Trace("Enter", Common.PROJECT_NAME);

            if (host is null)
            {
                host = new DxThemedWindowHost();

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

            if (mode == ShowWindowMode.Modal)
            {
                long endTicks2 = Log.Trace("Exit", Common.PROJECT_NAME, startTicks);

                host.Title = $"{host.GetType()} loadtime: {Log.GetDuration(startTicks, endTicks2)}";

                host.ShowDialog();
            }
            else
            {
                host.Show();
            }

            long endTicks = Log.Trace("Exit", Common.PROJECT_NAME, startTicks);

            host.Tag = $"{host.GetType()} loadtime: {Log.GetDuration(startTicks, endTicks)}";
        }
    }
}
