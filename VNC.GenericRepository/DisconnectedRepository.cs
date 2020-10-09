using System.Data.Entity;

namespace VNC.GenericRepository
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

    }
}
