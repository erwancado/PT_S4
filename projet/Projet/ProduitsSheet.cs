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
    public partial class ProduitsSheet : Form
    {
        Produits p;
        DB_ENTITIES _db;
        public ProduitsSheet(Produits p)
        {
            InitializeComponent();
            this.p = p;
            this._db = new DB_ENTITIES();
            intialiseText();
        }

        private void intialiseText()
        {
            this.d.Text = p.Description;
            this.nom.Text = p.Nom;
            this.pa.Text = p.PrixAcquisition.ToString();
            this.pv.Text = p.PrixVente.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
