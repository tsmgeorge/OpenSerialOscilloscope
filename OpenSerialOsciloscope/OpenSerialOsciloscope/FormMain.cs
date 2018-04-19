using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

/*
 * This Software is free and open source for educational use.
 *   Improve it and share it free!
 */

namespace OpenSerialOsciloscope
{
    public partial class FormMain : Form
    {
        SerialPort serialPort=null;
        Thread readSerialThread;
        double zoomOffset = 0.1;
        int timeOffset = 10;
        double CHwaveStart;
        double CHwaveEnd;
        long prevTime = 0;
        long currTime = 0;
        int hardwareDelay = 0;
        OscilloscopeChannel Osc;
        VerticalLineAnnotation vlaStart=new VerticalLineAnnotation();
        VerticalLineAnnotation vlaEnd = new VerticalLineAnnotation();

         //Struct
          public struct OscilloscopeChannel{

            public int measurLimit; 
            public long timeStamp;  //measurement timestamp
            public bool Ch1Enabled; 
            public bool Ch2Enabled;

            double Ch1Value;
            double Ch2Value;

            double CH1pp;    // channel 1 peak to peak difference of signal
            double CH2pp;    // channel 2 peak to peak difference of signal
            double ScreenPP; // max diff of all signals

            double screenMax; // max measurement value on current screeen
            double screenMin; // min measurement value on current screeen
            double CH1max;    // max measurement value of channel 1
            double CH1min;    // min measurement value of channel 1
            double CH2max;    // max measurement value of channel 2
            double CH2min;    // min measurement value of channel 2

            double Signalfreq; // Frequency value off measured signal

           // GETTERS
              // Get CH1 value and set internal values
              public double CH1Val() {
                if (!Ch1Enabled) { return 0; }
                double measureTemp = this.Ch1Value;
                if (measureTemp > CH1max) { CH1max = measureTemp; }//max
                if (measureTemp < CH1min) { CH1min = measureTemp; }//min
                if (measureTemp > screenMax) { screenMax = measureTemp; }//max
                if (measureTemp < screenMin) { screenMin = measureTemp; }//min
                return Ch1Value;
            }//CH1Val

            // Get CH2 value and set internal values
            public double CH2Val()
            {
                if (!Ch2Enabled) { return 0; }
                double measureTemp = this.Ch2Value;
                if (measureTemp > CH2max) { CH2max = measureTemp; }//max
                if (measureTemp < CH2min) { CH2min = measureTemp; }//min
                if (measureTemp > screenMax) { screenMax = measureTemp; }//max
                if (measureTemp < screenMin) { screenMin = measureTemp; }//min
                return Ch2Value;
            }//CH1Val

            public double GetCH1pp()
            {
                CH1pp = CH1max - CH1min;
                return CH1pp;
            }//GetCH1pp
            public double GetCH2pp()
            {
                CH2pp = CH2max - CH2min;
                return CH2pp;
            }//GetCH1pp

            public double GetSreenPP()
            {
                ScreenPP = screenMax - screenMin;
                return ScreenPP;
            }//GetCH1pp

            public double GetSreenMin() {
                return screenMin; 
            }//GetCH1pp

            public double GetSreenMax() {
                return screenMax; 
            }//GetCH1pp

     
          // SETTERS
            public void SetCH1Val(string strVal){
                Ch1Value = StringToDouble(strVal);
            }//SetCH1Val

            public void SetCH1Val(double val){
              Ch1Value= val;
            }//SetCH1Val

            public void SetCH2Val(string strVal){
                Ch2Value = StringToDouble(strVal);
            }//SetCH1Val

            public void SetCH2Val(double val){
                Ch2Value = val;
            }//SetCH1Val

        //CALC
            public void ResetMinMax() {
                    screenMax = double.MinValue;
                    screenMin = double.MaxValue;
                    CH1max = double.MinValue;
                    CH1min = double.MaxValue;
                    CH2max = double.MinValue;
                    CH2min = double.MaxValue;
            }//ResetMinMax

