namespace OnScreenRuler
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
            this.UnitsBox = new System.Windows.Forms.ComboBox();
            this.CalibrateTextBox = new System.Windows.Forms.TextBox();
            this.CalibrateBtn = new System.Windows.Forms.Button();
            this.CalibrateUnitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UnitsBox
            // 
            this.UnitsBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.UnitsBox.FormattingEnabled = true;
            this.UnitsBox.Items.AddRange(new object[] {
            "pixels",
            "milliseconds",
            "seconds",
            "bpm"});
            this.UnitsBox.Location = new System.Drawing.Point(991, 0);
            this.UnitsBox.Name = "UnitsBox";
            this.UnitsBox.Size = new System.Drawing.Size(181, 39);
            this.UnitsBox.TabIndex = 0;
            this.UnitsBox.SelectedIndexChanged += new System.EventHandler(this.UnitsBox_SelectedIndexChanged);
            // 
            // CalibrateTextBox
            // 
            this.CalibrateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalibrateTextBox.BackColor = System.Drawing.Color.White;
            this.CalibrateTextBox.Location = new System.Drawing.Point(858, 46);
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
            this.CalibrateBtn.Location = new System.Drawing.Point(1009, 46);
            this.CalibrateBtn.Name = "CalibrateBtn";
            this.CalibrateBtn.Size = new System.Drawing.Size(175, 38);
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
            this.CalibrateUnitLabel.Location = new System.Drawing.Point(948, 50);
            this.CalibrateUnitLabel.Name = "CalibrateUnitLabel";
            this.CalibrateUnitLabel.Size = new System.Drawing.Size(50, 31);
            this.CalibrateUnitLabel.TabIndex = 3;
            this.CalibrateUnitLabel.Text = "ms";
            // 
            // RulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 416);
            this.Controls.Add(this.CalibrateUnitLabel);
            this.Controls.Add(this.CalibrateBtn);
            this.Controls.Add(this.CalibrateTextBox);
            this.Controls.Add(this.UnitsBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RulerForm";
            this.Text = "On Screen Calipers";
            this.Load += new System.EventHandler(this.RulerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UnitsBox;
        private System.Windows.Forms.TextBox CalibrateTextBox;
        private System.Windows.Forms.Button CalibrateBtn;
        private System.Windows.Forms.Label CalibrateUnitLabel;
    }
}

