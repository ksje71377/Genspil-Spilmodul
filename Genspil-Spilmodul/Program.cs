using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.InteropServices;

//Først angives klasserne, som er de objekter, der skal oprettes og manipuleres i programmet.

//Vi har her to klasser, Game og Client, som repræsenterer spil og kunder.

//Klassen Game indeholder generel information om spil

public class Game
{
    private string title;
    private string genre;
    private string developer;
    private double price;
    private int condition;
    private int ageRating;
    private int playerNumbers;

    //Indkapsler værdien for at beskytte variablen. Ugyldigt input forkastes. 

    //Hvad angår titel, så er den påkrævet. Derfor er der validering. For at tage højde for sjældne og obskure spil, vil vi godt lade genre og udgiver være "not defined" som standardværdi.

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

    //Kontrollerer at der ikke indtastes en negativ pris

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

    //Contructor Game definerer standardværdier for et nyt spil

    public Game()
    {
        genre = "not defined";
        developer = "not defined";
        price = 0.9;
    }
}

//Klassen Client indeholder generel information om kunder

public class Client
{
    //Variablerne er private, så de ikke kan tilgås direkte. 
    //Vi kræver som et absolut minimum et navn og et telefonnummer for at kunne oprette en reservation for en kunde. Derfor er der validering på disse to felter.

    private string name;
    private string address;
    private string email;
    private int phoneNumber;
    private string city;
    private int postalCode;

    //De er indkapslet i properties, så de kan tilgås og ændres via disse.

    //Afviser blankt input, så man ikke kan oprette en kunde uden et navn

    public string nName
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("FEJL. Navn er påkrævet.");
            }
            name = value;
        }
    }
    public string nAddress
    { get; set; }

    //Tjekker at brugeren indtaster en gyldig mail ved at afvise input uden @

    public string nEmail
    {
        get { return email; }
        set
        {
            if (value.Contains("@"))
            {
                throw new ArgumentException("Du kan ikke have en e-mail som ikke indeholder et @.");
            }
            email = value;
        }
    }

    //Afviser input uden telefonnummer

    public int nPhoneNumber
    {
        get { return phoneNumber; }
        set
        {
            if (value > 20000000)
            {
                throw new ArgumentException("FEJL. Telefonnummeret er ikke et gyldigt format");
            }
            phoneNumber = value;
        }
    }

    public string nCity
    { get; set; }
    public int nPostalCode
    { get; set; }


    //Constructor Client definerer standardværdier for en ny kunde i tilfælde af blankt input

    public Client()
    {
        address = "undefined";
        city = "undefined";
        postalCode = 0000;
    }
}

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
        //Method CreateClient opretter en ny kunde i systemet.

        public void CreateClient()
        {

            //Opretter ny instans af klassen Client

        }

        //I tråd med princippet om konceptuelle klasser foregår alt databehandling og manipulering af spil gennem klassen GameManager.

        public class GameManager
        {
            //Method CreateGame opretter et nyt spil i lagerbeholdningen.

            public void CreateGame(string title, string genre, string developer, string variant, int condition, double price, int playerNumbers, int ageRestriction)

            {
                int loopControlGame = 1;
                do
                {
                    //List inventory er lagerbeholdning - af fysiske spil som Genspil har rådighed over

                    List<string> inventory = new List<string>();


                    //Opretter nyt spil i lagerbeholdning + ny instans af klassen Game

                    Game newGame = new Game();

                    Console.WriteLine("Indtast titel på spil:");
                    newGame.nTitle = Console.ReadLine();

                    Console.WriteLine("Indtast genre på spil:");
                    newGame.nGenre = Console.ReadLine();

                    Console.WriteLine("Indtast udvikler på spil:");
                    newGame.nDeveloper = Console.ReadLine();

                    Console.WriteLine("Spillet er nu oprettet i lagerbeholdning.");

                    Console.WriteLine("Indtast '1' efterfulgt af enter, såfremt du vil tilføje et spil mere i hukommelsen.");
                    Console.WriteLine("\nEnhver andentast afbryder operationen");

                    Console.ReadLine();
                }

                while (loopControlGame == 1);
            }
            //Method EditGame styrer redigering af spil i lagerbeholdningen
            static void EditGame()
            {

            }

        }
        //Start på programmet

        static void Main(string[] args)



        {
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

                        GameManager gameManager = new GameManager();
 
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

