using System.Collections.Generic;

namespace LoveLetter
{
    public class Player
    {
        private string _name;
        private List<Card> _hand = new List<Card>();
        private int _tokens;
        private bool _isOut;
        private bool _isProtected;
        private int _totalCards = 0;

        public Player(string pName)
        {
            _name = pName;
        }

        public string Name
        {
            get { return _name; }
        }

        public List<Card> Hand
        {
            get { return _hand; }
        } 

        public void AddToHand(Card pCard)
        {
            _hand.Add(pCard);
        }

        public void AddToTotal(Card pCard)
        {
            _totalCards += pCard.Score;
        }
    }
}