using System;
using System.Windows.Controls;

namespace VNC.WPF.Presentation.Views
{
    public partial class ModelessUI : UserControl
    {
        public ModelessUI()
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InitializeComponent();

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}
