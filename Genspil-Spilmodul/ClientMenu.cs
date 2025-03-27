using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil_Spilmodul
{
    public class ClientMenu()
    {
        public int clientMenuInput;

        public void RetrieveClientMenu()
        {
            //Ny instans af ClientManager klassen

            ClientManager clientManager = new ClientManager();

            //Clearer konsollen så der ikke er så meget "støj" på skærmen.

            Console.Clear();

            Console.WriteLine("\t****----- Kundekartotek -----****");
            Console.WriteLine("\n\n\n\tAngiv, hvad du ønsker at gøre:");
            Console.WriteLine("\n-------------------------------------------------\n");
            Console.WriteLine("Tast det ønskede tal, og tryk på enter. Funktionen vil herefter aktiveres.\n");

            //Henter metoder fra ClientManager klassen

            Console.WriteLine("\t- 1. Opret kunde i kunderegister");
            Console.WriteLine("\t- 2. Ret eller ændre kunde i kunderegister");

            //Henter foreach loop til at printe kunderegister

            Console.WriteLine("\n\t- 5. Print kunderegister");

            //Sletter vores list<t> clientList, som er vores kunderegister

            Console.WriteLine("\n\t- 7. Tilbage til hovedmenu");

            int.TryParse(Console.ReadLine(), out clientMenuInput);

            switch (clientMenuInput)
            {
                case 1:
                    Console.Clear();


                    Console.WriteLine("\t****----- Opret ny kunde -----****");
                    Console.WriteLine("\n\t- Tast '1' og Enter for at begynde processen.");

                        Client newClient = clientManager.PrepareNewClient();

                        Console.WriteLine("\n\t- Kundens navn");

                        clientManager.SetClientName(newClient); //Bemærk clientManager med småt - så er det non-static. Ellers ville C# tolke det som static, og det ville ikke virke. 

                        Console.WriteLine("\n\t- Kundens adresse");

                        clientManager.SetClientAddress(newClient);

                        Console.WriteLine("\n\t- Kundens postnummer");

                        clientManager.SetClientPostal(newClient);

                        Console.WriteLine("\n\t- Kundens telefonnummer");

                        clientManager.SetClientPhone(newClient);

                        Console.WriteLine("\n\t- Kundens email");

                        clientManager.SetClientEmail(newClient);
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("\n\n\t- Tryk på en vilkårlig tast for at gemme det indtastede i databasen.");
                        Console.WriteLine("-----------------------------------------------------------------------------");

                        clientManager.CreateClient();

                        Console.ReadLine();

                        break;
                    
                case 2:
                    clientManager.UpdateClient();
                    break;
                case 3:
                    clientManager.DeleteClient();
                    break;
                case 5:
                    clientManager.PrintList();
            }
        }
}
}

