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
        public DiscardPile discardPile = new DiscardPile();

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
                Console.WriteLine();
                
                AskToDiscard(currentPlayer);

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

        public void AskToDiscard(Player pCurrentPlayer)
        {
            Console.WriteLine("Which card would you like to discard?");
            string input = Console.ReadLine();
            bool validInput = false;
            int chosenCard = 0;
                
            for (int i = 0; i < pCurrentPlayer.Hand.Count; i++)
            {
                if (pCurrentPlayer.Hand[i].Name.ToUpper() == input.ToUpper())
                {
                    validInput = true;
                    chosenCard = i;
                    break;
                }
            }

            if (validInput == false)
            {
                Console.WriteLine("Please enter a valid card name.");
                AskToDiscard(pCurrentPlayer);
            }
            
            discardPile.DiscardCard(pCurrentPlayer, chosenCard);
        }
    }
}