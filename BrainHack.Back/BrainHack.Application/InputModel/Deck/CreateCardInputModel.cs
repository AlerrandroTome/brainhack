namespace BrainHack.Application.InputModel.Deck
{
    public class CreateCardInputModel
    {
        public CreateCardInputModel(string frontText, string backText)
        {
            FrontText = frontText;
            BackText = backText;
        }

        public string FrontText { get; set; } // Text displayed on the front of the card
        public string BackText { get; set; } // Text displayed on the back of the card
    }
}
