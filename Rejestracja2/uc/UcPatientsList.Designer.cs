namespace Rejestracja2.uc
{
    partial class UcPatientsList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridViewPatients = new DataGridView();
            lblFullName = new Label();
            lblPesel = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            dataGridViewAppointments = new DataGridView();
            btnEdit = new Button();
            label2 = new Label();
            txtSearch = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(316, 54);
            label1.TabIndex = 0;
            label1.Text = "Lista pacjentów";
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.AllowUserToResizeColumns = false;
            dataGridViewPatients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            dataGridViewPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPatients.BackgroundColor = Color.White;
            dataGridViewPatients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewPatients.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPatients.EnableHeadersVisualStyles = false;
            dataGridViewPatients.Location = new Point(18, 80);
            dataGridViewPatients.MultiSelect = false;
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.ReadOnly = true;
            dataGridViewPatients.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPatients.RowHeadersVisible = false;
            dataGridViewPatients.RowHeadersWidth = 51;
            dataGridViewPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatients.Size = new Size(448, 543);
            dataGridViewPatients.TabIndex = 1;
            dataGridViewPatients.SelectionChanged += DataGridViewPatients_SelectionChanged;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblFullName.Location = new Point(503, 139);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(205, 46);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "lblFullName";
            // 
            // lblPesel
            // 
            lblPesel.AutoSize = true;
            lblPesel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblPesel.Location = new Point(503, 185);
            lblPesel.Name = "lblPesel";
            lblPesel.Size = new Size(102, 35);
            lblPesel.TabIndex = 3;
            lblPesel.Text = "lblPesel";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 15F);
            lblAddress.Location = new Point(503, 220);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(132, 35);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "lblAddress";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 15F);
            lblPhone.Location = new Point(503, 255);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(112, 35);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "lblPhone";
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.AllowUserToResizeColumns = false;
            dataGridViewAppointments.AllowUserToResizeRows = false;
            dataGridViewAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAppointments.BackgroundColor = Color.White;
            dataGridViewAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewAppointments.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewAppointments.EnableHeadersVisualStyles = false;
            dataGridViewAppointments.Location = new Point(503, 435);
            dataGridViewAppointments.MultiSelect = false;
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.ReadOnly = true;
            dataGridViewAppointments.RowHeadersVisible = false;
            dataGridViewAppointments.RowHeadersWidth = 51;
            dataGridViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointments.Size = new Size(385, 188);
            dataGridViewAppointments.TabIndex = 6;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(241, 196, 15);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(952, 23);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 54);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edytuj";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(503, 54);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 9;
            label2.Text = "Wyszukaj pacjenta";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(503, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nazwisko lub PESEL";
            txtSearch.Size = new Size(248, 27);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSeach_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(924, 435);
            button1.Name = "button1";
            button1.Size = new Size(158, 68);
            button1.TabIndex = 11;
            button1.Text = "Anuluj wizytę";
            button1.UseVisualStyleBackColor = false;
            // 
            // UcPatientsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(btnEdit);
            Controls.Add(dataGridViewAppointments);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblPesel);
            Controls.Add(lblFullName);
            Controls.Add(dataGridViewPatients);
            Controls.Add(label1);
            Name = "UcPatientsList";
            Size = new Size(1100, 665);
            Load += UcPatientsList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewPatients;
        private Label lblFullName;
        private Label lblPesel;
        private Label lblAddress;
        private Label lblPhone;
        private DataGridView dataGridViewAppointments;
        private Button btnEdit;
        private Label label2;
        private TextBox txtSearch;
        private Button button1;
    }
}
