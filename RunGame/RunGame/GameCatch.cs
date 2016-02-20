using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace RunGame
{
    public class GameCatch
    {
        public List<IPlayer> Gamers { get; private set; }
        IPlayer _Leader;

        public GameCatch()
        {
            Gamers = new List<IPlayer>();
            _Leader = null;
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
            if (_Leader == null)
                return;
            SetNewLeader(Gamers.FirstOrDefault(g=>_Leader.IsCatch(g)));
            /* foreach (IPlayer g in Gamers)
            {
                if (_Leader.IsCatch(g))
                {
                    SetNewLeader(g);
                    break;
                }
            }*/
        }

        public void RunAll()
        {
            Gamers.ForEach(g=>g.Run());
            /*foreach (var g in Gamers)
                g.Run();*/
        }

        private void SetNewLeader(IPlayer gamer)
        {
            _Leader?.NoGole();
            _Leader = gamer;
            _Leader?.Gole();
        }
    }
}