            // Calc signal frequency 
            public double CalcFreq(double f1, double f2,long ms){
                int dF = (int) (f2 - f1); // time diff = point2 -point1
                float divider = (dF * ms );
                if (divider == 0) { this.Signalfreq=0; }
                else{
                    this.Signalfreq = 1000 / (float)divider; //freq= 1Sec/ time diff units* millisec per measurement
                }//else
                return Signalfreq;
            }//Calc Freq

         }; //Struct OscilloscopeChannel
        


        //Main Constructor
        public FormMain()
        {
            InitializeComponent();
        }//Form Main Constructor



        //Form Main On Load
        private void FormMain_Load(object sender, EventArgs e) {
            InitGUI();
            ScanSerialPorts();           
        }// On load main Form
        


        //Initiallize GUI
        void InitGUI(){
            //Init values
            Osc.measurLimit = 100;
            trackBarAxisXmax.Value = Osc.measurLimit;
            textBoxAxisXmax.Text = "" + trackBarAxisXmax.Value;
            zoomOffset = trackBarZoomScale.Value;
            textBoxMicroMs.Text = "" + trackBarMicroTime.Value;
            hardwareDelay = trackBarMicroTime.Value;
            comboBoxDaudRate.SelectedIndex = 0;
            comboBoxScreenColor.SelectedIndex = 0;
            //Chart
            // chartOsc.ChartAreas.Add("Screen");
            SetScreenColor();
            chartOsc.ChartAreas["Screen"].AxisX.Minimum = 0;
            chartOsc.ChartAreas["Screen"].AxisX.Maximum = Osc.measurLimit;
            chartOsc.ChartAreas["Screen"].AxisX.Interval = 1;
            chartOsc.ChartAreas["Screen"].AxisX.LineWidth = 3;
            chartOsc.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
            chartOsc.ChartAreas["Screen"].AxisY.Minimum = -5;
            chartOsc.ChartAreas["Screen"].AxisY.Maximum = 25;
            chartOsc.ChartAreas["Screen"].AxisY.Interval = 1;
            chartOsc.ChartAreas["Screen"].AxisY.LineWidth = 3;
            chartOsc.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
            //chartOsc.Series["CH1"].Color = Color.Red;
            chartOsc.Series["CH1"].BorderWidth = 2;
            //chartOsc.Series["CH2"].Color = Color.Yellow;
            chartOsc.Series["CH2"].BorderWidth = 2;
            SetGridIntervalY();
            SetGridIntervalX();
            //Annotation srart
            vlaStart.AxisX = chartOsc.ChartAreas["Screen"].AxisX;
            vlaStart.AllowMoving = false;
            vlaStart.IsInfinitive = true;
            vlaStart.ClipToChartArea = chartOsc.ChartAreas["Screen"].Name;
            vlaStart.Name = "F1";
            vlaStart.LineColor = Color.Blue;
            vlaStart.LineWidth = 2;        
            vlaStart.X = 0;
            chartOsc.Annotations.Add(vlaStart);
            //Annotation end
            vlaEnd.AxisX = chartOsc.ChartAreas["Screen"].AxisX;
            vlaEnd.AllowMoving = false;
            vlaEnd.IsInfinitive = true;
            vlaEnd.ClipToChartArea = chartOsc.ChartAreas["Screen"].Name;
            vlaEnd.Name = "F2";
            vlaEnd.LineColor = Color.Blue;
            vlaEnd.LineWidth = 2;   
            vlaEnd.X = 0;
            chartOsc.Annotations.Add(vlaEnd);
        }//initillize GUI


        
        //String To Double
        // Convert string numbers with ',' or '.' to double
        public static double StringToDouble(string str){
            char systemSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
            double result = 0;
            try {
                if (str != null)
                    if (!str.Contains(","))
                        result = double.Parse(str, CultureInfo.InvariantCulture);
                    else
                        result = Convert.ToDouble(str.Replace(".", systemSeparator.ToString()).Replace(",", systemSeparator.ToString()));
            }//try
            catch (Exception exp){
                try{
                    result = Convert.ToDouble(str);
                }//try
                catch{
                    try{  result = Convert.ToDouble(str.Replace(",", ";").Replace(".", ",").Replace(";", ".")); }
                    catch{
                        throw new Exception("Wrong string-to-double format");
                    }//catch
                }//catch
            }//catch
            return result;
        }// String To Double



