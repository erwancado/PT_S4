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
    public partial class Maladies_Form : Form
    {

        DB_ENTITIES _db;
        Animaux animal;
        DateTime date;
        public Maladies_Form(Animaux animal)
        {
            InitializeComponent();
            this.animal = animal;
            dateTimePicker1.MaxDate = DateTime.Now;
            _db = new DB_ENTITIES();
            date = DateTime.Now;
            completeMaladie();
            animal = _db.Animaux.Find(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (description.Text != null && nameDesease != null) {
                String name = nameDesease.Text;
                String descriptionMaladie = description.Text;
                Maladies maMaladie = new Maladies();
                maMaladie.Nom = name;
                maMaladie.Description = descriptionMaladie;
                _db.Maladies.Add(maMaladie);
                _db.SaveChanges();
                MessageBox.Show("Ajout de la maladie");
                nameDesease.Text ="";
                description.Text="";
                completeMaladie();
            }
            else
            {
                MessageBox.Show("Merci de completer les champs de nom et de description");
            }
        }

        private void completeMaladie()
        {
            comboBox1.Items.Clear();
            var maladies = _db.Maladies;
            foreach(Maladies maladie in maladies)
            {
                comboBox1.Items.Add(maladie.Nom);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() != null)
            {
                var maladies = _db.Maladies;
                foreach (Maladies maladie in maladies)
                {
                    if (maladie.Nom.Equals(comboBox1.SelectedItem.ToString())) {
                        List<Animaux> liste = new List<Animaux>();
                        liste.Add(animal);
                        Animaux_maladies g = new Animaux_maladies();
                        g.Animaux_idAnimaux = (animal.idAnimaux);
                        g.Date = date;
                        g.Maladies_idMaladies = maladie.idMaladies;
                        _db.Animaux_maladies.Add(g);
                        _db.SaveChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show("Merci de completer les champs de nom et de description");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           date = dateTimePicker1.Value;
        }
    }
}
