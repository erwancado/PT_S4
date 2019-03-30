using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projet
{
    public partial class InscriptionAnimalInterface : Form
    {


        private Boolean isMan;
        private String name;
        private String especee;
        private DateTime dateNais;
        private int poidss;

        private Especes especeSelected = null;

        private String infos;
        bool isModification;
        DB_ENTITIES _db;
        AnimauxInterface animalList;
        Animaux animal;
        Clients client;

        Race raceSelected;

        int idAnimal;

       
        

        public InscriptionAnimalInterface(Animaux animalSelected, AnimauxInterface animalInterface, Clients client)
        {

            InitializeComponent();
            isModification = false;
            this.client = client;
            dateTimePicker1.MaxDate = DateTime.Now;
            this.animalList = animalInterface;
            animal = animalSelected;
            this._db = new DB_ENTITIES();
            isMan = true;
            dateNais = DateTime.Now;
            idAnimal = 0;
            if (animal != null)
            {
                idAnimal = animal.idAnimaux;
                initializeInput();
                isModification = true;
            }
            init();
        }

        private void init()
        {
            var especes = _db.Especes;

            foreach(Especes espece in especes)
            {
               
                comboBox1.Items.Add(espece.Nom);
                
            }
         
        }

        private void initializeInput()
        {
            textBox1.Text = animal.Nom;
            dateNais = (DateTime)animal.DateNaissance;
            dateTimePicker1.Value = dateNais;
            richTextBox1.Text = animal.Caractéristiques;
            if (animal.Sexe.Equals("M"))
            {
                male.Checked = true;
            }
            else
            {
                femelle.Checked = true;
            }
            animal.Poids = (int)numericUpDown1.Value;
           
        }



        private void inscription_Click(object sender, EventArgs e)
        {
            Animaux an = new Animaux();
            an.Nom = textBox1.Text;
            an.Poids = (int)numericUpDown1.Value;
            an.Caractéristiques = richTextBox1.Text;
            an.DateNaissance = dateTimePicker1.Value;
            if (client != null) {

                an.Clients_idClients = client.idClients;
            }
            if (femelle.Checked)
            {
                an.Sexe = "F";
            }
            else
            {
                an.Sexe = "M";
            }
            if (animal == null)
            {
                _db.Animaux.Add(an);
            }
            else
            {
                animal.Nom = an.Nom;
                animal.DateNaissance = an.DateNaissance;
                animal.Sexe = an.Sexe;
                animal.Poids = an.Poids;
                animal.Caractéristiques = an.Caractéristiques;
            }
            _db.SaveChanges();
            var animaux = _db.Animaux;
            int max = 0;
            foreach (Animaux ani in animaux) {
                max = ani.idAnimaux;
            }
            List<Race> mesRaces = new List<Race>();
            mesRaces.Add(raceSelected);
            Animaux animal2 = _db.Animaux.Find(max);
         
            animal2.Race = mesRaces;
            _db.SaveChanges();
            inscriptionGood(an);
            
        }


        private void resetAllInput()
        {
            textBox1.ResetText();
            numericUpDown1.ResetText();
            richTextBox1.ResetText();
            dateTimePicker1.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void inscriptionGood(Animaux myAnimal)
        {
            var animaux = _db.Animaux;
            foreach (Animaux animal in animaux)
            {
                if (animal.Nom.Equals(myAnimal.Nom) && animal.Poids.Equals(myAnimal.Poids)
                    && animal.DateNaissance.Equals(myAnimal.DateNaissance) && animal.Caractéristiques == myAnimal.Caractéristiques) 
                {
                    MessageBox.Show("Animal inscrit");
                    this.animal = animal;
                    this.Hide();
                    FicheAnimalInterface animalInsert = new FicheAnimalInterface(myAnimal);
                    animalInsert.Show();
                    if (animalList != null)
                    {
                        animalList.InitializeAnimauxInterface("");
                    }
                }
                resetAllInput();
            }
        }

        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateNais = dateTimePicker1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string esp = comboBox1.SelectedItem.ToString();
            var races = _db.Race;
            foreach(Race race in races)
            {
                especeSelected = _db.Especes.Find(race.Especes_idEspeces);
                if (especeSelected.Nom.Equals(esp))
                {
                    comboBox2.Items.Add(race.Nom);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string r = comboBox2.SelectedItem.ToString();
            var races = _db.Race;
            foreach (Race race in races)
            {
                if (race.Nom.Equals(r))
                {
                    raceSelected = race;
                }
            }
        }
    }
}
