using System.Collections.Generic;

namespace LoveLetter
{
    public class Game
    {
        private Player _winner;
        private List<Player> _players = new List<Player>();

        public List<Player> Players
        {
            get { return _players; }
        }

        public void AddPlayer(Player pPlayer)
        {
            _players.Add(pPlayer);
        }
    }
}