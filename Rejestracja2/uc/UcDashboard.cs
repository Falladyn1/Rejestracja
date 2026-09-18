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
    public partial class UcDashboard : UserControl
    {
        public UcDashboard()
        {
            InitializeComponent();
            timer1.Start();
            NumOfPatients();


            LoadAppointmentsToday();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = System.DateTime.Now.ToString("dd.MM.yyyy\nHH:mm:ss");
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            // przełączenie widoku na panel rejestracji nowego pacjenta
            Panel parentPanel = (Panel)this.Parent;

            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();

                UcNewPatient newPatientPanel = new UcNewPatient();

                newPatientPanel.Dock = DockStyle.Fill;

                parentPanel.Controls.Add(newPatientPanel);
            }
        }

        private void btnNewVisit_Click(object sender, EventArgs e)
        {
            // przełączenie widoku na panel umawiania nowej wizyty.
            Panel parentPanel = (Panel)this.Parent;

            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();

                UcNewVisit newVisitPanel = new UcNewVisit();


                newVisitPanel.Dock = DockStyle.Fill;

                parentPanel.Controls.Add(newVisitPanel);
            }

        }

        private void NumOfPatients()
        {
            // statystki całkowitej liczby pacjentów i dzisiejszych wizyt
            int numOfPatients;
            int allPatietnts = PatientDatabase.LoadPatients().Count;
            var allAppointments = AppointmentDatabase.LoadAppointments();

            // filtrowanie przy użyciu LINQ 
            var patientsToday = allAppointments
                .Where(a => DateTime.ParseExact(a.AppDate, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture) == DateTime.Today)
                .ToList();

            numOfPatients = patientsToday.Count;
            lblNumOfPatientsToday.Text = numOfPatients.ToString();

            lblNumOfPatients.Text = allPatietnts.ToString();

        }

        private void LoadAppointmentsToday()
        {
            string today = DateTime.Today.ToString("dd.MM.yyyy");

            var allPatients = PatientDatabase.LoadPatients();
            var allAppointments = AppointmentDatabase.LoadAppointments();

            // zapytanie join do złączenia list wizyt i pacjentów na podstawie peselu
            var combinedData = from a in allAppointments
                               where a.AppDate == today
                               join p in allPatients on a.PatientPesel equals p.Pesel
                               orderby a.AppTime
                               select new
                               {
                                   FullName = p.FullName,
                                   Pesel = p.Pesel,
                                   AppTime = a.AppTime,  
                                   Doctor = a.Doctor      
                               };

            dataGridView1.DataSource = combinedData.ToList();

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["FullName"].HeaderText = "Pacjent";
                dataGridView1.Columns["Pesel"].HeaderText = "PESEL";
                dataGridView1.Columns["AppTime"].HeaderText = "Godzina";
                dataGridView1.Columns["Doctor"].HeaderText = "Lekarz";

                dataGridView1.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }
    }
}
