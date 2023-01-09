using OnScreenCalipers.Properties;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static OnScreenCalipers.CalPresets;

namespace OnScreenCalipers
{
    public partial class CalPresets : Form
    {
        public double PPMS { get; set; }
        public double PPMV { get; set; }
        public string LoadedPreset { get; set; }
        

        public CalPresets(RulerForm rulerForm)
        {
            InitializeComponent();
        }
        
        public Preset[] PresetArray =
        {
            new Preset("Mayo 12-Lead",0.143,0.1,true),
            new Preset("Mayo Telemetry",0.1181,0.1,true),
            new Preset("Mayo Patient Strips",0.100,0.1,true)
        };

        public Preset[] HardcodedArray =
{
            new Preset("Mayo 12-Lead",0.143,0.1,true),
            new Preset("Mayo Telemetry",0.1181,0.1,true),
            new Preset("Mayo Patient Strips",0.100,0.1,true)
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
                LoadedPresetBox.Text = PresetArray[presetList.SelectedIndex].Name;
                LoadedPreset = PresetArray[presetList.SelectedIndex].Name;
                PresetPPMS = PresetArray[presetList.SelectedIndex].PPMS;
                PresetPPMV = PresetArray[presetList.SelectedIndex].PPMV;
                RulerForm rulerForm = (RulerForm)this.Owner;
                rulerForm.ruler.PPMS= PresetPPMS;
                rulerForm.ruler.UpdateRuler();
                rulerForm.UpdateCalibrateBox();
                rulerForm.Invalidate();
                //DialogResult = DialogResult.OK;
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
            this.TopMost= true;
            //if (CheckPresetMatches())
            if (LoadedPreset != null)
            {
                LoadedPresetBox.Text = LoadedPreset;
            }
            PPMSBox.Text = PPMS.ToString("N3");
            PPMVBox.Text = PPMV.ToString("N3");
            RefreshPresetList();
            LoadPresets();
        }

