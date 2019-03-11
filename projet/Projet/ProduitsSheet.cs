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
        public ProduitsSheet(Produits p)
        {
            InitializeComponent();
            this.p = p;
            intialiseText();
        }

        private void intialiseText()
        {
            this.desc.Text = p.Description;
            this.name.Text = p.Nom;
            this.acqP.Text = p.PrixAcquisition.ToString();
            this.sellingP.Text = p.PrixVente.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
