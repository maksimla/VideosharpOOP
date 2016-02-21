using System.Collections.Generic;
using System.Linq;

namespace RunGame
{
    internal class GameCatch : IGame
    {
        public List<IPlayer> Gamers { get; }
        public bool FreezeAll { get; set; }
        public bool FreezeBed { get; set; }
        private IPlayer _leader;
        private int _leaderSkipSteps;
        private const int MaxSkipSteps = 10;

        public GameCatch()
        {
            Gamers = new List<IPlayer>();
            _leader = null;
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
            if (_leader == null)
                return;
            if (_leaderSkipSteps > 0)
            {
                _leaderSkipSteps--;
                return;
            }

            foreach (var g in Gamers.Where(g => !_leader.Equals(g)).Where(g => _leader.IsCatch(g)))
            {
                SetNewLeader(g);
                break;
            }
        }

        public void RunAll()
        {
            if (FreezeAll)
                return;
            if (FreezeBed)
                foreach (var g in Gamers.Where(g => !_leader.Equals(g)))
                    g.Run();
            else
                Gamers.ForEach(g => g.Run());
        }

        private void SetNewLeader(IPlayer gamer)
        {
            _leader?.NoGole();
            _leader = gamer;
            _leader?.Gole();
            _leaderSkipSteps = MaxSkipSteps;
        }
    }
}
