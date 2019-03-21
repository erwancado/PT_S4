﻿using System;
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
        DB_ENTITIES _db;
        String searchName;
        String selectedLine;
        public ClientList()
        {
            _db = new DB_ENTITIES();
            InitializeComponent();
            searchName = "";
            selectedLine = "";
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            allClientList.Columns.Add(header);
            InitializeClientList("");
        }

        public void InitializeClientList(String request)
        {
            this.allClientList.Items.Clear();
            if (request.Equals(""))
            {
                var clients = _db.Clients;
                foreach (Clients client in clients)
                {
                    ListViewItem item = new ListViewItem(client.idClients.ToString());
                    item.SubItems.Add(client.Nom);
                    item.SubItems.Add(client.Prenom);
                    item.SubItems.Add(client.DateNaissance.ToString());
                    item.SubItems.Add(client.Téléphone.ToString());
                    item.SubItems.Add(client.Email);
                    item.SubItems.Add(client.ProchaineVisite.ToString());
                    allClientList.Items.Add(item);
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
                            ListViewItem item = new ListViewItem(client.idClients.ToString());
                            item.SubItems.Add(client.Nom);
                            item.SubItems.Add(client.Prenom);
                            item.SubItems.Add(client.DateNaissance.ToString());
                            item.SubItems.Add(client.Téléphone.ToString());
                            item.SubItems.Add(client.Email);
                            item.SubItems.Add(client.ProchaineVisite.ToString());
                            allClientList.Items.Add(item);
                        }
                    }
                }
            }
            allClientList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            allClientList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
            ClientForm newClient = new ClientForm(null, _db, this);
            newClient.Show();
            this.Hide();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (allClientList.SelectedItems.Count > 0) {
                selectedLine = this.allClientList.SelectedItems[0].Text;
                int id  = int.Parse(this.allClientList.SelectedItems[0].Text);
                Clients selectedClient = getClient(id);
                ClientForm modifyClient = new ClientForm(selectedClient, _db, this);
                modifyClient.Show();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (allClientList.SelectedItems.Count > 0)
            {
                selectedLine = this.allClientList.SelectedItems[0].Text;
                int id = int.Parse(this.allClientList.SelectedItems[0].Text);
                Clients selectedClient = getClient(id);
                _db.Clients.Remove(selectedClient);
                _db.SaveChanges();
            }
        }

        private Clients getClient(int idClient) {
            var clients = _db.Clients;
            foreach (Clients client in clients)
            {
                if (client.idClients== idClient)
                {
                    return client;
                }
            }
            return null;
        }
       
        private void allClientList_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(this.allClientList.SelectedItems[0].Text);
            Clients toShow = _db.Clients.Find(id);
            ClientSheet sheet = new ClientSheet(toShow);
            sheet.Show();
        }
    }
}
