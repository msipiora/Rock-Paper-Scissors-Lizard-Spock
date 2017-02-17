using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class PlayGame : Program
    {
        Player player = new Player();
        Player opponent = new Player();
        Game startgame = new Game();

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
                OpponentSelection = OpponentSelection.ToLower();
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
            if (player.playerScore < 2 && player.opponentScore < 2)
            {
                ComputerChoice();
                Console.WriteLine($"{player.player1Name}, choose 'rock' 'paper' 'scissors' 'spock' or 'lizard'");
                string playerChoice = Console.ReadLine();
                playerChoice = playerChoice.ToLower();



                switch (playerChoice)
                {
                    case "rock":
                        {
                            if (OpponentSelection == "rock")
                            {
                                if(numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} tied {player.opponentName}. No score");
                                MakeChoice();
                            }

                            if (OpponentSelection == "paper")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "scissors")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "spock")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "lizard")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
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
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "paper")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} tied {player.opponentName}. No score");
                                MakeChoice();

                            }
                            if (OpponentSelection == "rock")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "spock")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "lizard")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
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
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "paper")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "scissors")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} tied {player.opponentName}. No score.");
                                MakeChoice();

                            }

                            if (OpponentSelection == "spock")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "lizard")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
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
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "paper")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "spock")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "lizard")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "lizard")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} tied {player.opponentName}. No score.");
                                MakeChoice();

                            }
                            break;
                        }
                    case "spock":
                        {
                            if (OpponentSelection == "rock")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} won. You scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "paper")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} lost. {player.opponentName} scored a point.");
                                player.opponentScore += 1;
                                MakeChoice();

                            }
                            if (OpponentSelection == "scissors")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} won and scored a point.");
                                player.playerScore += 1;
                                MakeChoice();

                            }

                            if (OpponentSelection == "spock")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
                                Console.WriteLine($"{player.player1Name} tied {player.opponentName}. No score.");
                                MakeChoice();

                            }
                            if (OpponentSelection == "lizard")
                            {
                                if (numberofPlayers == "1")
                                {
                                    Console.WriteLine($"{player.opponentName} chose {OpponentSelection}");

                                }
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
            
            else if (player.playerScore > 1)
            {
                Console.WriteLine($"Congratulations {player.player1Name} you dominated {player.opponentName}. Enter 'restart' to play again or anything else to end the game");
                string EndChoice = Console.ReadLine();
                EndChoice = EndChoice.ToLower();
                switch (EndChoice)
                {
                    case "restart":
                        startgame.StartGame();
                        break;
                    default:
                        Environment.Exit(0);
                        break;

                        }
            }

            else
            {
                Console.WriteLine($"{player.opponentName} dominated {player.player1Name}. Type 'restart' to play again or anything else to end the game");
                string EndChoice = Console.ReadLine();
                EndChoice = EndChoice.ToLower();
                switch (EndChoice)
                {
                    case "restart":
                        startgame.StartGame();
                        break;
                    default:
                        Environment.Exit(0);
                        break;

                }
            }

        }

    }
}

            
        

    


