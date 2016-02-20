using System.Windows.Forms;

namespace RunGame
{
    public partial class FormGame : Form
    {
        private Arena _arena;
        private GameCatch _game;

        public FormGame()
        {
            InitializeComponent();
            _arena = new Arena(picture);
            _game= new GameCatch();
            timer.Enabled = true;
        }

        private void buttonAddGamer_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                _game.AddGamer(Arena.NewCircle());
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            _game.Step();
            _arena.Clear();

            foreach (Circle circle in _game.Gamers)
               _arena.Show(circle);
            _arena.Refresh();
        }
    }
}
