namespace LoveLetter
{
    public class Priest : Card
    {
        private Player _player;
        
        public Priest() : base()
        {
            _name = "Priest";
            _description = "Look at another player's hand.";
            _score = 2;
        }
    }
}