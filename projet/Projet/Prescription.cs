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
    public partial class Prescription : Form
    {
        String nameClient;
        String prenomClient;
        DateTime birthdayClient;
        String prescription;
        DB_ENTITIES _db;

        int idClientSelected;
        int idAnimalSelected;
        String searchName;

        
        String productSelect;

        public Prescription(int idClient, int idAnimal)
        {
            idClientSelected = idClient;
            idAnimalSelected = idAnimal;
            _db = new DB_ENTITIES();
            InitializeComponent();
            InitializeClientList("");
            InitializeProduct();
            if (idAnimal != 0 && idClient != 0)
            {
                secondPagePanel.Visible = true;
            }
            listClient.FullRowSelect = true;
            ClientsAnimal.FullRowSelect = true;
            
        }

        public void InitializeClientList(String request)
        {
            this.listClient.Items.Clear();
            if (request.Equals(""))
            {
                var clients = _db.Clients;
                foreach (Clients client in clients)
                {
                    ListViewItem item = new ListViewItem(client.idClients.ToString());
                    item.SubItems.Add(client.Nom);
                    item.SubItems.Add(client.Prenom);
                    DateTime naissance = (DateTime)client.DateNaissance;
                    item.SubItems.Add(naissance.ToShortDateString());
                    listClient.Items.Add(item);
                }
            }
            else
            {
                if (request.Equals("typed"))
                {
                    var clients = _db.Clients;
                    foreach (Clients client in clients)
                    {
                        if (client.Nom.StartsWith(searchName))
                        {
                            ListViewItem item = new ListViewItem(client.idClients.ToString());
                            item.SubItems.Add(client.Nom);
                            item.SubItems.Add(client.Prenom);
                            item.SubItems.Add(client.DateNaissance.ToString());
                            item.SubItems.Add(client.Téléphone.ToString());
                            item.SubItems.Add(client.Email);
                            item.SubItems.Add(client.ProchaineVisite.ToString());
                            listClient.Items.Add(item);

                        }
                    }
                }
            }
            listClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (idAnimalSelected != 0 && idClientSelected != 0)
            {
                secondPagePanel.Visible = true;
            }
            else {
                MessageBox.Show("Merci de selectionner un client et son animal");
            }
            
        }

        private void searchClientButton_Click(object sender, EventArgs e)
        {
            nameClient = nameInput.Text;
            prenomClient = prenomInput.Text;
            birthdayClient = birthdayInput.Value;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            secondPagePanel.Visible = false;
        }

        private void addLineButton_Click(object sender, EventArgs e)
        {
            prescription += "❏ " + productSelect +
                            "\n      " + posologyInput.Text + "\n";
            essaiLabel.Text = prescription;
        }

        private void removeLineButton_Click(object sender, EventArgs e)
        {
            String[] eachPrescription = essaiLabel.Text.Split('❏');
            String result = "";
            for (int i = 0; i < eachPrescription.Length - 1; i++) {
                if (eachPrescription[i] != " " && eachPrescription[i] != "")
                {
                    result += "❏" + eachPrescription[i];
                }
            }
            prescription = result;
            essaiLabel.Text = prescription;
        }

        private void pdfExportButton_Click(object sender, EventArgs e)
        {
            
            DateTime today = DateTime.Today;
            Clients client = _db.Clients.Find(idClientSelected);
            Animaux animal = _db.Animaux.Find(idAnimalSelected);
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new Paragraph("Ordonnance du " + today.ToString("dd/MM/yyyy")));
                        doc.Add(new Paragraph("Concernant l'animal " + animal.Nom + " appartenant à " + client.Nom + "."));
                        doc.Add(new Paragraph(prescription));
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
            MessageBox.Show("Ordonnance a bien été généré");
            this.Hide();
        }

        private void listClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listClient.SelectedItems.Count > 0)
            {
                idClientSelected = int.Parse(this.listClient.SelectedItems[0].Text);
                InitializeClientAnimal(idClientSelected);
            }
            
        }

        private void InitializeClientAnimal(int idClientSelected)
        {
            var animaux = _db.Animaux;
            ClientsAnimal.Items.Clear();
            foreach (Animaux animal in animaux)
            {
                if (animal.Clients_idClients == idClientSelected) {

                    ListViewItem item = new ListViewItem(animal.idAnimaux.ToString());
                    item.SubItems.Add(animal.Nom);
                    DateTime naissance = (DateTime)animal.DateNaissance;
                    item.SubItems.Add(naissance.ToShortDateString());
                    ClientsAnimal.Items.Add(item);

                }
            
            }
            ClientsAnimal.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ClientsAnimal.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ClientsAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientsAnimal.SelectedItems.Count > 0)
            {
                idAnimalSelected = int.Parse(this.ClientsAnimal.SelectedItems[0].Text);
            }
        }

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productSelect = productListBox.SelectedItem.ToString();
        }

        private void InitializeProduct()
        {
            var products = _db.Produits;
            List<String> mesProduits = new List<String>();
            foreach (Produits product in products)
            {
                if (!mesProduits.Contains(product.Nom)) {
                    mesProduits.Add(product.Nom);
                    productListBox.Items.Add(product.Nom);
                }

            }
        }
    }
}
