namespace Rejestracja2
{
    partial class UcDashboard
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnNewVisit = new Button();
            btnNewPatient = new Button();
            panelPatientNum = new Panel();
            lblNumOfPatientsToday = new Label();
            label2 = new Label();
            panelNewPatients = new Panel();
            lblNumOfPatients = new Label();
            label1 = new Label();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            panelPatientNum.SuspendLayout();
            panelNewPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNewVisit
            // 
            btnNewVisit.BackColor = Color.FromArgb(46, 204, 113);
            btnNewVisit.FlatAppearance.BorderSize = 0;
            btnNewVisit.FlatStyle = FlatStyle.Flat;
            btnNewVisit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewVisit.ForeColor = Color.White;
            btnNewVisit.Location = new Point(611, 578);
            btnNewVisit.Name = "btnNewVisit";
            btnNewVisit.Size = new Size(230, 58);
            btnNewVisit.TabIndex = 0;
            btnNewVisit.Text = "Umów wizytę";
            btnNewVisit.UseVisualStyleBackColor = false;
            btnNewVisit.Click += btnNewVisit_Click;
            // 
            // btnNewPatient
            // 
            btnNewPatient.BackColor = Color.FromArgb(241, 196, 15);
            btnNewPatient.FlatAppearance.BorderSize = 0;
            btnNewPatient.FlatStyle = FlatStyle.Flat;
            btnNewPatient.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewPatient.ForeColor = Color.White;
            btnNewPatient.Location = new Point(850, 578);
            btnNewPatient.Name = "btnNewPatient";
            btnNewPatient.Size = new Size(230, 58);
            btnNewPatient.TabIndex = 1;
            btnNewPatient.Text = "Nowy Pacjent";
            btnNewPatient.UseVisualStyleBackColor = false;
            btnNewPatient.Click += btnNewPatient_Click;
            // 
            // panelPatientNum
            // 
            panelPatientNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelPatientNum.AutoSize = true;
            panelPatientNum.BackColor = Color.FromArgb(46, 204, 113);
            panelPatientNum.Controls.Add(lblNumOfPatientsToday);
            panelPatientNum.Controls.Add(label2);
            panelPatientNum.Location = new Point(608, 18);
            panelPatientNum.Name = "panelPatientNum";
            panelPatientNum.Size = new Size(233, 185);
            panelPatientNum.TabIndex = 10;
            // 
            // lblNumOfPatientsToday
            // 
            lblNumOfPatientsToday.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNumOfPatientsToday.AutoSize = true;
            lblNumOfPatientsToday.Font = new Font("Segoe UI", 24F);
            lblNumOfPatientsToday.ForeColor = Color.White;
            lblNumOfPatientsToday.Location = new Point(94, 72);
            lblNumOfPatientsToday.Name = "lblNumOfPatientsToday";
            lblNumOfPatientsToday.Size = new Size(45, 54);
            lblNumOfPatientsToday.TabIndex = 2;
            lblNumOfPatientsToday.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(165, 28);
            label2.TabIndex = 1;
            label2.Text = "Liczba wizyt dziś:";
            // 
            // panelNewPatients
            // 
            panelNewPatients.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelNewPatients.AutoSize = true;
            panelNewPatients.BackColor = Color.FromArgb(241, 196, 15);
            panelNewPatients.Controls.Add(lblNumOfPatients);
            panelNewPatients.Controls.Add(label1);
            panelNewPatients.Location = new Point(847, 18);
            panelNewPatients.Name = "panelNewPatients";
            panelNewPatients.Size = new Size(233, 185);
            panelNewPatients.TabIndex = 9;
            // 
            // lblNumOfPatients
            // 
            lblNumOfPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNumOfPatients.AutoSize = true;
            lblNumOfPatients.Font = new Font("Segoe UI", 24F);
            lblNumOfPatients.ForeColor = Color.White;
            lblNumOfPatients.Location = new Point(89, 72);
            lblNumOfPatients.Name = "lblNumOfPatients";
            lblNumOfPatients.Size = new Size(45, 54);
            lblNumOfPatients.TabIndex = 3;
            lblNumOfPatients.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 1;
            label1.Text = "Wszyscy pacjenci:";
            // 
            // labelTime
            // 
            labelTime.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelTime.Location = new Point(18, 23);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(352, 133);
            labelTime.TabIndex = 11;
            labelTime.Text = "time";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(18, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(583, 427);
            dataGridView1.TabIndex = 12;
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(labelTime);
            Controls.Add(panelPatientNum);
            Controls.Add(panelNewPatients);
            Controls.Add(btnNewPatient);
            Controls.Add(btnNewVisit);
            Name = "UcDashboard";
            Size = new Size(1100, 665);
            panelPatientNum.ResumeLayout(false);
            panelPatientNum.PerformLayout();
            panelNewPatients.ResumeLayout(false);
            panelNewPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewVisit;
        private Button btnNewPatient;
        private Panel panelPatientNum;
        private Label lblNumOfPatientsToday;
        private Label label2;
        private Panel panelNewPatients;
        private Label lblNumOfPatients;
        private Label label1;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dataGridView1;
    }
}
