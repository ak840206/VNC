using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VNC.Core.DomainServices
{
    // TODO(crhodes)
    // Should we call the interface IDomainService or IDataService
    public class ConnectedRepository<TEntity> : IDataService<TEntity>
    where TEntity : class
    {
        internal DbContext _context;
        internal DbSet<TEntity> _dbSet;

        #region Constructors

        public ConnectedRepository(DbContext context)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            _context = context;
            _dbSet = context.Set<TEntity>();

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        #endregion Constructors

        #region Public Methods

        #region All

        public IEnumerable<TEntity> All()
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif

            return _dbSet.AsNoTracking().ToList();
        }

        public async Task<List<TEntity>> AllAsync()
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif

            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public IEnumerable<TEntity> AllInclude(
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
            return GetAllIncluding(includeProperties).ToList();
        }

        public async Task<IEnumerable<TEntity>> AllIncludeAsync(
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif

            return await GetAllIncluding(includeProperties).ToListAsync();
        }

        #endregion All

        #region Find

        public TEntity FindById(int entityId)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter entityId:({entityId})", Common.LOG_APPNAME);
#endif

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
            return _dbSet.Find(entityId);
            //using (var context = _contextCreator())
            //{
            //    return context.CustomerSet.AsNoTracking()
            //        .Single(f => f.Id == entityId);
            //}
        }

        public async Task<TEntity> FindByIdAsync(int entityId)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter entityId:({entityId})", Common.LOG_APPNAME);
#endif

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif

            return await _dbSet.FindAsync(entityId);
        }

        public IEnumerable<TEntity> FindBy(
            Expression<Func<TEntity, bool>> predicate)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            IEnumerable<TEntity> results = _dbSet.AsNoTracking()
              .Where(predicate).ToList();

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif

            return results;
        }

        public async  Task<IEnumerable<TEntity>> FindByAsync(
            Expression<Func<TEntity, bool>> predicate)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            IEnumerable<TEntity> results = await _dbSet.AsNoTracking()
              .Where(predicate).ToListAsync();

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif

            return results;
        }

        public IEnumerable<TEntity> FindByInclude(
            Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            var query = GetAllIncluding(includeProperties);
            IEnumerable<TEntity> results = query.Where(predicate).ToList();

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif

            return results;
        }

        public async Task<IEnumerable<TEntity>> FindByIncludeAsync(
            Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            var query = GetAllIncluding(includeProperties);
            IEnumerable<TEntity> results = await query.Where(predicate).ToListAsync();

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif

            return results;
        }

        // This is not part of the interface but left to show the technique

        //public TEntity FindByKey(int id)
        //{
        //    return _dbSet.Find(id);
        //    // This handles <Entity>Id style keys, e.g. CustomerId
        //    //Expression<Func<TEntity, bool>> lambda = Utilities.BuildLambdaForFindByKey<TEntity>(id);
        //    //return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        //}

        #endregion

        #region Insert

        public void Insert(TEntity entity)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            _dbSet.Add(entity);
            _context.SaveChanges();

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        public async Task InsertAsync(TEntity entity)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        #endregion Insert

        #region Update

        public void Update(TEntity entity)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        public async Task UpdateAsync(TEntity entity)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        #endregion Update

        #region Delete

        public void Delete(int id)
        {
#if LOGGING
            long startTicks = Log.Debug($"Enter id:({id})", Common.LOG_APPNAME);
#endif
            var entity = FindById(id);
            _dbSet.Remove(entity);
            _context.SaveChanges();

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        public async Task DeleteAsync(int entityId)
        {
#if LOGGING
            long startTicks = Log.Debug($"Enter entityId:({entityId})", Common.LOG_APPNAME);
#endif
            var entity = FindById(entityId);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif
        }

        #endregion Delete

        #endregion Public Methods

        #region Private Methods

        private IQueryable<TEntity> GetAllIncluding(
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            long startTicks = Log.Trace($"Enter", Common.LOG_APPNAME);
#endif
            IQueryable<TEntity> queryable = _dbSet.AsNoTracking();

#if LOGGING
            Log.Trace($"Exit", Common.LOG_APPNAME, startTicks);
#endif

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }

        #endregion Private Methods
    }
}
