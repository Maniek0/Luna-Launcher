namespace Luna_Launcher.Controls
{
    partial class Home
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
            panel1 = new Panel();
            playBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 41, 45);
            panel1.Controls.Add(playBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 513);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 48);
            panel1.TabIndex = 0;
            // 
            // playBtn
            // 
            playBtn.Dock = DockStyle.Right;
            playBtn.FlatAppearance.BorderSize = 0;
            playBtn.FlatStyle = FlatStyle.Flat;
            playBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            playBtn.ForeColor = SystemColors.Control;
            playBtn.Location = new Point(181, 0);
            playBtn.Name = "playBtn";
            playBtn.Size = new Size(167, 48);
            playBtn.TabIndex = 1;
            playBtn.Text = "Graj";
            playBtn.UseVisualStyleBackColor = true;
            playBtn.Click += playBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 41, 60);
            Controls.Add(panel1);
            Name = "Home";
            Size = new Size(348, 561);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button playBtn;
    }
}
