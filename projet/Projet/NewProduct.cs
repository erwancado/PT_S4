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
    public partial class NewProduct : Form
    {
        DB_ENTITIES _db;
        Stock s;
        public NewProduct(Stock s)
        {
            InitializeComponent();
            this.s = s;
            _db = new DB_ENTITIES();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            DateTime d;
            if (!pAcq.Text.Equals("") && !pVente.Text.Equals("") && !dAcq.Text.Equals("") 
                && !re.Text.Equals("") && !des.Text.Equals("") && !pNom.Text.Equals("") && DateTime.TryParse(dAcq.Text, out d))
            {
                Produits toInsert = new Produits();
                toInsert.Nom = pNom.Text;
                toInsert.refProduits = re.Text;
                toInsert.Description = des.Text;
                toInsert.PrixAcquisition = Convert.ToInt32(pAcq.Text);
                toInsert.PrixVente = Convert.ToInt32(pVente.Text);
                toInsert.DateAcquisition = DateTime.Parse(dAcq.Text);
                _db.Produits.Add(toInsert);
                _db.SaveChanges();
                s.initialiseProduits("");
                s.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Show();
            this.Close();
        }
    }
}
