using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rejestracja2.uc
{
    public partial class UcPatientsList : UserControl
    {
        // lista przechowująca załadowanych pacjentów
        private List<Patient> loadedPatients;

        public UcPatientsList()
        {
            InitializeComponent();
            LoadPatients();


        }

        private void UcPatientsList_Load(object? sender, EventArgs e)
        {
            // usunięcie domyślnego zaznaczenia po załadowaniu
            dataGridViewPatients.CurrentCell = null;
            dataGridViewPatients.ClearSelection();
        }

        private void LoadPatients()
        {
            // pobranie pacjentów z bazy
            loadedPatients = PatientDatabase.LoadPatients();
            dataGridViewPatients.DataSource = loadedPatients;

            if (dataGridViewPatients.Columns.Count > 0)
            {
                // konfiguracja nagłówków kolmun
                dataGridViewPatients.Columns["FirstName"].HeaderText = "Imię";
                dataGridViewPatients.Columns["LastName"].HeaderText = "Nazwisko";
                dataGridViewPatients.Columns["Pesel"].HeaderText = "PESEL";

                dataGridViewPatients.Columns["PhoneNumber"].Visible = false;
                dataGridViewPatients.Columns["City"].Visible = false;
                dataGridViewPatients.Columns["PostCode"].Visible = false;
                dataGridViewPatients.Columns["Street"].Visible = false;
                dataGridViewPatients.Columns["HomeNum"].Visible = false;

                dataGridViewPatients.Columns["FullName"].Visible = false;
                dataGridViewPatients.Columns["Address"].Visible = false;

                dataGridViewPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            // filtrowanie na zywo po peseleu/nazwisku
            string text = txtSearch.Text.ToLower();

            var filteredText = loadedPatients.Where(p => p.LastName.ToLower().Contains(text) ||
            p.Pesel.Contains(text)).ToList();

            dataGridViewPatients.DataSource = filteredText;
        }

        private void DataGridViewPatients_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count > 0)
            {
                // obsługa kliknięcia na wiersz pacjenta i pobranie jego danych i wyświetlenie w labelach oraz tabeli wizyt.
                string selectedPesel = dataGridViewPatients.SelectedRows[0].Cells["Pesel"].Value.ToString();
                Patient selectedPatient = loadedPatients.FirstOrDefault(p => p.Pesel == selectedPesel);

                if (selectedPatient != null)
                {
                    lblFullName.Text = $"Pacjent: {selectedPatient.FullName}";
                    lblPesel.Text = $"PESEL: {selectedPatient.Pesel}";
                    lblAddress.Text = $"Adres: {selectedPatient.Address}";
                    if (selectedPatient.PhoneNumber.Length == 9)
                    {
                        lblPhone.Text = $"Telefon: {selectedPatient.PhoneNumber.Substring(0, 3)}-{selectedPatient.PhoneNumber.Substring(3, 3)}-{selectedPatient.PhoneNumber.Substring(6, 3)}";
                    }
                    else
                    {
                        lblPhone.Text = $"Telefon: {selectedPatient.PhoneNumber}";
                    }
                    // załadowanie wizyt pacjenta
                    LoadAppointmentsForPatient(selectedPesel);
                }
            }
            else
            {
                lblFullName.Text = "Pacjent: Brak";
                lblPesel.Text = "PESEL: Brak";
                lblAddress.Text = "Adres: Brak";
                lblPhone.Text = "Telefon: Brak";
                dataGridViewAppointments.DataSource = null;
            }
        }

        private void LoadAppointmentsForPatient(string pesel)
        {
            var allAppointments = AppointmentDatabase.LoadAppointments();
            // filtrowanie wizyt pacjenta po peselu
            var patientAppointments = allAppointments
                .Where(a => a.PatientPesel == pesel)
                .OrderByDescending(a => DateTime.ParseExact(a.AppDate, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture))
                .ThenByDescending(a => TimeSpan.Parse(a.AppTime))
                .ToList();

            dataGridViewAppointments.DataSource = patientAppointments;

            if (dataGridViewAppointments.Columns.Count > 0)
            {
                dataGridViewAppointments.Columns["PatientPesel"].Visible = false;

                dataGridViewAppointments.Columns["AppDate"].HeaderText = "Data";
                dataGridViewAppointments.Columns["AppTime"].HeaderText = "Godzina";
                dataGridViewAppointments.Columns["Doctor"].HeaderText = "Lekarz";

                dataGridViewAppointments.Columns["AppDate"].DisplayIndex = 0;
                dataGridViewAppointments.Columns["AppTime"].DisplayIndex = 1;
                dataGridViewAppointments.Columns["Doctor"].DisplayIndex = 2;

                dataGridViewAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridViewAppointments.ClearSelection();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0) return;
            string pesel = dataGridViewPatients.SelectedRows[0].Cells["Pesel"].Value.ToString();

            Panel parent = (Panel)this.Parent;
            if (parent != null)
            {
                parent.Controls.Clear();
                UcEdit ucEdit = new UcEdit(pesel);
                ucEdit.Dock = DockStyle.Fill;
                parent.Controls.Add(ucEdit);
            }
        }

    }
}