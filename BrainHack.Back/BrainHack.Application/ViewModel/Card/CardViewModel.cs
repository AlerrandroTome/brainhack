namespace BrainHack.Application.ViewModel.Card
{
    public class CardViewModel
    {
        public CardViewModel(Guid id, string frontText, string backText)
        {
            Id = id;
            FrontText = frontText;
            BackText = backText;
        }

        public Guid Id { get; set; }
        public string FrontText { get; set; }
        public string BackText { get; set; }
    }
}
