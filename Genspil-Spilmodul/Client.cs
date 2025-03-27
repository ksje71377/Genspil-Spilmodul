using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil_Spilmodul
{
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
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Du kan ikke have en e-mail som ikke indeholder et @.");
                }
                email = value;
            }
        }

public int nPhoneNumber
{
    get { return phoneNumber; }
    set
    {
        // Tjek om nummeret er et gyldigt 8-cifret telefonnummer

        if (value < 20000000 || value > 99999999)
        {
            throw new ArgumentException("FEJL. Telefonnummeret er ikke et gyldigt format");
        }
        phoneNumber = value; // Gem telefonnummeret, hvis det er gyldigt
    }
}

        public string nCity
        { get; set; }

        public int nPostalCode
        {
            get { return postalCode; }
            set
            {
                //Postnr skal være mellem 1000 og 9999 for at være gyldigt:

                if (value < 1000 || value > 9999)
                {
                    throw new ArgumentException("FEJL. Postnr er ikke et gyldigt format");
                }
                postalCode = value; // Gem postnummeret
            }
        }


        //Constructor Client definerer standardværdier for en ny kunde i tilfælde af blankt input

        public Client()
        {
            address = "undefined";
            city = "undefined";
            postalCode = 0000;
        }
    }
    }
