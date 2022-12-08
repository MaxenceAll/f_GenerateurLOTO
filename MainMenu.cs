namespace f_GenerateurLOTO
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classique classique = new Classique();
            classique.tirer();
        }
    }
}