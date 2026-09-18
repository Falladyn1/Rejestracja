using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rejestracja2
{
    public partial class UcCalendar : UserControl
    {
        // zdarzenie do wysyłania daty na zewnątrz
        public event EventHandler<string> DateSelected;


        private int currentYear = DateTime.Now.Year;
        private int currentMonth = DateTime.Now.Month;

        // właściwość do pobrania wybranej daty z innych klas
        public string SelectedDate { get; set; } = "";

        public UcCalendar()
        {
            InitializeComponent();

            RefreshCalendar(); // Ładujemy kalendarz od razu przy odpaleniu kontrolki

        }

        private void RefreshCalendar()
        {
            DateTime displayDate = new DateTime(currentYear, currentMonth, 1);
            // pobranie polskiej nazwy miesiaca
            string monthName = displayDate.ToString("MMMM yyyy", new System.Globalization.CultureInfo("pl-PL"));

            if (lblMonthYear != null)
            {
                lblMonthYear.Text = char.ToUpper(monthName[0]) + monthName.Substring(1);
            }

            BuildCalendar(currentYear, currentMonth);
        }

        private void BuildCalendar(int year, int month)
        {
            // czyszczenie siatki przed narysowaniem kolejnego miesiaca
            dataGridViewCalendar.Columns.Clear();
            dataGridViewCalendar.Rows.Clear();
            dataGridViewCalendar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewCalendar.DefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            string[] days = { "PN", "WT", "ŚR", "CZW", "PT", "SOB", "NDZ" };

            foreach (string day in days)
            {
                dataGridViewCalendar.Columns.Add(day, day);
            }

            DateTime firstDayInMonth = new DateTime(year, month, 1);
            int countDaysInMonth = DateTime.DaysInMonth(year, month);


            // sprawdzenie w jaki dzien tygodnia zaczyna sie miesiąc
            // niedziela to 0
            int starterDayInWeek = (int)firstDayInMonth.DayOfWeek;
            starterDayInWeek = starterDayInWeek == 0 ? 6 : starterDayInWeek - 1;

            int currentRow = dataGridViewCalendar.Rows.Add();

            // wypelnienie pustymi polami miejsce przed pierwszym dniem miesiąca
            for (int i = 0; i < starterDayInWeek; i++)
            {
                dataGridViewCalendar.Rows[currentRow].Cells[i].Value = "";
            }

            int curretCell = starterDayInWeek;

            // pętla przez wyszytkie dni miesiąca
            for (int day = 1; day <= countDaysInMonth; day++)
            {
                dataGridViewCalendar.Rows[currentRow].Cells[curretCell].Value = day.ToString();

                // ustawienie bierzącego dnia na czerwnono 
                if (year == DateTime.Now.Year && month == DateTime.Now.Month && day == DateTime.Now.Day)
                {
                    dataGridViewCalendar.Rows[currentRow].Cells[curretCell].Style.ForeColor = Color.Red;
                }

                curretCell++;

                // nowy tydzien nowy wiersz
                if (curretCell > 6 && day < countDaysInMonth)
                {
                    curretCell = 0;
                    currentRow = dataGridViewCalendar.Rows.Add();
                }
            }

            foreach (DataGridViewRow row in dataGridViewCalendar.Rows)
            {
                row.Height = 50;
            }
        }

        // usuniecie zaznaczenia startowego
        private void UcCalendar_Load(object sender, EventArgs e)
        {
            dataGridViewCalendar.CurrentCell = null;
            dataGridViewCalendar.ClearSelection();
        }


        // cofanie miesiąca do tyłu
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentMonth--;
            if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            RefreshCalendar();
        }

        // miesiąc do przodu
        private void btnNext_Click(object sender, EventArgs e)
        {
            currentMonth++;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            RefreshCalendar();
        }

        private void DataGridViewCalendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // sprawdzenie czy nie zostało kliniete w nagłowek
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string wartosc = dataGridViewCalendar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                // sprawdzenie czy kliknieto w pole z tekstem
                if (!string.IsNullOrWhiteSpace(wartosc))
                {
                    int dzien = int.Parse(wartosc);
                    // sklejanie daty w całość
                    SelectedDate = $"{dzien:D2}.{currentMonth:D2}.{currentYear}";

                    // wywołanie zdarzenia
                    DateSelected?.Invoke(this, SelectedDate);
                }
            }
        }


    }
}