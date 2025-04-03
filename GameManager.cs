using System;
using System.IO;

//I tråd med princippet om konceptuelle klasser foregår alt databehandling og manipulering af spil gennem klassen GameManager.

namespace Genspil_Spilmodul
{
    public class GameManager
    {
        //Stien til at gemme fil databasen. Bemærk const, for at den ikke kan ændres.
        const string filePath = "gameDatabase.txt";

        public static void ReadFromFile(string filePath)
        {             //Metoden ReadFromFile læser fra en fil, og returnerer en string.
            StreamReader reader = new StreamReader(filePath);
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }

                reader.Close();
        }
                {   

        //Metoden Countdatabase tæller hvor mange spil der totalt er oprettet i databasen.
                StreamReader reader = new StreamReader(filePath);

                //EndOfStream betyder ved enden af listen

                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                count++;
                } //Der er {0} spil i databasen, count);

               //Console.WriteLine("Der er {0} spil i databasen", count);

               //reader og writer skal altid lukkes, når de ikke længere er i brug.
                 reader.Close();
                }

        public static void WriteToFile(string filePath, string content)
        {
            //Metoden WriteToFile skriver til en fil, og tager en string som parameter.

            StreamWriter writer = new StreamWriter(filePath, true);

            //(filePath, true) betyder at vi tilføjer til filen, og ikke overskriver den.

            writer.WriteLine(content);
        //Som før, husker vi at Close for at undgå problemer senere hen. 
        writer.Close();
        }

        // String-interpolation med $ og {} til at indsætte variabelværdier i en streng
        public void GameConvertToString
        { 
        return $"{nTitle},{nGenre},{nPrice},{nDeveloper}, {nCondition},{nAgeRating},{nPlayerNumbers}";
        }

        //Method CreateGame opretter et nyt spil i lagerbeholdningen.
        public void CreateGame()
        {
        if (currentId == 0)
        {
        Id = currentId++;
        }
        else
        {
        Id = currentId++;
        }
        }

        //Method EditGame styrer redigering af spil i lagerbeholdningen
        public void EditGame()
        {
        }

        //Method EditGame sørger for sletning af spil i lagerbeholdningen
        public void DeleteGame()
        {
        }

        // Metode til at gemme en liste af afdelinger i en fil
        public void SaveGamesToFile(List<Game> games)
        {
        using (StreamWriter sw = new StreamWriter(filePath)) // Åbner filen til skrivning
        {
        foreach (var game in games)
        {
            foreach (var gameList in games)
            {
                sw.WriteLine(gameList.ToString()); // Gemmer hver medarbejder som en linje i filen
            }
        }
    }
}
    }
}