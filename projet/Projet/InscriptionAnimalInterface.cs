﻿using System;
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
        AnimauxInterface animalList;
        Animaux animal;

        public InscriptionAnimalInterface(Animaux animalSelected, DB_ENTITIES _db, AnimauxInterface animalInterface)
        {

            InitializeComponent();
            isModification = false;
            this.animalList = animalList;
            animal = animalSelected;
            this._db = _db;
            isMan = true;
            dateNais = DateTime.Now;
            if (animal != null)
            {
                initializeInput();
                isModification = true;
            }
        }

        private void initializeInput()
        {
            textBox1.Text = animal.Nom;
           // comboBox1.Text = animal.Espece;
           // comboBox2.SelectedText = animal.Race;
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
            // validateButton.Text = "Modifier";
        }



        private void inscription_Click(object sender, EventArgs e)
        {
            Animaux an = new Animaux();
            an.Nom = textBox1.Text;
            an.Poids = (int)numericUpDown1.Value;
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
          /*  Especes esp = new Especes();
            esp.Nom = comboBox1.Text;
            Race race = new Race();
            race.Nom = comboBox2.Text;*/
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
                animal.Clients_idClients = 2; // TODO
            }
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
                    animalList.InitializeAnimauxInterface("");
                }
                resetAllInput();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateNais = dateTimePicker1.Value;
        }
    }
}
