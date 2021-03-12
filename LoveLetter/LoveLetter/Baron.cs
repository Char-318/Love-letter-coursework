using System.Buffers.Text;

namespace LoveLetter
{
    public class Baron : Card
    {
        private Player _player;

        public Baron() : base()
        {
            _name = "Baron";
            _description = 
                "You and another player secretly compare hands. The player with the lower value is out of the round.";
            _score = 3;
        }
    }
}