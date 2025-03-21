using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.InteropServices;

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

    internal class Program

    {

        //Start på programmet

        static void Main(string[] args)



        {
            //Instantierer nye elementer af klasserne GameManager og ClientManager for at kunne tilgå metoderne i disse klasser.

            GameManager gameManager = new GameManager();
            ClientManager clientManager = new ClientManager();

            //int gameMenuInput styrer input til menuvalget.

            int gameMenuInput;

            //int loopControl sørger for at menulinjen kører igen ved afsluttelse af operation eller forkert input.

            int loopControl = 1;
            int loopControlGame = 1;

            //Bruger præsenteres for en menu, hvori der med et numerisk input vælges ønsket funktion. Menuen kører i et do-while loop, da mængden af iterationer afhænger af brugerspecifikke omstændigheder.

            do

            {

                Console.WriteLine("\t****----- Spil -----****");
                Console.WriteLine("\n\n\n\tAngiv, hvad du ønsker at gøre:");
                Console.WriteLine("\n-------------------------------------------------\n");
                Console.WriteLine("Tast det ønskede tal, og tryk på enter. Funktionen vil herefter aktiveres.\n");

                Console.WriteLine("\t- 1. Opret spil i lagerbeholdning");
                Console.WriteLine("\t- 2. Ret eller ændre spil i lagerbeholdning");

                Console.WriteLine("\n\t- 3. Opret efterlysning på spil");
                Console.WriteLine("\t- 4. Ret eller ændre efterlysning på spil");

                Console.WriteLine("\n\t- 5. Tilbage til hovedmenu");

                //Læser brugerinput og konverterer til integer

                int.TryParse(Console.ReadLine(), out gameMenuInput);

                //Switch til at vælge videre handling baseret på brugerens input

                switch (gameMenuInput)
                {
                    //Opretter spil i listen. For hvert loop oprettes et nyt objekt i klassen, og et nyt spil tilføjes til listen.

                    case 1:

                        GameManager.CreateGame();

                        break;

                    case 2:
                        //henter metode til at søge på, ændre eller slette i lagerbeholdning

                        break;

                    case 3:
                        //henter metode til at oprette efterlysning på spil
                        break;

                    case 4:
                        //henter metode til at søge på, ændre eller slette efterlysning i databasen
                        break;

                    case 5:
                        //Ændrer loopControl variabel til 0, hvilket gør betingelsen falsk. Derved afsluttes løkken og der vendes retur til en eventuel hovedmenu
                        loopControl = 0;
                        break;

                    default:
                        Console.WriteLine("Ugyldigt input. Der SKAL vælges en værdi som fremgår foroven.");
                        break;

                }
            }

            while (loopControl == 1);

        }
    }
}

