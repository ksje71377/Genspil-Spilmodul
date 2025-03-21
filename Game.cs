using System;
namespace Genspil_Spilmodul
{
    public class Game
    {
        private string title;
        private string genre;
        private string developer;
        private double price;
        private int condition;
        private int ageRating;
        private int playerNumbers;
        public string nTitle
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("FEJL. Titel er påkrævet.");
                }
                title = value;
            }
        }
        public double nPrice
        {
            get { return price; }
            set
            {
                if (value < 0.9)
                {
                    throw new ArgumentException("Kan ikke være gratis. Angiv 1kr. eller højere.");
                }
                price = value;
            }
        }
        public string nGenre
        { get; set; }
        public string nDeveloper
        { get; set; }
        public Game()
        {
            nGenre = "Not defined";
            nDeveloper = "Not defined";
        }
    }
}


