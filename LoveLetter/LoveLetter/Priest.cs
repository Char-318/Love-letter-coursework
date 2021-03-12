namespace LoveLetter
{
    public class Priest : Card
    {
        private Player _player;
        
        public Priest(string pName, string pDescription, int pScore, int pAmount) : base(pName, pDescription, pScore, pAmount)
        {
            pName = "Priest";
            pDescription = "Look at another player's hand.";
            pScore = 2;
            pAmount = 2;
        }
    }
}