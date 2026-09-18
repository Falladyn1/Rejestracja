using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rejestracja2
{
    public partial class UcNewVisit : UserControl
    {
        // pola przechowujące lokalną liste pacjentów oraz pesel wybrenej osoby
        private List<Patient> allPatients;
        private string selectedPesel;

        public UcNewVisit()
        {
            InitializeComponent();

            LoadDoctors();
            LoadPatients();

            // blokada aby użytkownik najpierw wybrał datę
            //cmbDoctor.Enabled = false;
            cmbTime.Enabled = false;
        }

        private void LoadDoctors()
        {
            cmbDoctor.Items.Clear();
            cmbDoctor.Items.Add("dr Jan Kowalski");
            cmbDoctor.Items.Add("dr Anna Nowak");
            cmbDoctor.Items.Add("dr Piotr Wiśniewski");
        }

        private void LoadPatients()
        {
            // wczytanie bazy
            allPatients = PatientDatabase.LoadPatients();
            dataGridViewSearch.DataSource = allPatients;

            if (dataGridViewSearch.Rows.Count > 0)
            {
                // konfiguracja nagłówków w tabeli
                dataGridViewSearch.Columns["FirstName"].HeaderText = "Imię";
                dataGridViewSearch.Columns["LastName"].HeaderText = "Nazwisko";
                dataGridViewSearch.Columns["Pesel"].HeaderText = "PESEL";

                dataGridViewSearch.Columns["PhoneNumber"].Visible = false;
                dataGridViewSearch.Columns["City"].Visible = false;
                dataGridViewSearch.Columns["PostCode"].Visible = false;
                dataGridViewSearch.Columns["Street"].Visible = false;
                dataGridViewSearch.Columns["HomeNum"].Visible = false;

                dataGridViewSearch.Columns["FullName"].Visible = false;
                dataGridViewSearch.Columns["Address"].Visible = false;

                dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            // dynamiczne szukanie po peselu/nazwisku
            string text = txtSearch.Text.ToLower();

            var filteredText = allPatients.Where(p => p.LastName.ToLower().Contains(text) ||
            p.Pesel.Contains(text)).ToList();

            dataGridViewSearch.DataSource = filteredText;
        }

        private void dataGridViewSearch_SelectionChanged(object? sender, EventArgs e)
        {
            // obsługa zaznaczenia wiersza w tabeli i przypisanie wybranego pacjenta do zmiennej
            if (dataGridViewSearch.SelectedRows.Count > 0)
            {
                selectedPesel = dataGridViewSearch.SelectedRows[0].Cells["Pesel"].Value.ToString();
                string firstName = dataGridViewSearch.SelectedRows[0].Cells["FirstName"].Value.ToString();
                string lastName = dataGridViewSearch.SelectedRows[0].Cells["LastName"].Value.ToString();

                lblSelectedPatient.Text = $"Wybrany pacjent: {firstName} {lastName} ({selectedPesel})";
            }
            else
            {
                selectedPesel = "";
                lblSelectedPatient.Text = "Wybrany pacjent: Brak";
            }
        }

        private void UcCalendar1_DateSelected(object sender, string wybranaData)
        {
            // odebranie zdarzenia wywołanego przez kalendarz i oblokowanie cmb update godzin
            lblSelectedDate.Text = "Wybrana data: " + wybranaData;
            cmbDoctor.Enabled = true;
            cmbTime.Enabled = true;
            UpdateAvailableTimes();
        }

        private void CmbDoctor_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // zmiana lekarza od nowa sprawdzamy godziny
            UpdateAvailableTimes();
        }

        private void UpdateAvailableTimes()
        {
            cmbTime.Items.Clear();

            // zabezpieczenie przed brakiem lekarza/daty
            if (string.IsNullOrEmpty(ucCalendar1.SelectedDate) || cmbDoctor.SelectedItem == null) return;

            string selectedDate = ucCalendar1.SelectedDate;
            string selectedDoctor = cmbDoctor.SelectedItem.ToString();

            // lista godzin które są już zajęte
            List<string> bookedTimes = new List<string>();

            // wyciągamy z pliku tylko dla wybranego lekarza i dnia
            foreach (Appointment a in AppointmentDatabase.LoadAppointments())
            {
                if (a.AppDate == selectedDate && a.Doctor == selectedDoctor)
                {
                    bookedTimes.Add(a.AppTime);
                }
            }

            // ustawnie zakresu 8-16 co 30min
            TimeSpan czasStart = new TimeSpan(8, 0, 0);
            TimeSpan czasKoniec = new TimeSpan(16, 0, 0);
            TimeSpan czasWizyty = new TimeSpan(0, 30, 0);

            // petla generująca terminy jesli termin nie jest w bookedTimes to dodajemy do listy
            while (czasStart <= czasKoniec)
            {
                string currentTimeStr = czasStart.ToString(@"hh\:mm");
                if (!bookedTimes.Contains(currentTimeStr))
                {
                    cmbTime.Items.Add(currentTimeStr);
                }
                czasStart = czasStart.Add(czasWizyty);
            }

            cmbTime.SelectedIndex = -1;
            cmbTime.Text = "";
        }

        private void btnFastBooking_Click(object sender, EventArgs e)
        {
            // obsługa kliknięcia przycisku szybkiego zapisu
            // wyszukuje najbliższy wolny termin i automatycznie uzupełnia odpowiednie kontrolki

            // Sprawdzamy, czy użytkownik ma wybranego konkretnego lekarza w kontrolce
            string selectedDoctor = cmbDoctor.SelectedItem?.ToString();

            // wywołanie metody pomocniczej zwracającej krotkę z wolną datą lekarzem i godziną
            var (date, doctor, time) = FindNextAvailableSlot(selectedDoctor);

            // sprawdzenie czy udało się pomyślnie znaleźć wolny termin
            if (date != null && doctor != null && time != null)
            {
                cmbDoctor.Enabled = true;
                cmbTime.Enabled = true;
                // przypisanie znalezionych wartości do odpowiednich kontrolek formularza
                cmbDoctor.SelectedItem = doctor;
                ucCalendar1.SelectedDate = date;
                // ustawienie daty w kontrolce kalendarza
                lblSelectedDate.Text = "Wybrana data: " + date;
                // odświeżenie listy dostępnych godzin dla wybranego lekarza i daty oraz wybranie konkretnego czasu
                UpdateAvailableTimes();
                cmbTime.SelectedItem = time;

                MessageBox.Show($"Znaleziono najbliższy wolny termin!\nData: {date}\nLekarz: {doctor}\nGodzina: {time}",
                    "Szybki zapis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string message = string.IsNullOrEmpty(selectedDoctor)
                    ? "Brak wolnych terminów w najbliższym czasie!"
                    : $"Brak wolnych terminów dla lekarza: {selectedDoctor} w najbliższym czasie!";

                MessageBox.Show(message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private (string date, string doctor, string time) FindNextAvailableSlot(string targetDoctor = null)
        {
            var appointments = AppointmentDatabase.LoadAppointments();

            // Jeśli podano konkretnego lekarza, przeszukujemy tylko jego; w przeciwnym razie wszystkich
            string[] doctors = string.IsNullOrEmpty(targetDoctor) ? new string[] { "dr Jan Kowalski", "dr Anna Nowak", "dr Piotr Wiśniewski" }
                : new string[] { targetDoctor };

            // ustawienie daty początkowej na dzień dzisiejszy
            DateTime checkDate = DateTime.Today;

            // pętla sprawdzająca kolejne 30 dni
            for (int dayOffset = 0; dayOffset < 30; dayOffset++)
            {
                // ppomijanie dni weekendowych
                if (checkDate.DayOfWeek == DayOfWeek.Saturday || checkDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    checkDate = checkDate.AddDays(1);
                    continue;
                }

                string dateStr = checkDate.ToString("dd.MM.yyyy");

                // po każdym lekarzu dla danego dnia roboczego
                foreach (string doctor in doctors)
                {
                    TimeSpan slotTime = new TimeSpan(8, 0, 0);
                    TimeSpan endTime = new TimeSpan(16, 0, 0);

                    // pętla przechodząca przez sloty czasowe w danym dniu
                    while (slotTime < endTime)
                    {
                        string timeStr = slotTime.ToString(@"hh\:mm");

                        // sprawdzenie czy w bazie istnieje już wizyta w tym terminie dla tego lekarza i o tej godzinie
                        bool isTaken = appointments.Any(a => a.AppDate == dateStr && a.Doctor == doctor && a.AppTime == timeStr);

                        // jeśli slot jest wolny zwracamy znalezione dane
                        if (!isTaken)
                        {
                            return (dateStr, doctor, timeStr);
                        }

                        // [rzejście do kolejnego slotu czasowego
                        slotTime = slotTime.Add(TimeSpan.FromMinutes(30));
                    }
                }

                // przejście do kolejnego dnia
                checkDate = checkDate.AddDays(1);
            }

            return (null, null, null);
        }

        private void btnBook_Click(object? sender, EventArgs e)
        {
            // zabezpieczenie przed brakiem wybrania pacjenta
            if (string.IsNullOrEmpty(selectedPesel))
            {
                MessageBox.Show("Najpierw wyszukaj i wybierz pacjenta z listy!", "Brak pacjenta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // zabezpieczenie przed brakiem wybranai daty/lekarza/godziny
            if (string.IsNullOrEmpty(ucCalendar1.SelectedDate) || cmbDoctor.SelectedItem == null || cmbTime.SelectedItem == null)
            {
                MessageBox.Show("Wybierz datę, lekarza i godzinę!", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // utworzenie nowej wizyty w pliku txt
            List<Appointment> appList = AppointmentDatabase.LoadAppointments();
            appList.Add(new Appointment(selectedPesel, cmbDoctor.SelectedItem.ToString(), ucCalendar1.SelectedDate, cmbTime.SelectedItem.ToString()));
            AppointmentDatabase.SaveAppointments(appList);

            MessageBox.Show("Wizyta została pomyślnie umówiona!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // powrot do dashboard
            Panel parentPanel = (Panel)this.Parent;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();
                UcDashboard dashboard = new UcDashboard();
                dashboard.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(dashboard);
            }
        }
    }
}