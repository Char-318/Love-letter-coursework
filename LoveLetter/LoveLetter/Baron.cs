using System.Buffers.Text;

namespace LoveLetter
{
    public class Baron : Card
    {
        private Player _player;

        public Baron(string pName, string pDescription, int pScore, int pAmount) : base(pName, pDescription, pScore, pAmount)
        {
            pName = "Baron";
            pDescription = 
                "You and another player secretly compare hands. The player with the lower value is out of the round.";
            pScore = 3;
            pAmount = 2;
        }
    }
}