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
    public partial class Authentication : Form
    {

        DB_ENTITIES _db;
        Timer time;
        public Authentication()
        {
            InitializeComponent();
            time = new Timer();
            startTime();
            _db = new DB_ENTITIES();
        }

        public void startTime()
        {
            time.Tick += (s, e) => { DateLabel.Text = DateTime.Now.ToString(); };
            time.Interval = 500;
            time.Start();
        }

        private void LogingIn_Click(object sender, EventArgs e)
        {
            String login = "";
            var utilisateurs = _db.Utilisateurs;
            foreach(Utilisateurs u in utilisateurs)
            {
                if (u.Login.Equals(this.login.Text) && u.MotDePasse.Equals(this.pass.Text))
                {
                    login = u.Login;
                    Logs l = new Logs();
                    l.Action = "Connexion de " + u.Login;
                    l.Date = DateTime.Now;
                    _db.Logs.Add(l);
                }
            }
            _db.SaveChanges();
            if (login != "")
            {
                Globalinterface g = new Globalinterface(login);
                g.Show();
                this.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MdpOublié mdp = new MdpOublié();
            mdp.Show();
        }
    }
}
