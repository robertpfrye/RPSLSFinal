using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock. \n" +
                "The rules are simple, choose one of the five available gestures \n" +
                "and the entries will be compared to determine a winner for the \n" +
                "round or a tie. The winner is determined by the best of 3 rounds. \n" +
                "Each gesture beats 2 of the other gestures. Rock > Scissors & Lizard, \n" +
                "Paper > Rock & Spock, Scissors > Paper & Lizard, Lizard > Paper & \n" +
                "Spock, and Spock > Rock & Scissors.");

            //game.RunGame();
        }
    }
}
