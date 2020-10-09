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
            MessageBox.Show("Beta 1 Says Hello");
        }
    }
}
