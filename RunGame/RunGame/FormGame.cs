using System;
using System.Windows.Forms;

namespace RunGame
{
    public partial class FormGame : Form
    {
        private readonly Arena _arena;
        private IGame _game;

        public FormGame()
        {
            InitializeComponent();
            _arena = new Arena(picture);
            Checked();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _game.Step();
            _arena.Clear();

            _game.Gamers.ForEach(obj => _arena.Show(obj));
            _arena.Refresh();
        }

        private void radioGolia_CheckedChanged(object sender, EventArgs e)
        {
            Checked();
        }

        private void radioVirus_CheckedChanged(object sender, EventArgs e)
        {
            Checked();
        }

        private void buttonAddCircle_Click(object sender, EventArgs e)
        {
            AddCircle();
        }

        private void buttonAddBox_Click(object sender, EventArgs e)
        {
            AddBox();
        }

        private void buttonAddGamer_Click(object sender, EventArgs e)
        {
            AddCircle();
            AddBox();
        }

        private void Checked()
        {
            if (radioGolia.Checked)
            {
                _game = new GameCatch();
                checkStopBed.Text = "Стоп Голя";
            }
            if (radioVirus.Checked)
            {
                _game = new GameVirus();
                checkStopBed.Text = "Стоп Вирус";
            }
            timer.Enabled = true;
        }

        private void AddCircle(int? count = null)
        {
            if (count == null) count = 5;
            for (var i = 0; i < count; i++)
                _game.AddGamer(Arena.NewCircle());
        }

        private void AddBox(int? count = null)
        {
            if (count == null) count = 5;
            for (var i = 0; i < count; i++)
                _game.AddGamer(Arena.NewBox());
        }

        private void checkStopAll_CheckedChanged(object sender, EventArgs e)
        {
            _game.FreezeAll = checkStopAll.Checked;
        }

        private void checkStopBed_CheckedChanged(object sender, EventArgs e)
        {
            _game.FreezeBed = checkStopBed.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hide = (string)button1.Tag == "True";

            panel1.Visible = !hide;
            button1.Text = hide ? "показать" : "скрыть";
            button1.Tag = (!hide).ToString();

        }
    }
}
