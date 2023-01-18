using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SoundBeats.Infrastructure.Persistence.Repository.Base
{
    public class BaseRepository<T, TKey, TContext> : IBaseRepository<T, TContext>
        where T : class
        where TContext : DbContext, new()
    {
        private TContext _dataContext;
        private readonly DbSet<T> _dbSet;
        protected IDbFactory<TContext> DbFactory { get; private set; }
        protected TContext DbContext { get => _dataContext ?? (_dataContext = DbFactory.Init()); }
        public BaseRepository(IDbFactory<TContext> dbFactory) { DbFactory = dbFactory; _dbSet = DbContext.Set<T>(); }


        public async Task<IEnumerable<T>> AllAsync(CancellationToken cancellationToken = default) =>
         await _dbSet.ToListAsync(cancellationToken);


        public async Task<IEnumerable<T>> FilterAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default) =>
          await _dbSet.Where(predicate).ToListAsync(cancellationToken);


        public async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
          await _dbSet.FindAsync(new object[] { id }, cancellationToken);
        

        public async Task AddAsync(T entity, CancellationToken cancellationToken = default) =>
          await _dbSet.AddAsync(entity, cancellationToken);
        

        public void Update(T entity) => _dbSet.Update(entity);


        public void Delete(T entity) => _dbSet.Remove(entity);
    }
}