        // Data Reader
        bool DataReader(string str){
            try{
                if (str == null) { return false; }
                if (str == "") { return false; }
                string ch1 = "null", ch2 = "null", time = "";
                string[] measures = str.Split(' '); //split string by space in measures
                int n = 0;
                // access all measures and store values
                foreach (string measure in measures){
                    // if item name=="x" the next item is value of x
                    if ((checkBoxCH1Enable.Checked) &&(measure == "CH1")) { ch1 = measures[n + 1]; }
                    if ((checkBoxCH2Enable.Checked) &&(measure == "CH2")) { ch2 = measures[n + 1]; }
                    if (measure == "T") { time = measures[n + 1]; }
                    n++;
                }//foreach
                //Set oscilloscope object from read data
                if (time == "") { Osc.timeStamp = 0; }//if not time on read data
                else{ Osc.timeStamp = Convert.ToInt64(time); }//else
                if (ch1 == "null"){
                    Osc.Ch1Enabled = false; //disable CH1
                } //if CH1 null
                else{
                    Osc.Ch1Enabled = true; //enable CH1
                    Osc.SetCH1Val(ch1);    //Set CH1
                }//else CH1 not null
                if (ch2 == "null"){
                    Osc.Ch2Enabled = false; //disable CH2
                }//if CH2 null
                else{
                    Osc.Ch2Enabled = true;  //enable CH2
                    Osc.SetCH2Val(ch2);     //Set CH2
                }//if CH2 not null
                return true;
            }//try
            catch(Exception exp){
                string msg = "An error occured during received data reading.\n Error: " + exp.Message;
                MessageBox.Show(msg);
                return false;
            }//catch
        }//DataReader



        // Read Serial Data
        void ReadSerialData(){
            try{
                int i = 0;
                if (serialPort.ReadChar() > 0) { serialPort.DiscardInBuffer(); }//clear buffer before start 
                Osc.ResetMinMax();  //reset object data
                while (true){
                    //serialPort.Write("R");
                    string dataRX = serialPort.ReadLine();  //Read incoming data
                    if (!DataReader(dataRX)) { continue; }  //if Data Reader fail, loop and try again
                    richTextBoxConsol.Invoke((MethodInvoker)delegate {
                        richTextBoxConsol.Text += dataRX; // show received data
                        currTime = Osc.timeStamp - prevTime;
                        prevTime = Osc.timeStamp;       //store last read timestamp
                        textBoxMesurePerSec.Text = "" + currTime;
                        if (Osc.Ch1Enabled) {
                            chartOsc.Series["CH1"].Points.AddY(Osc.CH1Val()); //plot CH1
                            textBoxCh1pp.Text = "" + string.Format("{0:#,##0.00}", Osc.GetCH1pp()); //set text with format
                        }//if CH1 Enabled
                        if (Osc.Ch2Enabled) {
                            chartOsc.Series["CH2"].Points.AddY(Osc.CH2Val()); //plot CH2
                            textBoxCh2pp.Text = "" + string.Format("{0:#,##0.00}", +Osc.GetCH2pp()); //set text with format
                        }//if CH2 Enabled
                        //if reatch the screen limit, clear oscilloscop screen
                        if (i >= Osc.measurLimit) {
                            ClearOscilloScreen();
                            i = 0;
                        }//if n loops
                        i++;
                        chartOsc.Update();
                        // auto scroll at received data text box
                        if (checkBoxConsolAutoScroll.Checked == true) {
                            richTextBoxConsol.SelectionStart = richTextBoxConsol.TextLength;
                            richTextBoxConsol.ScrollToCaret();
                        }//if AutoScroll Enabled
                    }); //Invoke
                }//while
            }//try
            catch(Exception exp){
            
            }//catch
           }//Read Serial Data



