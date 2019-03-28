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
    public partial class Rappels_Form : Form
    {
        DB_ENTITIES _db;
        Animaux animal;
        public Rappels_Form(Animaux animal)
        {
            _db = new DB_ENTITIES();
            InitializeComponent();
            datePicker.MinDate = DateTime.Now;
            this.animal = animal;

        }

        private void validateRappel_Click(object sender, EventArgs e)
        {
            if (description.Text.Equals(""))
                MessageBox.Show("Veuillez entrer une description.");
            else
            {
                Rappel rappel = new Rappel();
                rappel.Description = description.Text;
                rappel.Date = datePicker.Value;
                rappel.Animaux_idAnimaux=animal.idAnimaux;
                animal.Rappel.Add(rappel);
                _db.Rappel.Add(rappel);
                _db.SaveChanges();
                string message = "Le rappel a été ajouté avec succès. Voulez-vous ajouté un nouveau rappel ?";
                string caption = "Rappel ajouté";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                }
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    description.Clear();
                    datePicker.Value = DateTime.Now;
                }
            }
            
        }
    }
}
