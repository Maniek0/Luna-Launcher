namespace Luna_Launcher
{
    partial class MainGui
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            settingsBtn = new Button();
            homeBtn = new Button();
            home1 = new Controls.Home();
            settings1 = new Controls.settings();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 41, 45);
            panel1.Controls.Add(settingsBtn);
            panel1.Controls.Add(homeBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 561);
            panel1.TabIndex = 1;
            // 
            // settingsBtn
            // 
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            settingsBtn.ForeColor = SystemColors.Control;
            settingsBtn.Location = new Point(0, 513);
            settingsBtn.Margin = new Padding(0);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(136, 48);
            settingsBtn.TabIndex = 1;
            settingsBtn.Text = "Ustawienia";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            homeBtn.ForeColor = SystemColors.Control;
            homeBtn.Location = new Point(0, 0);
            homeBtn.Margin = new Padding(0);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(136, 48);
            homeBtn.TabIndex = 0;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // home1
            // 
            home1.BackColor = Color.FromArgb(40, 41, 60);
            home1.Dock = DockStyle.Fill;
            home1.Location = new Point(136, 0);
            home1.Margin = new Padding(0);
            home1.Name = "home1";
            home1.Size = new Size(348, 561);
            home1.TabIndex = 2;
            // 
            // settings1
            // 
            settings1.BackColor = Color.FromArgb(40, 41, 60);
            settings1.Dock = DockStyle.Fill;
            settings1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            settings1.ForeColor = SystemColors.Control;
            settings1.Location = new Point(136, 0);
            settings1.Margin = new Padding(0);
            settings1.Name = "settings1";
            settings1.Size = new Size(348, 561);
            settings1.TabIndex = 3;
            settings1.Visible = false;
            // 
            // MainGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 41, 60);
            ClientSize = new Size(484, 561);
            Controls.Add(settings1);
            Controls.Add(home1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainGui";
            Text = "Luna-Launcher";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button homeBtn;
        private Button settingsBtn;
        private Controls.Home home1;
        private Controls.settings settings1;
    }
}