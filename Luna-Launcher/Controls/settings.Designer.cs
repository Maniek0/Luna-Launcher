namespace Luna_Launcher.Controls
{
    partial class settings
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
            userName = new TextBox();
            groupBox1 = new GroupBox();
            OldBeta = new CheckBox();
            OldAlpha = new CheckBox();
            Snapshot = new CheckBox();
            groupBox2 = new GroupBox();
            maximumMb = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            minimumMb = new NumericUpDown();
            button1 = new Button();
            Versions = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            progress = new ProgressBar();
            button3 = new Button();
            otherVersions = new ComboBox();
            label5 = new Label();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maximumMb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimumMb).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Nazwa gracza";
            // 
            // userName
            // 
            userName.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            userName.Location = new Point(167, 14);
            userName.Margin = new Padding(0);
            userName.MaxLength = 32;
            userName.Name = "userName";
            userName.Size = new Size(171, 22);
            userName.TabIndex = 1;
            userName.Text = "Player";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OldBeta);
            groupBox1.Controls.Add(OldAlpha);
            groupBox1.Controls.Add(Snapshot);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(15, 50);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(323, 126);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pokaż inne wersje";
            // 
            // OldBeta
            // 
            OldBeta.AutoSize = true;
            OldBeta.Location = new Point(12, 87);
            OldBeta.Name = "OldBeta";
            OldBeta.Size = new Size(90, 25);
            OldBeta.TabIndex = 2;
            OldBeta.Text = "OldBeta";
            OldBeta.UseVisualStyleBackColor = true;
            // 
            // OldAlpha
            // 
            OldAlpha.AutoSize = true;
            OldAlpha.Location = new Point(12, 56);
            OldAlpha.Name = "OldAlpha";
            OldAlpha.Size = new Size(101, 25);
            OldAlpha.TabIndex = 1;
            OldAlpha.Text = "OldAlpha";
            OldAlpha.UseVisualStyleBackColor = true;
            // 
            // Snapshot
            // 
            Snapshot.AutoSize = true;
            Snapshot.Location = new Point(14, 25);
            Snapshot.Name = "Snapshot";
            Snapshot.Size = new Size(99, 25);
            Snapshot.TabIndex = 0;
            Snapshot.Text = "Snapshot";
            Snapshot.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(maximumMb);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(minimumMb);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(15, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pamięć ram";
            // 
            // maximumMb
            // 
            maximumMb.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            maximumMb.Location = new Point(152, 64);
            maximumMb.Margin = new Padding(0);
            maximumMb.Maximum = new decimal(new int[] { 131072, 0, 0, 0 });
            maximumMb.Minimum = new decimal(new int[] { 1024, 0, 0, 0 });
            maximumMb.Name = "maximumMb";
            maximumMb.Size = new Size(165, 22);
            maximumMb.TabIndex = 3;
            maximumMb.TextAlign = HorizontalAlignment.Right;
            maximumMb.Value = new decimal(new int[] { 1024, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 2;
            label3.Text = "Maximum Ram";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 1;
            label2.Text = "Minimum Ram";
            // 
            // minimumMb
            // 
            minimumMb.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            minimumMb.Location = new Point(152, 24);
            minimumMb.Margin = new Padding(0);
            minimumMb.Maximum = new decimal(new int[] { 131072, 0, 0, 0 });
            minimumMb.Name = "minimumMb";
            minimumMb.Size = new Size(165, 22);
            minimumMb.TabIndex = 0;
            minimumMb.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(257, 444);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 4;
            button1.Text = "Zapisz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Versions
            // 
            Versions.DropDownStyle = ComboBoxStyle.DropDownList;
            Versions.Location = new Point(101, 285);
            Versions.Name = "Versions";
            Versions.Size = new Size(138, 29);
            Versions.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 293);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 6;
            label4.Text = "Wersja";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(245, 285);
            button2.Name = "button2";
            button2.Size = new Size(40, 30);
            button2.TabIndex = 7;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(progress);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(otherVersions);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(3, 320);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 45);
            panel1.TabIndex = 8;
            panel1.Visible = false;
            // 
            // progress
            // 
            progress.Dock = DockStyle.Bottom;
            progress.Location = new Point(0, 40);
            progress.Name = "progress";
            progress.Size = new Size(345, 5);
            progress.TabIndex = 10;
            progress.Visible = false;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(242, 7);
            button3.Name = "button3";
            button3.Size = new Size(87, 29);
            button3.TabIndex = 9;
            button3.Text = "Instaluj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // otherVersions
            // 
            otherVersions.DropDownStyle = ComboBoxStyle.DropDownList;
            otherVersions.Location = new Point(98, 7);
            otherVersions.Name = "otherVersions";
            otherVersions.Size = new Size(138, 29);
            otherVersions.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 15);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 7;
            label5.Text = "Inne";
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(293, 285);
            button4.Name = "button4";
            button4.Size = new Size(40, 30);
            button4.TabIndex = 9;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 41, 60);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(Versions);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(userName);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "settings";
            Size = new Size(348, 486);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maximumMb).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimumMb).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userName;
        private GroupBox groupBox1;
        private CheckBox Snapshot;
        private CheckBox OldAlpha;
        private CheckBox OldBeta;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private NumericUpDown minimumMb;
        private NumericUpDown maximumMb;
        private Button button1;
        private ComboBox Versions;
        private Label label4;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private ComboBox otherVersions;
        private Label label5;
        private ProgressBar progress;
        private Button button4;
    }
}
