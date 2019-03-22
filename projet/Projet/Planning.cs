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
    public partial class Planning : Form
    {
        DB_ENTITIES _db;
        int NBHOURS = 10;
        int GRIDSIZE = 8;
        int NBDAYS = 7;
        int hourOffset = 8;
        public Planning()
        {
            InitializeComponent();
            _db = new DB_ENTITIES();
            SetupDataGrid();
            PopulateDataGrid(datePicker.Value);
        }


        private void SetupDataGrid()
        {
            this.Controls.Add(planningGridView);
            planningGridView.ColumnCount = 7;

            planningGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            planningGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            planningGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(planningGridView.Font, FontStyle.Bold);

            planningGridView.Name = "planningGridView";
            planningGridView.Location = new Point(8, 8);
            planningGridView.Size = new Size(500, 250);
            planningGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            planningGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            planningGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            planningGridView.GridColor = Color.Black;
            planningGridView.RowHeadersVisible = false;
            planningGridView.ColumnCount = 8;
            planningGridView.Columns[0].Name = "Plage horaire";
            planningGridView.Columns[1].Name = "Lundi";
            planningGridView.Columns[2].Name = "Mardi";
            planningGridView.Columns[3].Name = "Mercredi";
            planningGridView.Columns[4].Name = "Jeudi";
            planningGridView.Columns[5].Name = "Vendredi";
            planningGridView.Columns[6].Name = "Samedi";
            planningGridView.Columns[7].Name = "Dimanche";
            planningGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            planningGridView.MultiSelect = false;
            planningGridView.Dock = DockStyle.Fill;

        }

        private void PopulateDataGrid(DateTime date)
        {
            DayOfWeek day = date.DayOfWeek;
            int dayOffset = dayOfWeekNumber(date.DayOfWeek);
            var rdv = _db.RendezVous.Where(r => r.Date.DayOfYear >= date.DayOfYear - dayOffset && r.Date.DayOfYear < date.DayOfYear - dayOffset + 7);
            List<RendezVous>[,] hours = new List<RendezVous>[7, 10];
            for (int i = 0; i < NBDAYS; i++)
                for (int j = 0; j < NBHOURS; j++)
                    hours[i, j] = new List<RendezVous>();
            foreach (RendezVous r in rdv)
            {
                int dayNumber = dayOfWeekNumber(r.Date.DayOfWeek);
                int hour = r.Date.Hour-hourOffset;
                hours[dayNumber, hour].Add(r);
            }
            for (int i = 0; i < NBHOURS; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(planningGridView);
                for(int j=0; j < planningGridView.ColumnCount; j++)
                {
                    if (i == 0)
                        row.Cells[j].Value = j + hourOffset;
                    else
                    {
                        String rdvList = "";
                        foreach(RendezVous r in hours[i, j])
                        {
                            rdvList += r.Date.Hour.ToString() + ":" + r.Date.Minute.ToString() + "\n"
                                +r.Clients.Prenom+" "+r.Clients.Nom+"\n";
                            
                        }
                        row.Cells[j].Value = rdvList;
                    }
                        
                }
                planningGridView.Rows.Add(row);
            }

        }

        private int dayOfWeekNumber(DayOfWeek day)
        {
            int dayNb;
            switch (day)
            {
                case DayOfWeek.Monday:
                    dayNb= 0;
                    break;
                case DayOfWeek.Tuesday:
                    dayNb = 1;
                    break;
                case DayOfWeek.Wednesday:
                    dayNb = 2;
                    break;
                case DayOfWeek.Thursday:
                    dayNb = 3;
                    break;
                case DayOfWeek.Friday:
                    dayNb = 4;
                    break;
                case DayOfWeek.Saturday:
                    dayNb = 5;
                    break;
                case DayOfWeek.Sunday:
                    dayNb = 6;
                    break;
                default:
                    dayNb = -1;
                    break;
            }
            return dayNb;
        }

        private void InitializeComponent()
        {
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.planningGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.planningGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(314, 34);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 0;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // planningGridView
            // 
            this.planningGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planningGridView.Location = new System.Drawing.Point(12, 103);
            this.planningGridView.Name = "planningGridView";
            this.planningGridView.Size = new System.Drawing.Size(818, 390);
            this.planningGridView.TabIndex = 1;
            // 
            // Planning
            // 
            this.ClientSize = new System.Drawing.Size(842, 505);
            this.Controls.Add(this.planningGridView);
            this.Controls.Add(this.datePicker);
            this.Name = "Planning";
            ((System.ComponentModel.ISupportInitialize)(this.planningGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            planningGridView.Rows.Clear();
            PopulateDataGrid(datePicker.Value);
        }
    }
}
