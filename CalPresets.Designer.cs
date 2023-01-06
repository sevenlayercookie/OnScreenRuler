namespace OnScreenCalipers
{
    partial class CalPresets
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
            this.presetList = new System.Windows.Forms.ListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PPMSBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PPMVBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SelectedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeletePresetBtn = new System.Windows.Forms.Button();
            this.restoreDefaultsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // presetList
            // 
            this.presetList.FormattingEnabled = true;
            this.presetList.ItemHeight = 16;
            this.presetList.Location = new System.Drawing.Point(21, 22);
            this.presetList.Name = "presetList";
            this.presetList.Size = new System.Drawing.Size(202, 292);
            this.presetList.TabIndex = 4;
            this.presetList.SelectedIndexChanged += new System.EventHandler(this.presetList_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.Location = new System.Drawing.Point(368, 125);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(103, 26);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save Preset";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PPMSBox
            // 
            this.PPMSBox.Location = new System.Drawing.Point(368, 53);
            this.PPMSBox.Name = "PPMSBox";
            this.PPMSBox.Size = new System.Drawing.Size(66, 22);
            this.PPMSBox.TabIndex = 1;
            this.PPMSBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "X-axis (pixels per ms)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y-axis (pixels per mV)";
            // 
            // PPMVBox
            // 
            this.PPMVBox.Location = new System.Drawing.Point(368, 87);
            this.PPMVBox.Name = "PPMVBox";
            this.PPMVBox.Size = new System.Drawing.Size(66, 22);
            this.PPMVBox.TabIndex = 2;
            this.PPMVBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(368, 19);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(156, 22);
            this.nameBox.TabIndex = 0;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_TextChanged);
            // 
            // LoadButton
            // 
            this.LoadButton.AutoSize = true;
            this.LoadButton.Location = new System.Drawing.Point(21, 320);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(97, 26);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load Preset";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SelectedBox
            // 
            this.SelectedBox.Location = new System.Drawing.Point(299, 371);
            this.SelectedBox.Name = "SelectedBox";
            this.SelectedBox.ReadOnly = true;
            this.SelectedBox.Size = new System.Drawing.Size(202, 22);
            this.SelectedBox.TabIndex = 12;
            this.SelectedBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Loaded Preset:";
            // 
            // DeletePresetBtn
            // 
            this.DeletePresetBtn.AutoSize = true;
            this.DeletePresetBtn.Location = new System.Drawing.Point(124, 320);
            this.DeletePresetBtn.Name = "DeletePresetBtn";
            this.DeletePresetBtn.Size = new System.Drawing.Size(99, 26);
            this.DeletePresetBtn.TabIndex = 6;
            this.DeletePresetBtn.Text = "Delete Preset";
            this.DeletePresetBtn.UseVisualStyleBackColor = true;
            this.DeletePresetBtn.Click += new System.EventHandler(this.DeletePresetBtn_Click);
            // 
            // restoreDefaultsBtn
            // 
            this.restoreDefaultsBtn.AutoSize = true;
            this.restoreDefaultsBtn.Location = new System.Drawing.Point(21, 349);
            this.restoreDefaultsBtn.Name = "restoreDefaultsBtn";
            this.restoreDefaultsBtn.Size = new System.Drawing.Size(122, 26);
            this.restoreDefaultsBtn.TabIndex = 7;
            this.restoreDefaultsBtn.Text = "Restore Defaults";
            this.restoreDefaultsBtn.UseVisualStyleBackColor = true;
            this.restoreDefaultsBtn.Click += new System.EventHandler(this.restoreDefaultsBtn_Click);
            // 
            // CalPresets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 408);
            this.Controls.Add(this.restoreDefaultsBtn);
            this.Controls.Add(this.DeletePresetBtn);
            this.Controls.Add(this.SelectedBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PPMVBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PPMSBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.presetList);
            this.Name = "CalPresets";
            this.Text = "Calibration Presets";
            this.Load += new System.EventHandler(this.CalPresets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox presetList;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox PPMSBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PPMVBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox SelectedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeletePresetBtn;
        private System.Windows.Forms.Button restoreDefaultsBtn;
    }
}