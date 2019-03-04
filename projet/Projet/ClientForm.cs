using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class ClientForm : Form
    {
        private Boolean isMan;
        private DateTime SelectedDate;
        private String name;
        private String firstName;
        private String adress;
        private String tel;
        private String email;

        DB_ENTITIES _db;
        OleDbConnection dbConnection;


        public ClientForm()
        {
            InitializeComponent();
            _db = new DB_ENTITIES();
            isMan = true;
            SelectedDate = DateTime.Now;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            Clients toInsert = new Clients();
            toInsert.Nom = nameTextBox.Text;
            toInsert.Prenom = prenomTextBox.Text;
            toInsert.Adresse = adressTextBox.Text;
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(emailTextBox.Text);
                toInsert.Email = emailTextBox.Text;
                toInsert.DateNaissance = SelectedDate;
                if (isMan)
                {
                    toInsert.Sexe = "M";
                }
                else
                {
                    toInsert.Sexe = "F";
                }
                if (telTextBox.Text == "")
                {
                    MessageBox.Show("numéro null");
                }
                try
                {
                    toInsert.Téléphone = Int32.Parse(telTextBox.Text);
                    _db.Clients.Add(toInsert);
                    _db.SaveChanges();
                    inscriptionGood(toInsert);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("numéro incorrect (format incorrect)");
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("numéro incorrect (trop long) ");
                }
            }
            catch (FormatException ex)
            {
                emailTextBox.ResetText();
                MessageBox.Show("Email incorrect");
            }

        }

        private void inscriptionGood(Clients myClient)
        {
            var clients = _db.Clients;
            foreach (Clients client in clients)
            {
                if (client.Nom.Equals(myClient.Nom) && myClient.Prenom.Equals(myClient.Prenom)
                    && client.Adresse.Equals(myClient.Adresse) && client.Téléphone == myClient.Téléphone
                    && client.Email.Equals(myClient.Email) && client.DateNaissance == myClient.DateNaissance)
                {
                    MessageBox.Show("Client inscrit");
                }
                resetAllInput();
            }
        }

        private void resetAllInput()
        {
            nameTextBox.ResetText();
            prenomTextBox.ResetText();
            emailTextBox.ResetText();
            adressTextBox.ResetText();
            telTextBox.ResetText();
            naissanceDatePicker.ResetText();
        }

        private void womanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!womanRadioButton.Checked)
            {
                isMan = false;
            }
        }

        private void manRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!manRadioButton.Checked)
            {
                isMan = true;
            }
        }

        private void naissanceDatePicker_ValueChanged(object sender, EventArgs e)
        {
            SelectedDate = naissanceDatePicker.Value;
        }
    }
}
