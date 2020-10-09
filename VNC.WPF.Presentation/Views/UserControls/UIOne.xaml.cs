using System.Windows;

namespace VNC.WPF.Presentation.Views
{
    public partial class UIOne
    {
        public UIOne()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("One Boom");
        }
    }
}
