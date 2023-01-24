using System;

namespace rockPaperScissors {
    class Program {

        static void Main(string[] args) {

            string inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    System.Console.Write("Choose between ROCK, PAPER, SCISSORS:     ");        

                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random random = new Random();

                    randomInt = random.Next(1,4); 
                
                switch(randomInt)
                {
                    case 1:
                        inputCPU = "ROCK";
                        System.Console.WriteLine("CPU choose ROCK");
                        if (inputPlayer == "ROCK")
                        {
                            System.Console.WriteLine("DRAW!!\n\n");
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            System.Console.WriteLine("PLAYER WINS!!\n\n");
                            scorePlayer++;
                        }
                        if (inputPlayer == "SCISSORS")
                        {
                            System.Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                    break;
                    case 2:
                        inputCPU = "PAPER";
                        System.Console.WriteLine("CPU choose PAPER");
                        if (inputPlayer == "PAPER")
                        {
                            System.Console.WriteLine("DRAW!!\n\n");
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            System.Console.WriteLine("PLAYER WINS!!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            System.Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                    break;
                    case 3:
                        inputCPU = "SCISSORS";
                        System.Console.WriteLine("CPU choose SCISSORS");
                        if (inputPlayer == "SCISSORS")
                        {
                            System.Console.WriteLine("DRAW!!\n\n");
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            System.Console.WriteLine("PLAYER WINS!!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            System.Console.WriteLine("CPU WINS!!\n\n");
                            scoreCPU++;
                        }
                    break;
                    default:
                        System.Console.WriteLine("INVALID ENTRY");
                    break;
                }
                System.Console.WriteLine("\n\nSCORES: \tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);
                }

                if (scorePlayer == 3)
                {
                    System.Console.WriteLine("PLAYER WON!");
                }
                else if (scoreCPU == 3)
                {
                    System.Console.WriteLine("CPU WON!");
                }
                else
                {

                }
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();

                if (loop == "y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
        }
    }
}