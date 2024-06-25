using BrainHack.Application.InputModel.Deck;

namespace BrainHack.Application.InputModel.Card
{
    public class UpdateDeckInputModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OwnerId { get; set; }

        public Dictionary<string, CreateCardInputModel> Cards { get; set; }
    }
}
