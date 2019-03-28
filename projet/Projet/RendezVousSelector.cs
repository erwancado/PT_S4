using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class RendezVousSelector : Form
    {
        private List<RendezVous> rdvs;
        private DB_ENTITIES _db;

        public RendezVousSelector(List<RendezVous> rendezVous)
        {
            rdvs = rendezVous;
            _db = new DB_ENTITIES();
            InitializeComponent();
            foreach(RendezVous rdv in rendezVous)
                listRdv.Items.Add(rdv.Date.ToShortTimeString() + "  " + rdv.Clients.Prenom + " " + rdv.Clients.Nom);
        }


        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listRdv.SelectedItem == null)
                MessageBox.Show("Sélectionnez un rendez-vous.");
            else
            {
                int selectedRdv = listRdv.SelectedIndex;
                RendezVousForm rendezVousForm = new RendezVousForm(rdvs[selectedRdv]);
                rendezVousForm.Show();
                this.Close();
            }
            
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listRdv.SelectedItem == null)
                MessageBox.Show("Sélectionnez un rendez-vous.");
            else
            {
                RendezVous selectedRdv = rdvs[listRdv.SelectedIndex];
                Utils.removeRdv(selectedRdv.idRendezVous, _db);
                _db.SaveChanges();
                this.Close();
            }
            

        }
    }
}
