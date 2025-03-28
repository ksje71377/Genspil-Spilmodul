﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil_Spilmodul
{
    //I tråd med princippet om konceptuelle klasser foregår alt databehandling og manipulering af spil gennem klassen GameManager.

        //Game liste deklareres 
        
        public class GameManager
        {

        private List<Game> gameList;

        //Følgende metoder tilføjer brugerinput til VARIABLER:

        public void SetGameName()
        {
            //Metoden sætter navn på spil.
        }

        //Følgende metoder relaterer sig til LISTER:

        //Metoden CreateGameList opretter en ny liste til spil.

        public void CreateGameList()
        {

            //Metoden opretter en ny liste til spil.

                gameList = new List<Game>();

        }
        //Method CreateGame opretter et nyt spil i lagerbeholdningen.
        public void CreateGame()
        {
            //Auto-check for eksisterende liste. Hvis listen ikke eksisterer, oprettes en ny liste.

            if (gameList == null)
            {
                CreateGameList();

                Game game = new Game();
                gameList.Add(new Game());
            }
            else
            {
                Game game = new Game();
                gameList.Add(new Game());
            }
        }
            //Method EditGame styrer redigering af spil i lagerbeholdningen
            public void EditGame()
            {
            }
            //Method DeleteGame sørger for sletning af spil i lagerbeholdningen
            public void DeleteGame()
            {
            }
        }
    }