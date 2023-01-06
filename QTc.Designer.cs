namespace On_Screen_Calipers
{
    partial class QTc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QTc));
            this.QTcBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MayoRadio = new System.Windows.Forms.RadioButton();
            this.RautaharjuRadio = new System.Windows.Forms.RadioButton();
            this.HodgesRadio = new System.Windows.Forms.RadioButton();
            this.FraminghamRadio = new System.Windows.Forms.RadioButton();
            this.FridericiaRadio = new System.Windows.Forms.RadioButton();
            this.BazettRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HRBox = new System.Windows.Forms.TextBox();
            this.QTBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QTcBox
            // 
            this.QTcBox.Location = new System.Drawing.Point(125, 87);
            this.QTcBox.Name = "QTcBox";
            this.QTcBox.ReadOnly = true;
            this.QTcBox.Size = new System.Drawing.Size(64, 22);
            this.QTcBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "QT (uncorrected)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Heart rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "QTc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MayoRadio);
            this.groupBox1.Controls.Add(this.RautaharjuRadio);
            this.groupBox1.Controls.Add(this.HodgesRadio);
            this.groupBox1.Controls.Add(this.FraminghamRadio);
            this.groupBox1.Controls.Add(this.FridericiaRadio);
            this.groupBox1.Controls.Add(this.BazettRadio);
            this.groupBox1.Location = new System.Drawing.Point(255, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 228);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulas:";
            // 
            // MayoRadio
            // 
            this.MayoRadio.AutoSize = true;
            this.MayoRadio.Location = new System.Drawing.Point(11, 179);
            this.MayoRadio.Name = "MayoRadio";
            this.MayoRadio.Size = new System.Drawing.Size(62, 20);
            this.MayoRadio.TabIndex = 5;
            this.MayoRadio.Text = "Mayo";
            this.MayoRadio.UseVisualStyleBackColor = true;
            this.MayoRadio.CheckedChanged += new System.EventHandler(this.FormulaRadio_CheckedChanged);
            // 
            // RautaharjuRadio
            // 
            this.RautaharjuRadio.AutoSize = true;
            this.RautaharjuRadio.Location = new System.Drawing.Point(11, 149);
            this.RautaharjuRadio.Name = "RautaharjuRadio";
            this.RautaharjuRadio.Size = new System.Drawing.Size(93, 20);
            this.RautaharjuRadio.TabIndex = 4;
            this.RautaharjuRadio.Text = "Rautaharju";
            this.RautaharjuRadio.UseVisualStyleBackColor = true;
            this.RautaharjuRadio.CheckedChanged += new System.EventHandler(this.FormulaRadio_CheckedChanged);
            // 
            // HodgesRadio
            // 
            this.HodgesRadio.AutoSize = true;
            this.HodgesRadio.Location = new System.Drawing.Point(11, 119);
            this.HodgesRadio.Name = "HodgesRadio";
            this.HodgesRadio.Size = new System.Drawing.Size(77, 20);
            this.HodgesRadio.TabIndex = 3;
            this.HodgesRadio.Text = "Hodges";
            this.HodgesRadio.UseVisualStyleBackColor = true;
            this.HodgesRadio.CheckedChanged += new System.EventHandler(this.FormulaRadio_CheckedChanged);
            // 
            // FraminghamRadio
            // 
            this.FraminghamRadio.AutoSize = true;
            this.FraminghamRadio.Location = new System.Drawing.Point(11, 89);
            this.FraminghamRadio.Name = "FraminghamRadio";
            this.FraminghamRadio.Size = new System.Drawing.Size(103, 20);
            this.FraminghamRadio.TabIndex = 2;
            this.FraminghamRadio.Text = "Framingham";
            this.FraminghamRadio.UseVisualStyleBackColor = true;
            this.FraminghamRadio.CheckedChanged += new System.EventHandler(this.FormulaRadio_CheckedChanged);
            // 
            // FridericiaRadio
            // 
            this.FridericiaRadio.AutoSize = true;
            this.FridericiaRadio.Location = new System.Drawing.Point(11, 59);
            this.FridericiaRadio.Name = "FridericiaRadio";
            this.FridericiaRadio.Size = new System.Drawing.Size(84, 20);
            this.FridericiaRadio.TabIndex = 1;
            this.FridericiaRadio.Text = "Fridericia";
            this.FridericiaRadio.UseVisualStyleBackColor = true;
            this.FridericiaRadio.CheckedChanged += new System.EventHandler(this.FormulaRadio_CheckedChanged);
            // 
            // BazettRadio
            // 
            this.BazettRadio.AutoSize = true;
            this.BazettRadio.Checked = true;
            this.BazettRadio.Location = new System.Drawing.Point(11, 29);
            this.BazettRadio.Name = "BazettRadio";
            this.BazettRadio.Size = new System.Drawing.Size(65, 20);
            this.BazettRadio.TabIndex = 0;
            this.BazettRadio.TabStop = true;
            this.BazettRadio.Text = "Bazett";
            this.BazettRadio.UseVisualStyleBackColor = true;
            this.BazettRadio.CheckedChanged += new System.EventHandler(this.FormulaRadio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "bpm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "ms";
            // 
            // HRBox
            // 
            this.HRBox.Location = new System.Drawing.Point(125, 40);
            this.HRBox.Name = "HRBox";
            this.HRBox.Size = new System.Drawing.Size(64, 22);
            this.HRBox.TabIndex = 1;
            this.HRBox.TextChanged += new System.EventHandler(this.HRBox_TextChanged);
            // 
            // QTBox
            // 
            this.QTBox.Location = new System.Drawing.Point(125, 11);
            this.QTBox.Name = "QTBox";
            this.QTBox.Size = new System.Drawing.Size(64, 22);
            this.QTBox.TabIndex = 0;
            this.QTBox.TextChanged += new System.EventHandler(this.QTBox_TextChanged);
            // 
            // QTc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 264);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QTcBox);
            this.Controls.Add(this.HRBox);
            this.Controls.Add(this.QTBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QTc";
            this.Text = "QTc";
            this.Load += new System.EventHandler(this.QTc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox QTcBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MayoRadio;
        private System.Windows.Forms.RadioButton RautaharjuRadio;
        private System.Windows.Forms.RadioButton HodgesRadio;
        private System.Windows.Forms.RadioButton FraminghamRadio;
        private System.Windows.Forms.RadioButton FridericiaRadio;
        private System.Windows.Forms.RadioButton BazettRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HRBox;
        private System.Windows.Forms.TextBox QTBox;
    }
}