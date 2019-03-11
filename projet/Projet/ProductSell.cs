using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class ProductSell : Form
    {
        Produits produit;
        int stock;
        DB_ENTITIES _db;
        Stock s;
        public ProductSell(Produits produit, Stock stock)
        {
            InitializeComponent();
            this.produit = produit;
            this.label1.Text = "0";
            _db = new DB_ENTITIES();
            findStock();
            fillList();
            this.pro.Text = produit.Nom;
            this.client.Text = "";
            this.s = stock;
        }

        private void findStock()
        {
            var produits = _db.Produits;
            stock = produits.Where(s => s != null && s.Nom.Equals(produit.Nom)).Count();
        }

        private void fillList()
        {
            var clients = _db.Clients;
            foreach (Clients c in clients)
            {
                this.listBox1.Items.Add(c.Nom + " " + c.Prenom);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.label1.Text) < stock)
            {
                this.label1.Text = Convert.ToString(Convert.ToInt32(this.label1.Text) + 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.label1.Text) > 0)
            {
                this.label1.Text = Convert.ToString(Convert.ToInt32(this.label1.Text) - 1);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.client.Text = this.listBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var produits = _db.Produits;
            int i = 0;
            foreach(Produits p in produits)
            {
                if (p.Nom.Equals(produit.Nom))
                {
                    if (i < Convert.ToInt32(this.label1.Text))
                    {
                        _db.Produits.Remove(p);
                        i++;
                    }
                }
            }
            _db.SaveChanges();
            generateFacture();
            s.initialiseProduits("");
            this.Close();
        }

        private void generateFacture()
        {
            int prix = Convert.ToInt32(this.label1.Text) * produit.PrixVente;
            DateTime today = DateTime.Today;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new Paragraph("Facture du " + today.ToString("dd/MM/yyyy")));
                        doc.Add(new Paragraph("Concernant le client : " + this.listBox1.SelectedItem.ToString() + "."));
                        doc.Add(new Paragraph("Concernant le produit : " + produit.Nom + " vendu au prix de " + produit.PrixVente + "."));
                        doc.Add(new Paragraph(" Prix : " + prix));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
    }
}
