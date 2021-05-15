using System;
using System.Windows;

namespace VNC.WPF.Presentation.Views
{
    public partial class BetaTwo
    {
        public BetaTwo()
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InitializeComponent();

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);

            MessageBox.Show("Beta 2 Says Hello");
            
            Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY);
        }
    }
}
