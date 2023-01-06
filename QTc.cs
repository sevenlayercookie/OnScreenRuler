using OnScreenRuler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace On_Screen_Calipers
{
    public partial class QTc : Form
    {
        public double DialogQT = 0;
        public bool DialogTopmost = false;
        public QTc()
        {
            InitializeComponent();
        }

        private void QTBox_TextChanged(object sender, EventArgs e)
        {
            if (IsInt(QTBox))
            {
                CalculateQTC();
            }
        }

        private void HRBox_TextChanged(object sender, EventArgs e)
        {
            if (IsInt(HRBox))
            {
                CalculateQTC();
            }
        }

        public RadioButton SelectedFormula;
        private void CalculateQTC()
        {
            if (HRBox.Text != "" && HRBox.Text != "")
            {
                double QT = float.Parse(QTBox.Text) / 1000; // in seconds
                double HR = float.Parse(HRBox.Text); // in bpm
                double RR = (1 / (HR / 60)); // in seconds
                double QTc = 0;
                if (SelectedFormula == null) { SelectedFormula = BazettRadio; }
                
                switch (SelectedFormula.Text)
                {
                    case "Bazett":
                        // Bazett formula, QTc = QT / √RR
                        QTc = (QT / Math.Sqrt(RR));
                        break;
                    case "Fridericia":
                        // Fridericia, QTc = QT / RR^(1/3)
                        QTc = QT/Math.Pow(RR, 0.3333333333333333333333);
                        break;
                    case "Framingham":
                        // QTc = QT + 0.154 * (1 - RR)
                        QTc = QT + 0.154 * (1 - RR);
                        break;
                    case "Hodges":
                        // QTc = QT + 0.00175 * (HR - 60)
                        QTc = QT + 0.00175 * (HR - 60);
                        break;
                    case "Rautaharju":
                        // QTc = QT * (120 + HR) / 180
                        QTc = QT * (120 + HR) / 180;
                        break;

                }
                QTc = QTc * 1000;  // convert back to milliseconds
                QTcBox.Text = ((int)Math.Round(QTc)).ToString();


            }
        }

        private bool IsInt(System.Windows.Forms.TextBox e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                e.Text = e.Text.Remove(e.Text.Length - 1);
                return false;
            }
            return true;
        }

        private void FormulaRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton senderButton = (RadioButton)sender;
            if (senderButton.Checked)
            {
                SelectedFormula = senderButton;
            }
            CalculateQTC();
        }

        private void QTc_Load(object sender, EventArgs e)
        {
            QTBox.Text = DialogQT.ToString("N0");
            this.TopMost = DialogTopmost;
        }
    }
}
