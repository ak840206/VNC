using System.Data.Entity;

namespace VNC.AZDOHelper.Interfaces
{
    public interface ILookupService<TEntity> where TEntity : class
    {
        IDbSet<TEntity> Items { get; set; }

        void Save();
    }
}
