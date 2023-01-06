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
            this.CalibrateUnitLabel = new System.Windows.Forms.Label();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.UnitsBox.Location = new System.Drawing.Point(120, 16);
            this.UnitsBox.Name = "UnitsBox";
            this.UnitsBox.Size = new System.Drawing.Size(203, 39);
            this.UnitsBox.TabIndex = 0;
            this.UnitsBox.SelectedIndexChanged += new System.EventHandler(this.UnitsBox_SelectedIndexChanged);
            // 
            // CalibrateTextBox
            // 
            this.CalibrateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalibrateTextBox.BackColor = System.Drawing.Color.White;
            this.CalibrateTextBox.Location = new System.Drawing.Point(30, 16);
            this.CalibrateTextBox.Name = "CalibrateTextBox";
            this.CalibrateTextBox.Size = new System.Drawing.Size(84, 38);
            this.CalibrateTextBox.TabIndex = 1;
            this.CalibrateTextBox.Text = "1000";
            this.CalibrateTextBox.TextChanged += new System.EventHandler(this.CalibrateTextBox_change);
            // 
            // CalibrateBtn
            // 
            this.CalibrateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalibrateBtn.BackColor = System.Drawing.Color.White;
            this.CalibrateBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.CalibrateBtn.Location = new System.Drawing.Point(120, 62);
            this.CalibrateBtn.Name = "CalibrateBtn";
            this.CalibrateBtn.Size = new System.Drawing.Size(203, 38);
            this.CalibrateBtn.TabIndex = 2;
            this.CalibrateBtn.Text = "Calibrate";
            this.CalibrateBtn.UseVisualStyleBackColor = false;
            this.CalibrateBtn.Click += new System.EventHandler(this.CalibrateBtn_Click);
            // 
            // CalibrateUnitLabel
            // 
            this.CalibrateUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalibrateUnitLabel.AutoSize = true;
            this.CalibrateUnitLabel.BackColor = System.Drawing.Color.DarkGray;
            this.CalibrateUnitLabel.Location = new System.Drawing.Point(64, 66);
            this.CalibrateUnitLabel.Name = "CalibrateUnitLabel";
            this.CalibrateUnitLabel.Size = new System.Drawing.Size(50, 31);
            this.CalibrateUnitLabel.TabIndex = 3;
            this.CalibrateUnitLabel.Text = "ms";
            this.CalibrateUnitLabel.Visible = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(1201, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.closeImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // closeImageToolStripMenuItem
            // 
            this.closeImageToolStripMenuItem.Name = "closeImageToolStripMenuItem";
            this.closeImageToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.closeImageToolStripMenuItem.Text = "Close Image";
            this.closeImageToolStripMenuItem.Click += new System.EventHandler(this.closeImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.screenshotToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // screenshotToolStripMenuItem
            // 
            this.screenshotToolStripMenuItem.Name = "screenshotToolStripMenuItem";
            this.screenshotToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.screenshotToolStripMenuItem.Text = "Capture";
            this.screenshotToolStripMenuItem.Click += new System.EventHandler(this.screenshotToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transparentModeToolStripMenuItem,
            this.caliperAppearanceToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // transparentModeToolStripMenuItem
            // 
            this.transparentModeToolStripMenuItem.Checked = true;
            this.transparentModeToolStripMenuItem.CheckOnClick = true;
            this.transparentModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.transparentModeToolStripMenuItem.Name = "transparentModeToolStripMenuItem";
            this.transparentModeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transparentModeToolStripMenuItem.Text = "Transparent Mode";
            this.transparentModeToolStripMenuItem.Click += new System.EventHandler(this.transparentModeToolStripMenuItem_Click);
            // 
            // caliperAppearanceToolStripMenuItem
            // 
            this.caliperAppearanceToolStripMenuItem.Name = "caliperAppearanceToolStripMenuItem";
            this.caliperAppearanceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.caliperAppearanceToolStripMenuItem.Text = "Caliper Appearance";
            this.caliperAppearanceToolStripMenuItem.Click += new System.EventHandler(this.caliperAppearanceToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qTcToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
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
            this.calibrateToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.calibrateToolStripMenuItem.Text = "Calibrate";
            // 
            // calibrateToolStripMenuItem1
            // 
            this.calibrateToolStripMenuItem1.Name = "calibrateToolStripMenuItem1";
            this.calibrateToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.calibrateToolStripMenuItem1.Text = "Calibrate";
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.presetsToolStripMenuItem.Text = "Presets...";
            this.presetsToolStripMenuItem.Click += new System.EventHandler(this.presetsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.helpToolStripMenuItem1.Text = "Help";
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
            this.TransparencyCheckBox2.Location = new System.Drawing.Point(120, 107);
            this.TransparencyCheckBox2.Name = "TransparencyCheckBox2";
            this.TransparencyCheckBox2.Size = new System.Drawing.Size(203, 35);
            this.TransparencyCheckBox2.TabIndex = 5;
            this.TransparencyCheckBox2.Text = "Transparency";
            this.TransparencyCheckBox2.UseVisualStyleBackColor = false;
            this.TransparencyCheckBox2.CheckedChanged += new System.EventHandler(this.TransparencyCheckBox2_CheckedChanged);
            this.TransparencyCheckBox2.Click += new System.EventHandler(this.transparentModeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.CalibrateBtn);
            this.panel1.Controls.Add(this.TransparencyCheckBox2);
            this.panel1.Controls.Add(this.UnitsBox);
            this.panel1.Controls.Add(this.CalibrateUnitLabel);
            this.panel1.Controls.Add(this.CalibrateTextBox);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(835, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 186);
            this.panel1.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox1.Location = new System.Drawing.Point(118, 146);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(205, 35);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Always on top";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1201, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RulerForm";
            this.Text = "On Screen Calipers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RulerForm_FormClosing);
            this.Load += new System.EventHandler(this.RulerForm_Load);
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
        private System.Windows.Forms.Label CalibrateUnitLabel;
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
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

