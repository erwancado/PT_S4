using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class ClientSheet : Form
    {
        private Clients client;

        public ClientSheet( Clients client)
        {
            InitializeComponent();
            this.client = client;
            InitializeIntels();
        }

        private void InitializeIntels()
        {
            nameLabel.Text += " " + client.Nom;
            prenomLabel.Text += " " + client.Prenom;
            //MessageBox.Show(client.DateNaissance.ToString("d", CultureInfo.CreateSpecificCulture("fr-FR")));
            String naissance = "212/78/87";
            NaissanceLabel.Text += " " +  naissance;
            emailLabel.Text += " " + client.Email;
            telLabel.Text += " " + client.Téléphone;
            adressLabel.Text += " "+ client.Adresse;
            if (client.Sexe.Equals("M")) {
                sexeLabel.Text += " Masculin";
            }
            else
            {
                sexeLabel.Text += " Féminin";
            }

            
        }
    }
}
