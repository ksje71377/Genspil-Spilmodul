using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil_Spilmodul
{
    public class MenuRetriever
    {
        public void RetrieveMenu()
        {
            Console.WriteLine("\t****----- Spil -----****");
            Console.WriteLine("\n\n\n\tAngiv, hvad du ønsker at gøre:");
            Console.WriteLine("\n-------------------------------------------------\n");
            Console.WriteLine("Tast det ønskede tal, og tryk på enter. Funktionen vil herefter aktiveres.\n");

            //Henter metoder fra GameManager klassen

            Console.WriteLine("\t- 1. Opret spil i lagerbeholdning");
            Console.WriteLine("\t- 2. Ret eller ændre spil i lagerbeholdning");

            Console.WriteLine("\n\t- 3. Opret efterlysning på spil");
            Console.WriteLine("\t- 4. Ret eller ændre efterlysning på spil");

            //Henter foreach loop til at printe lagerbeholdning

            Console.WriteLine("\n\t- 5. Print lagerbeholdning");

            //Sletter vores list<t> gameList, som er vores lagerbeholdning

            Console.WriteLine("\n\t- 6. Slet database");

            Console.WriteLine("\n\t- 7. Afslut programmet");
        }
    }
}
