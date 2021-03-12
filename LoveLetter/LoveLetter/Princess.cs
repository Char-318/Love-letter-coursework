namespace LoveLetter
{
    public class Princess : Card
    {
        public Princess(string pName, string pDescription, int pScore, int pAmount) : base(pName, pDescription, pScore, pAmount)
        {
            pName = "Princess";
            pDescription = "If you discard this card, you are out of the round.";
            pScore = 8;
            pAmount = 1;
        }
    }
}