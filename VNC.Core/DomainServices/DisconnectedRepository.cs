using System.Data.Entity;

namespace VNC.Core.DomainServices
{
    public class DisconnectedRepository<TEntity> where TEntity : class
    {
        internal DbContext _context;
        internal DbSet<TEntity> _dbSet;

        public DisconnectedRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        // TODO(crhodes)
        // Add stuff from Ninja or Claudius
        // This is for Web where there is not persistent context

    }
}
