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
        DB_ENTITIES _db;
        public ClientList()
        {
            _db = new DB_ENTITIES();
            InitializeComponent();
            InitializeClientList();
        }

        private void InitializeClientList()
        {
            var clients = _db.Clients;
            foreach (Clients client in clients)
            {
                ListViewItem item1 = new ListViewItem("client",0);
            }
        }
    }
}
