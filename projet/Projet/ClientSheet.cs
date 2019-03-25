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

        DB_ENTITIES _db;

        public ClientSheet( Clients client)
        {
            _db = new DB_ENTITIES();
            InitializeComponent();
            this.client = client;
            InitializeIntels();
        }

        private void InitializeIntels()
        {
            nameLabel.Text += " " + client.Nom;
            prenomLabel.Text += " " + client.Prenom;
            String naissance = client.DateNaissance.ToString();
            NaissanceLabel.Text += " " +  naissance;
            emailLabel.Text += " " + client.Email;
            telLabel.Text += " " + client.Téléphone;
            adressLabel.Text += " "+ client.Adresse;
            if (client.Sexe == null) {
                client.Sexe = "M";
            }
            if (client.Sexe.Equals("M")) {
                sexeLabel.Text += " Masculin";
            }
            else
            {
                sexeLabel.Text += " Féminin";
            }
            completeAnimalList("");
            completeRDVList();
        }

        private void completeRDVList()
        {
            this.allRDVList.Items.Clear();
            var appointments = _db.RendezVous;
            foreach (RendezVous appointment in appointments) {
                allRDVList.Items.Add(appointment.Date.ToString());
            }
        }

        private void completeAnimalList(String request)
        {
            this.allAnimalsClient.Items.Clear();
            if (request.Equals("")) {
                var animals = _db.Animaux;
                foreach (Animaux animal in animals)
                {
                    if (animal.Clients_idClients == client.idClients) {
                        ListViewItem item = new ListViewItem(animal.idAnimaux.ToString());
                        item.SubItems.Add(animal.Nom);
                        item.SubItems.Add(animal.Poids.ToString());
                        String race = "";
                        foreach (Race raceSelected in animal.Race)
                        {
                            race += raceSelected.Nom + "/";
                        }
                        item.SubItems.Add(race);
                        allAnimalsClient.Items.Add(item);
                    }
                }
            }
            allAnimalsClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            allAnimalsClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private String getRaceNom(Race race) {
            var races = _db.Race;
            foreach (Race raceSelected in races)
            {
                if (race.Nom.Equals(raceSelected.Nom)) {
                    return raceSelected.Nom;
                }
            }
            return null;
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            ClientForm modifyClient = new ClientForm(client, _db, null);
            modifyClient.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
              
        }

        private void addAnimalButton_Click(object sender, EventArgs e)
        {

        }

        private void addRDVButton_Click(object sender, EventArgs e)
        {

        }

        private void allAnimalsClient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("genugnue");
            int id = int.Parse(this.allAnimalsClient.SelectedItems[0].Text);
            Animaux toShow = _db.Animaux.Find(id);
            FicheAnimalInterface sheet = new FicheAnimalInterface(toShow);
            sheet.Show();
        }
    }
}
