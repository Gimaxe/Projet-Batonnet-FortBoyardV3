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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            ChargerLaListe();
            InitializeComponent();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ChargerLaListe();
        }

        private void ChargerLaListe()
        {
            try
            {
                using (FortBoyardRomainMathisContext db = new FortBoyardRomainMathisContext())
                {
                    List<Partie> partie = db.Parties.ToList();
                    foreach (Partie par in partie)
                    {
                        listboxPartieTrouve.Items.Add(par);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
