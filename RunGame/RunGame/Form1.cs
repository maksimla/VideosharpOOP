using System.Windows.Forms;

namespace RunGame
{
    public partial class Form1 : Form
    {
        private GameCatch game;
        private Arena arena;

        public Form1()
        {
            InitializeComponent();
            Init();
            AddGamers();
        }

        private void AddGamers()
        {
            game.AddGamer(new Circle(100, 100, 50));
            game.AddGamer(new Circle(50, 50, 10));
            arena.DrawAll(game.Gamers);
        }

        private void Init()
        {
            game = new GameCatch();
            arena = new Arena(pictureBox1);
        }
    }
}
