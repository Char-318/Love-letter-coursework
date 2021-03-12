namespace LoveLetter
{
    public class Card
    {
        protected string _name;
        protected string _description;
        protected int _score;
        protected int _amount;

        public Card(string pName, string pDescription, int pScore, int pAmount)
        {
            _name = pName;
            _description = pDescription;
            _score = pScore;
            _amount = pAmount;
        }
    }
}