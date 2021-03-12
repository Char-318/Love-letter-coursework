namespace LoveLetter
{
    public class Handmaid : Card
    {
        public Handmaid(string pName, string pDescription, int pScore, int pAmount) : base(pName, pDescription, pScore, pAmount)
        {
            pName = "Handmaid";
            pDescription = "Until your next turn, ignore all effects from other players' cards.";
            pScore = 4;
            pAmount = 2;
        }
    }
}