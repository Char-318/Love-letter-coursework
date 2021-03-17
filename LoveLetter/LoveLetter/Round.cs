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
            }
            
            CreateQueue();

            do
            {
                Player currentPlayer = _playersQueue.Dequeue();
                Console.WriteLine(currentPlayer.Name + "'s turn:");
                drawPile.DrawCard(currentPlayer);
                //Console.WriteLine("Hand: {0}, {1}", currentPlayer.Hand.ElementAt(0).Name, currentPlayer.Hand.ElementAt(1).Name);
                Console.Write("Hand: ");
                foreach (Card card in currentPlayer.Hand)
                {
                    Console.Write(card.Name + " ");
                }
                Console.WriteLine();R

                _playersQueue.Enqueue(currentPlayer);
            } while (_playersQueue.Count != 1 && drawPile._cards.Count != 0);
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