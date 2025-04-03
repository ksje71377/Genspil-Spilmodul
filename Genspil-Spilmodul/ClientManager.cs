using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Genspil_Spilmodul
{



    //Klassen ClientManager indeholder alle relevante ændringsmuligheder for kunder

    public class ClientManager()

    {
        public Client PrepareNewClient()
        {
            return new Client();
        }

        //Følgende metoder tilføjer brugerinput til VARIABLER:

        //Bemærk "Client client" for at kunne tilgå instansen af Client-klassen.

        public void SetClientName(Client client)
        {
            //Metoden sætter navn på kunde.

            client.nName = Console.ReadLine();

        }

        public void SetClientAddress(Client client)
        {
            //Metoden sætter adresse på kunde.

            client.nAddress = Console.ReadLine();

        }
        public void SetClientPostal(Client client)
        {
            //Sætter postnummer på kunde.

            //Vi skal have nogle konverteringer fra strings til interger, men int.TryParse fungerer ikke med properties.
            //Derfor deklareres og initiliseres en midlertidig variabel som kan overføre værdien til klasse-properties. 

            int parsedValue;

            int.TryParse(Console.ReadLine(), out parsedValue);

            client.nPostalCode = parsedValue;

        }
        public void SetClientPhone(Client client)
        {
            //Sætter telefonnummer på kunde.

            int parsedValue;

            int.TryParse(Console.ReadLine(), out parsedValue);

            client.nPhoneNumber = parsedValue;

        }
        public void SetClientEmail(Client client)
        {
            //Sætter email på kunde.
            client.nEmail = Console.ReadLine();
        }

        //Følgende metoder relaterer sig til LISTER:

        //Kunde-liste deklareres 

        private List<Client> clientList;

        public void CreateClientList()
        {
            //Metoden opretter en ny liste til spil.

            clientList = new List<Client>();

        }
        public void CreateClient()
        {
            //Opretter en ny kunde i databasen - ny instant i Client klassen

            if (clientList == null)
            {
                CreateClientList();

                Client client = new Client();
                clientList.Add(new Client());
            }
            else
            {
                Client client = new Client();
                clientList.Add(new Client());
            }
        }
        public void UpdateClient()
        {
            //Opdaterer en kunde i databasen
        }
        public void DeleteClient()
        {
            //Sletter en kunde i databasen
        }
        }
    }
    
    
   
    
