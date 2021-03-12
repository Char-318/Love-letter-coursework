namespace LoveLetter
{
    public class Guard : Card
    {
        private Player _player;
        private Card _card;
        
        public Guard(string pName, string pDescription, int pScore, int pAmount) : base(pName, pDescription, pScore, pAmount)
        {
            pName = "Guard";
            pDescription = 
                "Name a non-Guard card and choose another player. " +
                "If that player has that card, they are out of the round.";
            pScore = 1;
            pAmount = 5;
        }
    }
}