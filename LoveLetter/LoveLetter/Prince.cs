namespace LoveLetter
{
    public class Prince : Card
    {
        private Player _player;
        
        public Prince() : base()
        {
            _name = "Prince";
            _description = "Choose any player (including yourself) to discard their hand and draw a new card.";
            _score = 5;
        }
    }
}