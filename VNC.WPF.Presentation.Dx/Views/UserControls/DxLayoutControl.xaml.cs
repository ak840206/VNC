using System.Windows.Controls;

namespace VNC.WPF.Presentation.Dx.Views
{
    public partial class DxLayoutControl : UserControl
    {
        public DxLayoutControl()
        {
            long startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InitializeComponent();

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}
