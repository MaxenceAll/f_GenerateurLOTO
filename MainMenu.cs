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
            switch (choixJeu.SelectedIndex)
            {
                case 0: Classique classique = new Classique(); classique.tirer(); break;
                case 1: break;
                default: break;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}