using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Core.Interfaces.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SoundBeats.Core.Interfaces.Services.Base
{
    public interface IReadService<TGetDto, TKey, TEntity, TRepoRead, TContext>
      where TEntity : class, IEntityBase<TKey>
      where TRepoRead : IReadRepository<TEntity, TContext>
      where TContext : DbContext, new()
    {
        Task<IEnumerable<TGetDto>> GetAll(CancellationToken cancellationToken = default);
        Task<TGetDto> FindAsync(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<TGetDto>> FilterAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
    }
}
