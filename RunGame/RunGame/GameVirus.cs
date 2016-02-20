using System.Collections.Generic;
using System.Linq;

namespace RunGame
{
    class GameVirus
    {
        public List<IPlayer> Gamers { get; private set; }
        private List<IPlayer> _virused;
        private bool _blue = true;

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
            foreach (var g in Gamers.Where(g => !_virused.Contains(g)))
                g.Run();
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
            foreach (IPlayer g in Gamers)
                if (!_virused.Contains(g))
                {
                    if (_virused.Count == Gamers.Count - 1)
                    {
                        SetNewVirus(g);
                        break;
                    }
                    foreach (var virus in _virused)
                        if (g.IsCatch(virus))
                        {
                            _virused.Add(g);
                            g.Gole();
                            break;
                        }
                }
        }
    }
}
