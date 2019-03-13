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

        Clients client;
        bool isModification;

        ClientList clientList;


        public ClientForm(Clients clientSelected, DB_ENTITIES _db, ClientList clientList)
        {
            InitializeComponent();
            isModification = false;
            this.clientList = clientList;
            client = clientSelected;
            this._db = _db;
            isMan = true;
            SelectedDate = DateTime.Now;
            if (client != null)
            {
                initializeInput();
                isModification = true;
            }
        }

        private void initializeInput()
        {
            nameTextBox.Text = client.Nom;
            prenomTextBox.Text = client.Prenom;
            adressTextBox.Text = client.Adresse;
            emailTextBox.Text = client.Email;
            SelectedDate = (DateTime ) client.DateNaissance;
            naissanceDatePicker.Value = SelectedDate;
            if (client.Sexe.Equals("M"))
            {
                manRadioButton.Checked = true;
            }
            else {
                womanRadioButton.Checked = true;
            }
            telTextBox.Text = client.Téléphone.ToString();
            validateButton.Text = "Modifier";

        }
        private void validateButton_Click(object sender, EventArgs e)
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
                if (womanRadioButton.Checked)
                {
                    toInsert.Sexe = "F";
                }
                else
                {
                    toInsert.Sexe = "M";
                }
                if (telTextBox.Text == "")
                {
                    MessageBox.Show("numéro null");
                }
                try
                {
                    toInsert.Téléphone = Int32.Parse(telTextBox.Text);
                    if (client == null)
                    {
                        _db.Clients.Add(toInsert);
                    }
                    else {
                        client.Nom = toInsert.Nom;
                        client.Prenom = toInsert.Prenom;
                        client.Adresse = toInsert.Adresse;
                        client.Email = toInsert.Email;
                        client.DateNaissance = toInsert.DateNaissance;
                        client.Sexe = toInsert.Sexe;
                        client.Téléphone = toInsert.Téléphone;
                    }
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
                    if (!isModification)
                    {
                        MessageBox.Show("Client inscrit");
                    }
                    else {
                        MessageBox.Show("Client modifier");
                    }
                    this.Hide();
                    ClientSheet clientInsert = new ClientSheet(myClient);
                    clientInsert.Show();
                    clientList.InitializeClientList("");
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

            private void naissanceDatePicker_ValueChanged(object sender, EventArgs e)
        {
            SelectedDate = naissanceDatePicker.Value;
        }

        
    }
}
