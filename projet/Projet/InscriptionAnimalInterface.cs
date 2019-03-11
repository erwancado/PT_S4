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

        DB_ENTITIES _db;
        OleDbConnection dbConnection;

        public InscriptionAnimalInterface()
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
            Especes esp = new Especes();
            esp.Nom = comboBox1.Text;
            Race race = new Race();
            race.Nom = comboBox2.Text;
            //an.Sexe=
         
        }

        private void retourFicheClient_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  ClientList cl = new ClientList();
           // cl.Show();
        }
    }
}
