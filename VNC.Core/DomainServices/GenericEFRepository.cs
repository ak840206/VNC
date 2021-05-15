using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VNC.Core.DomainServices
{
    public class GenericEFRepository<TEntity,TContext> : IGenericRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        protected readonly TContext Context;

        internal DbSet<TEntity> _dbSet;

        #region Constructors

        public GenericEFRepository(TContext context)
        {
#if LOGGING
            long startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);
#endif
            Context = context;
            _dbSet = context.Set<TEntity>();

#if LOGGING
            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion Constructors

        #region Public Methods

        #region All

        public virtual IEnumerable<TEntity> All()
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif

            var result = _dbSet.AsNoTracking().ToList();

#if LOGGING
            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        public virtual async Task<List<TEntity>> AllAsync()
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);
#endif

            var result = await _dbSet.AsNoTracking().ToListAsync();

#if LOGGING
            Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        public virtual IEnumerable<TEntity> AllInclude(
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif

            var result = GetAllIncluding(includeProperties).ToList();

#if LOGGING
            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        public virtual async Task<IEnumerable<TEntity>> AllIncludeAsync(
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);
#endif

            var result = await GetAllIncluding(includeProperties).ToListAsync();

#if LOGGING
            Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        #endregion All

        #region Find

        public virtual TEntity FindById(int entityId)
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE($"Enter entityId:({entityId})", Common.LOG_CATEGORY);
#endif

            var result = _dbSet.Find(entityId);

#if LOGGING
            Log.PERSISTENCE($"Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        public virtual async Task<TEntity> FindByIdAsync(int entityId)
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE($"(GenericEFRepository) Enter entityId:({entityId})", Common.LOG_CATEGORY);
#endif

            var result = await _dbSet.FindAsync(entityId);

#if LOGGING
            Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return result;
        }

        public virtual IEnumerable<TEntity> FindBy(
            Expression<Func<TEntity, bool>> predicate)
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE($"Enter", Common.LOG_CATEGORY);
#endif

            var results = _dbSet.AsNoTracking().Where(predicate).ToList();

#if LOGGING
            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return results;
        }

        public virtual async Task<IEnumerable<TEntity>> FindByAsync(
            Expression<Func<TEntity, bool>> predicate)
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);
#endif

            var results = await _dbSet.AsNoTracking().Where(predicate).ToListAsync();

#if LOGGING
            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return results;
        }

        public virtual IEnumerable<TEntity> FindByInclude(
            Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif

            var query = GetAllIncluding(includeProperties);
            var results = query.Where(predicate).ToList();

#if LOGGING
            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return results;
        }

        public virtual async Task<IEnumerable<TEntity>> FindByIncludeAsync(
            Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);
#endif

            var query = GetAllIncluding(includeProperties);
            var results = await query.Where(predicate).ToListAsync();

#if LOGGING
            Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);
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

        #region Add/Remove

        public virtual void Add(TEntity entity)
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif
            _dbSet.Add(entity);

#if LOGGING
            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        public virtual void Remove(TEntity entity)
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif
            _dbSet.Remove(entity);

#if LOGGING
            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif
        }

        #endregion Insert

        #region Update

        public virtual bool HasChanges()
        {
            Int64 startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);

            var result = Context.ChangeTracker.HasChanges();

            Log.PERSISTENCE($"Exit ({result})", Common.LOG_CATEGORY, startTicks);

            return result;
        }

        public virtual void Update()
        {
            Int64 startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);

            Context.SaveChanges();

            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
        }

        public virtual async Task UpdateAsync()
        {
            Int64 startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_CATEGORY);

            await Context.SaveChangesAsync();

            Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_CATEGORY, startTicks);
        }

        // NOTE(crhodes)
        // Not sure why these exist.  Causes problems if use Add and then call this with Entity

        //        public void Update(TEntity entity)
        //        {
        //#if LOGGING
        //            Int64 startTicks = Log.PERSISTENCE("Enter", Common.LOG_APPNAME);
        //#endif
        //            _dbSet.Attach(entity);
        //            Context.Entry(entity).State = EntityState.Modified;
        //            Context.SaveChanges();

        //#if LOGGING
        //            Log.PERSISTENCE("Exit", Common.LOG_APPNAME, startTicks);
        //#endif
        //        }

        //        public async Task UpdateAsync(TEntity entity)
        //        {
        //#if LOGGING
        //            Int64 startTicks = Log.PERSISTENCE("(GenericEFRepository) Enter", Common.LOG_APPNAME);
        //#endif
        //            _dbSet.Attach(entity);
        //            Context.Entry(entity).State = EntityState.Modified;
        //            await Context.SaveChangesAsync();

        //#if LOGGING
        //            Log.PERSISTENCE("(GenericEFRepository) Exit", Common.LOG_APPNAME, startTicks);
        //#endif
        //        }

        #endregion Update

        #endregion Public Methods

        #region Private Methods

        private IQueryable<TEntity> GetAllIncluding(
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
#if LOGGING
            long startTicks = Log.PERSISTENCE("Enter", Common.LOG_CATEGORY);
#endif
            IQueryable<TEntity> queryable = _dbSet.AsNoTracking();

#if LOGGING
            Log.PERSISTENCE("Exit", Common.LOG_CATEGORY, startTicks);
#endif

            return includeProperties.Aggregate
              (queryable, (current, includeProperty) => current.Include(includeProperty));
        }

        #endregion Private Methods
    }
}
