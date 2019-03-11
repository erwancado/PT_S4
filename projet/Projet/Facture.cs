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
    public partial class Facture : Form
    {
        public Facture(List<Soins> soins, Animaux animal, Clients client)
        {
            InitializeComponent();
            soins.ForEach(s => this.soinsList.Items.Add(s.Description));
            this.animalName.Text = animal.Nom;
            this.nameClient.Text = client.Nom;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(prix.Text, out int n);
            if (isNumeric && !prix.Text.Equals(""))
            {
                generateFacture();
            } else
            {
                MessageBox.Show("Enter a valide price!");
            }
        }

        private void generateFacture()
        {
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
                        doc.Add(new Paragraph("Concernant l'animal " + animalName.Text + " appartenant à " + nameClient.Text + "."));
                        doc.Add(new Paragraph(" Prix : " + prix.Text));
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
