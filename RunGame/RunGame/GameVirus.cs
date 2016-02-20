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
            // SetNewVirus(gamer);
        }

        public void Step()
        {
            RunAll();
            FindNewVirus();
        }

        private void RunAll()
        {
            Gamers.ForEach(g => g.Run());
        }

        public void SetNewVirus(IPlayer gamer)
        {
            if (_blue)
                gamer.Gole();
            else
                gamer.NoGole();
            _virused.Add(gamer);
        }

        private void FindNewVirus()
        {
            foreach (var g in from g in Gamers.Where(g => !_virused.Contains(g)) from v in _virused.ToList().Where(v => v.IsCatch(g)) select g)
            {
                SetNewVirus(g);
            }

            if (Gamers.Count != _virused.Count + 1)
                return;
            var virus = Gamers.FirstOrDefault(g => !_virused.Contains(g));
            _virused = new List<IPlayer>();
            _blue = !_blue;
            SetNewVirus(virus);
        }
    }
}
