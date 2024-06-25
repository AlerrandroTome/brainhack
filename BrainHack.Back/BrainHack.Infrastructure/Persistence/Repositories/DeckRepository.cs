using BrainHack.Core.Entities;
using BrainHack.Core.Repositories;
using BrainHack.Infrastructure.Persistence.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BrainHack.Infrastructure.Persistence.Repositories
{
    public class DeckRepository : IDeckRepository
    {
        private readonly IMongoCollection<Deck> _decks;

        public DeckRepository(IOptions<MongoDBSettings> mongoDBSettings, IMongoDatabase database)
        {
            _decks = database.GetCollection<Deck>(mongoDBSettings.Value.CollectionName);
        }

        public async Task CreateAsync(Deck deck)
        {
            await _decks.InsertOneAsync(deck);
        }

        public async Task DeleteAsync(string id)
        {
            await _decks.DeleteOneAsync(card => card.Id == id);
        }

        public async Task<List<Deck>> GetAllAsync()
        {
            return await _decks.Find(card => true).ToListAsync();
        }

        public async Task<Deck> GetAsync(string id)
        {
            return await _decks.Find(card => card.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Deck deckUpdated)
        {
            await _decks.ReplaceOneAsync(deck => deck.Id == deckUpdated.Id, deckUpdated);
        }
    }
}
