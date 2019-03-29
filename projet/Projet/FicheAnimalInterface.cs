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
    public partial class FicheAnimalInterface : Form
    {
        private Animaux animal;

        DB_ENTITIES _db;
        public FicheAnimalInterface(Animaux animal)
        {
            _db = new DB_ENTITIES();
            InitializeComponent();
            this.animal = animal;
            InitializeIntels();
            listOfDiseases.FullRowSelect = true;
            listReminders.FullRowSelect = true;
            completeMaladieList();
            completeRemindersList();
        }

        private void InitializeIntels()
        {
            nom.Text += " " + animal.Nom;
            String naissance = animal.DateNaissance.ToString();
            dateNais.Text += " " + naissance;
            poids.Text += " " + animal.Poids.ToString();
            Clients monClient = _db.Clients.Find(animal.Clients_idClients);
            nomProprietaire.Text += " " + monClient.Nom;
            Race maRace = new Race();
            foreach (Race race in animal.Race)
            {
                maRace = race;
            }
            Especes monEspece = _db.Especes.Find(maRace.Especes_idEspeces);
            nomRace.Text += " " + maRace.Nom;
            nomEspece.Text += " " + monEspece.Nom;
            //   emailLabel.Text += " " + client.Email;
            // telLabel.Text += " " + client.Téléphone;
            //adressLabel.Text += " " + client.Adresse;
            if (animal.Sexe == null)
            {
                animal.Sexe = "M";
            }
            if (animal.Sexe.Equals("M"))
            {
                sexe.Text += " Masculin";
            }
            else
            {
                sexe.Text += " Féminin";
            }
           // completeAnimalList("");
           //completeRDVList();
        }

        private void modifierAnimal_Click(object sender, EventArgs e)
        {
            InscriptionAnimalInterface modifyAnimal = new InscriptionAnimalInterface(animal, null, null);
            modifyAnimal.Show();
            this.Hide();
        }


        private void retourPageAnimal_Click(object sender, EventArgs e)
        {
            AnimauxInterface toShow = new AnimauxInterface();
            toShow.Show();
            this.Hide();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Soin
            MessageBox.Show("add soins");
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Soin
            MessageBox.Show("modifier soins");
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Soins
            MessageBox.Show("Supprimer soins");
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Maladies_Form maladies_Form = new Maladies_Form(animal);
            maladies_Form.Show();
            MessageBox.Show("add maladie");
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Maladie
            MessageBox.Show("modifier maladie");
        }

        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Maladie
            MessageBox.Show("Supprimer maladie");
        }

        private void ajouterRappel_Click(object sender, EventArgs e)
        {
            Rappels_Form rappels_Form = new Rappels_Form(animal);
            rappels_Form.Show();
        }


        private void completeMaladieList()
        {
            this.listOfDiseases.Items.Clear();
                var maladies = _db.Animaux_maladies;
                foreach (Animaux_maladies maladie in maladies)
                {
                    if (maladie.Animaux_idAnimaux== animal.idAnimaux) {
                        var mesMaladies = _db.Maladies;
                        foreach (Maladies mal in mesMaladies) {
                            if (mal.idMaladies == maladie.Maladies_idMaladies) {
                                ListViewItem item = new ListViewItem();
                                item.SubItems.Add(mal.Nom);
                                item.SubItems.Add(maladie.Date.ToShortDateString());
                                listOfDiseases.Items.Add(item);
                            }
                        }
                    }
                }
            listOfDiseases.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            listOfDiseases.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void completeRemindersList()
        {
            this.listReminders.Items.Clear();
            var rappels = _db.Rappel.Where(r => r.Animaux_idAnimaux == animal.idAnimaux);
            
            foreach (Rappel rappel in rappels)
            {
                ListViewItem item = new ListViewItem(rappel.Description);
                item.SubItems.Add(rappel.Date.ToShortDateString());
                listReminders.Items.Add(item);
            }
            listReminders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listReminders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void supprimerAnimal_Click(object sender, EventArgs e)
        {
            Utils.removeAnimal(animal.idAnimaux, _db);
        }

        private void genererOrdonnance_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription(animal.Clients_idClients, animal.idAnimaux);
            prescription.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            completeMaladieList();
            completeRemindersList();
        }
    }
}
