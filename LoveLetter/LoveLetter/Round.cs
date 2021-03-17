using System;
using System.Linq;

namespace LoveLetter
{
    public class Round
    {
        private int _numOfPlayers;
        private Card _hiddenCard;
        
        public DrawPile drawPile = new DrawPile();

        public Round()
        {
            drawPile.Shuffle();
            _hiddenCard = drawPile._cards.ElementAt(0);
            drawPile._cards.RemoveAt(0);
        }

        public void StartRound()
        {
            _numOfPlayers = Program.game.Players.Count;
            
            foreach (Player player in Program.game.Players)
            {
                drawPile.DrawCard(player);
                Console.WriteLine("{0} has the {1}", player.Name, player.Hand.ElementAt(0).Name);
            }
            
            Random rand = new Random();
            int randNum = rand.Next(0, _numOfPlayers);
            Player firstPlayer = Program.game.Players.ElementAt(randNum);
            Console.WriteLine(firstPlayer.Name + " is going first.");
        }
    }
}