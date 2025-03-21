using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil_Spilmodul
{
    using System;

    namespace Genspil_Spilmodul
    {

        //enum GameCondition repræsenterer et par faste værdier af "stand" som spillet kan være i.

        //enum er (helt generelt i denne kode) valgt frem for Array, da det er ønsket at have statiske data, som ikke skal ændres..

        public enum GameCondition
        {
            unused,
            perfect,
            good,
            average,
            poor,
            repair,
            unknown,
        }

        //enum GameState relaterer sig til spillets status. 

        public enum GameState
        {
            inStock,
            notInStock,
            requested,
            notDefined,
        }

        //enum ageRating relaterer sig til spillets aldersgrænse

        public enum AgeRating
        {
            all,
            three,
            seven,
            eleven,
            fifteen,
            eighteen,
        }

        //enum playerNumbers relaterer sig til spillets "fra"- antal spillere

        public enum PlayerNumbers
        {
            zero,
            two,
            four,
            six,
            eight,
        }

        //Game Class begynder herfra. 

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
}
