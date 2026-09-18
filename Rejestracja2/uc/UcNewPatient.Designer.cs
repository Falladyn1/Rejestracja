namespace Rejestracja2
{
    partial class UcNewPatient
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
            groupBox1 = new GroupBox();
            txtPostCode = new MaskedTextBox();
            lblPostCode = new Label();
            txtHomeNum = new TextBox();
            lblHomeNum = new Label();
            txtStreet = new TextBox();
            label10 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtPhone = new MaskedTextBox();
            txtPesel = new MaskedTextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnNewPatient = new Button();
            ucCalendar1 = new UcCalendar();
            cmbDoctor = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            cmbTime = new ComboBox();
            lblSelectedDate = new Label();
            btnFastBook = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(241, 196, 15);
            label1.Location = new Point(4, 38);
            label1.Name = "label1";
            label1.Size = new Size(282, 54);
            label1.TabIndex = 0;
            label1.Text = "Nowy Pacjent";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPostCode);
            groupBox1.Controls.Add(lblPostCode);
            groupBox1.Controls.Add(txtHomeNum);
            groupBox1.Controls.Add(lblHomeNum);
            groupBox1.Controls.Add(txtStreet);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtPesel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(28, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 500);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane osobowe";
            // 
            // txtPostCode
            // 
            txtPostCode.Location = new Point(6, 347);
            txtPostCode.Mask = "00-000";
            txtPostCode.Name = "txtPostCode";
            txtPostCode.Size = new Size(168, 30);
            txtPostCode.TabIndex = 17;
            // 
            // lblPostCode
            // 
            lblPostCode.AutoSize = true;
            lblPostCode.Font = new Font("Segoe UI", 10.8F);
            lblPostCode.Location = new Point(6, 319);
            lblPostCode.Name = "lblPostCode";
            lblPostCode.Size = new Size(126, 25);
            lblPostCode.TabIndex = 16;
            lblPostCode.Text = "Kod pocztowy";
            // 
            // txtHomeNum
            // 
            txtHomeNum.AllowDrop = true;
            txtHomeNum.Location = new Point(6, 463);
            txtHomeNum.Name = "txtHomeNum";
            txtHomeNum.Size = new Size(84, 30);
            txtHomeNum.TabIndex = 15;
            // 
            // lblHomeNum
            // 
            lblHomeNum.AutoSize = true;
            lblHomeNum.Font = new Font("Segoe UI", 10.8F);
            lblHomeNum.Location = new Point(6, 435);
            lblHomeNum.Name = "lblHomeNum";
            lblHomeNum.Size = new Size(84, 25);
            lblHomeNum.TabIndex = 14;
            lblHomeNum.Text = "Nr domu";
            // 
            // txtStreet
            // 
            txtStreet.AllowDrop = true;
            txtStreet.Location = new Point(6, 405);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(168, 30);
            txtStreet.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F);
            label10.Location = new Point(6, 377);
            label10.Name = "label10";
            label10.Size = new Size(49, 25);
            label10.TabIndex = 12;
            label10.Text = "Ulica";
            // 
            // txtCity
            // 
            txtCity.AllowDrop = true;
            txtCity.Location = new Point(6, 289);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(168, 30);
            txtCity.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(6, 261);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 10;
            label6.Text = "Miasto";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(6, 222);
            txtPhone.Mask = "000-000-000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(168, 30);
            txtPhone.TabIndex = 9;
            // 
            // txtPesel
            // 
            txtPesel.Location = new Point(6, 152);
            txtPesel.Mask = "00000000000";
            txtPesel.Name = "txtPesel";
            txtPesel.Size = new Size(168, 30);
            txtPesel.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(6, 194);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 7;
            label5.Text = "Telefon";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(6, 99);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(168, 30);
            txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(6, 46);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(168, 30);
            txtFirstName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 4;
            label4.Text = "PESEL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 3;
            label3.Text = "Nazwisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 2;
            label2.Text = "Imię";
            // 
            // btnNewPatient
            // 
            btnNewPatient.BackColor = Color.FromArgb(241, 196, 15);
            btnNewPatient.FlatAppearance.BorderSize = 0;
            btnNewPatient.FlatStyle = FlatStyle.Flat;
            btnNewPatient.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewPatient.ForeColor = Color.White;
            btnNewPatient.Location = new Point(922, 570);
            btnNewPatient.Name = "btnNewPatient";
            btnNewPatient.Size = new Size(156, 58);
            btnNewPatient.TabIndex = 2;
            btnNewPatient.Text = "Nowy Pacjent";
            btnNewPatient.UseVisualStyleBackColor = false;
            btnNewPatient.Click += btnAddPatient_Click;
            // 
            // ucCalendar1
            // 
            ucCalendar1.BackColor = Color.White;
            ucCalendar1.Location = new Point(292, 51);
            ucCalendar1.Name = "ucCalendar1";
            ucCalendar1.SelectedDate = "";
            ucCalendar1.Size = new Size(742, 409);
            ucCalendar1.TabIndex = 3;
            ucCalendar1.DateSelected += UcCalendar1_DateSelected;
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(299, 557);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(187, 28);
            cmbDoctor.TabIndex = 4;
            cmbDoctor.SelectedIndexChanged += CmbDoctor_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(299, 529);
            label7.Name = "label7";
            label7.Size = new Size(61, 25);
            label7.TabIndex = 5;
            label7.Text = "Lekarz";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.Location = new Point(492, 529);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 6;
            label8.Text = "Godzina";
            // 
            // cmbTime
            // 
            cmbTime.FormattingEnabled = true;
            cmbTime.Location = new Point(492, 557);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(187, 28);
            cmbTime.TabIndex = 7;
            // 
            // lblSelectedDate
            // 
            lblSelectedDate.AutoSize = true;
            lblSelectedDate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSelectedDate.Location = new Point(292, 479);
            lblSelectedDate.Name = "lblSelectedDate";
            lblSelectedDate.Size = new Size(277, 38);
            lblSelectedDate.TabIndex = 8;
            lblSelectedDate.Text = "Wybrana data: Brak";
            // 
            // btnFastBook
            // 
            btnFastBook.BackColor = Color.FromArgb(46, 204, 113);
            btnFastBook.FlatAppearance.BorderSize = 0;
            btnFastBook.FlatStyle = FlatStyle.Flat;
            btnFastBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFastBook.ForeColor = Color.White;
            btnFastBook.Location = new Point(922, 493);
            btnFastBook.Name = "btnFastBook";
            btnFastBook.Size = new Size(156, 71);
            btnFastBook.TabIndex = 16;
            btnFastBook.Text = "Najbliższy termin";
            btnFastBook.UseVisualStyleBackColor = false;
            btnFastBook.Click += btnFastBooking_Click;
            // 
            // UcNewPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnFastBook);
            Controls.Add(lblSelectedDate);
            Controls.Add(cmbTime);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmbDoctor);
            Controls.Add(label1);
            Controls.Add(ucCalendar1);
            Controls.Add(btnNewPatient);
            Controls.Add(groupBox1);
            Name = "UcNewPatient";
            Size = new Size(1100, 665);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtFirstName;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCity;
        private Label label6;
        private MaskedTextBox txtPhone;
        private MaskedTextBox txtPesel;
        private Label label5;
        private TextBox txtLastName;
        private Button btnNewPatient;
        private UcCalendar ucCalendar1;
        private ComboBox cmbDoctor;
        private Label label7;
        private Label label8;
        private ComboBox cmbTime;
        private Label lblSelectedDate;
        private TextBox txtStreet;
        private Label label10;
        private TextBox txtHomeNum;
        private Label lblHomeNum;
        private MaskedTextBox txtPostCode;
        private Label lblPostCode;
        private Button btnFastBook;
    }
}
