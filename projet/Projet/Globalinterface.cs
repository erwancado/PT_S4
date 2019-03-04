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
        public Globalinterface(String id)
        {
            InitializeComponent();
            time = new Timer();
            this.id = id;
            startTime();
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
    }
}
