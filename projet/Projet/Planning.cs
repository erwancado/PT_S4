using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            planningGridView.ColumnCount = 8;

            planningGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            planningGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            planningGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(planningGridView.Font, FontStyle.Bold);

            planningGridView.Name = "planningGridView";
            planningGridView.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            planningGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
            
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
            planningGridView.DefaultCellStyle.WrapMode =
            DataGridViewTriState.True;

            planningGridView.MultiSelect = false;

        }

        private void PopulateDataGrid(DateTime date)
        {
            DayOfWeek day = date.DayOfWeek;
            int dayOffset = dayOfWeekNumber(date.DayOfWeek)+1;
            DateTime dateMin = date.AddDays(-dayOffset);
            DateTime dateMax = date.AddDays(NBDAYS - dayOffset);
            var rdv = _db.RendezVous.Where(r => ((DateTime)r.Date).CompareTo(dateMin) >= 0 && ((DateTime)r.Date).CompareTo(dateMax) <= 0);
            List<RendezVous>[,] hours = new List<RendezVous>[7, 10];
            for (int i = 0; i < NBDAYS; i++)
                for (int j = 0; j < NBHOURS; j++)
                    hours[i, j] = new List<RendezVous>();
            foreach (RendezVous r in rdv)
            {
                int dayNumber = dayOfWeekNumber(r.Date.DayOfWeek);
                int hour = r.Date.Hour-hourOffset;
                if(hour<=9 && hour>=0)
                    hours[dayNumber, hour].Add(r);
            }
            for (int i = 0; i < NBHOURS; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(planningGridView);
                for(int j=0; j < planningGridView.ColumnCount; j++)
                {
                    if (j == 0)
                        row.Cells[j].Value = (i + hourOffset).ToString()+"h -- "+ (i+1 + hourOffset).ToString()+"h";
                    else
                    {
                        String rdvList = "";
                        String descriptions = "";
                        foreach(RendezVous r in hours[j-1,i])
                        {
                            rdvList += ((DateTime) r.Date).ToShortTimeString() + "\r\n "
                                +r.Clients.Prenom+" "+r.Clients.Nom+ "\n";
                            descriptions += r.Description + "\n" + ((DateTime)r.Date).ToShortDateString()+"  "+ ((DateTime)r.Date).ToShortTimeString() + "\n";
                            
                        }
                        row.Cells[j].Value = rdvList;
                        row.Cells[j].ToolTipText = descriptions;


                    }
                        
                }
                planningGridView.Rows.Add(row);
            }
            planningGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            planningGridView.AutoResizeRows();
            var height = 40;
            foreach (DataGridViewRow dr in planningGridView.Rows)
            {
                height += dr.Height;
            }

            planningGridView.Height = height;
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
            this.datePicker.Location = new System.Drawing.Point(667, 40);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 0;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // planningGridView
            // 
            this.planningGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planningGridView.Location = new System.Drawing.Point(49, 58);
            this.planningGridView.Margin = new System.Windows.Forms.Padding(10);
            this.planningGridView.Name = "planningGridView";
            this.planningGridView.Size = new System.Drawing.Size(818, 390);
            this.planningGridView.TabIndex = 1;
            this.planningGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.planningGridView_CellPainting);
            // 
            // Planning
            // 
            this.ClientSize = new System.Drawing.Size(935, 579);
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

        private void planningGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
           
        }
    }
}
