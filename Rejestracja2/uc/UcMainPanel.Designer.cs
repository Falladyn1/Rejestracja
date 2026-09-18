namespace Rejestracja2
{
    partial class UcMainPanel
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
            panelMenu = new Panel();
            lblUsername = new Label();
            btnLogout = new Button();
            btnPatientList = new Button();
            btnDashboard = new Button();
            panelMainDashboard = new Panel();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelMainDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(33, 43, 54);
            panelMenu.Controls.Add(lblUsername);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnPatientList);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(146, 673);
            panelMenu.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.FlatStyle = FlatStyle.Flat;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(0, 572);
            lblUsername.Name = "lblUsername";
            lblUsername.RightToLeft = RightToLeft.No;
            lblUsername.Size = new Size(146, 38);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "lblUsername";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            lblUsername.Click += lblUsername_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 613);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 60);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Wyloguj";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnPatientList
            // 
            btnPatientList.FlatAppearance.BorderSize = 0;
            btnPatientList.FlatStyle = FlatStyle.Flat;
            btnPatientList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnPatientList.ForeColor = Color.White;
            btnPatientList.Location = new Point(0, 78);
            btnPatientList.Name = "btnPatientList";
            btnPatientList.Size = new Size(146, 60);
            btnPatientList.TabIndex = 1;
            btnPatientList.Text = "Lista Pacjentów";
            btnPatientList.UseVisualStyleBackColor = true;
            btnPatientList.Click += btnPatientList_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 12);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(146, 60);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Panel Główny";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelMainDashboard
            // 
            panelMainDashboard.Controls.Add(label1);
            panelMainDashboard.Location = new Point(152, 3);
            panelMainDashboard.Name = "panelMainDashboard";
            panelMainDashboard.Size = new Size(1107, 667);
            panelMainDashboard.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(346, 284);
            label1.Name = "label1";
            label1.Size = new Size(423, 41);
            label1.TabIndex = 0;
            label1.Text = "System Rejestracji Pacjentów";
            // 
            // UcMainPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMainDashboard);
            Controls.Add(panelMenu);
            Name = "UcMainPanel";
            Size = new Size(1262, 673);
            panelMenu.ResumeLayout(false);
            panelMainDashboard.ResumeLayout(false);
            panelMainDashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelMainDashboard;
        private Button btnPatientList;
        private Button btnDashboard;
        private Label label1;
        private Button btnLogout;
        private Label lblUsername;
    }
}
