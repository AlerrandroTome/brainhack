using BrainHack.Core.Entities;

namespace BrainHack.Core.Repositories
{
    public interface IDeckRepository
    {
        public Task<Deck> GetAsync(string id);
        public Task<List<Deck>> GetAllAsync();
        public Task CreateAsync(Deck deck);
        public Task UpdateAsync(Deck deckUpdated);
        public Task DeleteAsync(string id);
    }
}
