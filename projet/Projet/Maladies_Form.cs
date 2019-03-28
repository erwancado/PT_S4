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
    public partial class Maladies_Form : Form
    {
        public Maladies_Form()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
        }
    }
}
