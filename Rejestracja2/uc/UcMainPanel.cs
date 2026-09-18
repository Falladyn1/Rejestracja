using Rejestracja2.uc;
using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Rejestracja2
{
    public partial class UcMainPanel : UserControl
    {
        public UcMainPanel()
        {
            InitializeComponent();

            lblUsername.Text = $"{Session.LoggedInUser}";

        }

        // przełączenie na dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelMainDashboard.Controls.Clear();
            UcDashboard mainPanel = new UcDashboard();
            mainPanel.Dock = DockStyle.Fill;
            panelMainDashboard.Controls.Add(mainPanel);
        }

        // przełączenie na liste pacjentów
        private void btnPatientList_Click(object sender, EventArgs e)
        {
            panelMainDashboard.Controls.Clear();
            UcPatientsList patientsList = new UcPatientsList();
            patientsList.Dock = DockStyle.Fill;
            panelMainDashboard.Controls.Add(patientsList);
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wylogowanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Session.LoggedInUser = "";
                Application.Restart(); // Zamyka i odpala program od nowa 
            }
        }

        // metoda w ramach testu
        private void lblUsername_Click(object sender, EventArgs e)
        {
            PatientsGenerator.GenerateData(500);
            MessageBox.Show("Wygenerowano 500 pacjentow i wizyt");
        }
    }
}