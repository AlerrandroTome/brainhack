using BrainHack.Application.ViewModel.Card;

namespace BrainHack.Application.ViewModel.Deck
{
    public class DeckViewModel
    {
        public DeckViewModel(string id, string name, string description, string ownerId, Dictionary<string, CardViewModel> cards)
        {
            Id = id;
            Name = name;
            Description = description;
            OwnerId = ownerId;
            Cards = cards;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OwnerId { get; set; }

        public Dictionary<string, CardViewModel> Cards { get; set; }
    }
}