        // Fit Auto Range
        void FitAutoRange(){
            try{
                double dff = Osc.GetSreenPP(); //Calc peak to peak (max diff)
                if (dff < 1) {
                    if (dff == 0) { dff = 0.1; }//if 0 coorect the value
                    double tempValMin = Osc.GetSreenMin() - dff;
                    double tempValMax = Osc.GetSreenMax() + dff;
                    //if (tempValMin >= tempValMax) { return; }
                    chartOsc.ChartAreas["Screen"].AxisY.Minimum = tempValMin;
                    chartOsc.ChartAreas["Screen"].AxisY.Maximum = tempValMax;
                    chartOsc.ChartAreas["Screen"].AxisY.Interval = dff;
                }//if <1
                if ((dff >= 1) && (dff < 5)) {
                    //set screen limits + - 1 from max min corresponding
                    chartOsc.ChartAreas["Screen"].AxisY.Minimum = Osc.GetSreenMin() - 1;
                    chartOsc.ChartAreas["Screen"].AxisY.Maximum = Osc.GetSreenMax() + 1;
                    chartOsc.ChartAreas["Screen"].AxisY.Interval = dff / 10;
                }//if <1
                if ((dff >= 5) && (dff <= 25)){
                    chartOsc.ChartAreas["Screen"].AxisY.Minimum = Osc.GetSreenMin() - 1;
                    chartOsc.ChartAreas["Screen"].AxisY.Maximum = Osc.GetSreenMax() + 1;
                    chartOsc.ChartAreas["Screen"].AxisY.Interval = 1;
                }//if <1
                chartOsc.Update();
            }//try
            catch(Exception exp){
                string msg = "This action can not be performed because of the following problem: " + exp.Message;
                MessageBox.Show(msg);
            }//catch
        }//FitAutoRange



        //ClearOscilloScreen
        void ClearOscilloScreen() {
            foreach (var series in chartOsc.Series){
                series.Points.Clear();
            }//for all points
            Osc.ResetMinMax();
        }//ClearOscilloScreen



        // Scan Serial Ports
        void ScanSerialPorts() {
            try{
                comboBoxSerialPorts.Items.Clear();
                foreach (string serialName in SerialPort.GetPortNames()) {
                    comboBoxSerialPorts.Items.Add(serialName); // fill comboBox with all COMs
                }//foreach      
                comboBoxSerialPorts.SelectedIndex = comboBoxSerialPorts.Items.Count - 1; //select last
            }//try
            catch(Exception exp){
                string msg = "An error occured during the serial port scanning.\n Error: " + exp.Message;
                MessageBox.Show(msg);
            }//catch serial scan exception
        }//ScanSerialPorts



        //SetHardwareTime
        void SetHardwareTime() {
            try{
                if (serialPort != null){
                    if (serialPort.IsOpen){
                        serialPort.DiscardOutBuffer();
                        serialPort.Write("" + hardwareDelay+"\n");
                        if (serialPort.ReadChar() > 0) { serialPort.DiscardInBuffer(); };
                    }//if
                }//if serial not open
            }//try
            catch (Exception exp){
                string msg = "An error occured during the serial port write.\n Error: " + exp.Message;
                MessageBox.Show(msg);
            }//catch
        }//SetHardwareTime



