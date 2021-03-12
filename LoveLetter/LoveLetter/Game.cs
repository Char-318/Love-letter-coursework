namespace LoveLetter
{
    public class Game
    {
        private Player _winner;
        private Player[] _players;
        private Card[] _cards = new Card[16];

        public void CreateDeck()
        {
            for (int i = 0; i < 5; i++)
            {
                Card guard = new Guard();
                _cards[i] = guard;
            }

            for (int i = 5; i < 7; i++)
            {
                Card priest = new Priest();
                _cards[i] = priest;
            }

            for (int i = 7; i < 9; i++)
            {
                Card baron = new Baron();
                _cards[i] = baron;
            }

            for (int i = 9; i < 11; i++)
            {
                Card handmaid = new Handmaid();
                _cards[i] = handmaid;
            }

            for (int i = 11; i < 13; i++)
            {
                Card prince = new Priest();
                _cards[i] = prince;
            }
            
            Card king = new King();
            Card countess = new Countess();
            Card princess = new Princess();
            _cards[13] = king;
            _cards[14] = countess;
            _cards[15] = princess;
        }
    }
}