namespace BrainHack.Application.InputModel.Deck
{
    public class UpdateCardInputModel
    {
        public UpdateCardInputModel(string frontText, string backText)
        {
            FrontText = frontText;
            BackText = backText;
        }

        public Guid Id { get; set; }
        public string FrontText { get; set; } // Text displayed on the front of the card
        public string BackText { get; set; } // Text displayed on the back of the card
        public DateTime InsertionDate { get; set; } // Date when the card was inserted
        public int DifficultyLevel { get; set; } = 0;// Difficulty level: 1 (Easy), 2 (Medium), 3 (Hard)
        public DateTime? LastReviewDate { get; set; } // Date when the card was last reviewed
        public int ReviewCount { get; set; } = 0; // Number of times the card has been reviewed
        public double EaseFactor { get; set; } = 2.5; // Ease factor for the card
        public int Interval { get; set; } = 1; // Interval until the next review in days
    }
}
