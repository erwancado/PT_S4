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
    public partial class Globalinterface : Form
    {
        Timer time;
        public String id;
        DB_ENTITIES _db;
        public Globalinterface(String id)
        {
            InitializeComponent();
            _db = new DB_ENTITIES();
            time = new Timer();
            this.id = id;
            startTime();
            this.logsListView.View = View.List;
            this.rappelListView.View = View.List;
            this.todaysAppointmentListView.View = View.List;
            fillLog();
            fillRecall();
            fillTodaysApp();
        }

        public void fillLog()
        {
            foreach (Logs l in _db.Logs)
            {
                this.logsListView.Items.Add(l.Action + " " + l.Date.ToShortDateString() + " "+ l.Date.ToShortTimeString());
            }
        }

        public void fillTodaysApp()
        {
            foreach(RendezVous rdv in _db.RendezVous)
            {
                if (rdv.Date.ToShortDateString().Equals(DateTime.Today.ToShortDateString()))
                {
                    if (rdv.Description != null)
                        this.todaysAppointmentListView.Items.Add(rdv.Description + ", animal de " + _db.Clients.Find(rdv.Clients_idClients).Nom);
                }
            }
        }

        public void fillRecall()
        {
            Rappel[] dates = _db.Rappel.Where(r => r.Date > DateTime.Now).ToArray();
            int h, j;
            int N = dates.Length;
            for (j = N - 1; j > 0; j--)
            {
                for (h = 0; h < j; h++)
                {
                    if (dates[h].Date > dates[h + 1].Date)
                        exchange(dates, h, h + 1);
                }
            }
            for (int y = 0; y < dates.Length; y++)
            {
                Rappel r = dates[y];
                this.rappelListView.Items.Add("Concernant l'animal : " + _db.Animaux.Find(r.Animaux_idAnimaux).Nom + " : " + r.Description + " le " + r.Date.ToShortDateString());       
            }

        }

        public void startTime()
        {
            time.Tick += (s, e) => { DateLabel.Text = DateTime.Now.ToString()+"\n Utilisateur : "+ id; };
            time.Interval = 500;
            time.Start();
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if(e.Row == 0)
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.CellBounds);

            for(int i = 0; i < e.Row; i++)
                if(e.Column == 0)
                    e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr(e) de vouloir vous déconnecter ?", "Confirmez", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {

        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            Planning p = new Planning();
            p.Show();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            ClientList c = new ClientList();
            c.Show();
        }

        private void animalsButton_Click(object sender, EventArgs e)
        {

        }

        private void prescriptionButton_Click(object sender, EventArgs e)
        {

        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();
        }

        private void statsButton_Click(object sender, EventArgs e)
        {

        }

        private void Globalinterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public static void exchange(Rappel[] data, int m, int n)
        {
            Rappel temporary;
            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
        
    }
}