        //Set Screen Color
        void SetScreenColor(){
            string screenColor=(string) comboBoxScreenColor.SelectedItem;
            if (screenColor=="White") {
                chartOsc.ChartAreas["Screen"].BackColor = Color.White;
                chartOsc.ChartAreas["Screen"].AxisX.MajorGrid.LineColor = Color.Black;
                chartOsc.ChartAreas["Screen"].AxisY.MajorGrid.LineColor = Color.Black;
                chartOsc.Series["CH1"].Color = Color.Red;
                chartOsc.Series["CH2"].Color = Color.Green;
            }//if
            else if (screenColor=="Black"){
                chartOsc.ChartAreas["Screen"].BackColor = Color.Black;
                chartOsc.ChartAreas["Screen"].AxisX.MajorGrid.LineColor = Color.Gray;
                chartOsc.ChartAreas["Screen"].AxisY.MajorGrid.LineColor = Color.Gray;
                chartOsc.Series["CH1"].Color = Color.Red;
                chartOsc.Series["CH2"].Color = Color.Yellow;
            }//if black
            else if (screenColor == "Green"){
                chartOsc.ChartAreas["Screen"].BackColor = Color.FromArgb(255, 60, 179, 113);
                chartOsc.ChartAreas["Screen"].AxisX.MajorGrid.LineColor = Color.Lime;
                chartOsc.ChartAreas["Screen"].AxisY.MajorGrid.LineColor = Color.Lime;
                chartOsc.Series["CH1"].Color = Color.Red;
                chartOsc.Series["CH2"].Color = Color.Blue;
            }//if black
        }//Set Screen Color


 
        // Set Grid Interval X
        void SetGridIntervalX() {
            double xGridInterval = trackBarGridX.Value;
            chartOsc.ChartAreas["Screen"].AxisX.Interval = xGridInterval;
            textBoxXgridPerUnitVal.Text = "" + xGridInterval;
        }//Set X interval



        // Set Grid Interval Y
        void SetGridIntervalY() {
            double yGridInterval = trackBarGridY.Value;
            if (yGridInterval == 0) { yGridInterval = 0.5; }//if 0
            else if (yGridInterval == -1) { yGridInterval = 0.2; }//if 0
            else if (yGridInterval == -2) { yGridInterval = 0.1; }//if 0
            chartOsc.ChartAreas["Screen"].AxisY.Interval = yGridInterval;
            textBoxYgridPerUnitVal.Text = "" + yGridInterval;
        }//Set Y interval



        // Osc Move Up
        // set screen at higher values
        void OscMoveUp() {
            chartOsc.ChartAreas["Screen"].AxisY.Minimum += zoomOffset;
            chartOsc.ChartAreas["Screen"].AxisY.Maximum += zoomOffset;
            chartOsc.Update();
        }//OscMoveUp



        // Osc Move Up
        // set screen at lower values
        void OscMoveDown(){
            chartOsc.ChartAreas["Screen"].AxisY.Minimum -= zoomOffset;
            chartOsc.ChartAreas["Screen"].AxisY.Maximum -= zoomOffset;
            chartOsc.Update();
        }//OscMoveDown



        // Osc Move Time Plus
        //Shift + in time
        void OscMoveTimePlus(){
            chartOsc.ChartAreas["Screen"].AxisX.Minimum += zoomOffset;
            chartOsc.ChartAreas["Screen"].AxisX.Maximum += zoomOffset;
            chartOsc.Update();
        }//OscMoveUp



        // Osc Move Time Plus
        //Shift - in time
        void OscMoveTimeMinus(){
            chartOsc.ChartAreas["Screen"].AxisX.Minimum -= zoomOffset;
            chartOsc.ChartAreas["Screen"].AxisX.Maximum -= zoomOffset;
            chartOsc.Update();
        }//OscMoveUp



  //HUNDLERS

        // Button Open Serial Click
        private void buttonOpenSerial_Click(object sender, EventArgs e) {
            try{
                chartOsc.Focus();
                string serPort = "" + comboBoxSerialPorts.SelectedItem;
                int serBaudrate = Convert.ToInt32( comboBoxDaudRate.SelectedItem);
                if (serPort == "") { return; }//if empty
                if (serialPort == null){
                    ClearOscilloScreen();
                    serialPort = new SerialPort();
                    serialPort.PortName = "" + serPort;
                    serialPort.BaudRate = serBaudrate;
                    serialPort.Open();
                    serialPort.DiscardInBuffer();
                    readSerialThread = new Thread(ReadSerialData);
                    buttonOpenSerial.Text = "Stop";
                    readSerialThread.Start();
                }//if not open
                else{
                    
                    serialPort.Close();
                    serialPort = null;
                    buttonOpenSerial.Text = "RUN";
                    readSerialThread.Abort();
                }//else
            }//try
            catch(Exception exp){
                string msg = "An erros has occured during the serial port opening."
                    +"\n Please check the port settings. \n Error:"+exp.Message;
                MessageBox.Show(msg);
            }//catch
        }// Button Open Serial Click



