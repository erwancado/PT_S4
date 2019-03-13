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
            InitializeComponent();
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
            }
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

        private void refresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}

