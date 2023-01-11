using OnScreenCalipers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public CaliperAppearance(RulerForm rulerForm)
        {
            InitializeComponent();

        }

        private void CaliperFontBtn_Click(object sender, EventArgs e)
        {
            fontDialog1.Apply += new System.EventHandler(fontDialog1_Apply);
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rulerForm.ruler.Font = DialogSelectedFont = fontDialog1.Font;
                rulerForm.ruler.FontColor = DialogSelectedFontColor = fontDialog1.Color;
                rulerForm.Invalidate();
                
            }
        }

        private void fontDialog1_Apply (object sender, System.EventArgs e)
        {
            rulerForm.ruler.Font = DialogSelectedFont = fontDialog1.Font;
            rulerForm.ruler.FontColor = DialogSelectedFontColor = fontDialog1.Color;
            rulerForm.Invalidate();
        }

        private void CaliperColorBtn_Click(object sender, EventArgs e)
        {
            if (LineColorDialog.ShowDialog() == DialogResult.OK)
            {
                DialogSelectedLineColor = LineColorDialog.Color;
                rulerForm.ruler.Color = LineColorBox.BackColor = DialogSelectedLineColor;
                rulerForm.ruler.UpdateRuler();
                rulerForm.Invalidate();
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
        RulerForm rulerForm;
        private void CaliperAppearance_Load(object sender, EventArgs e)
        {
            // find reference to RulerForm
            rulerForm = (RulerForm)this.Owner;
            // load initial values
            caliperLineWidth.Value = DialogCaliperLineWidthNewValue;
            TickMarksCheckBox.Checked = DialogTickMarksEnabled;
            LabelBackColorBox.BackColor = DialogSelectedLabelBackColor;
            fontDialog1.Font = DialogSelectedFont;
            fontDialog1.Color = DialogSelectedFontColor;
            LabelBackColorDialog.Color = DialogSelectedLabelBackColor;
            BackgroundEnabled.Checked = !LabelBackTransparent;
            
            LineColorBox.BackColor = DialogSelectedLineColor;
            // border values
            BorderCheckBox.Checked = rulerForm.border.Enabled;
            BorderColorBox.BackColor = BorderColorDialog.Color = rulerForm.border.Color;
            BorderWidthBox.Value = rulerForm.border.Width;

            enableTopMost(DialogTopmost);
            



        }

        public bool enableTopMost(bool boolean)
        {
           return this.TopMost = TopmostBox.Checked = DialogTopmost = boolean;
        }

        private void LabelBackColorBox_Click(object sender, EventArgs e)
        {
            if (LabelBackColorDialog.ShowDialog() == DialogResult.OK)
            {
                rulerForm.ruler.LabelBackColor = LabelBackColorBox.BackColor = DialogSelectedLabelBackColor = LabelBackColorDialog.Color;
                rulerForm.Invalidate();
            }
        }

        private void BackgroundEnabled_CheckedChanged(object sender, EventArgs e)
        {
            LabelBackColorBox.Enabled = BackgroundEnabled.Checked;
            rulerForm.ruler.LabelBackTransparent = LabelBackTransparent = !BackgroundEnabled.Checked;
            rulerForm.Invalidate();
        }

        private void TickMarksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            rulerForm.ruler.EnableTicks = DialogTickMarksEnabled = TickMarksCheckBox.Checked;
            rulerForm.Invalidate();
          
        }

        private void TopmostBox_CheckedChanged(object sender, EventArgs e)
        {
            rulerForm.TopMostCheckBox.Checked = enableTopMost(((CheckBox)sender).Checked); //enable the main form checkbox, but the TopMost change will be handled when dialog closes
            this.Focus();
            rulerForm.Invalidate();
        }

        private void caliperLineWidth_ValueChanged(object sender, EventArgs e)
        {
            rulerForm.ruler.lineWidth = DialogCaliperLineWidthNewValue = (int)caliperLineWidth.Value;
            rulerForm.ruler.UpdateRuler();
            rulerForm.Invalidate();
        }

        private void BorderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            rulerForm.border.EnableBorder(((CheckBox)sender).Checked);
            BorderCheckBox.Checked = ((CheckBox)sender).Checked;
            rulerForm.Invalidate();
        }

        private void BorderWidthBox_ValueChanged(object sender, EventArgs e)
        {
            rulerForm.border.Width = (int)BorderWidthBox.Value;
            if (rulerForm.border.Enabled)
            { rulerForm.Invalidate(); }
        }

        private void BorderColorBtn_Click(object sender, EventArgs e)
        {
            if (BorderColorDialog.ShowDialog() == DialogResult.OK)
            {
                rulerForm.border.Color = BorderColorBox.BackColor = BorderColorDialog.Color;
                rulerForm.Invalidate();
            }
        }
    }
}
