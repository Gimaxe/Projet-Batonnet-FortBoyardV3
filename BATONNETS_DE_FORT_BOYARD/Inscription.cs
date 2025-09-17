using BATONNETS_DE_FORT_BOYARD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BATONNETS_DE_FORT_BOYARD
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using FortBoyardRomainMathisContext db = new FortBoyardRomainMathisContext();
                Compte compte = new Compte();
                compte.Nom = Txt_Name.Text;
                compte.Prenom = Txt_Prenom.Text;
                compte.Pseudo = Txt_UserName.Text;
                compte.MotDePasse = HashPassword.Hash(Txt_Password.Text);
                db.Comptes.Add(compte);
                db.SaveChanges();
                MessageBox.Show("Inscriprion Réussi !");
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erreur :" + ex.Message );
            }

        }
    }
}
