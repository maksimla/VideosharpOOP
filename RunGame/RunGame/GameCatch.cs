using System.Collections.Generic;

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
            foreach (IPlayer g in Gamers)
            {
                if (!Leader.Equals(g))
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
                //if (!Leader.Equals(g) || leaderSkipSteps == 0)
                g.Run();
        }

        private void SetNewLeader(IPlayer gamer)
        {
            if (Leader != null)
                Leader.NoGole();
            Leader = gamer;
            if (Leader != null)
                Leader.Gole();
            leaderSkipSteps = MaxSkipSteps;
        }
    }
}
