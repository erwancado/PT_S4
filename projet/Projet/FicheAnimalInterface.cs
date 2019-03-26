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
            InscriptionAnimalInterface modifyAnimal = new InscriptionAnimalInterface(animal, _db, null);
            modifyAnimal.Show();
            this.Hide();
        }

        private void supprimerAnimal_Click(object sender, EventArgs e)
        {

        }
    }
}
