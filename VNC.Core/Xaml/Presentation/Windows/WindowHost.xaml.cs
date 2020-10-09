using System;
using System.Windows;
using System.Windows.Controls;

using VNC;

namespace VNC.Core.Xaml.Presentation
{

    public partial class WindowHost : Window
    {
        // NOTE(crhodes)
        // Not sure why we need this constructor
        public WindowHost()
        {
            //// TODO(crhodes)
            //// Do we need to move the bootstrapper earlier?
            //// What happens if have multiple of these?

            //try
            //{
            //    var bootstrapper = new Application.Bootstrapper();
            //    bootstrapper.Run();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            InitializeComponent();

            this.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            this.VerticalAlignment = System.Windows.VerticalAlignment.Center;
        }

        // TODO: Maybe take size and position parameters
        public WindowHost(string title, UserControl userControl)
        {
            //try
            //{
            //    var bootstrapper = new Application.Bootstrapper();
            //    bootstrapper.Run();
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
                ShowUserControl(userControl);
            }
            catch (Exception ex)
            {
                
            }
        }

        //private void DisplayUserControlFromName(string userControlName)
        //{
        //    //string typeName = string.Format("SupportTools_Visio.User_Interface.User_Controls.{0}",
        //    //                ((Button)sender).Tag.ToString());

        //    Type ucType = Type.GetType(userControlName);
        //    //Type ucType = Type.GetType(typeName);

        //    try
        //    {
        //        var uc = Activator.CreateInstance(ucType);
        //        ShowUserControl((UserControl)uc);

        //        //if (uc.GetType().BaseType.Name == "wucDX_Base")
        //        //{
        //        //    //ShowUserControl((User_Interface.User_Controls.wucDX_Base)uc);
        //        //    ShowUserControl((UserControl)uc);
        //        //}
        //        //else
        //        //{
        //        //    ShowUserControl((UserControl)uc);
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Incorrect Tag Name.  Cannot load type:{0}", userControlName);
        //    }
        //}

        //public void ShowUserControl(User_Interface.User_Controls.wucDX_Base control)
        //{
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
        //}

        public void ShowUserControl(UserControl control)
        {
            //UnhookTitleEvent(_currentControl);


            try
            {
                if (control != null)
                {
                    g_UserControlContainer.Children.Clear();

                    g_UserControlContainer.Children.Add(control);

                    if (control.MinWidth > 0)
                    {
                        this.Width = control.MinWidth;// + Common.WINDOW_HOSTING_USER_CONTROL_WIDTH_PAD;
                        this.MinWidth = this.Width;
                    }

                    if (control.MinHeight > 0)
                    {
                        this.Height = control.MinHeight;// + Common.WINDOW_HOSTING_USER_CONTROL_HEIGHT_PAD;
                        this.MinHeight = this.Height;
                    }
                    //_currentControl = control;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //HookTitleEvent(_currentControl);
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
