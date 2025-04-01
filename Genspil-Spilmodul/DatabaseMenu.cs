using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil_Spilmodul
{
    internal class DatabaseMenu
    {
        public void RetrieveDatabaseMenu()
        {
            //henter metode til at slette diverse databaser.
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("\n\n\tSlet database");
            Console.WriteLine("-----------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nADVARSEL - ved at slette database fjernes data PERMANENT.");
            Console.ResetColor();

            Console.WriteLine("\n\tEr du sikker på, at du vil slette en database? Bekræft ved at taste \"slette\" og trykke på \"enter\".\nEnhver anden input afbryder operationen og venter retur til forrige menu.");
                        
            if (Console.ReadLine().ToLower() == "slette")
                        {
                            Console.WriteLine("\n\tTast 1 efterfulgt af \"enter\" for at slette database for spil\n\tTast 2. efterfulgt af \"enter\" for at slette database for kunder.");
                        }
            else
                Console.Clear();
        }
}
}
