namespace Kursovaya
{
    public partial class AppMenu : Form
    {
        public AppMenu()
        {
            InitializeComponent();
        }

        private void button_football_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FootballCategory().ShowDialog();
            this.Show();
        }

        private void button_basketball_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BasketballCategory().ShowDialog();
            this.Show();
        }

        private void button_tennis_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TennisCategory().ShowDialog();
            this.Show();
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RunningCategory().ShowDialog();
            this.Show();
        }

        private void button_swim_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SwimmingCategory().ShowDialog();
            this.Show();
        }

        private void button_bucket_Click(object sender, EventArgs e)
        {
            this.Hide();
            new placing_an_order().ShowDialog();
            this.Show();
        }
    }
}
