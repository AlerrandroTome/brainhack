﻿namespace BrainHack.Core.Entities
{
    public class Card
    {
        public Card(Guid id, string frontText, string backText, DateTime insertionDate, int difficultyLevel, DateTime lastReviewDate, int reviewCount, double easeFactor, int interval)
        {
            Id = id;
            FrontText = frontText;
            BackText = backText;
            InsertionDate = DateTime.Now;
        }        
        
        public Card(string frontText, string backText, DateTime insertionDate, int difficultyLevel, DateTime lastReviewDate, int reviewCount, double easeFactor, int interval)
        {
            Id = Guid.NewGuid();
            FrontText = frontText;
            BackText = backText;
            InsertionDate = DateTime.Now;
        }

        public Guid Id { get; set; } // Unique identifier for the card
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
