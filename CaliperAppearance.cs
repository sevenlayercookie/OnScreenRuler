using OnScreenCalipers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnScreenCalipers
{

    public partial class CaliperAppearance : Form
    {
        public int DialogCaliperLineWidthNewValue { get; set; }
        public bool DialogTickMarksEnabled { get; set; }
        public Color DialogSelectedLineColor { get; set; }
        public Font DialogSelectedFont { get; set; }
        public Color DialogSelectedFontColor { get; set; }
        public Color DialogSelectedLabelBackColor { get; set; }
        public bool LabelBackTransparent { get; set; }
        public bool DialogLineColorBox { get; set; }
        public bool DialogTopmost { get; set; }
        public CaliperAppearance()
        {
            InitializeComponent();

        }

        private void CaliperFontBtn_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                DialogSelectedFont = fontDialog1.Font;
                DialogSelectedFontColor = fontDialog1.Color;
            }
        }

        private void CaliperColorBtn_Click(object sender, EventArgs e)
        {
            if (LineColorDialog.ShowDialog() == DialogResult.OK)
            {
                DialogSelectedLineColor = LineColorDialog.Color;
                LineColorBox.BackColor = DialogSelectedLineColor;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;
            caliperLineWidth.Value = DialogCaliperLineWidthNewValue;
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            DialogCaliperLineWidthNewValue = (int)caliperLineWidth.Value;
            DialogTickMarksEnabled = TickMarksCheckBox.Checked;
            DialogSelectedLabelBackColor = LabelBackColorBox.BackColor;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CaliperAppearance_Load(object sender, EventArgs e)
        {
            // load initial values
            caliperLineWidth.Value = DialogCaliperLineWidthNewValue;
            TickMarksCheckBox.Checked = DialogTickMarksEnabled;
            LabelBackColorBox.BackColor = DialogSelectedLabelBackColor;
            fontDialog1.Font = DialogSelectedFont;
            fontDialog1.Color = DialogSelectedFontColor;
            LabelBackColorDialog.Color = DialogSelectedLabelBackColor;
            BackgroundEnabled.Checked = !LabelBackTransparent;

            LineColorBox.BackColor = DialogSelectedLineColor;
            this.TopMost = DialogTopmost;



        }

        private void LabelBackColorBox_Click(object sender, EventArgs e)
        {
            if (LabelBackColorDialog.ShowDialog() == DialogResult.OK)
            {
                LabelBackColorBox.BackColor = DialogSelectedLabelBackColor = LabelBackColorDialog.Color;
            }
        }

        private void BackgroundEnabled_CheckedChanged(object sender, EventArgs e)
        {
            LabelBackColorBox.Enabled = BackgroundEnabled.Checked;
            LabelBackTransparent = !BackgroundEnabled.Checked;
            
        }

        private void TickMarksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TickMarksCheckBox.Checked)
            {
                DialogTickMarksEnabled = true;
            }
            else
            {
                DialogTickMarksEnabled = false;
                
            }
        }

        private void TopmostBox_CheckedChanged(object sender, EventArgs e)
        {
            DialogTopmost = ((CheckBox)sender).Checked;
        }
    }
}
