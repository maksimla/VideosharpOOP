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
            SetNewLeader(Gamers.FirstOrDefault(a => Leader.IsCatch(a)));
        }

        public void RunAll()
        {
            foreach (var g in Gamers)
                g.Run();
        }

        private void SetNewLeader(IPlayer gamer)
        {
            Leader?.NoGole();
            Leader = gamer;
            Leader?.Gole();
        }
    }
}
