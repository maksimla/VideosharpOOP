using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunGame
{
    internal interface IGame
    {
        List<IPlayer> Gamers { get; }
        bool FreezeAll { get; set; }
        bool FreezeBed { get; set; }
        void AddGamer(IPlayer gamer);
        void Step();
    }
}
