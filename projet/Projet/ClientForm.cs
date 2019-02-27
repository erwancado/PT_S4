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

        PT4_S4P2C_E3Entities _db;
        OleDbConnection dbConnection;


        public ClientForm()
        {
            InitializeComponent();

            string chaineBd = "Provider=SQLOLEDB;Data Source=INFO-JOYEUX;Initial Catalog=PT4_S4P2C_E3;Integrated Security=SSPI;";
            dbConnection = new OleDbConnection(chaineBd);
            dbConnection.Open();

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

            string sql = "INSERT INTO Client(NOM_AB,PRENOM_AB,DATE_ABONNEMENT,NUM_AB) VALUES ('" + "','"  + "',SYSDATETIME(),(select MAX(Abonnes.NUM_AB)From Abonnes)+1)";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();

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
