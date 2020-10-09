namespace VNC.Core.Mvvm
{
    public interface IView
    {
        // View knows about ViewModel 
        // In View 1st approaches, View sets this. Typically passed in constructor.
        // In ViewModel 1st approaches ViewModel sets this.

        IViewModel ViewModel { get; set; }
    }
}
