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
    public partial class Prescription : Form
    {
        String nameClient;
        String prenomClient;
        DateTime birthdayClient;
        String prescription;

        public Prescription()
        {
            InitializeComponent(); 
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            secondPagePanel.Visible = true;
            essaiLabel.Text = "Le nom est :" + nameClient
                           + "\n Le prénom est :" + prenomClient
                           + "\n Il est née le :" + birthdayClient.ToShortDateString();
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
            prescription += "❏ " + productInput.Text +
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

        }
    }
}
