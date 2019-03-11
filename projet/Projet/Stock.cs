using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Projet
{
    public partial class Stock : Form
    {
        List<String> products;
        DB_ENTITIES _db;
        public Stock()
        {
            InitializeComponent();
            products = new List<string>();
            this.listView1.View = View.List;
            _db = new DB_ENTITIES();
            initialiseProduits("");
        }

        public void initialiseProduits(String str)
        {
            this.listView1.Items.Clear();
            this.products.Clear();
            if (str.Equals(""))
            {
                var produits = _db.Produits;
                foreach (Produits p in produits)
                {
                    int n = produits.Where(s => s != null && s.Nom.Equals(p.Nom)).Count();
                    String description = "Produit " + p.Nom + ".            Quantité : " + n;
                    if (!this.products.Contains(description))
                    {
                        this.listView1.Items.Add(p.idProduits + ". " + description);
                        this.products.Add(description);
                    }
                }
            } else
            {
                var produits = _db.Produits;
                foreach (Produits p in produits)
                {
                    int n = produits.Where(s => s != null && s.Nom.Equals(p.Nom)).Count();
                    String description = "Produit " + p.Nom + ".            Quantité : " + n;
                    if (!this.products.Contains(description) && description.Contains(this.textBox1.Text))
                    {
                        this.products.Add(description);
                        this.listView1.Items.Add(p.idProduits + ". " + description);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initialiseProduits("typed");
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = int.Parse(this.listView1.SelectedItems[0].SubItems[0].Text.Split('.')[0]);
            Produits toShow = _db.Produits.Find(id);
            ProduitsSheet sheet = new ProduitsSheet(toShow);
            sheet.Show();
        }

        private void nouv_Click(object sender, EventArgs e)
        {
            NewProduct n = new NewProduct(this);
            n.Show();
            this.Hide();
        }
    }
}
