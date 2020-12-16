using System.Windows.Controls;

namespace VNC.Core.Mvvm
{
    public class ViewBase : UserControl, IView
    {
        public ViewBase()
        {
        }

        public ViewBase(IViewModel viewModel)
        {
            ViewModel = viewModel;
        }

        private IViewModel _viewModel;

        public IViewModel ViewModel
        {
            get { return _viewModel; }

            set
            {
                _viewModel = value;
                DataContext = _viewModel;
            }
        }
    }
}
