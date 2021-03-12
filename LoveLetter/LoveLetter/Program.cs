using System;

namespace LoveLetter
{
    class Program
    {
        public static Game game = new Game();

        static void Main(string[] args)
        {
            game.CreateDeck();

            int numOfPlayers = AskForPlayers();
            for (int i = 0; i < numOfPlayers; i++)
            {
                AskForName(i);
            }
        }

        private static int AskForPlayers()
        {
            Console.WriteLine("How many players are there?");
            Console.WriteLine("Enter a number from 2 to 4: ");
            string input = Console.ReadLine();
            int numOfPlayers = 0;

            try
            {
                numOfPlayers = int.Parse(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number.");
                AskForPlayers();
            }

            if (numOfPlayers < 2 || numOfPlayers > 4)
            {
                Console.WriteLine("Please enter a number from 2 - 4");
                AskForPlayers();
            }

            return numOfPlayers;
        }

        private static void AskForName(int pPlayerNumber)
        {
            Console.WriteLine("Enter player {0}'s name", pPlayerNumber + 1);
            string name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("Player must have a name.");
                AskForName(pPlayerNumber);
            }
            
            Player player = new Player(name);
            game.AddPlayer(player);
        }
    }
}