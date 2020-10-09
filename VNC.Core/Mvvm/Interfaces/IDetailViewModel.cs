using System.Threading.Tasks;

namespace VNC.Core.Mvvm
{
    public interface IDetailViewModel : IViewModel
    {
        int Id { get; }

        string Title { get; }

        bool HasChanges { get; }

        Task LoadAsync(int id);
    }
}
