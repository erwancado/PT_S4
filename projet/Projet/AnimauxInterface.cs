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
    public partial class AnimauxInterface : Form
    {

        List<String> animaux;
        DB_ENTITIES _db;
        String searchName;
        String selectedLine;

        public AnimauxInterface()
        {
            _db = new DB_ENTITIES();
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
            searchName = "";
            selectedLine = "";
            this.allAnimauxList.View = View.List;
            animaux = new List<string>();
            InitializeAnimauxInterface("");
        }

        public void InitializeAnimauxInterface(String request)
        {
            this.allAnimauxList.Items.Clear();
            this.animaux.Clear();
            if (request.Equals(""))
            {
                var animaux = _db.Animaux;
                foreach (Animaux animal in animaux)
                {
                    String description = //animal. nomPropriétaire +
                                         " "
                                        + animal.Nom + " " +
                                        animal.DateNaissance.ToString() + " " +
                                       // animal.espece + " " +
                                       animal.Race + " ";

                    if (!this.animaux.Contains(description))
                    {
                        this.allAnimauxList.Items.Add(animal.idAnimaux + ". " + description);
                        this.animaux.Add(description);
                    }
                }
            }
            else
            {
                if (request.Equals("typed"))
                {
                    var animaux = _db.Animaux;
                    foreach (Animaux animal in animaux)
                    {
                        if ((animal.Nom.Equals(searchName)) || (animal.DateNaissance.Equals(searchName)) || (animal.Race.Equals(searchName)) || animal.DateNaissance.Equals(searchName))
                        {
                            String description = animal.Nom + " "

                                          + animal.DateNaissance.ToString() + " " +
                                           // animal.Race+" "+
                                            animal.Caractéristiques;
                            // + " " + animal.Espece;
                            if (!this.animaux.Contains(description))
                            {
                                this.allAnimauxList.Items.Add(animal.idAnimaux + ". " + description);
                                this.animaux.Add(description);
                            }
                        }
                    }
                }
            }
        }




      

        private void delete_Click(object sender, EventArgs e)
        {
            if (allAnimauxList.SelectedItems.Count > 0)
            {
                selectedLine = allAnimauxList.SelectedItems[0].Text;
                int id = int.Parse(selectedLine.Split('.')[0]);
                Animaux selectedAnimal = getAnimaux(id);
                _db.Animaux.Remove(selectedAnimal);
                _db.SaveChanges();
                InitializeAnimauxInterface("");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            InscriptionAnimalInterface newAnimal = new InscriptionAnimalInterface(null, _db, this);
            newAnimal.Show();
            this.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (allAnimauxList.SelectedItems.Count > 0)
            {
                selectedLine = allAnimauxList.SelectedItems[0].Text;
                int id = int.Parse(selectedLine.Split('.')[0]);
                Animaux selectedAnimal = getAnimaux(id);
                InscriptionAnimalInterface modifyAnimal = new InscriptionAnimalInterface(selectedAnimal, _db, this);
                modifyAnimal.Show();
            }
        }


        private Animaux getAnimaux(int idAnimal)
        {
            var animaux = _db.Animaux;
            foreach (Animaux animal in animaux)
            {
                if (animal.idAnimaux == idAnimal)
                {
                    return animal;
                }
            }
            return null;
        }

        private void allAnimauxList_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(this.allAnimauxList.SelectedItems[0].SubItems[0].Text.Split('.')[0]);
            Animaux toShow = _db.Animaux.Find(id);
            FicheAnimalInterface fai = new FicheAnimalInterface(toShow);
            fai.Show();
            this.Hide();
        }

        private void filtrer_Click(object sender, EventArgs e)
        {
            if (!textBox4.Text.Equals(""))
            {
                searchName = textBox4.Text;
            }

            InitializeAnimauxInterface("typed");
        }
    }
}

