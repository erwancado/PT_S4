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
        public Globalinterface()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if(e.Row == 0)
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.CellBounds);

            for(int i = 0; i < e.Row; i++)
                if(e.Column == 0)
                    e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
