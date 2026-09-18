namespace Rejestracja2
{
    partial class UcCalendar
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
            btnPrev = new Button();
            btnNext = new Button();
            lblMonthYear = new Label();
            dataGridViewCalendar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendar).BeginInit();
            SuspendLayout();
            // 
            // btnPrev
            // 
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnPrev.ForeColor = Color.Black;
            btnPrev.Location = new Point(245, 365);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(94, 37);
            btnPrev.TabIndex = 0;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(440, 365);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 37);
            btnNext.TabIndex = 1;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblMonthYear
            // 
            lblMonthYear.AutoSize = true;
            lblMonthYear.Location = new Point(345, 376);
            lblMonthYear.Name = "lblMonthYear";
            lblMonthYear.Size = new Size(50, 20);
            lblMonthYear.TabIndex = 2;
            lblMonthYear.Text = "label1";
            // 
            // dataGridViewCalendar
            // 
            dataGridViewCalendar.AllowUserToAddRows = false;
            dataGridViewCalendar.BackgroundColor = Color.White;
            dataGridViewCalendar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCalendar.Location = new Point(72, 37);
            dataGridViewCalendar.Name = "dataGridViewCalendar";
            dataGridViewCalendar.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCalendar.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCalendar.RowHeadersVisible = false;
            dataGridViewCalendar.RowHeadersWidth = 51;
            dataGridViewCalendar.Size = new Size(636, 322);
            dataGridViewCalendar.TabIndex = 3;
            dataGridViewCalendar.CellClick += DataGridViewCalendar_CellClick;
            // 
            // UcCalendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridViewCalendar);
            Controls.Add(lblMonthYear);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Name = "UcCalendar";
            Size = new Size(785, 438);
            Load += UcCalendar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrev;
        private Button btnNext;
        private Label lblMonthYear;
        private DataGridView dataGridViewCalendar;
    }
}
