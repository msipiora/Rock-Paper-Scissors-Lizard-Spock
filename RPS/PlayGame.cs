using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class PlayGame
    {
        Player player = new Player();
        Player opponent = new Player();

        public string numberofPlayers;
        public string OpponentSelection;
        public int PlayerScore = 0;
        public int OpponentScore = 0;
        string[] choices = new string[] { "rock", "paper", "scissors", "spock", "lizard" };
        public PlayGame()
        {

        }

        public void GetPlayers()
        {
            Console.WriteLine("How many players? Enter '1' or '2'");
            numberofPlayers = Console.ReadLine();
            switch (numberofPlayers)
            {
                case "1":
                    {
                        player.getNamesComputer();
                        break;
                    }
                case "2":
                    {
                        player.getNamesPlayers();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Only type '1' or '2'");
                        GetPlayers();
                        break;
                    }


            }
        }





        public void ComputerChoice()
        {
            Random rand = new Random();

            if (numberofPlayers == "2")
            {
                Console.WriteLine($"{player.opponentName}, choose 'rock' 'paper' 'scissors' 'spock' or 'lizard'");
                OpponentSelection = Console.ReadLine();
                if (OpponentSelection != "rock" && OpponentSelection != "paper" && OpponentSelection != "scissors" && OpponentSelection != "spock" && OpponentSelection != "lizard")
                {
                    Console.WriteLine("Invalid selection");
                    ComputerChoice();
                }
            }
            else
            {
                OpponentSelection = choices[rand.Next(0, choices.Length)];
            }
        }


        public void MakeChoice()
        {
            while (player.playerScore < 2 && player.opponentScore < 2)
            {
                ComputerChoice();
                Console.WriteLine($"{player.player1Name}, choose 'rock' 'paper' 'scissors' 'spock' or 'lizard'");
                string playerChoice = Console.ReadLine();



                switch (playerChoice)
                {
                    case "rock":
                        {
                            if (OpponentSelection == "rock")
                            {
                                Console.WriteLine($"{player.player1Name} tied {player.opponentName}. No score");
                                MakeChoice();
                            }

                            if (OpponentSelection == "paper")
                            {
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "scissors")
                            {
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "spock")
                            {
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "lizard")
                            {
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }
                            break;
                        }
                    case "paper":
                        {
                            if (OpponentSelection == "scissors")
                            {
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "paper")
                            {
                                Console.WriteLine($"{player.player1Name} tied {player.opponentName}. No score");
                                MakeChoice();

                            }
                            if (OpponentSelection == "rock")
                            {
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "spock")
                            {
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "lizard")
                            {
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            break;
                        }
                    case "scissors":
                        {
                            if (OpponentSelection == "rock")
                            {
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "paper")
                            {
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "scissors")
                            {
                                Console.WriteLine($"{player.player1Name} tied {player.opponentName}. No score.");
                                MakeChoice();

                            }

                            if (OpponentSelection == "spock")
                            {
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "lizard")
                            {
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }
                            break;
                        }

                    case "lizard":
                        {
                            if (OpponentSelection == "rock")
                            {
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "paper")
                            {
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "scissors")
                            {
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "spock")
                            {
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "lizard")
                            {
                                Console.WriteLine($"{player.player1Name} tied {player.opponentName}. No score.");
                                MakeChoice();

                            }
                            break;
                        }
                    case "spock":
                        {
                            if (OpponentSelection == "rock")
                            {
                                Console.WriteLine($"{player.player1Name} won. You scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "paper")
                            {
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "scissors")
                            {
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "spock")
                            {
                                Console.WriteLine($"{player.player1Name} tied {player.opponentName}. No score.");
                                MakeChoice();

                            }
                            if (OpponentSelection == "lizard")
                            {
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            break;

                        }
                    default:
                        Console.WriteLine("Invalid selection");
                        MakeChoice();
                        break;
                }

            }

        }
        public void EndGame()
        {
            if (playerScore = 2)
            {

            }

            



        }

    }
}

            
        

    


