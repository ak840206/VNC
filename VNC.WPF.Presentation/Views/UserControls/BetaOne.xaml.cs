using System.Windows;

namespace VNC.WPF.Presentation.Views
{
    public partial class BetaOne
    {
        public BetaOne()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Log.EVENT_HANDLER("Enter", Common.LOG_CATEGORY);

            MessageBox.Show("Beta 1 Says Hello");
            
            Log.EVENT_HANDLER("Exit", Common.LOG_CATEGORY);
        }
    }
}
