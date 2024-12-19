namespace Synapse_Z
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            TopBar = new System.Windows.Forms.Panel();
            Minimize = new System.Windows.Forms.Button();
            Close = new System.Windows.Forms.Button();
            synlabel = new System.Windows.Forms.Label();
            Logo = new System.Windows.Forms.PictureBox();
            TabClosingPrompt = new System.Windows.Forms.CheckBox();
            ClearEditorPrompt = new System.Windows.Forms.CheckBox();
            TopMostCheck = new System.Windows.Forms.CheckBox();
            UnlockFPS = new System.Windows.Forms.CheckBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            Reset = new System.Windows.Forms.Button();
            mainPanel = new System.Windows.Forms.Panel();
            TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopBar
            // 
            TopBar.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            TopBar.Controls.Add(Minimize);
            TopBar.Controls.Add(Close);
            TopBar.Controls.Add(synlabel);
            TopBar.Controls.Add(Logo);
            TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            TopBar.Location = new System.Drawing.Point(0, 0);
            TopBar.Name = "TopBar";
            TopBar.Size = new System.Drawing.Size(330, 31);
            TopBar.TabIndex = 2;
            TopBar.MouseDown += panel1_MouseDown;
            TopBar.MouseMove += panel1_MouseMove;
            TopBar.MouseUp += panel1_MouseUp;
            // 
            // Minimize
            // 
            Minimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Minimize.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Minimize.FlatAppearance.BorderSize = 0;
            Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 78);
            Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Minimize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Minimize.ForeColor = System.Drawing.Color.White;
            Minimize.Location = new System.Drawing.Point(284, 0);
            Minimize.Name = "Minimize";
            Minimize.Size = new System.Drawing.Size(20, 23);
            Minimize.TabIndex = 4;
            Minimize.Text = "_";
            Minimize.UseVisualStyleBackColor = false;
            Minimize.Click += Minimize_Click;
            Minimize.MouseEnter += FlatButton_MouseEnter;
            Minimize.MouseLeave += FlatButton_MouseLeave;
            // 
            // Close
            // 
            Close.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Close.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 62, 78);
            Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Close.ForeColor = System.Drawing.Color.White;
            Close.Location = new System.Drawing.Point(310, 0);
            Close.Name = "Close";
            Close.Size = new System.Drawing.Size(20, 23);
            Close.TabIndex = 3;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += CloseBtn_Click;
            Close.MouseEnter += FlatButton_MouseEnter;
            Close.MouseLeave += FlatButton_MouseLeave;
            // 
            // synlabel
            // 
            synlabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            synlabel.BackColor = System.Drawing.Color.Transparent;
            synlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            synlabel.ForeColor = System.Drawing.Color.White;
            synlabel.Location = new System.Drawing.Point(51, 0);
            synlabel.Name = "synlabel";
            synlabel.Size = new System.Drawing.Size(227, 31);
            synlabel.TabIndex = 1;
            synlabel.Text = "Synapse X - Options";
            synlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            synlabel.MouseDown += panel1_MouseDown;
            synlabel.MouseMove += panel1_MouseMove;
            synlabel.MouseUp += panel1_MouseUp;
            // 
            // Logo
            // 
            Logo.BackgroundImage = Properties.Resources.syn2_JoE_icon;
            Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Logo.Location = new System.Drawing.Point(4, 4);
            Logo.Name = "Logo";
            Logo.Size = new System.Drawing.Size(23, 23);
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // TabClosingPrompt
            // 
            TabClosingPrompt.AutoSize = true;
            TabClosingPrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TabClosingPrompt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TabClosingPrompt.ForeColor = System.Drawing.Color.White;
            TabClosingPrompt.Location = new System.Drawing.Point(23, 70);
            TabClosingPrompt.Name = "TabClosingPrompt";
            TabClosingPrompt.Size = new System.Drawing.Size(265, 23);
            TabClosingPrompt.TabIndex = 3;
            TabClosingPrompt.Text = "                           Tab Closing Prompt";
            TabClosingPrompt.UseVisualStyleBackColor = true;
            TabClosingPrompt.CheckedChanged += TabClosingPrompt_CheckedChanged;
            // 
            // ClearEditorPrompt
            // 
            ClearEditorPrompt.AutoSize = true;
            ClearEditorPrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ClearEditorPrompt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ClearEditorPrompt.ForeColor = System.Drawing.Color.White;
            ClearEditorPrompt.Location = new System.Drawing.Point(23, 37);
            ClearEditorPrompt.Name = "ClearEditorPrompt";
            ClearEditorPrompt.Size = new System.Drawing.Size(265, 23);
            ClearEditorPrompt.TabIndex = 3;
            ClearEditorPrompt.Text = "                          Clear Editor Prompt";
            ClearEditorPrompt.UseVisualStyleBackColor = true;
            ClearEditorPrompt.CheckedChanged += ClearEditorPrompt_CheckedChanged;
            // 
            // TopMostCheck
            // 
            TopMostCheck.AutoSize = true;
            TopMostCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TopMostCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TopMostCheck.ForeColor = System.Drawing.Color.White;
            TopMostCheck.Location = new System.Drawing.Point(23, 103);
            TopMostCheck.Name = "TopMostCheck";
            TopMostCheck.Size = new System.Drawing.Size(265, 23);
            TopMostCheck.TabIndex = 3;
            TopMostCheck.Text = "                                            Top Most";
            TopMostCheck.UseVisualStyleBackColor = true;
            TopMostCheck.CheckedChanged += TopMost_CheckedChanged;
            // 
            // UnlockFPS
            // 
            UnlockFPS.AutoSize = true;
            UnlockFPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            UnlockFPS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            UnlockFPS.ForeColor = System.Drawing.Color.White;
            UnlockFPS.Location = new System.Drawing.Point(23, 6);
            UnlockFPS.Name = "UnlockFPS";
            UnlockFPS.Size = new System.Drawing.Size(264, 23);
            UnlockFPS.TabIndex = 3;
            UnlockFPS.Text = "                                         Unlock FPS";
            UnlockFPS.UseVisualStyleBackColor = true;
            UnlockFPS.CheckedChanged += UnlockFPS_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "tomorrow_night_eighties", "tomorrow_night", "tomorrow_night_blue", "tomorrow_night_bright", "chrome", "clouds", "crimson_editor", "dawn", "dreamweaver", "eclipse", "github", "iplastic", "katzenmilch", "kuroir", "solarized_light", "sqlserver", "textmate", "tomorrow", "xcode", "ambiance", "chaos", "clouds_midnight", "cobalt", "dracula", "gob", "gruvbox", "idle_fingers", "kr_theme", "merbivore", "merbivore_soft", "mono_industrial", "monokai", "pastel_on_dark", "solarized_dark", "terminal", "twilight" });
            comboBox1.Location = new System.Drawing.Point(17, 246);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(273, 24);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(116, 228);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 15);
            label1.TabIndex = 5;
            label1.Text = "Editor Theme";
            label1.Click += label1_Click;
            // 
            // Reset
            // 
            Reset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Reset.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Reset.FlatAppearance.BorderSize = 0;
            Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(54, 72, 88);
            Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(44, 61, 80);
            Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Reset.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Reset.ForeColor = System.Drawing.Color.White;
            Reset.Location = new System.Drawing.Point(50, 308);
            Reset.Name = "Reset";
            Reset.Size = new System.Drawing.Size(205, 26);
            Reset.TabIndex = 10;
            Reset.Text = "Reset Settings";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            Reset.MouseEnter += FlatButton_MouseEnter;
            Reset.MouseLeave += FlatButton_MouseLeave;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            mainPanel.Controls.Add(Reset);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(comboBox1);
            mainPanel.Controls.Add(UnlockFPS);
            mainPanel.Controls.Add(TopMostCheck);
            mainPanel.Controls.Add(ClearEditorPrompt);
            mainPanel.Controls.Add(TabClosingPrompt);
            mainPanel.Location = new System.Drawing.Point(12, 37);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(306, 348);
            mainPanel.TabIndex = 4;
            // 
            // Options
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            ClientSize = new System.Drawing.Size(330, 397);
            Controls.Add(mainPanel);
            Controls.Add(TopBar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Options";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label synlabel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.CheckBox TabClosingPrompt;
        private System.Windows.Forms.CheckBox ClearEditorPrompt;
        private System.Windows.Forms.CheckBox TopMostCheck;
        private System.Windows.Forms.CheckBox UnlockFPS;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Panel mainPanel;
    }
}