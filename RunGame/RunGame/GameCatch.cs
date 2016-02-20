using System.Collections.Generic;
using System.Linq;

namespace RunGame
{
    class GameCatch
    {
        public List<IPlayer> Gamers { get; private set; }
        IPlayer Leader;
        private int leaderSkipSteps;
        private static int MaxSkipSteps = 10;

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
            if (leaderSkipSteps > 0)
            {
                leaderSkipSteps--;
                return;
            }

            foreach (var g in Gamers.Where(g => !Leader.Equals(g)).Where(g => Leader.IsCatch(g)))
            {
                SetNewLeader(g);
                break;
            }
        }

        public void RunAll()
        {
            Gamers.ForEach(g => g.Run());
        }

        private void SetNewLeader(IPlayer gamer)
        {
            Leader?.NoGole();
            Leader = gamer;
            Leader?.Gole();
            leaderSkipSteps = MaxSkipSteps;
        }
    }
}
