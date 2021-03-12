using System;
using System.Linq;

namespace LoveLetter
{
    public class Round
    {
        private int _numOfPlayers;
        private Card _hiddenCard;

        public Round()
        {
            DrawPile drawPile = new DrawPile();
            drawPile.Shuffle();
            _hiddenCard = drawPile._cards.ElementAt(0);
            drawPile._cards.RemoveAt(0);

            _numOfPlayers = Program.game.Players.Count;
        }
    }
}