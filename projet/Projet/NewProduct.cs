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
        Produits p;
        public NewProduct(Stock s, DB_ENTITIES _db, Produits p)
        {
            InitializeComponent();
            this.s = s;
            this._db = _db;
            this.p = p;
            if (p != null)
            {
                fillInfos();
                this.qtt.Hide();
                this.label3.Hide();
            }
        }

        private void fillInfos()
        {
            pAcq.Text = p.PrixAcquisition.ToString();
            pVente.Text = p.PrixVente.ToString();
            dAcq.Text = p.DateAcquisition.ToString();
            re.Text = p.refProduits;
            des.Text = p.Description;
            pNom.Text = p.Nom;
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
                if (p == null)
                {
                    int i;
                    if (!this.qtt.Text.Equals("") && int.TryParse(this.qtt.Text, out i))
                    {
                        for (int j = 0; j < i; j++)
                        {
                            p = new Produits();
                            p.Nom = pNom.Text;
                            p.refProduits = re.Text;
                            p.Description = des.Text;
                            p.PrixAcquisition = Convert.ToInt32(pAcq.Text);
                            p.PrixVente = Convert.ToInt32(pVente.Text);
                            p.DateAcquisition = DateTime.Parse(dAcq.Text);
                            _db.Produits.Add(p);
                        }
                    }
                } else
                {
                    String old = p.Nom;
                    p.Nom = pNom.Text;
                    p.refProduits = re.Text;
                    p.Description = des.Text;
                    p.PrixAcquisition = Convert.ToInt32(pAcq.Text);
                    p.PrixVente = Convert.ToInt32(pVente.Text);
                    p.DateAcquisition = DateTime.Parse(dAcq.Text);
                    foreach (Produits pr in _db.Produits)
                    {
                        if (pr.Nom == old)
                        {
                            pr.Nom = pNom.Text;
                            pr.refProduits = re.Text;
                            pr.Description = des.Text;
                            pr.PrixAcquisition = Convert.ToInt32(pAcq.Text);
                            pr.PrixVente = Convert.ToInt32(pVente.Text);
                            pr.DateAcquisition = DateTime.Parse(dAcq.Text);
                        }
                    }
                }
                _db.SaveChanges();
                s.initialiseProduits("");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
