using System;
using System.Collections.Generic;
using System.Linq;

namespace LoveLetter
{
    public class Round
    {
        private int _numOfPlayers;
        private Card _hiddenCard;
        private Queue<Player> _playersQueue = new Queue<Player>();
        
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
            
            CreateQueue();
        }

        public void CreateQueue()
        {
            Random rand = new Random();
            int randNum = rand.Next(0, _numOfPlayers);
             
            for (int i = randNum; i < _numOfPlayers; i++)
            {
                _playersQueue.Enqueue(Program.game.Players.ElementAt(i));
            }

            if (randNum != 0)
            {
                for (int i = 0; i < randNum; i++)
                {
                    _playersQueue.Enqueue(Program.game.Players.ElementAt(i));
                }
            }

        }
    }
}