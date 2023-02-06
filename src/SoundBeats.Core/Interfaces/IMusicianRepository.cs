using SoundBeats.Core.Entities;

namespace SoundBeats.Core.Interfaces
{
    public interface IMusicianRepository
    {
        Task<List<Musician>> GetMusicians();
        Task<Musician> GetMusician(int id);
        Task<Musician> InsertMusician(Musician genre);
        Task<Musician> UpdateMusician(Musician genre);
        Task<Musician> DeleteMusician(int id);
    }
}
