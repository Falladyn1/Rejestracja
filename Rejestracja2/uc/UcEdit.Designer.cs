namespace Rejestracja2.uc
{
    partial class UcEdit
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
            lblTitle = new Label();
            groupBox1 = new GroupBox();
            txtPostCode = new MaskedTextBox();
            lblPostCode = new Label();
            txtHomeNum = new TextBox();
            lblHomeNum = new Label();
            txtStreet = new TextBox();
            lblStreet = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtPhone = new MaskedTextBox();
            txtPesel = new MaskedTextBox();
            lblPhone = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblPesel = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            btnNewPatient = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTitle.Location = new Point(21, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Edycja\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPostCode);
            groupBox1.Controls.Add(lblPostCode);
            groupBox1.Controls.Add(txtHomeNum);
            groupBox1.Controls.Add(lblHomeNum);
            groupBox1.Controls.Add(txtStreet);
            groupBox1.Controls.Add(lblStreet);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(lblCity);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtPesel);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(lblPesel);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(21, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(637, 555);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane osobowe";
            // 
            // txtPostCode
            // 
            txtPostCode.Location = new Point(443, 84);
            txtPostCode.Mask = "00-000";
            txtPostCode.Name = "txtPostCode";
            txtPostCode.Size = new Size(168, 30);
            txtPostCode.TabIndex = 17;
            // 
            // lblPostCode
            // 
            lblPostCode.AutoSize = true;
            lblPostCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPostCode.Location = new Point(443, 26);
            lblPostCode.Name = "lblPostCode";
            lblPostCode.Size = new Size(140, 28);
            lblPostCode.TabIndex = 16;
            lblPostCode.Text = "Kod pocztowy";
            // 
            // txtHomeNum
            // 
            txtHomeNum.AllowDrop = true;
            txtHomeNum.Location = new Point(443, 175);
            txtHomeNum.Name = "txtHomeNum";
            txtHomeNum.Size = new Size(84, 30);
            txtHomeNum.TabIndex = 15;
            // 
            // lblHomeNum
            // 
            lblHomeNum.AutoSize = true;
            lblHomeNum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblHomeNum.Location = new Point(443, 117);
            lblHomeNum.Name = "lblHomeNum";
            lblHomeNum.Size = new Size(94, 28);
            lblHomeNum.TabIndex = 14;
            lblHomeNum.Text = "Nr domu";
            // 
            // txtStreet
            // 
            txtStreet.AllowDrop = true;
            txtStreet.Location = new Point(269, 175);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(168, 30);
            txtStreet.TabIndex = 13;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStreet.Location = new Point(269, 117);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(55, 28);
            lblStreet.TabIndex = 12;
            lblStreet.Text = "Ulica";
            // 
            // txtCity
            // 
            txtCity.AllowDrop = true;
            txtCity.Location = new Point(269, 84);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(168, 30);
            txtCity.TabIndex = 11;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCity.Location = new Point(269, 26);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(73, 28);
            lblCity.TabIndex = 10;
            lblCity.Text = "Miasto";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(6, 344);
            txtPhone.Mask = "000-000-000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(168, 30);
            txtPhone.TabIndex = 9;
            // 
            // txtPesel
            // 
            txtPesel.Location = new Point(6, 253);
            txtPesel.Mask = "00000000000";
            txtPesel.Name = "txtPesel";
            txtPesel.Size = new Size(168, 30);
            txtPesel.TabIndex = 8;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhone.Location = new Point(6, 286);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(79, 28);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Telefon";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(6, 175);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(168, 30);
            txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(6, 84);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(168, 30);
            txtFirstName.TabIndex = 2;
            // 
            // lblPesel
            // 
            lblPesel.AutoSize = true;
            lblPesel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPesel.Location = new Point(6, 208);
            lblPesel.Name = "lblPesel";
            lblPesel.Size = new Size(65, 28);
            lblPesel.TabIndex = 4;
            lblPesel.Text = "PESEL";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblLastName.Location = new Point(6, 117);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(98, 28);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Nazwisko";
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblFirstName.Location = new Point(6, 26);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(58, 55);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "Imię";
            // 
            // btnNewPatient
            // 
            btnNewPatient.BackColor = Color.FromArgb(46, 204, 113);
            btnNewPatient.FlatAppearance.BorderSize = 0;
            btnNewPatient.FlatStyle = FlatStyle.Flat;
            btnNewPatient.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewPatient.ForeColor = Color.White;
            btnNewPatient.Location = new Point(912, 574);
            btnNewPatient.Name = "btnNewPatient";
            btnNewPatient.Size = new Size(155, 58);
            btnNewPatient.TabIndex = 3;
            btnNewPatient.Text = "Zapisz";
            btnNewPatient.UseVisualStyleBackColor = false;
            btnNewPatient.Click += btnNewPatient_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(700, 574);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 58);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // UcEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnNewPatient);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Name = "UcEdit";
            Size = new Size(1100, 665);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox groupBox1;
        private MaskedTextBox txtPostCode;
        private Label lblPostCode;
        private TextBox txtHomeNum;
        private Label lblHomeNum;
        private TextBox txtStreet;
        private Label lblStreet;
        private TextBox txtCity;
        private Label lblCity;
        private MaskedTextBox txtPhone;
        private MaskedTextBox txtPesel;
        private Label lblPhone;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblPesel;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnNewPatient;
        private Button btnCancel;
    }
}
