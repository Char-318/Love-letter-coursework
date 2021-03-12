namespace LoveLetter
{
    public class Guard : Card
    {
        private Player _player;
        private Card _card;
        
        public Guard() : base()
        {
            _name = "Guard";
            _description = 
                "Name a non-Guard card and choose another player. " +
                "If that player has that card, they are out of the round.";
            _score = 1;
        }
    }
}