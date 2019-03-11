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
            Animaux toInsert = new Animaux();
            toInsert.Nom = textBox1.Text;
            toInsert.Prenom = prenomTextBox.Text;
            toInsert.Adresse = adressTextBox.Text;
        }
    }
}
