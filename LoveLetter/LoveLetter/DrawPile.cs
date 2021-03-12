using System;
using System.Collections.Generic;
using System.Linq;

namespace LoveLetter
{
    public class DrawPile : CardCollection
    {
        private Card _card;
        
        public void Shuffle()
        {
            List<Card> allCards = Program.game.Cards.ToList();
            Random rand = new Random();

            for (int i = 15; i >= 0; i--)
            {
                int randIndex = rand.Next(0, i + 1);
                Card randCard = allCards.ElementAt(randIndex);
                allCards.RemoveAt(randIndex);
                _cards.Add(randCard);
            }
        }
    }
}