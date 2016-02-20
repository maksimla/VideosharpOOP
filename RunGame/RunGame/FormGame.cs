using System.Windows.Forms;

namespace RunGame
{
    public partial class FormGame : Form
    {
        private Arena _arena;
        public FormGame()
        {
            InitializeComponent();
            _arena = new Arena(picture);
        }

        private void buttonAddGamer_Click(object sender, System.EventArgs e)
        {

            for (int i = 0; i < 10; i++)
                _arena.Show(Arena.NewCircle());
            _arena.Refresh();
        }
    }
}
