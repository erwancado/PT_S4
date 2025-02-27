﻿using System;
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
            //Position
            Point p = new Point(110, 145);
            this.Location = p;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
                        this.listView1.Items.Add(p.idProduits + ". " + description + ". Prix :" + p.PrixVente);
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
                    if (!this.products.Contains(description) && description.ToLower().Contains(this.textBox1.Text.ToLower()))
                    {
                        this.products.Add(description);
                        this.listView1.Items.Add(p.idProduits + ". " + description + ". Prix :" + p.PrixVente);
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
            NewProduct n = new NewProduct(this, this._db, null);
            n.Show();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        this.contextMenuStrip1.Show(this.listView1, e.Location);
                    }
                    break;
            }
        }

        private void vendreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.listView1.SelectedItems[0].SubItems[0].Text.Split('.')[0]);
            Produits toShow = _db.Produits.Find(id);
            ProductSell sheet = new ProductSell(toShow, this);
            sheet.Show();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.listView1.SelectedItems[0].SubItems[0].Text.Split('.')[0]);
            Produits toShow = _db.Produits.Find(id);
            NewProduct sheet = new NewProduct(this, this._db, toShow);
            sheet.Show();
        }

        private void Stock_ResizeEnd(object sender, EventArgs e)
        {
            
        }
    }
}
