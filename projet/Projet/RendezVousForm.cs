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
    public partial class RendezVousForm : Form
    {
        DB_ENTITIES _db;
        int rdvDelay = 30;
        int rdvId = -1;
    
        public RendezVousForm(RendezVous rendezVous)
        {
            _db = new DB_ENTITIES();     
            InitializeComponent();
            populateClientList();
            if (rendezVous != null)
            {
                rdvId = rendezVous.idRendezVous;
                clientList.SelectedIndex = rendezVous.Clients_idClients;
                datePicker.Value = rendezVous.Date;
                timePicker.Value = rendezVous.Date;
                description.Text = rendezVous.Description;
                validateButton.Text = "Modifier";
            }
            displayRdv(datePicker.Value);
        }
        private void populateClientList()
        {
            var clients = _db.Clients;
            foreach (Clients client in clients)
            {
                clientList.Items.Add(client.idClients.ToString() + "." + client.Nom + " " + client.Prenom);
            }
        }
        private void displayRdv(DateTime date)
        {
            var rdvs = _db.RendezVous;
            foreach(RendezVous rdv in rdvs)
            {
                if(rdv.Date.ToShortDateString().Equals(date.ToShortDateString()))
                    rdvView.Items.Add(rdv.Date.ToShortTimeString() + "  " + rdv.Clients.Prenom + " " + rdv.Clients.Nom);
            }
        }

        private bool rdvValid()
        {
            bool isValid = true;
            DateTime rdvDate = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);
            if (DateTime.Today.CompareTo(rdvDate) > 0)
                isValid = false;
            if (timePicker.Value.Hour < 8 || timePicker.Value.Hour > 18)
                isValid = false;
            var dayRdvs = _db.RendezVous.Where(r=>r.Date==rdvDate && r.Date.Hour==rdvDate.Hour && r.Date.Minute<rdvDate.Minute+rdvDelay&& r.Date.Minute > rdvDate.Minute - rdvDelay);
            if (dayRdvs.Count() > 0 && rdvId==-1)
                isValid = false;
            if (clientList.SelectedItem == null)
                isValid = false;
            return isValid;
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            if (rdvValid())
            {
                RendezVous rdvToAdd = new RendezVous(); ;
                if (rdvId != -1)
                    rdvToAdd = _db.RendezVous.Find(rdvId);
                DateTime rdvDate = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);
                int idClient = int.Parse(((String)clientList.SelectedItem.ToString()).Substring(0, ((String)clientList.SelectedItem.ToString()).IndexOf('.', 0)));
                rdvToAdd.Clients_idClients = idClient;
                rdvToAdd.Date = rdvDate;
                rdvToAdd.Description = description.Text;
                if(rdvId==-1)
                    _db.RendezVous.Add(rdvToAdd);
                _db.SaveChanges();
                string message = "Le rendez-vous a été ajouté avec succès. Voulez-vous ajouté un nouveau rendez-vous ?";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                }
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    description.Clear();
                    clientList.ClearSelected();
                }
            }
            else
            {
                MessageBox.Show("Le rendez-vous entré n'est pas valide.");
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            rdvView.Items.Clear();
            displayRdv(datePicker.Value);
        }
    }
}
