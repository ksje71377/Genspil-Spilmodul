using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.InteropServices;


namespace Genspil_Spilmodul

{
    internal class Program
    { 
        //Start på programmet

        static void Main(string[] args)

        {
            //Instantierer nye elementer af klasserne GameManager og ClientManager for at kunne tilgå metoderne i disse klasser.

            GameManager gameManager = new GameManager();
            ClientManager clientManager = new ClientManager();
            MenuRetriever menuRetriever = new MenuRetriever();

            //int gameMenuInput styrer input til menuvalget.

            int gameMenuInput;

            //int loopControl sørger for at menulinjen kører igen ved afsluttelse af operation eller forkert input.

            int loopControl = 1;

            //Bruger præsenteres for en menu, hvori der med et numerisk input vælges ønsket funktion. Menuen kører i et do-while loop, da mængden af iterationer afhænger af brugerspecifikke omstændigheder.

            do

            {
                //Henter metoden RetrieveMenu fra MenuRetriever klassen, som printer menuen til brugeren.

                menuRetriever.RetrieveMenu();

                //Læser brugerinput og konverterer til integer

                int.TryParse(Console.ReadLine(), out gameMenuInput);

                //Switch til at vælge videre handling baseret på brugerens input

                switch (gameMenuInput)
                {
                    //Opretter spil i listen. For hvert loop oprettes et nyt objekt i klassen, og et nyt spil tilføjes til listen.

                    case 1:



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
                        //henter metode til at printe lagerbeholdning
                        Console.WriteLine("\n\n\t****----- Lagerbeholdning -----****");
                        Console.WriteLine("\nIkke implementeret.");
                        Console.ReadKey();
                        break;

                    case 6:
                        //henter metode til at slette diverse databaser.
                        Console.WriteLine("\n\n\t****----- Slet database -----****");
                        Console.WriteLine("\nADVARSEL - ved at slette database fjernes data PERMANENT.");
                        Console.WriteLine("\n\tEr du sikker på, at du vil slette en database? Bekræft ved at taste \"slette\" og trykke på \"enter\".");
                        if (Console.ReadLine().ToLower() == "slette")
                        {
                            Console.WriteLine("\n\tTast 1 efterfulgt af \"enter\" for at slette database for spil\n\tTast 2. efterfulgt af \"enter\" for at slette database for kunder.");
                        }
                        break;

                    case 7:
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