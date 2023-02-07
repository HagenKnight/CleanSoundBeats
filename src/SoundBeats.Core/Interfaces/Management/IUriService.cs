using SoundBeats.Core.Parameters;

namespace SoundBeats.Core.Interfaces.Management
{
    public interface IUriService
    {
        Uri GetPageUri(RequestParameter filter, string route);
    }
}
