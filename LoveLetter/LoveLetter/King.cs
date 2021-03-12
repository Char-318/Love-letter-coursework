namespace LoveLetter
{
    public class King : Card
    {
        private Player _player;
        
        public King() : base()
        {
            _name = "King";
            _description = "Trade hands with another player of your choice.";
            _score = 6;
        }
    }
}