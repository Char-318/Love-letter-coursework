using System.Collections;
using System.Collections.Generic;

namespace LoveLetter
{
    public class CardCollection
    {
        public List<Card> _cards = new List<Card>();
        public Card[] _allCards = new Card[16];

        public CardCollection()
        {
            for (int i = 0; i < 5; i++)
            {
                Card guard = new Guard();
                _allCards[i] = guard;
            }

            for (int i = 5; i < 7; i++)
            {
                Card priest = new Priest();
                _allCards[i] = priest;
            }

            for (int i = 7; i < 9; i++)
            {
                Card baron = new Baron();
                _allCards[i] = baron;
            }

            for (int i = 9; i < 11; i++)
            {
                Card handmaid = new Handmaid();
                _allCards[i] = handmaid;
            }

            for (int i = 11; i < 13; i++)
            {
                Card prince = new Prince();
                _allCards[i] = prince;
            }
            
            Card king = new King();
            Card countess = new Countess();
            Card princess = new Princess();
            _allCards[13] = king;
            _allCards[14] = countess;
            _allCards[15] = princess;
        }
    }
}