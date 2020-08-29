using System;

public class RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int PlayerScore = 0;
            int CPUScore = 0;

            while (true)
            {
                //Pick
                Console.WriteLine("Pick rock, paper, or scissors");
                string input = Console.ReadLine();


                //Decides what CPU will play
                Random rand = new Random();
                int randomNum = rand.Next(1, 4);
                String CPUPick = "";

                switch (randomNum)
                {
                    case 1:
                        CPUPick = "rock";
                        if (input == "rock") Console.WriteLine("Tie");
                        else if (input == "paper") { Console.WriteLine("You Win!"); PlayerScore++; }
                        else if (input == "scissors") { Console.WriteLine("You Lose!"); CPUScore++; }
                        else Console.WriteLine("Wrong input");
                        Console.WriteLine("CPU picked " + CPUPick + "\n");
                        break;
                    case 2:
                        CPUPick = "paper";
                        if (input == "paper") Console.WriteLine("Tie");
                        else if (input == "scissors") { Console.WriteLine("You Win!"); PlayerScore++; }
                        else if (input == "rock") { Console.WriteLine("You Lose!"); CPUScore++; }
                        else Console.WriteLine("Wrong input");
                        Console.WriteLine("CPU picked " + CPUPick + "\n");
                        break;
                    case 3:
                        CPUPick = "scissors";
                        if (input == "scissors") Console.WriteLine("Tie");
                        else if (input == "rock") { Console.WriteLine("You Win!"); PlayerScore++; }
                        else if (input == "paper") { Console.WriteLine("You Lose!"); CPUScore++; }
                        else Console.WriteLine("Wrong input");
                        Console.WriteLine("CPU picked " + CPUPick + "\n");
                        break;
                }
                Console.WriteLine("Do you want to play again?");
                string input2 = Console.ReadLine();
                if (input2 == "yes") { Console.WriteLine(""); continue; }
                else break;
            }
        }
    }
}