namespace OnScreenCalipers
{
    partial class CaliperAppearance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaliperAppearance));
            this.LineColorDialog = new System.Windows.Forms.ColorDialog();
            this.CaliperFontBtn = new System.Windows.Forms.Button();
            this.CaliperColorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.caliperLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TickMarksCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelBackColorBox = new System.Windows.Forms.PictureBox();
            this.BackgroundEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LineColorBox = new System.Windows.Forms.PictureBox();
            this.LabelBackColorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TopmostBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BorderColorBox = new System.Windows.Forms.PictureBox();
            this.BorderColorBtn = new System.Windows.Forms.Button();
            this.BorderCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BorderWidthBox = new System.Windows.Forms.NumericUpDown();
            this.BorderColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.caliperLineWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelBackColorBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineColorBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorderColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderWidthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LineColorDialog
            // 
            this.LineColorDialog.Color = System.Drawing.Color.Lime;
            // 
            // CaliperFontBtn
            // 
            this.CaliperFontBtn.Location = new System.Drawing.Point(45, 21);
            this.CaliperFontBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CaliperFontBtn.Name = "CaliperFontBtn";
            this.CaliperFontBtn.Size = new System.Drawing.Size(149, 38);
            this.CaliperFontBtn.TabIndex = 0;
            this.CaliperFontBtn.Text = "Font";
            this.CaliperFontBtn.UseVisualStyleBackColor = true;
            this.CaliperFontBtn.Click += new System.EventHandler(this.CaliperFontBtn_Click);
            // 
            // CaliperColorBtn
            // 
            this.CaliperColorBtn.Location = new System.Drawing.Point(43, 21);
            this.CaliperColorBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CaliperColorBtn.Name = "CaliperColorBtn";
            this.CaliperColorBtn.Size = new System.Drawing.Size(149, 38);
            this.CaliperColorBtn.TabIndex = 1;
            this.CaliperColorBtn.Text = "Line Color";
            this.CaliperColorBtn.UseVisualStyleBackColor = true;
            this.CaliperColorBtn.Click += new System.EventHandler(this.CaliperColorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caliper Line Width:";
            // 
            // caliperLineWidth
            // 
            this.caliperLineWidth.Location = new System.Drawing.Point(151, 68);
            this.caliperLineWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caliperLineWidth.Name = "caliperLineWidth";
            this.caliperLineWidth.Size = new System.Drawing.Size(52, 22);
            this.caliperLineWidth.TabIndex = 3;
            this.caliperLineWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.caliperLineWidth.ValueChanged += new System.EventHandler(this.caliperLineWidth_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "px";
            // 
            // TickMarksCheckBox
            // 
            this.TickMarksCheckBox.AutoSize = true;
            this.TickMarksCheckBox.Checked = true;
            this.TickMarksCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TickMarksCheckBox.Location = new System.Drawing.Point(77, 103);
            this.TickMarksCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TickMarksCheckBox.Name = "TickMarksCheckBox";
            this.TickMarksCheckBox.Size = new System.Drawing.Size(95, 20);
            this.TickMarksCheckBox.TabIndex = 5;
            this.TickMarksCheckBox.Text = "Tick Marks";
            this.TickMarksCheckBox.UseVisualStyleBackColor = true;
            this.TickMarksCheckBox.CheckedChanged += new System.EventHandler(this.TickMarksCheckBox_CheckedChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(155, 300);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(95, 34);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Location = new System.Drawing.Point(53, 300);
            this.OKBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(95, 34);
            this.OKBtn.TabIndex = 7;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowApply = true;
            this.fontDialog1.ShowColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelBackColorBox);
            this.groupBox1.Controls.Add(this.BackgroundEnabled);
            this.groupBox1.Controls.Add(this.CaliperFontBtn);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(255, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caliper Label";
            // 
            // LabelBackColorBox
            // 
            this.LabelBackColorBox.BackColor = System.Drawing.Color.Black;
            this.LabelBackColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelBackColorBox.Location = new System.Drawing.Point(189, 78);
            this.LabelBackColorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelBackColorBox.Name = "LabelBackColorBox";
            this.LabelBackColorBox.Size = new System.Drawing.Size(20, 20);
            this.LabelBackColorBox.TabIndex = 9;
            this.LabelBackColorBox.TabStop = false;
            this.LabelBackColorBox.Click += new System.EventHandler(this.LabelBackColorBox_Click);
            // 
            // BackgroundEnabled
            // 
            this.BackgroundEnabled.AutoSize = true;
            this.BackgroundEnabled.Checked = true;
            this.BackgroundEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BackgroundEnabled.Location = new System.Drawing.Point(45, 78);
            this.BackgroundEnabled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackgroundEnabled.Name = "BackgroundEnabled";
            this.BackgroundEnabled.Size = new System.Drawing.Size(137, 20);
            this.BackgroundEnabled.TabIndex = 8;
            this.BackgroundEnabled.Text = "Background Color";
            this.BackgroundEnabled.UseVisualStyleBackColor = true;
            this.BackgroundEnabled.CheckedChanged += new System.EventHandler(this.BackgroundEnabled_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LineColorBox);
            this.groupBox2.Controls.Add(this.CaliperColorBtn);
            this.groupBox2.Controls.Add(this.TickMarksCheckBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.caliperLineWidth);
            this.groupBox2.Location = new System.Drawing.Point(28, 144);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(255, 135);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Line Settings";
            // 
            // LineColorBox
            // 
            this.LineColorBox.BackColor = System.Drawing.Color.Black;
            this.LineColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LineColorBox.Location = new System.Drawing.Point(198, 30);
            this.LineColorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineColorBox.Name = "LineColorBox";
            this.LineColorBox.Size = new System.Drawing.Size(20, 20);
            this.LineColorBox.TabIndex = 10;
            this.LineColorBox.TabStop = false;
            this.LineColorBox.Click += new System.EventHandler(this.CaliperColorBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TopmostBox);
            this.groupBox3.Location = new System.Drawing.Point(313, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 114);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Window Priority";
            // 
            // TopmostBox
            // 
            this.TopmostBox.AutoSize = true;
            this.TopmostBox.Location = new System.Drawing.Point(6, 21);
            this.TopmostBox.Name = "TopmostBox";
            this.TopmostBox.Size = new System.Drawing.Size(83, 20);
            this.TopmostBox.TabIndex = 0;
            this.TopmostBox.Text = "Topmost";
            this.TopmostBox.UseVisualStyleBackColor = true;
            this.TopmostBox.CheckedChanged += new System.EventHandler(this.TopmostBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BorderColorBox);
            this.groupBox4.Controls.Add(this.BorderColorBtn);
            this.groupBox4.Controls.Add(this.BorderCheckBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.BorderWidthBox);
            this.groupBox4.Location = new System.Drawing.Point(313, 144);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(255, 135);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Window Border";
            // 
            // BorderColorBox
            // 
            this.BorderColorBox.BackColor = System.Drawing.Color.Yellow;
            this.BorderColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorderColorBox.Location = new System.Drawing.Point(198, 30);
            this.BorderColorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorderColorBox.Name = "BorderColorBox";
            this.BorderColorBox.Size = new System.Drawing.Size(20, 20);
            this.BorderColorBox.TabIndex = 10;
            this.BorderColorBox.TabStop = false;
            this.BorderColorBox.Click += new System.EventHandler(this.BorderColorBtn_Click);
            // 
            // BorderColorBtn
            // 
            this.BorderColorBtn.Location = new System.Drawing.Point(43, 21);
            this.BorderColorBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorderColorBtn.Name = "BorderColorBtn";
            this.BorderColorBtn.Size = new System.Drawing.Size(149, 38);
            this.BorderColorBtn.TabIndex = 1;
            this.BorderColorBtn.Text = "Line Color";
            this.BorderColorBtn.UseVisualStyleBackColor = true;
            this.BorderColorBtn.Click += new System.EventHandler(this.BorderColorBtn_Click);
            // 
            // BorderCheckBox
            // 
            this.BorderCheckBox.AutoSize = true;
            this.BorderCheckBox.Location = new System.Drawing.Point(43, 103);
            this.BorderCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorderCheckBox.Name = "BorderCheckBox";
            this.BorderCheckBox.Size = new System.Drawing.Size(175, 20);
            this.BorderCheckBox.TabIndex = 5;
            this.BorderCheckBox.Text = "Window Border Enabled";
            this.BorderCheckBox.UseVisualStyleBackColor = true;
            this.BorderCheckBox.CheckedChanged += new System.EventHandler(this.BorderCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Border Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "px";
            // 
            // BorderWidthBox
            // 
            this.BorderWidthBox.Location = new System.Drawing.Point(151, 68);
            this.BorderWidthBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BorderWidthBox.Name = "BorderWidthBox";
            this.BorderWidthBox.Size = new System.Drawing.Size(52, 22);
            this.BorderWidthBox.TabIndex = 3;
            this.BorderWidthBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.BorderWidthBox.ValueChanged += new System.EventHandler(this.BorderWidthBox_ValueChanged);
            // 
            // BorderColorDialog
            // 
            this.BorderColorDialog.Color = System.Drawing.Color.Lime;
            // 
            // CaliperAppearance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 367);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaliperAppearance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caliper Appearance";
            this.Load += new System.EventHandler(this.CaliperAppearance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caliperLineWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelBackColorBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineColorBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorderColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderWidthBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog LineColorDialog;
        private System.Windows.Forms.Button CaliperFontBtn;
        private System.Windows.Forms.Button CaliperColorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown caliperLineWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox TickMarksCheckBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox LabelBackColorBox;
        private System.Windows.Forms.CheckBox BackgroundEnabled;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColorDialog LabelBackColorDialog;
        private System.Windows.Forms.PictureBox LineColorBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox TopmostBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox BorderColorBox;
        private System.Windows.Forms.Button BorderColorBtn;
        private System.Windows.Forms.CheckBox BorderCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown BorderWidthBox;
        private System.Windows.Forms.ColorDialog BorderColorDialog;
    }
}