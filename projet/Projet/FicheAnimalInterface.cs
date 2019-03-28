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
           // allAnimalsClient.FullRowSelect = true;
            InitializeIntels();
        }

        private void InitializeIntels()
        {
            nom.Text += " " + animal.Nom;
            String naissance = animal.DateNaissance.ToString();
            dateNais.Text += " " + naissance;
            poids.Text += " " + animal.Poids.ToString();
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

        private void supprimerAnimal_Click(object sender, EventArgs e)
        {
            
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
            //Maladie
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

        }
    }
}
