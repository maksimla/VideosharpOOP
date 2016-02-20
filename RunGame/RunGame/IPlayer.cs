using System.Drawing;

namespace RunGame
{
    public interface IPlayer
    {
        void Run();
        void Gole();
        void NoGole();
        bool IsCatch(object obj);
        void Draw(Graphics graph);

    }
}
