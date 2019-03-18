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
        private String infos;
        bool isModification;
        DB_ENTITIES _db;
        OleDbConnection dbConnection;

        public InscriptionAnimalInterface(Animaux animalSelected, DB_ENTITIES _db, AnimauxInterface animalInterface)
        {
            InitializeComponent();
            _db = new DB_ENTITIES();
            isMan = true;
            dateNais = DateTime.Now;
        }

      

        private void inscription_Click(object sender, EventArgs e)
        {
            Animaux an = new Animaux();
            an.Nom = textBox1.Text;
            an.Poids =(int) numericUpDown1.Value;
            an.Caractéristiques = richTextBox1.Text;
            an.DateNaissance = dateTimePicker1.Value;
            if (femelle.Checked)
            {
                an.Sexe = "F";
            }
            else
            {
                an.Sexe = "M";
            }
            Especes esp = new Especes();
            esp.Nom = comboBox1.Text;
            Race race = new Race();
            race.Nom = comboBox2.Text;
            _db.SaveChanges();
            inscriptionGood(an);

        }

        private void retourFicheClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Clients cli = new Clients();
            // ClientSheet cl = new ClientSheet(cli);
            // cl.Show();
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
                    && animal.DateNaissance.Equals(myAnimal.DateNaissance) && animal.Caractéristiques == myAnimal.Caractéristiques) //Checker l'espece et la race aussi
                {
                    MessageBox.Show("Animal inscrit");
                    this.Hide();
                    FicheAnimalInterface animalInsert = new FicheAnimalInterface(myAnimal);
                    animalInsert.Show();
                }
                resetAllInput();
            }
        }
    }
}