        //Button Consol CLear Click
        private void buttonConsolClear_Click(object sender, EventArgs e){
            richTextBoxConsol.Text = "";
            chartOsc.Focus();
        }//button Consol CLear Click

  

        //Button Zoom Out Click
        private void buttonZoomOut_Click(object sender, EventArgs e) {
            double tempMin = chartOsc.ChartAreas["Screen"].AxisY.Minimum - zoomOffset;
            double tempMax = chartOsc.ChartAreas["Screen"].AxisY.Maximum + zoomOffset;
            //if ((tempMin <= -25) || (tempMax >= 25)) { return; } //limit zoom out
            chartOsc.ChartAreas["Screen"].AxisY.Minimum -= zoomOffset;
            chartOsc.ChartAreas["Screen"].AxisY.Maximum += zoomOffset;
            chartOsc.Update();
        }//button Zoom Out Click

        

        //Button Zoom In Click
        private void buttonZoomIn_Click(object sender, EventArgs e) { 
            double tempMin= chartOsc.ChartAreas["Screen"].AxisY.Minimum;
            double tempMax = chartOsc.ChartAreas["Screen"].AxisY.Maximum;
            if (tempMin + zoomOffset >= tempMax - zoomOffset) { return; } //limit zoom in
            chartOsc.ChartAreas["Screen"].AxisY.Minimum += zoomOffset;
            chartOsc.ChartAreas["Screen"].AxisY.Maximum -= zoomOffset;            
            chartOsc.Update();
        }//button Zoom In Click



        //Button Move Up Click
        private void buttonMoveUp_Click(object sender, EventArgs e) {
            OscMoveUp();
        }//button Move Up Click



        //Button Move Down Click
        private void buttonMoveDown_Click(object sender, EventArgs e) {
            OscMoveDown();
        }//Button Move Down Click



        //TrackBar Zoom Scale Scroll
        private void trackBarZoomScale_Scroll(object sender, EventArgs e){
            int tempVal= trackBarZoomScale.Value;
            if (tempVal == 1) { zoomOffset = 0.1; }//if x0.10
            if(tempVal==2){zoomOffset=0.5;}//if x1
            if(tempVal==3){zoomOffset=3;}//if x4
        }//trackBar Zoom Scale Scroll



        //Button Auto Range
        private void buttonAutoRange_Click(object sender, EventArgs e) {
            FitAutoRange();
        }//button Auto Range



        //TrackBar Grid X Scroll
        private void trackBarGridX_Scroll(object sender, EventArgs e) {
            SetGridIntervalX();
        }//trackBar Grid X Scroll



        //TrackBar Grid Y Scroll
        private void trackBarGridY_Scroll(object sender, EventArgs e) {
            SetGridIntervalY();
        }//trackBar Grid Y Scroll



