namespace LoveLetter
{
    public class Countess : Card
    {
        public Countess(string pName, string pDescription, int pScore, int pAmount) : base(pName, pDescription, pScore, pAmount)
        {
            pName = "Countess";
            pDescription = "If you have this card and the King or Prince in your hand, you must discard this card.";
            pScore = 7;
            pAmount = 1;
        }
    }
}