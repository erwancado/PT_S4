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
        private List<String> myAnimals;

        DB_ENTITIES _db;

        public ClientSheet( Clients client)
        {
            _db = new DB_ENTITIES();
            myAnimals = new List<string>();
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
        }

        private void completeAnimalList(String request)
        {
            this.listAnimals.Items.Clear();
            this.myAnimals.Clear();
            if (request.Equals("")) {
                var animals = _db.Animaux;
                foreach (Animaux animal in animals)
                {
                    if (animal.Clients_idClients == client.idClients) {
                        String race = "";
                        foreach (Race raceSelected in animal.Race)
                        {
                            race += raceSelected.Nom + "/";
                        }
                        String description = animal.idAnimaux + ". " + animal.Nom + " "
                                            + animal.Sexe + " "
                                            + race + " "
                                            + animal.DateNaissance.ToString() + " " +
                                            animal.Poids;
                        if (description != null)
                            if (!this.myAnimals.Contains(description))
                            {
                                this.listAnimals.Items.Add(description);
                                this.myAnimals.Add(description);
                            }
                    }
                }
            }
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
    }
}
