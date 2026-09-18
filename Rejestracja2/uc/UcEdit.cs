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
    public partial class UcEdit : UserControl
    {
        private string pesel;

        public UcEdit(string pesel)
        {
            InitializeComponent();
            this.pesel = pesel; // Przypisanie przekazanego PESELu do pola klasy
            lblTitle.Text = $"Edycja {pesel}";
            LoadPatient();
        }

        private void LoadPatient()
        {
            var allPatients = PatientDatabase.LoadPatients();
            // Używamy FirstOrDefault zamiast Where + as
            var patient = allPatients.FirstOrDefault(p => p.Pesel == pesel);

            // Sprawdzamy czy pacjent został znaleziony (!= null)
            if (patient != null)
            {
                txtFirstName.Text = patient.FirstName;
                txtLastName.Text = patient.LastName;
                txtPesel.Text = patient.Pesel;
                txtPhone.Text = patient.PhoneNumber;
                txtCity.Text = patient.City;
                txtPostCode.Text = patient.PostCode;
                txtStreet.Text = patient.Street;
                txtHomeNum.Text = patient.HomeNum;
            }
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtPesel.Text))
            {
                MessageBox.Show("Imię, nazwisko i PESEL są wymagane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPesel.Text.Length != 11 || !txtPesel.Text.All(char.IsDigit))
            {
                MessageBox.Show("Numer PESEL musi składać się dokładnie z 11 cyfr!", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var allPatients = PatientDatabase.LoadPatients();
            // Używamy FirstOrDefault zamiast Where + as
            var patient = allPatients.FirstOrDefault(p => p.Pesel == pesel);

            if (patient != null)
            {
                patient.FirstName = txtFirstName.Text;
                patient.LastName = txtLastName.Text;
                patient.Pesel = txtPesel.Text;
                patient.PhoneNumber = txtPhone.Text;
                patient.City = txtCity.Text;
                patient.PostCode = txtPostCode.Text;
                patient.Street = txtStreet.Text;
                patient.HomeNum = txtHomeNum.Text;

                PatientDatabase.SavePatients(allPatients);
                MessageBox.Show("Zaktualizowano dane pacjenta!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Panel parent = (Panel)this.Parent;
                if (parent != null)
                {
                    parent.Controls.Clear();
                    UcPatientsList ucPatientsList = new UcPatientsList();
                    ucPatientsList.Dock = DockStyle.Fill;
                    parent.Controls.Add(ucPatientsList);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel)this.Parent;
            if (parent != null)
            {
                parent.Controls.Clear();
                UcPatientsList ucPatientsList = new UcPatientsList();
                ucPatientsList.Dock = DockStyle.Fill;
                parent.Controls.Add(ucPatientsList);
            }
        }
    }
}