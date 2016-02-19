using System.Collections.Generic;

namespace RunGame
{
    class GameCatch
    {
        public List<IPlayer> Gamers { get; private set; }
        IPlayer Leader;

        public GameCatch()
        {
            Gamers = new List<IPlayer>();
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
            foreach (var g in Gamers)
                if (Leader.IsCatch(g))
                    SetNewLeader(g);
        }

        public void RunAll()
        {
            foreach (var g in Gamers)
                g.Run();
        }

        private void SetNewLeader(IPlayer gamer)
        {
            Leader.NoGole();
            Leader = gamer;
            Leader.Gole();
        }
    }
}
