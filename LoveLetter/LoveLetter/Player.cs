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
        private int _totalCards;
    }
}