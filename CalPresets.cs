using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace On_Screen_Calipers
{
    public partial class CalPresets : Form
    {
        public CalPresets()
        {
            InitializeComponent();
        }

        public class Preset
        {
            public string Name;
            public double PPMS;
            public double PPMV;

            public Preset(string name, double ppms, double ppmv)
            {
                Name = name;
                PPMS = ppms;
                PPMV = ppmv;
            }
        }

        public Preset[] PresetArray =
        {
            new Preset("Mayo 12-Lead",0.143,0.1),
            new Preset("Mayo Telemetry",0.1181,0.1),
            new Preset("Mayo Patient Strips",0.100,0.1)
        };

        public double PresetPPMS = 0.100;
        public double PresetPPMV = 0.100;
        
        private void presetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (presetList.SelectedItems.Count == 1)
            {
                nameBox.Text = PresetArray[presetList.SelectedIndex].Name;
                PPMSBox.Text = PresetArray[presetList.SelectedIndex].PPMS.ToString("N3");
                PPMVBox.Text = PresetArray[presetList.SelectedIndex].PPMV.ToString("N3");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (presetList.SelectedItems.Count == 1)
            {
                SelectedBox.Text = PresetArray[presetList.SelectedIndex].Name;
                PresetPPMS = PresetArray[presetList.SelectedIndex].PPMS;
                PresetPPMV = PresetArray[presetList.SelectedIndex].PPMV;
                DialogResult = DialogResult.OK;
            }
        }

        private void CalPresets_Load(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < PresetArray.Length; i++)
            {
                presetList.Items.Add(PresetArray[i].Name);
            }
            */
            RefreshPresestList();
        }

        private void RefreshPresestList()
        {
            presetList.Items.Clear();
            for (int i = 0; i < PresetArray.Length; i++)
            {
                presetList.Items.Add(PresetArray[i].Name);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (nameBox.TextLength != 0 && PPMSBox.TextLength != 0 && PPMVBox.TextLength != 0)
            {
                PresetArray.Append(new Preset(nameBox.Text,double.Parse(PPMSBox.Text),double.Parse(PPMVBox.Text)));
                RefreshPresestList();
            }
        }


    }
}
