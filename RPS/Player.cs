using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Player
    {
        //member variables
        public string player1Name;
        public string opponentName;
        public int playerScore;
        public int opponentScore;

        //constructor
        public Player()
        {


        }

        //methods
        public void getNamesComputer()
        {
            Console.WriteLine("Please enter your name: ");
            player1Name = Console.ReadLine();
            Console.WriteLine("Name the computer too: ");
            opponentName = Console.ReadLine();
        }
        public void getNamesPlayers()
        {
            Console.WriteLine("Please enter player 1 name: ");
            player1Name = Console.ReadLine();
            Console.WriteLine("Please enter player 2 name: ");
            opponentName = Console.ReadLine();
        }
        public void playerWin()
        {
            playerScore += 1;

        }
        public void computerWin()
        {
            opponentScore += 1;
        }

    }
}