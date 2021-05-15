using System.Windows.Controls;

namespace VNC.WPF.Presentation.Dx.Views
{
    public partial class DxDockLayoutControl : UserControl
    {
        public DxDockLayoutControl()
        {
            long startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InitializeComponent();

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}
