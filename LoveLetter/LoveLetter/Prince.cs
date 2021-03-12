namespace LoveLetter
{
    public class Prince : Card
    {
        private Player _player;
        
        public Prince(string pName, string pDescription, int pScore, int pAmount) : base(pName, pDescription, pScore, pAmount)
        {
            pName = "Prince";
            pDescription = "Choose any player (including yourself) to discard their hand and draw a new card.";
            pScore = 5;
            pAmount = 2;
        }
    }
}