        //Form Main Key Down
        private void FormMain_KeyDown(object sender, KeyEventArgs e) {
            try
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    chartOsc.Focus();
                    if (e.KeyCode == Keys.Up)
                    {
                        OscMoveUp();
                    }//if Ctrl+UP
                    else if (e.KeyCode == Keys.Down)
                    {
                        OscMoveDown();
                    }//if Ctrl+DOWN
                    else if (e.KeyCode == Keys.Left)
                    {
                        OscMoveTimeMinus();
                    }//if Ctrl+DOWN
                    else if (e.KeyCode == Keys.Right)
                    {
                        OscMoveTimePlus();
                    }//if Ctrl+DOWN
                    if (e.KeyCode == Keys.Space)
                    {
                        if (serialPort != null)
                        {
                            serialPort.DiscardInBuffer();
                        }//if serialPort not null
                    }//if space
                }//if Ctrl
            }//try
            catch(Exception exp){
                string msg = "An erros has occured from the key you pressed."
                        + "\n Error:" + exp.Message;
                MessageBox.Show(msg);
            }//catch
        }//Form Main Key Down



        //Button Move Left Click
        private void buttonMoveLeft_Click(object sender, EventArgs e) {
            OscMoveTimeMinus();
        }//button Move Left Click



        //Button Move Right Click
        private void buttonMoveRight_Click(object sender, EventArgs e) {
            OscMoveTimePlus();
        }//button Move Right Click



        //Chart Osc Mouse Down
        private void chartOsc_MouseDown(object sender, MouseEventArgs e) {
            try{
                if (e.Button == MouseButtons.Left){
                    CHwaveStart = CHwaveEnd = 0;
                    double xValue = vlaStart.AxisX.PixelPositionToValue(e.X);
                    CHwaveStart = xValue;
                    vlaStart.X = xValue;
                    chartOsc.UpdateAnnotations();
                }//if left
                else if (e.Button == MouseButtons.Right){
                    double xValue = vlaEnd.AxisX.PixelPositionToValue(e.X);
                    CHwaveEnd = xValue;
                    vlaEnd.X = xValue;
                    textBoxFreq.Text = "" + string.Format("{0:#,##0.00}", +Osc.CalcFreq(CHwaveStart, CHwaveEnd, currTime));
                    chartOsc.UpdateAnnotations();
                }//else right
            }//try
            catch(Exception exp){
            }//catch
          }//chart Osc Mouse Down



        //Button Zoom In X Click
        private void buttonZoomInX_Click(object sender, EventArgs e) {
            double tempMin = chartOsc.ChartAreas["Screen"].AxisX.Minimum;
            double tempMax = chartOsc.ChartAreas["Screen"].AxisX.Maximum;
            if (tempMin + zoomOffset >= tempMax - zoomOffset) { return; } //limit zoom in
            chartOsc.ChartAreas["Screen"].AxisX.Minimum += zoomOffset;
            chartOsc.ChartAreas["Screen"].AxisX.Maximum -= zoomOffset;
            chartOsc.Update();
        }//button Zoom In X Click



        //Button Zoom Out X Click
        private void buttonZoomOutX_Click(object sender, EventArgs e) {
            chartOsc.ChartAreas["Screen"].AxisX.Minimum -= zoomOffset;
            chartOsc.ChartAreas["Screen"].AxisX.Maximum += zoomOffset;
            chartOsc.Update();
        }//button Zoom Out X Click



        //Button Scan Serial Ports Click
        private void buttonScanSerialPorts_Click(object sender, EventArgs e) {
            ScanSerialPorts();
        }//button Scan Serial Ports Click



        //TrackBar Axis X Max Scroll
        private void trackBarAxisXmax_Scroll(object sender, EventArgs e) {
            Osc.measurLimit= trackBarAxisXmax.Value;
            textBoxAxisXmax.Text = ""+Osc.measurLimit;
            chartOsc.ChartAreas["Screen"].AxisX.Maximum = Osc.measurLimit;
        }//trackBar Axis X Max Scroll



        //Button Refresh Signal Click
        private void buttonRefreshSignal_Click(object sender, EventArgs e) {
            try{
                if (serialPort != null){
                    if (serialPort.IsOpen) {
                        serialPort.DiscardInBuffer();
                    }//if isOpen 
                }//if serialPort not null
            }//try
            catch (Exception exp){
                string msg = "An error occured during the serial port clear buffer.\n Error: " + exp.Message;
                MessageBox.Show(msg);
            }//catch
        }//button Refresh Signal Click



        //TrackBar Micro Time Scroll
        private void trackBarMicroTime_Scroll(object sender, EventArgs e) {
            textBoxMicroMs.Text=""+ trackBarMicroTime.Value;
            hardwareDelay = trackBarMicroTime.Value;
        }//button Refresh Signal Click



        //Button Set Micro Time Click
        private void buttonSetMicroTime_Click(object sender, EventArgs e) {
            SetHardwareTime();
            chartOsc.Focus();
        }//button Set Micro Time Click



        //ComboBox Screen Color
        private void comboBoxScreenColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScreenColor();
        }//comboBox Screen Color



        //Button Clear Screen Click
        private void buttonClearScreen_Click(object sender, EventArgs e){
            ClearOscilloScreen();
        }//button Clear Screen Click
   
            //

    }//Form Main

}// namespace
