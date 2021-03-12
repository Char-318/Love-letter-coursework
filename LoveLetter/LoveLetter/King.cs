namespace LoveLetter
{
    public class King : Card
    {
        private Player _player;
        
        public King(string pName, string pDescription, int pScore, int pAmount) : base(pName, pDescription, pScore, pAmount)
        {
            pName = "King";
            pDescription = "Trade hands with another player of your choice.";
            pScore = 6;
            pAmount = 1;
        }
    }
}