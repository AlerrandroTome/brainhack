using AutoMapper;
using BrainHack.Application.InputModel.Card;
using BrainHack.Application.Services;
using BrainHack.Application.ViewModel.Deck;
using BrainHack.Core.Entities;
using BrainHack.Core.Repositories;

namespace BrainHack.Core.Services
{
    public class DeckService : IDeckService
    {
        private readonly IDeckRepository _deckRepository;
        private readonly IMapper mapper;

        public DeckService(IDeckRepository deckRepository, IMapper mapper)
        {
            _deckRepository = deckRepository;
            this.mapper = mapper;
        }

        public async Task<DeckViewModel> CreateAsync(CreateDeckInputModel deckInputModel)
        {
            if (deckInputModel is null)
            {
                throw new ArgumentNullException(nameof(deckInputModel));
            }

            Deck deck = mapper.Map<Deck>(deckInputModel);
            await _deckRepository.CreateAsync(deck);
            
            return mapper.Map<DeckViewModel>(deck);
        }

        public async Task<string> DeleteAsync(string id)
        {
            await _deckRepository.DeleteAsync(id);
            return id;
        }

        public async Task<List<DeckViewModel>> GetAllAsync()
        {
             return mapper.Map<List<DeckViewModel>>(await _deckRepository.GetAllAsync());
        }

        public async Task<DeckViewModel> GetAsync(string id)
        {
            return mapper.Map<DeckViewModel>(await _deckRepository.GetAsync(id));
        }

        public async Task<DeckViewModel> UpdateAsync(UpdateDeckInputModel deckInputModel)
        {
            if (deckInputModel is null)
            {
                throw new ArgumentNullException(nameof(deckInputModel));
            }

            Deck deck = mapper.Map<Deck>(deckInputModel);
            await _deckRepository.UpdateAsync(deck);

            return mapper.Map<DeckViewModel>(deck);
        }
    }
}
