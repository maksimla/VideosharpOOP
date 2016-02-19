using System.Collections.Generic;
using System.Linq;

namespace RunGame
{
    class GameCatch
    {
        public List<IPlayer> Gamers { get; private set; }
        IPlayer Leader;

        public GameCatch()
        {
            Gamers = new List<IPlayer>();
            Leader = null;
        }

        public void AddGamer(IPlayer gamer)
        {
            Gamers.Add(gamer);
            SetNewLeader(gamer);
        }

        public void Step()
        {
            RunAll();
            FindNewLeader();
        }

        private void FindNewLeader()
        {
            if (Leader == null)
                return;
            foreach (IPlayer g in Gamers)
            {
                if (Leader.IsCatch(g))
                {
                    SetNewLeader(g);
                    break;
                }
            }
        }

        public void RunAll()
        {
            foreach (var g in Gamers)
                g.Run();
        }

        private void SetNewLeader(IPlayer gamer)
        {
            if (Leader != null)
                Leader.NoGole();
            Leader = gamer;
            if (Leader != null)
                Leader.Gole();
        }
    }
}
