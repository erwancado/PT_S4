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
    public partial class ClientList : Form
    {
        List<String> clients;
        DB_ENTITIES _db;
        String searchName;
        public ClientList()
        {
            _db = new DB_ENTITIES();
            InitializeComponent();
            searchName = "";
            this.allClientList.View = View.List;
            clients = new List<string>();
            InitializeClientList("");
        }

        private void InitializeClientList(String request)
        {
            this.allClientList.Items.Clear();
            this.clients.Clear();
            if (request.Equals(""))
            {
                var clients = _db.Clients;
                foreach (Clients client in clients)
                {
                    String description = client.Nom + " "
                                        + client.Prenom + " " +
                                        client.DateNaissance.ToString() + " " +
                                        client.ProchaineVisite + " " +
                                        client.Téléphone;
                    if (!this.clients.Contains(description))
                    {
                        this.allClientList.Items.Add(client.idClients + ". " + description);
                        this.clients.Add(description);
                    }
                }
            }
            else
            {
                if (request.Equals("typed"))
                {
                    var clients = _db.Clients;
                    foreach (Clients client in clients)
                    {
                        if (client.Nom.Equals(searchName))
                        {
                            String description = client.Nom + " "
                                            + client.Prenom + " " +
                                            client.DateNaissance.ToString() + " " +
                                            client.ProchaineVisite + " " +
                                            client.Téléphone;
                            if (!this.clients.Contains(description))
                            {
                                this.allClientList.Items.Add(client.idClients + ". " + description);
                                this.clients.Add(description);
                            }
                        }
                    }
                }
            }
        }
        

        private void allClientList_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(this.allClientList.SelectedItems[0].SubItems[0].Text.Split('.')[0]);
            Clients toShow = _db.Clients.Find(id);
            ClientSheet sheet = new ClientSheet(toShow);
            sheet.Show();
            this.Hide();
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            if (!nameInput.Text.Equals("")) {
                searchName = nameInput.Text;
            }
            InitializeClientList("typed");
        }

        private void newClientButton_Click(object sender, EventArgs e)
        {
            ClientForm newClient = new ClientForm();
            newClient.Show();
            this.Hide();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
