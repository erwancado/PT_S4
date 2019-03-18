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
    public partial class Planning : Form
    {
        DB_ENTITIES _db;
        DataGridView planning = new DataGridView();
        public Planning()
        {
            InitializeComponent();
            var rdv = _db.RendezVous;
        }

        private void Planning_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pT4_S4P2C_E3DataSet.RendezVous'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rendezVousTableAdapter.Fill(this.pT4_S4P2C_E3DataSet.RendezVous);
            
                

        }

        private void songsDataGridView_CellFormatting(object sender,
        System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
        }
}
