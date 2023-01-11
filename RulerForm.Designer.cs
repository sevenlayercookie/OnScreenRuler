namespace OnScreenCalipers
{
    partial class RulerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulerForm));
            this.UnitsBox = new System.Windows.Forms.ComboBox();
            this.CalibrateTextBox = new System.Windows.Forms.TextBox();
            this.CalibrateBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transparentModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caliperAppearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qTcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TransparencyCheckBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.presetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TopMostCheckBox = new System.Windows.Forms.CheckBox();
            this.TopMostBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnitsBox
            // 
            this.UnitsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitsBox.FormattingEnabled = true;
            this.UnitsBox.Items.AddRange(new object[] {
            "pixels",
            "milliseconds",
            "seconds",
            "bpm"});
            this.UnitsBox.Location = new System.Drawing.Point(60, 8);
            this.UnitsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UnitsBox.Name = "UnitsBox";
            this.UnitsBox.Size = new System.Drawing.Size(104, 24);
            this.UnitsBox.TabIndex = 0;
            this.UnitsBox.SelectedIndexChanged += new System.EventHandler(this.UnitsBox_SelectedIndexChanged);
            // 
            // CalibrateTextBox
            // 
            this.CalibrateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalibrateTextBox.BackColor = System.Drawing.Color.White;
            this.CalibrateTextBox.Location = new System.Drawing.Point(15, 8);
            this.CalibrateTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalibrateTextBox.Name = "CalibrateTextBox";
            this.CalibrateTextBox.Size = new System.Drawing.Size(44, 22);
            this.CalibrateTextBox.TabIndex = 1;
            this.CalibrateTextBox.Text = "1000";
            this.CalibrateTextBox.TextChanged += new System.EventHandler(this.CalibrateTextBox_change);
            this.CalibrateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalibrateTextBox_KeyPress);
            // 
            // CalibrateBtn
            // 
            this.CalibrateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalibrateBtn.AutoSize = true;
            this.CalibrateBtn.BackColor = System.Drawing.Color.White;
            this.CalibrateBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.CalibrateBtn.Location = new System.Drawing.Point(60, 32);
            this.CalibrateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalibrateBtn.Name = "CalibrateBtn";
            this.CalibrateBtn.Size = new System.Drawing.Size(102, 26);
            this.CalibrateBtn.TabIndex = 2;
            this.CalibrateBtn.Text = "Calibrate";
            this.CalibrateBtn.UseVisualStyleBackColor = false;
            this.CalibrateBtn.Click += new System.EventHandler(this.CalibrateBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.calibrateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(629, 26);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.closeImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // closeImageToolStripMenuItem
            // 
            this.closeImageToolStripMenuItem.Name = "closeImageToolStripMenuItem";
            this.closeImageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeImageToolStripMenuItem.Text = "Close Image";
            this.closeImageToolStripMenuItem.Click += new System.EventHandler(this.closeImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.screenshotToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // screenshotToolStripMenuItem
            // 
            this.screenshotToolStripMenuItem.Name = "screenshotToolStripMenuItem";
            this.screenshotToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.screenshotToolStripMenuItem.Text = "Capture";
            this.screenshotToolStripMenuItem.Click += new System.EventHandler(this.screenshotToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transparentModeToolStripMenuItem,
            this.caliperAppearanceToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // transparentModeToolStripMenuItem
            // 
            this.transparentModeToolStripMenuItem.Checked = true;
            this.transparentModeToolStripMenuItem.CheckOnClick = true;
            this.transparentModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.transparentModeToolStripMenuItem.Name = "transparentModeToolStripMenuItem";
            this.transparentModeToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.transparentModeToolStripMenuItem.Text = "Transparent Mode";
            this.transparentModeToolStripMenuItem.Click += new System.EventHandler(this.transparentModeToolStripMenuItem_Click);
            // 
            // caliperAppearanceToolStripMenuItem
            // 
            this.caliperAppearanceToolStripMenuItem.Name = "caliperAppearanceToolStripMenuItem";
            this.caliperAppearanceToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.caliperAppearanceToolStripMenuItem.Text = "Caliper Appearance";
            this.caliperAppearanceToolStripMenuItem.Click += new System.EventHandler(this.caliperAppearanceToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qTcToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.calculateToolStripMenuItem.Text = "Calculate";
            // 
            // qTcToolStripMenuItem
            // 
            this.qTcToolStripMenuItem.Name = "qTcToolStripMenuItem";
            this.qTcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.qTcToolStripMenuItem.Text = "QTc";
            this.qTcToolStripMenuItem.Click += new System.EventHandler(this.qTcToolStripMenuItem_Click);
            // 
            // calibrateToolStripMenuItem
            // 
            this.calibrateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calibrateToolStripMenuItem1,
            this.presetsToolStripMenuItem});
            this.calibrateToolStripMenuItem.Name = "calibrateToolStripMenuItem";
            this.calibrateToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.calibrateToolStripMenuItem.Text = "Calibrate";
            // 
            // calibrateToolStripMenuItem1
            // 
            this.calibrateToolStripMenuItem1.Name = "calibrateToolStripMenuItem1";
            this.calibrateToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.calibrateToolStripMenuItem1.Text = "Calibrate";
            this.calibrateToolStripMenuItem1.Click += new System.EventHandler(this.CalibrateBtn_Click);
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.presetsToolStripMenuItem.Text = "Presets...";
            this.presetsToolStripMenuItem.Click += new System.EventHandler(this.presetsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // TransparencyCheckBox2
            // 
            this.TransparencyCheckBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransparencyCheckBox2.AutoSize = true;
            this.TransparencyCheckBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TransparencyCheckBox2.Checked = true;
            this.TransparencyCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TransparencyCheckBox2.Location = new System.Drawing.Point(49, 77);
            this.TransparencyCheckBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransparencyCheckBox2.Name = "TransparencyCheckBox2";
            this.TransparencyCheckBox2.Size = new System.Drawing.Size(113, 20);
            this.TransparencyCheckBox2.TabIndex = 5;
            this.TransparencyCheckBox2.Text = "Transparency";
            this.TransparencyCheckBox2.UseVisualStyleBackColor = false;
            this.TransparencyCheckBox2.CheckedChanged += new System.EventHandler(this.TransparencyCheckBox2_CheckedChanged);
            this.TransparencyCheckBox2.Click += new System.EventHandler(this.transparentModeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.presetLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TopMostCheckBox);
            this.panel1.Controls.Add(this.CalibrateBtn);
            this.panel1.Controls.Add(this.TransparencyCheckBox2);
            this.panel1.Controls.Add(this.UnitsBox);
            this.panel1.Controls.Add(this.CalibrateTextBox);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(418, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 125);
            this.panel1.TabIndex = 6;
            // 
            // presetLabel
            // 
            this.presetLabel.AutoSize = true;
            this.presetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetLabel.Location = new System.Drawing.Point(60, 60);
            this.presetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.presetLabel.Name = "presetLabel";
            this.presetLabel.Size = new System.Drawing.Size(0, 25);
            this.presetLabel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Preset:";
            // 
            // TopMostCheckBox
            // 
            this.TopMostCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMostCheckBox.AutoSize = true;
            this.TopMostCheckBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TopMostCheckBox.Location = new System.Drawing.Point(49, 97);
            this.TopMostCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopMostCheckBox.Name = "TopMostCheckBox";
            this.TopMostCheckBox.Size = new System.Drawing.Size(112, 20);
            this.TopMostCheckBox.TabIndex = 6;
            this.TopMostCheckBox.Text = "Always on top";
            this.TopMostCheckBox.UseVisualStyleBackColor = false;
            this.TopMostCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TopMostBox
            // 
            this.TopMostBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMostBox.AutoSize = true;
            this.TopMostBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TopMostBox.Location = new System.Drawing.Point(118, 188);
            this.TopMostBox.Name = "TopMostBox";
            this.TopMostBox.Size = new System.Drawing.Size(205, 35);
            this.TopMostBox.TabIndex = 6;
            this.TopMostBox.Text = "Always on top";
            this.TopMostBox.UseVisualStyleBackColor = false;
            this.TopMostBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RulerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 299);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RulerForm";
            this.Text = "On Screen Calipers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RulerForm_FormClosing);
            this.Load += new System.EventHandler(this.RulerForm_Load);
            this.DpiChanged += new System.Windows.Forms.DpiChangedEventHandler(this.RulerForm_DpiChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.RulerForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.RulerForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RulerForm_KeyDown);
            this.Resize += new System.EventHandler(this.RulerForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UnitsBox;
        private System.Windows.Forms.TextBox CalibrateTextBox;
        private System.Windows.Forms.Button CalibrateBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenshotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transparentModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibrateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibrateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem caliperAppearanceToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox TransparencyCheckBox2;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qTcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label presetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox TopMostBox;
        public System.Windows.Forms.CheckBox TopMostCheckBox;
    }
}

