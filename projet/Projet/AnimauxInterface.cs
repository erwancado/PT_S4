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
        String searchEspece;
        String searchRace;
        String searchNameProprietaire;
        String selectedLine;


        public AnimauxInterface()
        {
            _db = new DB_ENTITIES();
            InitializeComponent();
            searchName = "";
            searchEspece = "";
            searchRace = "";
            searchNameProprietaire = "";
            selectedLine = "";
            this.allAnimauxList.View = View.List;
            animaux = new List<string>();
            InitializeAnimauxInterface("");
            init();
        }

        private void init()
        {
            
            var especes = _db.Especes;

            foreach (Especes espece in especes)
            {
                comboBox1.Items.Add(espece.Nom);       
            }
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
                    Clients monClient = _db.Clients.Find(animal.Clients_idClients);
                    Race maRace = new Race();
                    foreach (Race race in animal.Race)
                    {
                        maRace = race;
                    }
                    Especes monEspece = _db.Especes.Find(maRace.Especes_idEspeces);
                    String description = monClient.Nom + " " + animal.Nom + " "
                       + maRace.Nom + " " 
                    + animal.Poids + " " + animal.Caractéristiques +
                    " " + animal.Sexe
                        + " " + animal.DateNaissance;

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
                        Clients monClient = _db.Clients.Find(animal.Clients_idClients);
                        Race maRace = new Race();
                        foreach (Race race in animal.Race)
                        {
                            maRace = race;
                        }
                        Especes monEspece = _db.Especes.Find(maRace.Especes_idEspeces);

                        if ((animal.Nom.StartsWith(searchName)) && (monClient.Nom.StartsWith(searchNameProprietaire)))
                        {
                            if (maRace.Nom != null)
                            {
                                if ((maRace.Nom.StartsWith(searchRace)))
                                {
                                    String description = monClient.Nom + " " + animal.Nom + " "
                      + maRace.Nom + " " + " "
                   + animal.Poids + " " + animal.Caractéristiques +
                   " " + animal.Sexe
                       + " " + animal.DateNaissance;
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
            }
        }



        private void delete_Click(object sender, EventArgs e)
        {
            if (allAnimauxList.SelectedItems.Count > 0)
            {
                selectedLine = allAnimauxList.SelectedItems[0].Text;
                int id = int.Parse(selectedLine.Split('.')[0]);
                Utils.removeAnimal(id, _db);
                InitializeAnimauxInterface("");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (allAnimauxList.SelectedItems.Count > 0)
            {
                selectedLine = allAnimauxList.SelectedItems[0].Text;
                int id = int.Parse(selectedLine.Split('.')[0]);
                Animaux selectedAnimal = getAnimaux(id);
                InscriptionAnimalInterface modifyAnimal = new InscriptionAnimalInterface(selectedAnimal, this, null);
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
 
        }




        private void filtrer_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null) {
                searchRace = comboBox2.SelectedItem.ToString();
            }
            
            if (!textBox4.Text.Equals(""))
            {
     
                searchName = textBox4.Text;
            }
            if (!textBox1.Text.Equals("")) {

                searchNameProprietaire = textBox1.Text;
            }

            InitializeAnimauxInterface("typed");
        }









        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string esp = comboBox1.SelectedItem.ToString();
            MessageBox.Show(esp);
            Especes especeSelected = null;
            var races = _db.Race;
            foreach (Race race in races)
            {
                especeSelected = _db.Especes.Find(race.Especes_idEspeces);
                if (especeSelected.Nom.Equals(esp))
                {
                    comboBox2.Items.Add(race.Nom);
                }
            }
        }
    }
}

