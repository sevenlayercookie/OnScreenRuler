using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OnScreenRuler
{
    public partial class RulerForm : Form
    {
        private Ruler ruler;
        private Crosshair crosshair;
        private bool isDragging;
        private Point mouseLocation = new Point(0, 0);
        private Button leftButton;
        private Button rightButton;

        public RulerForm()
        {
            InitializeComponent();
            //this.ControlBox = true;

            // Set the window to be transparent
            // so that it doesn't obscure the content underneath it
            this.TransparencyKey = Color.Red;
            this.BackColor = Color.Red;
            // Set the window to be topmost
            // so that it stays above other windows
            //this.TopMost = true;

            ruler = new Ruler();
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
            e.Graphics.DrawLine(Pens.Orange, 0, 0, (float)length, 0);

            // Draw Start and End Tick
            e.Graphics.DrawLine(Pens.Orange, 0, -capHeight, 0, capHeight);
            e.Graphics.DrawLine(Pens.Orange, (float)length, -capHeight, (float)length, capHeight);
            //e.Graphics.DrawLine(Pens.Orange, 0, -capHeight, 0, capHeight);
            //e.Graphics.DrawLine(Pens.Orange, (float)length, -capHeight, (float)length, capHeight);

            // Draw the tick marks and distance measurement
            // using the rotated coordinate system
            int tickInterval = ruler.CurrentTickWidth; // in pixels (should scale with PPMS)




            for (int i = tickInterval; i < Math.Abs(length); i += tickInterval)
            {
                if (length > 0)
                {
                    e.Graphics.DrawLine(Pens.Orange, i, 0, i, -5);
                }
                else
                {
                    e.Graphics.DrawLine(Pens.Orange, -i, 0, -i, -5);
                }
            }




            //string label = ruler.DistancePixels.ToString() + " " + ruler.CurrentUnit;
            string label = ruler.getCurrentLabel();

            SizeF labelSize = e.Graphics.MeasureString(label, this.Font);
            using (SolidBrush brush = new SolidBrush(Color.Orange))
            {
                e.Graphics.DrawString(label, this.Font, brush, (int)((length - labelSize.Width) / 2), -30);
            }





        }



        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // update textbox
            UpdateCalibrateBox(ruler.getCurrentValue(), ruler.CurrentUnit);
            newRuler = false;
            resizeStart = false;
            resizeEnd = false;
            moveEntireCaliper = false;
            if (Math.Abs(e.Location.X - ruler.Start.X) > clickTolerance && Math.Abs(e.Location.X - ruler.End.X) > clickTolerance)
            {
                if (Math.Abs(e.Location.Y - ruler.Start.Y) < clickTolerance && e.Location.X > ruler.Start.X && e.Location.X < ruler.End.X)
                {
                    // move entire caliper
                    moveEntireCaliper = true;
                    moveOffsetX = e.Location.X - ruler.Start.X;

                }
                else
                {
                    // make new caliper
                    newRuler = true;
                }
            }
            else
            {
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
        int moveOffsetY = 0;

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

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
                // Redraw the ruler
                this.Invalidate();
            }
            crosshair.Location = e.Location;
            this.Invalidate();
        }

        public int UpdateCalibrateBox(double value, string unit)
        {
            double endValue = 0;
            value = Math.Abs(value);
            if (unit == "seconds")
            {
                endValue = Math.Round(value,2);
            }
           else
            {
                endValue = Math.Round(value);
            }
            CalibrateTextBox.Text = endValue.ToString();
            CalibrateUnitLabel.Text = ruler.GetUnitAbbrev();
            return 0;
        }

        public bool swappedEnds = false;
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            // update textbox
            UpdateCalibrateBox(ruler.getCurrentValue(), ruler.CurrentUnit);

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

        private void Screenshot()
        {
            try
            {
                // set the screenshot resolution based on your monitor's resolution
                Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

                // select the save location of the captured screenshot
                //captureBitmap.Save(@"E:\Capture.jpg", ImageFormat.Jpeg);
                

                // show a message to let the user know that a screenshot has been captured
                MessageBox.Show("Screenshot taken! Press `OK` to continue...");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }



        private void RulerForm_Load(object sender, EventArgs e)
        {
            SetSelectedOption(UnitsBox, ruler);
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
            UpdateCalibrateBox(ruler.getCurrentValue(), ruler.CurrentUnit);
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
            
            double calibrateValue = double.Parse(CalibrateTextBox.Text);
            if (ruler.CurrentUnit == "pixels")
            {
                ruler.PPMS = ruler.DistancePixels / calibrateValue;
            }
            if (ruler.CurrentUnit == "milliseconds")
            {
                ruler.PPMS = ruler.DistancePixels / ruler.convertUnits(calibrateValue, "ms", "px");
            }
            if (ruler.CurrentUnit == "seconds")
            {
                ruler.PPMS = ruler.DistancePixels / ruler.convertUnits(calibrateValue, "sec", "px");
            }
            if (ruler.CurrentUnit == "bpm")
            {
                ruler.PPMS = ruler.DistancePixels / ruler.convertUnits(calibrateValue, "bpm", "px");
            }
            this.Invalidate();
            
        }
    }

    // A class to represent the on-screen ruler
    class Ruler
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public double DistancePixels { get; set; }
        public double Milliseconds { get; set; }
        public double Seconds { get; set; }
        public double BPM { get; set; }
        public string CurrentUnit { get; set; }
        public string CurrentUnitAbbrev { get; set; }
        public double PPMS { get; set; }        // pixels per millisecond

        public string CurrentLabel { get; set; }
        public int CurrentTickWidth { get; set; }

        public Ruler()
        {
            Start = new Point(0, 0);
            End = new Point(0, 0);
            DistancePixels = 0;
            CurrentUnit = "milliseconds";
            CurrentUnitAbbrev = "ms";
            PPMS = 306.0/789.0;   // 306 pixels per 789 ms (Mayo 12-Lead)
            Milliseconds = DistancePixels / PPMS;
            Seconds = Milliseconds / 1000.0;
            BPM = 1.0 / (Seconds / 36000.0);
            CurrentTickWidth = (int)(40.0 * PPMS);
            //CurrentLabel = "pixels";
            

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
                return Milliseconds;
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
                ms = inputValue/PPMS;
            }
            if (inputUnit == "milliseconds" || inputUnit == "ms")
            {
                ms = inputValue;
            }
            if (inputUnit == "seconds" || inputUnit == "sec")
            {
                ms = inputValue / 1000;
            }
            if (CurrentUnit == "bpm")
            {
                ms = 1/((inputValue / 1000)/60);
            }

            // convert ms to output
            if (outputUnit == "pixels" || outputUnit == "px")
            {
                return Math.Round(ms*PPMS);
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
                return Math.Round(1/((ms / 1000)/60));
            }

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