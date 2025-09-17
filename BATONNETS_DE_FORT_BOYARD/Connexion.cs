using BATONNETS_DE_FORT_BOYARD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BATONNETS_DE_FORT_BOYARD
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using FortBoyardRomainMathisContext db = new FortBoyardRomainMathisContext();
                Compte compte = new Compte();

                string GetUserName = db.Comptes.Where(o => o.Pseudo == Txt_UserName.Text).ToString();
                string GetPassword = db.Comptes.Where(o => o.MotDePasse == HashPassword.Hash(Txt_Password.Text)).ToString();
                if (GetUserName == Txt_UserName.Text && GetPassword == HashPassword.Hash(Txt_Password.Text))
                {
                    MessageBox.Show("Test OK");
                }
                else
                {
                    MessageBox.Show("Test PAS OK");
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}