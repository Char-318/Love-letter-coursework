using System.Linq;

namespace LoveLetter
{
    public class DiscardPile : CardCollection
    {
        public void DiscardCard(Player pPlayer, int pCardIndex)
        {
            Card card = pPlayer.Hand.ElementAt(pCardIndex);
            _cards.Add(card);
            pPlayer.Hand.RemoveAt(pCardIndex);
            pPlayer.AddToTotal(card);
        }
    }
}