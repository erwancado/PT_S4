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
        int prix;
        int quantité;
        public ProductSell(Produits produit, Stock stock)
        {
            InitializeComponent();
            this.produit = produit;
            this.label1.Text = "0";
            this.quantité = int.Parse(this.label1.Text);
            _db = new DB_ENTITIES();
            findStock();
            fillList();
            this.pro.Text = produit.Nom;
            this.client.Text = "";
            this.s = stock;
            this.textBox1.Enabled = false;
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
                this.listBox1.Items.Add(c.idClients + ". " + c.Nom + " " + c.Prenom);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.label1.Text) < stock)
            {
                this.label1.Text = Convert.ToString(Convert.ToInt32(this.label1.Text) + 1);
                this.quantité++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.label1.Text) > 0)
            {
                this.label1.Text = Convert.ToString(Convert.ToInt32(this.label1.Text) - 1);
                this.quantité--;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.client.Text = this.listBox1.SelectedItem.ToString();
            int nbRDV = _db.RendezVous.AsEnumerable().Where(rdv => rdv.Clients_idClients == int.Parse(this.listBox1.SelectedItem.ToString().Split('.')[0])).Count();
            if (nbRDV >= 10)
            {
                this.textBox1.Enabled = true;
            }
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
            int price = (Convert.ToInt32(this.label1.Text) * produit.PrixVente) - this.prix;
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
                        doc.Add(new Paragraph("Concernant le produit : " + produit.Nom + " vendu au prix de " + produit.PrixVente + ", en quantité " + this.quantité));
                        doc.Add(new Paragraph(" Prix : " + price));
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            if (!textBox1.Text.Equals(""))
            {
                this.prix = int.Parse(textBox1.Text);
                Console.WriteLine(this.prix);
            }
        }
    }
}
