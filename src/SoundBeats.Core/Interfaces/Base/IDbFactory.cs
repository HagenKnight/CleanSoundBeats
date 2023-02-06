using Microsoft.EntityFrameworkCore;

namespace SoundBeats.Core.Interfaces.Base
{
    public interface IDbFactory<TContext> : IDisposable where TContext : DbContext, new()
    {
        TContext Init();
    }
}
