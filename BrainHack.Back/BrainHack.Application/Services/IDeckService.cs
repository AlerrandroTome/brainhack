using BrainHack.Application.InputModel.Card;
using BrainHack.Application.ViewModel.Deck;

namespace BrainHack.Application.Services
{
    public interface IDeckService
    {
        public Task<DeckViewModel> GetAsync(string id);
        public Task<List<DeckViewModel>> GetAllAsync();
        public Task<DeckViewModel> CreateAsync(CreateDeckInputModel deckInputModel);
        public Task<DeckViewModel> UpdateAsync(UpdateDeckInputModel deckInputModel);
        public Task<string> DeleteAsync(string id);
    }
}