namespace Rejestracja2
{
    partial class UcNewVisit
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            dataGridViewSearch = new DataGridView();
            lblSelectedPatient = new Label();
            ucCalendar1 = new UcCalendar();
            lblSelectedDate = new Label();
            cmbTime = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            cmbDoctor = new ComboBox();
            btnBook = new Button();
            btnFastBook = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(44, 102);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 0;
            label1.Text = "Wyszukaj pacjenta";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(44, 128);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nazwisko lub PESEL";
            txtSearch.Size = new Size(248, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSeach_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(46, 204, 113);
            label2.Location = new Point(30, 30);
            label2.Name = "label2";
            label2.Size = new Size(278, 54);
            label2.TabIndex = 2;
            label2.Text = "Umów wizytę";
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.AllowUserToResizeColumns = false;
            dataGridViewSearch.AllowUserToResizeRows = false;
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Location = new Point(30, 161);
            dataGridViewSearch.MultiSelect = false;
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.ReadOnly = true;
            dataGridViewSearch.RowHeadersVisible = false;
            dataGridViewSearch.RowHeadersWidth = 51;
            dataGridViewSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSearch.Size = new Size(322, 450);
            dataGridViewSearch.TabIndex = 3;
            dataGridViewSearch.SelectionChanged += dataGridViewSearch_SelectionChanged;
            // 
            // lblSelectedPatient
            // 
            lblSelectedPatient.AutoSize = true;
            lblSelectedPatient.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblSelectedPatient.Location = new Point(377, 64);
            lblSelectedPatient.Name = "lblSelectedPatient";
            lblSelectedPatient.Size = new Size(315, 38);
            lblSelectedPatient.TabIndex = 4;
            lblSelectedPatient.Text = "Wybrany pacjent: Brak";
            // 
            // ucCalendar1
            // 
            ucCalendar1.BackColor = Color.White;
            ucCalendar1.Location = new Point(334, 105);
            ucCalendar1.Name = "ucCalendar1";
            ucCalendar1.SelectedDate = "";
            ucCalendar1.Size = new Size(746, 437);
            ucCalendar1.TabIndex = 5;
            ucCalendar1.DateSelected += UcCalendar1_DateSelected;
            // 
            // lblSelectedDate
            // 
            lblSelectedDate.AutoSize = true;
            lblSelectedDate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSelectedDate.Location = new Point(358, 504);
            lblSelectedDate.Name = "lblSelectedDate";
            lblSelectedDate.Size = new Size(277, 38);
            lblSelectedDate.TabIndex = 9;
            lblSelectedDate.Text = "Wybrana data: Brak";
            // 
            // cmbTime
            // 
            cmbTime.FormattingEnabled = true;
            cmbTime.Location = new Point(551, 573);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(187, 28);
            cmbTime.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.Location = new Point(551, 545);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 12;
            label8.Text = "Godzina";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(358, 545);
            label7.Name = "label7";
            label7.Size = new Size(61, 25);
            label7.TabIndex = 11;
            label7.Text = "Lekarz";
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(358, 573);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(187, 28);
            cmbDoctor.TabIndex = 10;
            cmbDoctor.SelectedIndexChanged += CmbDoctor_SelectedIndexChanged;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(46, 204, 113);
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(904, 573);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(156, 58);
            btnBook.TabIndex = 14;
            btnBook.Text = "Umów wizytę";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnFastBook
            // 
            btnFastBook.BackColor = Color.FromArgb(241, 196, 15);
            btnFastBook.FlatAppearance.BorderSize = 0;
            btnFastBook.FlatStyle = FlatStyle.Flat;
            btnFastBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFastBook.ForeColor = Color.White;
            btnFastBook.Location = new Point(904, 496);
            btnFastBook.Name = "btnFastBook";
            btnFastBook.Size = new Size(156, 71);
            btnFastBook.TabIndex = 15;
            btnFastBook.Text = "Najbliższy termin";
            btnFastBook.UseVisualStyleBackColor = false;
            btnFastBook.Click += btnFastBooking_Click;
            // 
            // UcNewVisit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnFastBook);
            Controls.Add(dataGridViewSearch);
            Controls.Add(btnBook);
            Controls.Add(cmbTime);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmbDoctor);
            Controls.Add(lblSelectedDate);
            Controls.Add(ucCalendar1);
            Controls.Add(lblSelectedPatient);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "UcNewVisit";
            Size = new Size(1100, 665);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private DataGridView dataGridViewSearch;
        private Label lblSelectedPatient;
        private UcCalendar ucCalendar1;
        private Label lblSelectedDate;
        private ComboBox cmbTime;
        private Label label8;
        private Label label7;
        private ComboBox cmbDoctor;
        private Button btnBook;
        private Button btnFastBook;
    }
}