        public bool CheckPresetMatches()
        {
            if (PPMS == PresetPPMS)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void RefreshPresetList()
        {
            presetList.Items.Clear();
            for (int i = 0; i < PresetArray.Length; i++)
            {
                presetList.Items.Add(PresetArray[i].Name);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            Validator validator = new Validator();
            Preset newPreset = null;
            try
            {
                newPreset = new Preset(nameBox.Text, double.Parse(PPMSBox.Text), double.Parse(PPMVBox.Text));
            }
            catch 
            { 
                valid = false;
            }
            if (valid && validator.IsValid(newPreset))
            { 
                if (nameBox.TextLength != 0 && PPMSBox.TextLength != 0 && PPMVBox.TextLength != 0)
                {
                    bool exists = false;
                    for (int i = 0; i < PresetArray.Length; i++)
                    {
                        if (nameBox.Text == PresetArray[i].Name)
                        {
                            exists = true;
                            PresetArray[i].Name = nameBox.Text;
                            PresetArray[i].PPMS = double.Parse(PPMSBox.Text);
                            PresetArray[i].PPMV = double.Parse(PPMVBox.Text);
                            RefreshPresetList();
                            SavePresets();
                        }
                    }
                    if (!exists)
                    {
                        PresetArray = AppendPreset(PresetArray, new Preset(nameBox.Text, double.Parse(PPMSBox.Text), double.Parse(PPMVBox.Text)));
                        RefreshPresetList();
                        SavePresets();
                    }

                }
                }
            else
            {
                MessageBox.Show("Check for valid input and try again.");
            }
        }

        

        /*
        public Preset GetLoadedPreset()
        {
            
        }
        */
        public void SavePresets()
        {
 
            Settings.Default.PresetsArray = PresetArray;
            Settings.Default.Save();
        }

        public void LoadPresets()
        {
            //PresetArray = HDeserialize(Settings.Default.Presets);
            
            try
            {
                PresetArray = Settings.Default.PresetsArray;
            }
            catch 
            {
                MessageBox.Show("Unable to load from config file");
            SavePresets(); 
            }
            
            RefreshPresetList();
            //this.Invalidate();
        }
       

        
        private Preset[] AppendPreset (Preset[] array,Preset preset)
        {
            var newArray = new Preset[array.Length+1];
            array.CopyTo(newArray, 0 );
            newArray[newArray.Length-1] = preset;
            return newArray;

        }

        private Preset[] PrependPreset(Preset[] array, Preset preset)
        {
            var newArray = new Preset[array.Length + 1];
            newArray[1] = preset;
            array.CopyTo(newArray, 1);
            return newArray;

        }

        private Preset[] InsertPreset(Preset[] array, Preset preset, int location)
        {
            var newArray = new Preset[array.Length + 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i<location)
                {
                    newArray[i] = array[i];
                }
                else if (i==location)
                {
                    newArray[i] = preset;
                }
                if (i>location)
                {
                    newArray[i] = array[i-1];
                }

            }
            return newArray;
        }



        private void DeletePresetBtn_Click(object sender, EventArgs e)
        {
            if (presetList.SelectedItems.Count == 1)
            {
                if (PresetArray[presetList.SelectedIndex].ReadOnly == false)
                {
                    var newArray = new Preset[PresetArray.Length - 1];
                    for (int i = 0; i < newArray.Length; i++)
                    {

                        if (i < presetList.SelectedIndex)
                        {
                            newArray[i] = PresetArray[i];
                        }
                        else
                        {
                            newArray[i] = PresetArray[i + 1];
                        }

                    }
                    PresetArray = newArray;
                    RefreshPresetList();
                    SavePresets();
                }
                
            }
        }

        private void restoreDefaultsBtn_Click(object sender, EventArgs e)
        {
           var result = MessageBox.Show("Caution: Restoring defaults will erase any user-defined presets and restore original presets. Do you wish to continue?","Restore Default Presets",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PresetArray = HardcodedArray;
                RefreshPresetList();
                SavePresets();
            }
            else
            {
                // do nothing
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (presetList.SelectedItems.Count == 1)
            {
                var selectedPreset = PresetArray[presetList.SelectedIndex];
                if (nameBox.Text != selectedPreset.Name || PPMSBox.Text != selectedPreset.PPMS.ToString() || PPMVBox.Text != selectedPreset.PPMV.ToString())
                {
                    presetList.ClearSelected();
                }
            }
        }

   
    }

    [Serializable]
    public class Preset
    {
        public string Name;
        public double PPMS;
        public double PPMV;
        public bool ReadOnly;

        public Preset(string name, double ppms, double ppmv, bool readOnly = false)
        {
            Name = name;
            PPMS = ppms;
            PPMV = ppmv;
            ReadOnly = readOnly;
        }

        public Preset()
        {
            // Add any necessary initialization here
        }
    }

    public class Validator
    {
        public bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            if (value.GetType() == typeof(double))
            {

                return isPPMSValid((double)value);
            }
            if (value.GetType() == typeof(string))
            {

                return isNameValid((string)value);
            }
            if (value.GetType() == typeof(int))
            {

                if ((int)value < 1 || (int)value > 100)
                {
                    return false;
                }
            }
            if (value.GetType() == typeof(Preset))
            {
                Preset preset = (Preset)value;
                if (!isPPMSValid(preset.PPMS))
                { return false; }
                if (!isPPMSValid(preset.PPMV))
                { return false; }
                if (!isNameValid(preset.Name))
                { return false; }
            }

            if (value.GetType() == typeof(Preset[]))
            {
                for (int i = 0; i < ((Preset[])value).Length; i++)
                {
                    var preset = ((Preset[])value)[i];
                    if (!isPPMSValid(preset.PPMS))
                    { return false; }
                    if (!isPPMSValid(preset.PPMV))
                    { return false; }
                    if (!isNameValid(preset.Name))
                    { return false; }
                }
            }

            if (value.GetType() == typeof(Settings))
            {
                Settings settings = (Settings)value;
                if (!isPPMSValid(settings.LastPPMS))
                    {  return false; }
                if (!isIntValid(settings.LineWidth))
                { return false; }
                if (!isPresetArrayValid(settings.PresetsArray))
                {
                    return false;
                }
            }

            bool IsValid = true;
            return IsValid;
        }


        public bool isPPMSValid(double value)
        {
            if (value.GetType() == typeof(double))
            {

                if ((double)value <= 0 || (double)value > 100000)
                {
                    return false;
                }
            }
            return true;
        }

        public bool isIntValid(int value)
        {
            if (value.GetType() == typeof(int))
            {

                if ((int)value < 1 || (int)value > 100)
                {
                    return false;
                }
            }
            return true;
        }

        public bool isNameValid(string value)
        {
            if ((string)value == "")
            {
                return false;
            }
            return true;
        }

        public bool isPresetValid(Preset preset)
        {
            if (preset == null) { return false; }
                    if (!isPPMSValid(preset.PPMS))
                    { return false; }
                    if (!isPPMSValid(preset.PPMV))
                    { return false; }
                    if (!isNameValid(preset.Name))
                    { return false; }
                
            
            return true;
        }

        public bool isPresetArrayValid(Preset[] presetArray)
        {
            if (presetArray == null) { return false; }
                for (int i = 0; i < presetArray.Length; i++)
                {
                    if (!isPresetValid(presetArray[i]))
                    {
                        return false;
                    }

                }
            return true;
        }
    }
}
