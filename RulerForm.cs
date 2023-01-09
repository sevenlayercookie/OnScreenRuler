using OnScreenCalipers;
using OnScreenCalipers.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace OnScreenCalipers
{
    public partial class RulerForm : Form
    {
        public Ruler ruler;
        private Crosshair crosshair;
        private bool isDragging;
        private Point mouseLocation = new Point(0, 0);
        private Button leftButton;
        private Button rightButton;
        public RulerForm()
        {
            InitializeComponent();
            //this.ControlBox = true;
            ruler = new Ruler();
            // Set the window to be transparent
            // so that it doesn't obscure the content underneath it
            this.TransparencyKey = Color.AliceBlue;
            this.BackColor = Color.AliceBlue;

            // Set the window to be topmost
            // so that it stays above other windows
            //this.TopMost = true;


            crosshair = new Crosshair();

            // button intitialisation
            leftButton = new Button();
            leftButton.Size = new Size(80, 40);
            leftButton.Text = "<";
            leftButton.BackColor = Color.White;
            leftButton.Click += LeftButton_Click;

            rightButton = new Button();
            rightButton.Size = new Size(80, 40);
            rightButton.Text = ">";
            rightButton.BackColor = Color.White;
            rightButton.Click += RightButton_Click;

            //ghostRuler = new Ruler();
            isDragging = false;

        }

        private void SetSelectedOption(ComboBox unitsBox, Ruler ruler)
        {
            // Set the selected option of the unitsBox combo box
            // based on the value of the Units property of the ruler object
            if (ruler.CurrentUnit == "pixels")
            {
                unitsBox.SelectedIndex = 0;
            }
            else if (ruler.CurrentUnit == "milliseconds")
            {
                unitsBox.SelectedIndex = 1;
            }
            else if (ruler.CurrentUnit == "seconds")
            {
                unitsBox.SelectedIndex = 2;
            }
            else if (ruler.CurrentUnit == "bpm")
            {
                unitsBox.SelectedIndex = 3;
            }
            unitsBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // load values from settings
            // ruler.EnableTicks = CaliperAppearanceForm.DialogTickMarksEnabled;
            // draw image if it is present
            if (openedImage != null && transparency == false)
            {
                e.Graphics.DrawImage(openedImage, 0, menuStrip1.Size.Height);
            }

            //DrawBorder(); // draw border around window
            // Calculate the length and angle of the ruler
            int dx = ruler.End.X - ruler.Start.X;
            //int dy = ruler.End.Y - ruler.Start.Y;
            //int dy = 0;
            //double angle = Math.Atan2(dy, dx);
            double length = ruler.DistancePixels;

            //int capHeight = mouseLocation.Y - ruler.Start.Y;
            int capHeight = this.Height; // caps set to full height of form/window




            // draw crosshair
            crosshair.Draw(crosshair.Location, e, this.Width, this.Height);

            // Translate the origin of the coordinate system to the start point of the ruler
            e.Graphics.TranslateTransform(ruler.Start.X, ruler.Start.Y);
            // Draw the ruler
            //Pen RulerPen = new Pen(Pens.Lime.Brush,ruler.lineWidth);
            e.Graphics.DrawLine(ruler.Pen, 0, 0, (float)length, 0);

            // Draw Start and End Tick
            e.Graphics.DrawLine(ruler.Pen, 0, -capHeight, 0, capHeight);
            e.Graphics.DrawLine(ruler.Pen, (float)length, -capHeight, (float)length, capHeight);
            //e.Graphics.DrawLine(Pens.Orange, 0, -capHeight, 0, capHeight);
            //e.Graphics.DrawLine(Pens.Orange, (float)length, -capHeight, (float)length, capHeight);

            // Draw the tick marks and distance measurement
            // using the rotated coordinate system

            if (ruler.EnableTicks)
            {
                int tickInterval = ruler.CurrentTickInterval; // in pixels (should scale with PPMS)

                //Pen TickPen = new Pen(Pens.Lime.Brush, 1);
                
                for (int i = tickInterval; i < Math.Abs(length); i += tickInterval)
                {
                    if (length > 0)
                    {
                        e.Graphics.DrawLine(ruler.TickPen, i, 0, i, -5);
                    }
                    else
                    {
                        e.Graphics.DrawLine(ruler.TickPen, -i, 0, -i, -5);
                    }
                }

            }


            string label = ruler.getCurrentLabel();

            SizeF labelSize = e.Graphics.MeasureString(label, ruler.Font);

            // Calculate the x-coordinate of the text's position
            int x = (int)((length - labelSize.Width) / 2) + ruler.Start.X;
            int y = (int)(ruler.Start.Y - labelSize.Height - 10);

            // Ensure that the text is not drawn off the left side of the screen
            if (x < 0)
            {
                x = 0;
            }

            // Create a solid brush
            using (SolidBrush brush = new SolidBrush(ruler.FontColor))
            {
                if (!ruler.LabelBackTransparent)
                {
                    // Draw the text with a black outline using the TextRenderer.DrawText method
                    TextRenderer.DrawText(e.Graphics, label, ruler.Font, new Point(x, y), ruler.FontColor, ruler.LabelBackColor);
                }
                else
                {
                    TextRenderer.DrawText(e.Graphics, label, ruler.Font, new Point(x, y), ruler.FontColor);
                }
            }






        }

        private int DrawBorder()
        {

            Rectangle windowRect = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            Rectangle borderRect = new Rectangle(windowRect.X + 2, windowRect.Y + 2, windowRect.Width - 4, windowRect.Height - 4);

            Graphics e = this.CreateGraphics();
            Pen BorderPen = new Pen(Color.Blue, 4);
            e.DrawRectangle(BorderPen, borderRect);
            this.Invalidate();
            return 0;
        }



        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // update textbox
            UpdateCalibrateBox();
            newRuler = false;
            resizeStart = false;
            resizeEnd = false;
            moveEntireCaliper = false;
            if (Math.Abs(e.Location.X - ruler.Start.X) > clickTolerance && Math.Abs(e.Location.X - ruler.End.X) > clickTolerance)
            {
                if (Math.Abs(e.Location.Y - ruler.Start.Y) < clickTolerance && e.Location.X > ruler.Start.X && e.Location.X < ruler.End.X)
                {
                    // move entire caliper
                    this.Cursor = Cursors.Hand;
                    moveEntireCaliper = true;
                    moveOffsetX = e.Location.X - ruler.Start.X;

                }
                else
                {
                    // make new caliper
                    newRuler = true;
                    this.Cursor = Cursors.Hand;
                }
            }
            else
            {
                this.Cursor = Cursors.SizeWE;
                if (Math.Abs(e.Location.X - ruler.Start.X) < clickTolerance)
                {
                    // resize existing Start caliper

                    resizeStart = true;
                    resizeEnd = false;
                    newRuler = false;
                }
                else if (Math.Abs(e.Location.X - ruler.End.X) < clickTolerance)
                {
                    // resize existing End caliper
                    resizeStart = false;
                    resizeEnd = true;
                    newRuler = false;

                }

            }



            if (newRuler)
            {
                // create "new" ruler
                mouseLocation = e.Location;
                ruler.Start = e.Location;
                isDragging = true;
                clearForm();
            }
            else
            {
                if (resizeStart)
                {
                    mouseLocation = e.Location;
                    //ruler.Start = e.Location;
                    isDragging = true;
                    clearForm();

                }
                else if (resizeEnd)
                {
                    // resize existing End caliper
                    mouseLocation = e.Location;
                    //ruler.End = e.Location;
                    isDragging = true;
                    clearForm();

                }
            }
            isDragging = true;
            clearForm();
        }


        void clearForm()
        {
            this.Controls.Remove(leftButton);
            this.Controls.Remove(rightButton);
        }

        int clickTolerance = 10;
        bool newRuler = false;
        bool resizeStart = false;
        bool resizeEnd = false;
        bool moveEntireCaliper = false;
        int moveOffsetX = 0;

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (!isDragging)
            {
                if ((Math.Abs(e.Location.Y - ruler.Start.Y) < clickTolerance && e.Location.X > ruler.Start.X && e.Location.X < ruler.End.X) || (Math.Abs(e.Location.X - ruler.Start.X) < clickTolerance) || Math.Abs(e.Location.X - ruler.End.X) < clickTolerance)
                {
                    if ((Math.Abs(e.Location.X - ruler.Start.X) < clickTolerance) || Math.Abs(e.Location.X - ruler.End.X) < clickTolerance)
                    {
                        this.Cursor = Cursors.SizeWE;
                    }
                    else {
                        this.Cursor = Cursors.Hand;
                    }

                }
                else
                {
                    this.Cursor = Cursors.Cross;
                }

            }
            if (isDragging)
            {

                if (!moveEntireCaliper)
                {
                    // Update the end point of the ruler
                    // as the user moves the mouse
                    if (newRuler || resizeEnd)
                    {
                        ruler.End = new Point(e.Location.X, ruler.Start.Y);
                    }

                    if (newRuler)
                    {
                        ruler.Start = new Point(ruler.Start.X, e.Location.Y);
                    }

                    if (resizeStart)
                    {
                        ruler.Start = new Point(e.Location.X, ruler.Start.Y);
                    }
                }
                if (moveEntireCaliper)
                {
                    ruler.Start = new Point(e.Location.X - moveOffsetX, e.Location.Y);
                    ruler.End = new Point((int)(ruler.Start.X + ruler.DistancePixels), e.Location.Y);

                }
                // Calculate the distance between the start and end points
                int dx = ruler.End.X - ruler.Start.X;
                ruler.DistancePixels = dx;
                mouseLocation = e.Location;
                // update QT calc dialog box (if dialog exists)
                ruler.UpdateRuler();
                if (QTcForm != null)
                {
                    QTcForm.DialogQT = ruler.Milliseconds;
                    QTcForm.QTBox.Text = Math.Abs(Math.Round(ruler.Milliseconds)).ToString();
                    QTcForm.Invalidate();
                }

                // Redraw the ruler and calibratebox
                UpdateCalibrateBox();
                this.Invalidate();
            }
            crosshair.Location = e.Location;
            this.Invalidate();

        }

        public int UpdateCalibrateBox()
        {
            double endValue = 0;

            
            double value = Math.Abs(ruler.getCurrentValue());
            string unit = ruler.CurrentUnit;
           
            if (unit == "seconds")
            {
                endValue = Math.Round(value, 2);
            }
            else
            {
                endValue = Math.Round(value);
            }
            CalibrateTextBox.Text = endValue.ToString();
            // update units box if necessary
            if (UnitsBox.SelectedText != ruler.CurrentUnitAbbrev)
            {
                SetSelectedOption(UnitsBox, ruler);
            }
            // update preset label
            presetLabel.Text = ruler.LoadedPreset;
            //CalibrateUnitLabel.Text = ruler.GetUnitAbbrev();
            return 0;
        }

        public bool swappedEnds = false;
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            // update textbox
            UpdateCalibrateBox();

            // swap start and end if ends cross
            if (ruler.DistancePixels < 0)
            {

                Point newStart = ruler.End;
                ruler.End = ruler.Start;
                ruler.Start = newStart;
                ruler.DistancePixels = ruler.End.X - ruler.Start.X;
                swappedEnds = true;
            }

            // Stop dragging the ruler
            isDragging = false;
            this.Cursor = Cursors.Cross;

            // draw buttons
            DrawButtons();
        }

        void DrawButtons()
        {
            leftButton.Location = new Point(ruler.Start.X - leftButton.Width - 10, ruler.Start.Y - (leftButton.Height / 2));
            rightButton.Location = new Point(ruler.End.X + 10, ruler.End.Y - (rightButton.Height / 2));

            this.Controls.Add(leftButton);
            this.Controls.Add(rightButton);
        }
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int GetDeviceCaps(IntPtr hDC, int nIndex);

        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();

        private void Screenshot()
        {
            try
            {
                // set the screenshot resolution based on your monitor's resolution
                //Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
                
                Rectangle wholeScreen = GetDisplayResolution();          // gets whole screen

                // find coordinates of client area (area where controls can be placed) (does it include menubar?)
                Rectangle clientArea = this.ClientRectangle; // expressed in client coordinates, where 0,0 is top left of client windows
                Rectangle clientArea2 = this.RectangleToScreen(clientArea); // expressed in screen coordinates, where 0,0 is top left of entire screen
                clientArea2.Y += menuStrip1.Height; // account for the menu bar
                this.Hide();
                Rectangle windowRect = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                Rectangle fullScreen = Screen.AllScreens[0].Bounds;
                Rectangle resolution = clientArea2;
                openedImage = new Bitmap(resolution.Width, resolution.Height, PixelFormat.Format32bppArgb);
                
                Graphics captureGraphics = Graphics.FromImage(openedImage);
                captureGraphics.CopyFromScreen(resolution.Left, resolution.Top, 0, 0, resolution.Size);
                // fullscreen: captureGraphics.CopyFromScreen(0, 0, 0, 0, fullScreen.Size);

                // select the save location of the captured screenshot
                openedImage.Save(@"C:\Users\seven\Desktop\test\screenshot.jpeg", ImageFormat.Jpeg);

                this.Show();
                // show a message to let the user know that a screenshot has been captured
                //MessageBox.Show("Screenshot taken! Press `OK` to continue...");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }


            double GetWindowsScreenScalingFactor(bool percentage = true)
            {
                //Create Graphics object from the current windows handle
                Graphics GraphicsObject = Graphics.FromHwnd(IntPtr.Zero);
                //Get Handle to the device context associated with this Graphics object
                IntPtr DeviceContextHandle = GraphicsObject.GetHdc();
                //Call GetDeviceCaps with the Handle to retrieve the Screen Height
                int LogicalScreenHeight = GetDeviceCaps(DeviceContextHandle, (int)DeviceCap.VERTRES);
                int PhysicalScreenHeight = GetDeviceCaps(DeviceContextHandle, (int)DeviceCap.DESKTOPVERTRES);
                //Divide the Screen Heights to get the scaling factor and round it to two decimals
                double ScreenScalingFactor = Math.Round(PhysicalScreenHeight / (double)LogicalScreenHeight, 2);
                //If requested as percentage - convert it
                if (percentage)
                {
                    ScreenScalingFactor *= 100.0;
                }
                //Release the Handle and Dispose of the GraphicsObject object
                GraphicsObject.ReleaseHdc(DeviceContextHandle);
                GraphicsObject.Dispose();
                //Return the Scaling Factor
                return ScreenScalingFactor;
            }

           Rectangle GetDisplayResolution()
            {
                var sf = GetWindowsScreenScalingFactor(false);
                var screenWidth = Screen.PrimaryScreen.Bounds.Width * sf;
                var screenHeight = Screen.PrimaryScreen.Bounds.Height * sf;
                return new Rectangle(0,0,(int)screenWidth, (int)screenHeight);
            }
        }

        private void ImagePaste()
        {
            if(Clipboard.ContainsImage())
            {
                disableTransparency();
                Image pasted = Clipboard.GetImage();
                openedImage = pasted;
            }
        }

        
        private void RulerForm_Load(object sender, EventArgs e)
        {

            Settings.Default.SettingChanging += new SettingChangingEventHandler(SettingChanging);
            LoadSettings();
            SetProcessDPIAware();
            SetSelectedOption(UnitsBox, ruler);
            DoubleBuffered = true;
        }
        public class ValidCheck
        {
            public bool IsValid = true;
            public object ValidatedValue;
        }
        private void SettingChanging(Object sender, SettingChangingEventArgs e)
        {
            if (e.SettingName.Equals("LastPPMS"))
            {

                if (!validator.isPPMSValid((double)e.NewValue))
                {
                    e.Cancel = true;
                    // Inform the user.
                }
            }
            if (e.SettingName.Equals("PresetsArray"))
            {
                var presetsArray = (Preset[])e.NewValue;

                
                    if (!validator.isPresetArrayValid(presetsArray) || (presetsArray == null))
                    {
                        e.Cancel = true;
                    }

                
                
            }
            if (e.SettingName.Equals("LineWidth"))
            {

                if (!validator.isIntValid(((int)e.NewValue)))
                {
                    e.Cancel = true;
                    // Inform the user.
                }
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UnitsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the Units property of the ruler object
            // based on the selected option of the unitsBox combo box
            ruler.CurrentUnit = (string)UnitsBox.SelectedItem;
            // update textbox
            UpdateCalibrateBox();
            this.Invalidate();

        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            // shift ruler to left by "distance"
            ruler.Start = new Point((int)(ruler.Start.X - ruler.DistancePixels), ruler.Start.Y);
            ruler.End = new Point((int)(ruler.End.X - ruler.DistancePixels), ruler.End.Y);
            clearForm();
            this.Invalidate();
            DrawButtons();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            // shift ruler to right by "distance"
            ruler.Start = new Point((int)(ruler.Start.X + ruler.DistancePixels), ruler.Start.Y);
            ruler.End = new Point((int)(ruler.End.X + ruler.DistancePixels), ruler.End.Y);
            clearForm();
            this.Invalidate();
            DrawButtons();
        }

        private void CalibrateTextBox_change(object sender, EventArgs e)
        {
 
        }

        private void CalibrateBtn_Click(object sender, EventArgs e)
        {
            //Validator validator = new Validator();
            //string message = "";
            bool isValid = true;
            try
            {
                isValid = validator.isPPMSValid(double.Parse(CalibrateTextBox.Text));
            }
            catch
            {
                
                isValid = false;
            }
            if (ruler.DistancePixels <= 0)
            {
                isValid = false;
            }
            if (isValid)
            {
                double calibrateValue = double.Parse(CalibrateTextBox.Text);
                if (ruler.CurrentUnit == "pixels")
                {
                    // can't calibrate pixels.... they're literally just there

                }
                if (ruler.CurrentUnit == "milliseconds")
                {
                    ruler.PPMS = ruler.DistancePixels / calibrateValue;
                }
                if (ruler.CurrentUnit == "seconds")
                {
                    ruler.PPMS = ruler.DistancePixels / ruler.convertUnits(calibrateValue, "sec", "ms");
                }
                if (ruler.CurrentUnit == "bpm")
                {
                    ruler.PPMS = ruler.DistancePixels / ruler.convertUnits(calibrateValue, "bpm", "ms");
                }
                Settings.Default["LastPPMS"] = ruler.PPMS;
                // update preset label
                ruler.LoadedPreset = null;
                presetLabel.Text = ruler.LoadedPreset;
                ruler.UpdateRuler();
                Settings.Default.Save();
                this.Invalidate();
            }
            else
            {
                //MessageBox.Show("Check for valid inputs.");
            }

        }

        CaliperAppearance CaliperAppearanceForm = new CaliperAppearance();

        private void caliperAppearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // load current values into Dialog Form
            CaliperAppearanceForm.DialogCaliperLineWidthNewValue = ruler.lineWidth;
            CaliperAppearanceForm.DialogTickMarksEnabled = ruler.EnableTicks;
            CaliperAppearanceForm.DialogSelectedLineColor = ruler.Color;
            CaliperAppearanceForm.DialogSelectedFont = ruler.Font;
            CaliperAppearanceForm.DialogSelectedFontColor = ruler.FontColor;
            CaliperAppearanceForm.DialogSelectedLabelBackColor = ruler.LabelBackColor;
            CaliperAppearanceForm.LabelBackTransparent = ruler.LabelBackTransparent;
            CaliperAppearanceForm.DialogTopmost = this.TopMost;
            //CaliperAppearanceForm.linecol

            if (CaliperAppearanceForm.ShowDialog() == DialogResult.OK)
            {
                // save appearance settings
                ruler.lineWidth = CaliperAppearanceForm.DialogCaliperLineWidthNewValue;
                ruler.EnableTicks = CaliperAppearanceForm.DialogTickMarksEnabled;
                ruler.SetColor(CaliperAppearanceForm.DialogSelectedLineColor);
                ruler.Font = CaliperAppearanceForm.DialogSelectedFont;
                ruler.FontColor = CaliperAppearanceForm.DialogSelectedFontColor;
                ruler.LabelBackColor = CaliperAppearanceForm.DialogSelectedLabelBackColor;
                ruler.LabelBackTransparent = CaliperAppearanceForm.LabelBackTransparent;
                this.TopMost = CaliperAppearanceForm.DialogTopmost;

                // save to persistent settings
                SaveSettings();

            }
        }

        Validator validator = new Validator();
        private int SaveSettings()
        {
            if (!validator.isPPMSValid(ruler.PPMS))
            {
                ruler.PPMS = 0.100;
            }
            Settings.Default["LastPPMS"] = ruler.PPMS;
            Settings.Default["LabelFont"] = ruler.Font;
                Settings.Default.LabelFontColor = ruler.FontColor;
                Settings.Default["LabelBackColor"] = ruler.LabelBackColor;
                Settings.Default["LineColor"] = ruler.Color;
            if (!validator.isIntValid(ruler.lineWidth))
            {
                ruler.lineWidth = 2;
            }
            Settings.Default["LineWidth"] = ruler.lineWidth;
            Settings.Default["TicksEnabled"] = ruler.EnableTicks;
            
                //ruler.UpdateRuler();
                //Settings.Default["Ruler"] = ruler;
                Settings.Default.Save(); // Saves settings in application configuration file
                return 0;
            
        }
        private int LoadSettings()
        {
            Settings.Default.Reload(); // Load settings from application configuration file
            
            bool IsValid = validator.IsValid(Settings.Default);
            if (Settings.Default.LabelFont == null || IsValid == false) // if first run or invalid settings, restoredefaults
            {
                SaveSettings(); // initialize first run settings 
                return 1;
            }
            else
            {
                ValidateSettings();
                ruler.PPMS = Settings.Default.LastPPMS;
                ruler.Font = Settings.Default.LabelFont;
                ruler.FontColor = Settings.Default.LabelFontColor;
                ruler.LabelBackColor = Settings.Default.LabelBackColor;
                ruler.Color = Settings.Default.LineColor;
                ruler.lineWidth = Settings.Default.LineWidth;
                ruler.EnableTicks = Settings.Default.TicksEnabled;
                //ruler = Settings.Default.Ruler;
                ruler.UpdateRuler();               
                return 0;

            }
            
        }



        public Image openedImage;
        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                openedImage = new Bitmap(openFileDialog1.OpenFile());
                //this.BackgroundImage = openedImage;
                /*
                transparentModeToolStripMenuItem.Checked = false;
                TransparencyCheckBox2.Checked = false;
                this.BackColor = Color.LightGray;
                */
                disableTransparency();

            }

        }

        private void SetTransparent(bool boolean)
        {
            if (boolean)
            {
                enableTransparency();
            }
            else
            {
                disableTransparency();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void screenshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disableTransparency();
            Screenshot();
        }

        private void transparentModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (transparentModeToolStripMenuItem.Checked == true)
            {
                enableTransparency();
            }
            else
            {
                disableTransparency();
            }
        }

        public bool transparency = true;
        private void disableTransparency()
        {
            transparency = false;
            this.BackColor = Color.LightGray;
            TransparencyCheckBox2.Checked = false;
            transparentModeToolStripMenuItem.Checked = false;
        }

        private void enableTransparency()
        {
            transparency = true;
            this.BackColor = Color.AliceBlue;
            this.BackgroundImage = null;
            openedImage = null;
            TransparencyCheckBox2.Checked = true;
            transparentModeToolStripMenuItem.Checked = true;
        }

        private void closeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            openedImage = null;
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog AboutDialog = new AboutDialog();
            AboutDialog.Show();
        }

        private void TransparencyCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (TransparencyCheckBox2.Checked == true)
            {
                enableTransparency();
            }
            else
            {
                disableTransparency();
            }

        }

        public QTc QTcForm;
        private void qTcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QTcForm = new QTc(this);
            ruler.CurrentUnit = "milliseconds";
            ruler.UpdateRuler();
            UpdateAllGUI();
            QTcForm.DialogQT = ruler.Milliseconds;
            QTcForm.TopMost = this.TopMost;
            QTcForm.Show();
        }

        private int UpdateAllGUI()
        {
            UpdateCalibrateBox();
            return 0;
        }
        private void presetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalPresets CalPresetsForm = new CalPresets(this);
            CalPresetsForm.PPMS = ruler.PPMS;
            CalPresetsForm.PPMV = ruler.PPMV;
            CalPresetsForm.LoadedPreset = ruler.LoadedPreset;
            CalPresetsForm.ShowDialog(this);
                ruler.PPMS = CalPresetsForm.PresetPPMS;
                ruler.PPMV = CalPresetsForm.PresetPPMV;
                ruler.LoadedPreset = CalPresetsForm.LoadedPreset;
                presetLabel.Text = ruler.LoadedPreset;
            
        }

        private void RulerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void RulerForm_Resize(object sender, EventArgs e)
        {
            DrawBorder();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox1.Checked;
            CaliperAppearanceForm.DialogTopmost = checkBox1.Checked;
        }

        private void CalibrateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CalibrateBtn_Click(sender, e);
            }
        }

        private void RulerForm_KeyDown(object sender, KeyEventArgs e)
        {
            // handle CTRL + V (paste)
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsImage())
                {
                    ImagePaste();
                }
            }
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void RulerForm_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }

        public Ruler ValidateRulerSettings(Ruler testRuler)
        {
            if (testRuler.CurrentTickInterval < 1 || testRuler.CurrentTickInterval > 10000)
            {
                testRuler.CurrentTickInterval = 20;
            }

            return testRuler;
        }
      
        public int ValidateSettings(double PPMS, double PPMV, int lineWidth)
        {
            if (PPMS <= 0 || PPMS > 10000 || Double.IsNaN(PPMS))
            {
                return 1;
            }
            if (PPMV <= 0 || PPMV > 10000 || Double.IsNaN(PPMV))
            {
                return 1;
            }
            if (lineWidth < 1 || lineWidth > 50)
            {
                return 1;
            }
            return 0;
        }

        public int ValidateSettings()
        {
            int i = 0;
            Settings.Default.LastPPMS = validatePPMS(Settings.Default.LastPPMS);
            /*
            if (PPMV < 0 || PPMV > 10000 || Double.IsNaN(PPMV))
            {
                return 1;
            }
            */
            if (Settings.Default.LineWidth < 1 || Settings.Default.LineWidth > 50)
            {
                Settings.Default.LineWidth = 2;
                i = 1;
            }
            if (Settings.Default.PresetsArray != null)
            {
                for (int j = 0; j < Settings.Default.PresetsArray.Length; j++)
                {
                    Settings.Default.PresetsArray[j].PPMS = validatePPMS(Settings.Default.PresetsArray[j].PPMS);
                    if (Settings.Default.PresetsArray[j].Name == null)
                    {
                        Settings.Default.PresetsArray[j] = null;
                    }
                }
                
            }
            return i;

            
        }
        double validatePPMS(double ppms)
        {
            if (ppms <= 0 || ppms > 10000 || Double.IsNaN(ppms))
            {
                return 0.100;
            }
            return ppms;
        }

        Preset validatePreset(Preset preset)
        {
            preset.PPMS = validatePPMS(preset.PPMS);
            preset.PPMV = validatePPMS(preset.PPMV);
            if (preset.Name == null)
            {
                preset = null;
            }
            return preset;
        }


    }

    // A class to represent the on-screen ruler
    [Serializable]
    public class Ruler
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public double DistancePixels { get; set; }
        public double Milliseconds { get; set; }
        public double Seconds { get; set; }
        public double BPM { get; set; }
        public string CurrentUnit { get; set; }
        public string CurrentUnitAbbrev { get; set; }
        public string LoadedPreset { get; set; }
        public double PPMS { get; set; }        // pixels per millisecond
        public double PPMV { get; set; }        // pixels per mv

        public string CurrentLabel { get; set; }
        public int CurrentTickInterval { get; set; }

        // appearance
        public Color Color { get; set; }
        public int lineWidth { get; set; }
        public bool EnableTicks { get; set; }
        public Pen Pen { get; set; }
        public Pen TickPen { get; set; }
        public int TickLineWidth { get; set; }
        public Font Font { get; set; }
        public Color FontColor { get; set; }
        public Color LabelBackColor { get; set; }
        public bool LabelBackTransparent { get; set; }
        public Ruler()
        {
            Start = new Point(0, 0);
            End = new Point(0, 0);
            DistancePixels = 0;
            LoadedPreset = null;
            CurrentUnit = "milliseconds";
            CurrentUnitAbbrev = "ms";
            PPMS = 306.0 / 789.0;   // 306 pixels per 789 ms (Mayo 12-Lead)
            PPMV = 0.100;
            Milliseconds = DistancePixels / PPMS;
            Seconds = Milliseconds / 1000.0;
            BPM = 1.0 / (Seconds / 36000.0);
            EnableTicks = true;
            CurrentTickInterval = (int)(40.0 * PPMS);
            TickLineWidth = 1;

            // appearance
            lineWidth = 2;
            Color = Color.Lime;
            Pen = new Pen(Color, lineWidth);
            TickPen = new Pen(Color, TickLineWidth);
            Font = new Font("Arial", 16);
            FontColor = Color.Orange;
            LabelBackColor = Color.Black;
            LabelBackTransparent = false;



        }


        public string GetUnitAbbrev()
        {
            if (CurrentUnit == "pixels")
            {
                CurrentUnitAbbrev = "px";

            }
            if (CurrentUnit == "milliseconds")
            {
                CurrentUnitAbbrev = "ms";
            }
            if (CurrentUnit == "seconds")
            {
                CurrentUnitAbbrev = "sec";
            }
            if (CurrentUnit == "bpm")
            {
                CurrentUnitAbbrev = "bpm";
            }
            return CurrentUnitAbbrev;

        }
        public string getCurrentLabel()
        {
            Milliseconds = DistancePixels / PPMS;
            Seconds = Milliseconds / 1000.0;
            BPM = 1 / (Seconds / 60.0);

            if (CurrentUnit == "pixels")
            {
                CurrentLabel = Math.Abs(DistancePixels).ToString("N0") + " " + "px";

            }
            if (CurrentUnit == "milliseconds")
            {
                CurrentLabel = Math.Abs(Milliseconds).ToString("N0") + " " + "ms";
            }
            if (CurrentUnit == "seconds")
            {
                CurrentLabel = Math.Abs(Seconds).ToString("N2") + " " + "sec";
            }
            if (CurrentUnit == "bpm")
            {
                CurrentLabel = Math.Abs(BPM).ToString("N0") + " " + CurrentUnit;
            }
            return CurrentLabel;
        }

        public double getCurrentValue()
        {
            Milliseconds = DistancePixels / PPMS;
            Seconds = Milliseconds / 1000.0;
            BPM = 1 / (Seconds / 60.0);

            if (CurrentUnit == "pixels")
            {
                return DistancePixels;

            }
            if (CurrentUnit == "milliseconds")
            {
                return Math.Round(Milliseconds);
            }
            if (CurrentUnit == "seconds")
            {
                return Seconds;
            }
            if (CurrentUnit == "bpm")
            {
                return BPM;
            }
            return 0;
        }

        public double convertUnits(double inputValue, string inputUnit, string outputUnit)
        {
            double ms = 0;
            // convert input value to milliseconds (the "standard")
            if (inputUnit == "pixels" || inputUnit == "px")
            {
                ms = inputValue / PPMS;
            }
            if (inputUnit == "milliseconds" || inputUnit == "ms")
            {
                ms = inputValue;
            }
            if (inputUnit == "seconds" || inputUnit == "sec")
            {
                ms = inputValue * 1000;
            }
            if (inputUnit == "bpm")
            {
                ms = 1 / ((inputValue / 1000) / 60);
            }

            // convert ms to output
            if (outputUnit == "pixels" || outputUnit == "px")
            {
                return Math.Round(ms * PPMS);
            }
            if (outputUnit == "milliseconds" || outputUnit == "ms")
            {
                return Math.Round(ms);
            }
            if (outputUnit == "seconds" || outputUnit == "sec")
            {
                return Math.Round((ms / 1000), 2);
            }
            if (outputUnit == "bpm")
            {
                return Math.Round(1 / ((ms / 1000) / 60));
            }

            return 0;
        }

        public Color SetColor(Color NewColor)
        {
            Color = NewColor;
            Pen = new Pen(Color, lineWidth);
            TickPen = new Pen(Color, TickLineWidth);
            return Color;
        }

        public int UpdateRuler() // updates ruler vars based on the other calcs
        {
            // update Pen based on PenColor and LineWidth
            Pen = new Pen(Color, lineWidth);
            TickPen = new Pen(Color, TickLineWidth);
            // update calcs
            getCurrentValue();
            getCurrentLabel();
            CurrentTickInterval = (int)(40.0 * PPMS);
            return 0;
        }
    }

    

    class Crosshair
    {
        public Point Location { get; set; }
        public double Opacity { get; set; }
        public Pen LinePen { get; set; }

        public Crosshair()
        {
            Location = new Point(0, 0);
            Opacity = 0.9;
            LinePen = Pens.Gray;
            
        }


        
        public float Draw(Point location, PaintEventArgs e, int width, int height)
        {
            // Draw the crosshair
            e.Graphics.DrawLine(LinePen, 0, location.Y, width, location.Y);
            e.Graphics.DrawLine(LinePen, location.X, 0, location.X, height);
            return 0;
        }

        

    }


}