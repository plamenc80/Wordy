namespace Wordy
{
    public partial class Startmenu : Form
    {
        public Startmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Game game = new Game();
            game.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
          Quit quit = new Quit();
            quit.Show();
        }
    }
}
