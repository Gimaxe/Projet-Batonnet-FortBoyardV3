namespace BATONNETS_DE_FORT_BOYARD
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
        }
    }
}
