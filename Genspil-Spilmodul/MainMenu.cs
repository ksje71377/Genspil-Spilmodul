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

            //Henter metoder fra GameManager klassen

            Console.WriteLine("\t- 1. Opret spil i lagerbeholdning");
            Console.WriteLine("\t- 2. Ret eller ændre spil i lagerbeholdning");

            Console.WriteLine("\n\t- 3. Opret efterlysning på spil");
            Console.WriteLine("\t- 4. Ret eller ændre efterlysning på spil");

            //Henter foreach loop til at printe lagerbeholdning

            Console.WriteLine("\n\t- 5. Print lagerbeholdning");



            Console.WriteLine("\n\t- 7. Afslut programmet");
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("\nAndre funktioner:");
            Console.WriteLine("\n-----------------------------------------------------------------------------");

            //Hvis man ønsker at rette manuelt i kundekartoteket. 

            Console.WriteLine("\n\t- 10. Tilgå kundekartoteket manuelt");
            
            //Sletter vores list<t> gameList, som er vores lagerbeholdning, eller kundedatabasen. 

            Console.WriteLine("\n\t- 11. Slet database(r)");
            Console.WriteLine("\n-----------------------------------------------------------------------------");
        }
    }
}
