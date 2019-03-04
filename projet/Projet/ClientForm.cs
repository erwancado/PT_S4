using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class ClientForm : Form
    {
        private Boolean isMan;
        private DateTime SelectedDate;
        private String name;
        private String firstName;
        private String adress;
        private String tel;
        private String email;

        DB_ENTITIES _db;
        OleDbConnection dbConnection;


        public ClientForm()
        {
            InitializeComponent();

            _db = new DB_ENTITIES();
            isMan = true;
            SelectedDate = DateTime.Now;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            firstName = prenomTextBox.Text;
            adress = adressTextBox.Text;
            tel = telTextBox.Text;
            email = emailTextBox.Text;
            Clients toInsert = new Clients();
            toInsert.Nom = nameTextBox.Text;
            _db.Clients.Add(toInsert);
            _db.SaveChanges();

        }

        private void womanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!womanRadioButton.Checked)
            {
                isMan = false;
            }
        }

        private void manRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!manRadioButton.Checked) {
                isMan = true;
            }
        }

        private void naissanceDatePicker_ValueChanged(object sender, EventArgs e)
        {
            SelectedDate = naissanceDatePicker.Value;
        }
    }
}
