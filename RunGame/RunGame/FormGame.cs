using System.Windows.Forms;

namespace RunGame
{
    public partial class FormGame : Form
    {
        private Arena _arena;
        private GameVirus _game;

        public FormGame()
        {
            InitializeComponent();
            _arena = new Arena(picture);
            _game = new GameVirus();
            timer.Enabled = true;
        }

        private void buttonAddGamer_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                _game.AddGamer(Arena.NewCircle());
            _game.SetNewVirus(_game.Gamers[0]);
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
