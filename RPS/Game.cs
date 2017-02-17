using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Game
    {
        public void StartGame()
        {
            Intro gameStart = new Intro();
            PlayGame names = new PlayGame();
            gameStart.RunIntro();
            names.GetPlayers();
            names.MakeChoice();
        }
    }
}
