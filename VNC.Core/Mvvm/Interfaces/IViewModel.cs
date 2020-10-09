namespace VNC.Core.Mvvm
{
    public interface IViewModel
    {
        // In ViewModel 1st approaches, there is no property back to view

        // Normally in MVVM, a ViewModel does not know about the view.
        // In ViewModel 1st approaches, the View is typically passed in constructor.
        // Here we are using an Interface so there is still separation
        IView View { get; set; }
    }
}
