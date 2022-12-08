namespace f_GenerateurLOTO
{
    public partial class MainMenu : Form
    {
        Classique classique = new Classique();
        public MainMenu()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            switch (choixJeu.SelectedIndex)
            {
                case 0: classique.tirer(); break;
                case 1: break;
                default: break;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}