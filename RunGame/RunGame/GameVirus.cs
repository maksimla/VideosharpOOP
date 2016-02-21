using System.Collections.Generic;
using System.Linq;

namespace RunGame
{
    internal class GameVirus : IGame
    {
        public List<IPlayer> Gamers { get; }
        public bool FreezeAll { get; set; }
        public bool FreezeBed { get; set; }
        private List<IPlayer> _virused;

        public GameVirus()
        {
            Gamers = new List<IPlayer>();
            _virused = new List<IPlayer>();
        }

        public void AddGamer(IPlayer gamer)
        {
            Gamers.Add(gamer);
            SetNewVirus(gamer);
        }

        public void Step()
        {
            RunAll();
            FindNewVirus();
        }

        private void RunAll()
        {
            if (FreezeAll)
                return;
            if (FreezeBed)
                foreach (var g in Gamers.Where(g => !_virused.Contains(g)))
                    g.Run();
            else
                Gamers.ForEach(g => g.Run());
        }

        private void SetNewVirus(IPlayer gamer)
        {
            _virused = new List<IPlayer>();

            Gamers.ForEach(g => g.NoGole());
            gamer.Gole();
            _virused.Add(gamer);
        }

        private void FindNewVirus()
        {
            foreach (var g in Gamers.Where(g => !_virused.Contains(g)))
            {
                if (_virused.Count == Gamers.Count - 1)
                {
                    SetNewVirus(g);
                    break;
                }

                if (!_virused.Any(v => g.IsCatch(v))) continue;
                _virused.Add(g);
                g.Gole();
            }
        }
    }
}
