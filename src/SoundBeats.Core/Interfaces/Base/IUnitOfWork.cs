using Microsoft.EntityFrameworkCore;

namespace SoundBeats.Core.Interfaces.Base
{
    public interface IUnitOfWork<TContext> where TContext : DbContext, new()
    {
        void CreateTransaction();
        Task CreateTransactionAsync();
        Task CreateTransactionAsync(CancellationToken cancellationToken = default);
        void RollBack();
        Task RollBackAsync();
        Task RollBackAsync(CancellationToken cancellationToken = default);
        void Commit();
        Task CommitAsync(CancellationToken cancellationToken = default);
        Task CommitAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}
