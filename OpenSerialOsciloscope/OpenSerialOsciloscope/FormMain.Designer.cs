namespace OpenSerialOsciloscope
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea28 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend28 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series55 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series56 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.richTextBoxConsol = new System.Windows.Forms.RichTextBox();
            this.buttonOpenSerial = new System.Windows.Forms.Button();
            this.checkBoxConsolAutoScroll = new System.Windows.Forms.CheckBox();
            this.buttonConsolClear = new System.Windows.Forms.Button();
            this.chartOsc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonZoomInY = new System.Windows.Forms.Button();
            this.buttonZoomOutY = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.trackBarZoomScale = new System.Windows.Forms.TrackBar();
            this.buttonAutoRange = new System.Windows.Forms.Button();
            this.labelChange01 = new System.Windows.Forms.Label();
            this.labelChange05 = new System.Windows.Forms.Label();
            this.labelChange3 = new System.Windows.Forms.Label();
            this.trackBarGridY = new System.Windows.Forms.TrackBar();
            this.trackBarGridX = new System.Windows.Forms.TrackBar();
            this.groupBoxGrid = new System.Windows.Forms.GroupBox();
            this.labelXunits = new System.Windows.Forms.Label();
            this.labelUnitY = new System.Windows.Forms.Label();
            this.labelXgridPerUnit = new System.Windows.Forms.Label();
            this.textBoxXgridPerUnitVal = new System.Windows.Forms.TextBox();
            this.textBoxYgridPerUnitVal = new System.Windows.Forms.TextBox();
            this.labelYgridPerUnit = new System.Windows.Forms.Label();
            this.labelVerticalPos = new System.Windows.Forms.Label();
            this.panelChangesStep = new System.Windows.Forms.Panel();
            this.labelStepOfChange = new System.Windows.Forms.Label();
            this.panelVertPos = new System.Windows.Forms.Panel();
            this.labelMoveDownHint = new System.Windows.Forms.Label();
            this.labelMoveUpHint = new System.Windows.Forms.Label();
            this.panelHorizPos = new System.Windows.Forms.Panel();
            this.labelMoveRightHint = new System.Windows.Forms.Label();
            this.labelMoveLeftHint = new System.Windows.Forms.Label();
            this.labelHorizontalPos = new System.Windows.Forms.Label();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.labelFreq = new System.Windows.Forms.Label();
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.textBoxCh1pp = new System.Windows.Forms.TextBox();
            this.labelCH1PP = new System.Windows.Forms.Label();
            this.textBoxCh2pp = new System.Windows.Forms.TextBox();
            this.labelCH2PP = new System.Windows.Forms.Label();
            this.panelConsolPanel = new System.Windows.Forms.Panel();
            this.labelSerialData = new System.Windows.Forms.Label();
            this.textBoxMesurePerSec = new System.Windows.Forms.TextBox();
            this.labelMeasurePerSec = new System.Windows.Forms.Label();
            this.buttonZoomOutX = new System.Windows.Forms.Button();
            this.buttonZoomInX = new System.Windows.Forms.Button();
            this.labelVerticalZoom = new System.Windows.Forms.Label();
            this.panelVertZoom = new System.Windows.Forms.Panel();
            this.panelHorizZoom = new System.Windows.Forms.Panel();
            this.labelHorizZoom = new System.Windows.Forms.Label();
            this.panelChannelsSets = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRefreshSignal = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonScanSerialPorts = new System.Windows.Forms.Button();
            this.comboBoxSerialPorts = new System.Windows.Forms.ComboBox();
            this.textBoxAxisXmax = new System.Windows.Forms.TextBox();
            this.trackBarAxisXmax = new System.Windows.Forms.TrackBar();
            this.labelAxisXmax = new System.Windows.Forms.Label();
            this.groupBoxMicrocontroller = new System.Windows.Forms.GroupBox();
            this.buttonSetMicroTime = new System.Windows.Forms.Button();
            this.labelMicrocontrollerMS = new System.Windows.Forms.Label();
            this.labelMicroSetTime = new System.Windows.Forms.Label();
            this.textBoxMicroMs = new System.Windows.Forms.TextBox();
            this.trackBarMicroTime = new System.Windows.Forms.TrackBar();
            this.comboBoxDaudRate = new System.Windows.Forms.ComboBox();
            this.groupBoxSerialPort = new System.Windows.Forms.GroupBox();
            this.comboBoxScreenColor = new System.Windows.Forms.ComboBox();
            this.groupBoxScreen = new System.Windows.Forms.GroupBox();
            this.labelScreenStyle = new System.Windows.Forms.Label();
            this.buttonClearScreen = new System.Windows.Forms.Button();
            this.checkBoxCH1Enable = new System.Windows.Forms.CheckBox();
            this.checkBoxCH2Enable = new System.Windows.Forms.CheckBox();
            this.panelCHEnable = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartOsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoomScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGridY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGridX)).BeginInit();
            this.groupBoxGrid.SuspendLayout();
            this.panelChangesStep.SuspendLayout();
            this.panelVertPos.SuspendLayout();
            this.panelHorizPos.SuspendLayout();
            this.panelConsolPanel.SuspendLayout();
            this.panelVertZoom.SuspendLayout();
            this.panelHorizZoom.SuspendLayout();
            this.panelChannelsSets.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAxisXmax)).BeginInit();
            this.groupBoxMicrocontroller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMicroTime)).BeginInit();
            this.groupBoxSerialPort.SuspendLayout();
            this.groupBoxScreen.SuspendLayout();
            this.panelCHEnable.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxConsol
            // 
            this.richTextBoxConsol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxConsol.Location = new System.Drawing.Point(3, 35);
            this.richTextBoxConsol.Name = "richTextBoxConsol";
            this.richTextBoxConsol.ReadOnly = true;
            this.richTextBoxConsol.Size = new System.Drawing.Size(260, 62);
            this.richTextBoxConsol.TabIndex = 0;
            this.richTextBoxConsol.Text = "";
            // 
            // buttonOpenSerial
            // 
            this.buttonOpenSerial.Location = new System.Drawing.Point(339, 10);
            this.buttonOpenSerial.Name = "buttonOpenSerial";
            this.buttonOpenSerial.Size = new System.Drawing.Size(72, 30);
            this.buttonOpenSerial.TabIndex = 6;
            this.buttonOpenSerial.Text = "RUN";
            this.buttonOpenSerial.UseVisualStyleBackColor = true;
            this.buttonOpenSerial.Click += new System.EventHandler(this.buttonOpenSerial_Click);
            // 
            // checkBoxConsolAutoScroll
            // 
            this.checkBoxConsolAutoScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxConsolAutoScroll.AutoSize = true;
            this.checkBoxConsolAutoScroll.Checked = true;
            this.checkBoxConsolAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxConsolAutoScroll.Location = new System.Drawing.Point(105, 15);
            this.checkBoxConsolAutoScroll.Name = "checkBoxConsolAutoScroll";
            this.checkBoxConsolAutoScroll.Size = new System.Drawing.Size(77, 17);
            this.checkBoxConsolAutoScroll.TabIndex = 3;
            this.checkBoxConsolAutoScroll.Text = "Auto Scroll";
            this.checkBoxConsolAutoScroll.UseVisualStyleBackColor = true;
            // 
            // buttonConsolClear
            // 
            this.buttonConsolClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonConsolClear.Location = new System.Drawing.Point(191, 9);
            this.buttonConsolClear.Name = "buttonConsolClear";
            this.buttonConsolClear.Size = new System.Drawing.Size(72, 26);
            this.buttonConsolClear.TabIndex = 4;
            this.buttonConsolClear.Text = "Clear";
            this.buttonConsolClear.UseVisualStyleBackColor = true;
            this.buttonConsolClear.Click += new System.EventHandler(this.buttonConsolClear_Click);
            // 
            // chartOsc
            // 
            this.chartOsc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartOsc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.chartOsc.BorderSkin.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.chartOsc.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke;
            this.chartOsc.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea28.Name = "Screen";
            this.chartOsc.ChartAreas.Add(chartArea28);
            legend28.Name = "Legend1";
            this.chartOsc.Legends.Add(legend28);
            this.chartOsc.Location = new System.Drawing.Point(12, 46);
            this.chartOsc.Name = "chartOsc";
            series55.ChartArea = "Screen";
            series55.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series55.Legend = "Legend1";
            series55.Name = "CH1";
            series56.ChartArea = "Screen";
            series56.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series56.Legend = "Legend1";
            series56.Name = "CH2";
            this.chartOsc.Series.Add(series55);
            this.chartOsc.Series.Add(series56);
            this.chartOsc.Size = new System.Drawing.Size(643, 385);
            this.chartOsc.TabIndex = 1;
            this.chartOsc.Text = "Oscilloscope";
            this.chartOsc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chartOsc_MouseDown);
            // 
            // buttonZoomInY
            // 
            this.buttonZoomInY.Image = ((System.Drawing.Image)(resources.GetObject("buttonZoomInY.Image")));
            this.buttonZoomInY.Location = new System.Drawing.Point(20, 14);
            this.buttonZoomInY.Name = "buttonZoomInY";
            this.buttonZoomInY.Size = new System.Drawing.Size(34, 30);
            this.buttonZoomInY.TabIndex = 7;
            this.buttonZoomInY.UseVisualStyleBackColor = true;
            this.buttonZoomInY.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonZoomOutY
            // 
            this.buttonZoomOutY.Image = ((System.Drawing.Image)(resources.GetObject("buttonZoomOutY.Image")));
            this.buttonZoomOutY.Location = new System.Drawing.Point(20, 76);
            this.buttonZoomOutY.Name = "buttonZoomOutY";
            this.buttonZoomOutY.Size = new System.Drawing.Size(34, 30);
            this.buttonZoomOutY.TabIndex = 8;
            this.buttonZoomOutY.UseVisualStyleBackColor = true;
            this.buttonZoomOutY.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveUp.Image")));
            this.buttonMoveUp.Location = new System.Drawing.Point(23, 16);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(34, 30);
            this.buttonMoveUp.TabIndex = 9;
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveDown.Image")));
            this.buttonMoveDown.Location = new System.Drawing.Point(23, 78);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(34, 30);
            this.buttonMoveDown.TabIndex = 10;
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // trackBarZoomScale
            // 
            this.trackBarZoomScale.LargeChange = 1;
            this.trackBarZoomScale.Location = new System.Drawing.Point(4, 16);
            this.trackBarZoomScale.Maximum = 3;
            this.trackBarZoomScale.Minimum = 1;
            this.trackBarZoomScale.Name = "trackBarZoomScale";
            this.trackBarZoomScale.Size = new System.Drawing.Size(104, 45);
            this.trackBarZoomScale.TabIndex = 11;
            this.toolTip.SetToolTip(this.trackBarZoomScale, "The step off any change");
            this.trackBarZoomScale.Value = 2;
            this.trackBarZoomScale.Scroll += new System.EventHandler(this.trackBarZoomScale_Scroll);
            // 
            // buttonAutoRange
            // 
            this.buttonAutoRange.Location = new System.Drawing.Point(547, 10);
            this.buttonAutoRange.Name = "buttonAutoRange";
            this.buttonAutoRange.Size = new System.Drawing.Size(78, 30);
            this.buttonAutoRange.TabIndex = 12;
            this.buttonAutoRange.Text = "Auto- Range";
            this.buttonAutoRange.UseVisualStyleBackColor = true;
            this.buttonAutoRange.Click += new System.EventHandler(this.buttonAutoRange_Click);
            // 
            // labelChange01
            // 
            this.labelChange01.AutoSize = true;
            this.labelChange01.Location = new System.Drawing.Point(8, 46);
            this.labelChange01.Name = "labelChange01";
            this.labelChange01.Size = new System.Drawing.Size(22, 13);
            this.labelChange01.TabIndex = 13;
            this.labelChange01.Text = "0.1";
            this.toolTip.SetToolTip(this.labelChange01, "The step off any change");
            // 
            // labelChange05
            // 
            this.labelChange05.AutoSize = true;
            this.labelChange05.Location = new System.Drawing.Point(50, 46);
            this.labelChange05.Name = "labelChange05";
            this.labelChange05.Size = new System.Drawing.Size(22, 13);
            this.labelChange05.TabIndex = 14;
            this.labelChange05.Text = "0.5";
            this.toolTip.SetToolTip(this.labelChange05, "The step off any change");
            // 
            // labelChange3
            // 
            this.labelChange3.AutoSize = true;
            this.labelChange3.Location = new System.Drawing.Point(93, 46);
            this.labelChange3.Name = "labelChange3";
            this.labelChange3.Size = new System.Drawing.Size(13, 13);
            this.labelChange3.TabIndex = 15;
            this.labelChange3.Text = "3";
            this.toolTip.SetToolTip(this.labelChange3, "The step off any change");
            // 
            // trackBarGridY
            // 
            this.trackBarGridY.Location = new System.Drawing.Point(54, 16);
            this.trackBarGridY.Minimum = -2;
            this.trackBarGridY.Name = "trackBarGridY";
            this.trackBarGridY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGridY.Size = new System.Drawing.Size(45, 104);
            this.trackBarGridY.TabIndex = 16;
            this.trackBarGridY.Value = 2;
            this.trackBarGridY.Scroll += new System.EventHandler(this.trackBarGridY_Scroll);
            // 
            // trackBarGridX
            // 
            this.trackBarGridX.Location = new System.Drawing.Point(97, 63);
            this.trackBarGridX.Maximum = 20;
            this.trackBarGridX.Minimum = 2;
            this.trackBarGridX.Name = "trackBarGridX";
            this.trackBarGridX.Size = new System.Drawing.Size(118, 45);
            this.trackBarGridX.TabIndex = 17;
            this.trackBarGridX.Value = 5;
            this.trackBarGridX.Scroll += new System.EventHandler(this.trackBarGridX_Scroll);
            // 
            // groupBoxGrid
            // 
            this.groupBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxGrid.Controls.Add(this.labelXunits);
            this.groupBoxGrid.Controls.Add(this.labelUnitY);
            this.groupBoxGrid.Controls.Add(this.labelXgridPerUnit);
            this.groupBoxGrid.Controls.Add(this.trackBarGridY);
            this.groupBoxGrid.Controls.Add(this.textBoxXgridPerUnitVal);
            this.groupBoxGrid.Controls.Add(this.textBoxYgridPerUnitVal);
            this.groupBoxGrid.Controls.Add(this.labelYgridPerUnit);
            this.groupBoxGrid.Controls.Add(this.trackBarGridX);
            this.groupBoxGrid.Location = new System.Drawing.Point(534, 442);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Size = new System.Drawing.Size(219, 120);
            this.groupBoxGrid.TabIndex = 18;
            this.groupBoxGrid.TabStop = false;
            this.groupBoxGrid.Text = "Grid Settings";
            // 
            // labelXunits
            // 
            this.labelXunits.AutoSize = true;
            this.labelXunits.Location = new System.Drawing.Point(164, 51);
            this.labelXunits.Name = "labelXunits";
            this.labelXunits.Size = new System.Drawing.Size(31, 13);
            this.labelXunits.TabIndex = 39;
            this.labelXunits.Text = "Units";
            // 
            // labelUnitY
            // 
            this.labelUnitY.AutoSize = true;
            this.labelUnitY.Location = new System.Drawing.Point(15, 84);
            this.labelUnitY.Name = "labelUnitY";
            this.labelUnitY.Size = new System.Drawing.Size(31, 13);
            this.labelUnitY.TabIndex = 22;
            this.labelUnitY.Text = "Units";
            // 
            // labelXgridPerUnit
            // 
            this.labelXgridPerUnit.Location = new System.Drawing.Point(108, 29);
            this.labelXgridPerUnit.Name = "labelXgridPerUnit";
            this.labelXgridPerUnit.Size = new System.Drawing.Size(53, 29);
            this.labelXgridPerUnit.TabIndex = 20;
            this.labelXgridPerUnit.Text = "X  Grid every";
            this.labelXgridPerUnit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxXgridPerUnitVal
            // 
            this.textBoxXgridPerUnitVal.Location = new System.Drawing.Point(167, 29);
            this.textBoxXgridPerUnitVal.Name = "textBoxXgridPerUnitVal";
            this.textBoxXgridPerUnitVal.ReadOnly = true;
            this.textBoxXgridPerUnitVal.Size = new System.Drawing.Size(25, 20);
            this.textBoxXgridPerUnitVal.TabIndex = 21;
            // 
            // textBoxYgridPerUnitVal
            // 
            this.textBoxYgridPerUnitVal.Location = new System.Drawing.Point(19, 63);
            this.textBoxYgridPerUnitVal.Name = "textBoxYgridPerUnitVal";
            this.textBoxYgridPerUnitVal.ReadOnly = true;
            this.textBoxYgridPerUnitVal.Size = new System.Drawing.Size(25, 20);
            this.textBoxYgridPerUnitVal.TabIndex = 19;
            // 
            // labelYgridPerUnit
            // 
            this.labelYgridPerUnit.Location = new System.Drawing.Point(3, 34);
            this.labelYgridPerUnit.Name = "labelYgridPerUnit";
            this.labelYgridPerUnit.Size = new System.Drawing.Size(56, 29);
            this.labelYgridPerUnit.TabIndex = 18;
            this.labelYgridPerUnit.Text = "Y  Grid every";
            this.labelYgridPerUnit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelVerticalPos
            // 
            this.labelVerticalPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelVerticalPos.Location = new System.Drawing.Point(12, 49);
            this.labelVerticalPos.Name = "labelVerticalPos";
            this.labelVerticalPos.Size = new System.Drawing.Size(56, 29);
            this.labelVerticalPos.TabIndex = 19;
            this.labelVerticalPos.Text = "Vertical Position";
            this.labelVerticalPos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelChangesStep
            // 
            this.panelChangesStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChangesStep.BackColor = System.Drawing.SystemColors.Control;
            this.panelChangesStep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelChangesStep.Controls.Add(this.labelStepOfChange);
            this.panelChangesStep.Controls.Add(this.labelChange3);
            this.panelChangesStep.Controls.Add(this.labelChange05);
            this.panelChangesStep.Controls.Add(this.labelChange01);
            this.panelChangesStep.Controls.Add(this.trackBarZoomScale);
            this.panelChangesStep.Location = new System.Drawing.Point(44, 145);
            this.panelChangesStep.Name = "panelChangesStep";
            this.panelChangesStep.Size = new System.Drawing.Size(113, 63);
            this.panelChangesStep.TabIndex = 20;
            this.toolTip.SetToolTip(this.panelChangesStep, "The step off any change");
            // 
            // labelStepOfChange
            // 
            this.labelStepOfChange.AutoSize = true;
            this.labelStepOfChange.Location = new System.Drawing.Point(42, 1);
            this.labelStepOfChange.Name = "labelStepOfChange";
            this.labelStepOfChange.Size = new System.Drawing.Size(29, 13);
            this.labelStepOfChange.TabIndex = 16;
            this.labelStepOfChange.Text = "Step";
            // 
            // panelVertPos
            // 
            this.panelVertPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVertPos.BackColor = System.Drawing.SystemColors.Control;
            this.panelVertPos.Controls.Add(this.labelMoveDownHint);
            this.panelVertPos.Controls.Add(this.labelMoveUpHint);
            this.panelVertPos.Controls.Add(this.labelVerticalPos);
            this.panelVertPos.Controls.Add(this.buttonMoveDown);
            this.panelVertPos.Controls.Add(this.buttonMoveUp);
            this.panelVertPos.Location = new System.Drawing.Point(9, 7);
            this.panelVertPos.Name = "panelVertPos";
            this.panelVertPos.Size = new System.Drawing.Size(85, 130);
            this.panelVertPos.TabIndex = 21;
            // 
            // labelMoveDownHint
            // 
            this.labelMoveDownHint.AutoSize = true;
            this.labelMoveDownHint.Location = new System.Drawing.Point(12, 108);
            this.labelMoveDownHint.Name = "labelMoveDownHint";
            this.labelMoveDownHint.Size = new System.Drawing.Size(56, 13);
            this.labelMoveDownHint.TabIndex = 21;
            this.labelMoveDownHint.Text = "Ctrl+Down";
            // 
            // labelMoveUpHint
            // 
            this.labelMoveUpHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMoveUpHint.AutoSize = true;
            this.labelMoveUpHint.Location = new System.Drawing.Point(20, 3);
            this.labelMoveUpHint.Name = "labelMoveUpHint";
            this.labelMoveUpHint.Size = new System.Drawing.Size(42, 13);
            this.labelMoveUpHint.TabIndex = 20;
            this.labelMoveUpHint.Text = "Ctrl+Up";
            // 
            // panelHorizPos
            // 
            this.panelHorizPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHorizPos.BackColor = System.Drawing.SystemColors.Control;
            this.panelHorizPos.Controls.Add(this.labelMoveRightHint);
            this.panelHorizPos.Controls.Add(this.labelMoveLeftHint);
            this.panelHorizPos.Controls.Add(this.labelHorizontalPos);
            this.panelHorizPos.Controls.Add(this.buttonMoveRight);
            this.panelHorizPos.Controls.Add(this.buttonMoveLeft);
            this.panelHorizPos.Location = new System.Drawing.Point(7, 215);
            this.panelHorizPos.Name = "panelHorizPos";
            this.panelHorizPos.Size = new System.Drawing.Size(177, 53);
            this.panelHorizPos.TabIndex = 22;
            // 
            // labelMoveRightHint
            // 
            this.labelMoveRightHint.AutoSize = true;
            this.labelMoveRightHint.Location = new System.Drawing.Point(117, 4);
            this.labelMoveRightHint.Name = "labelMoveRightHint";
            this.labelMoveRightHint.Size = new System.Drawing.Size(53, 13);
            this.labelMoveRightHint.TabIndex = 21;
            this.labelMoveRightHint.Text = "Ctrl+Right";
            // 
            // labelMoveLeftHint
            // 
            this.labelMoveLeftHint.AutoSize = true;
            this.labelMoveLeftHint.Location = new System.Drawing.Point(9, 3);
            this.labelMoveLeftHint.Name = "labelMoveLeftHint";
            this.labelMoveLeftHint.Size = new System.Drawing.Size(46, 13);
            this.labelMoveLeftHint.TabIndex = 20;
            this.labelMoveLeftHint.Text = "Ctrl+Left";
            // 
            // labelHorizontalPos
            // 
            this.labelHorizontalPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelHorizontalPos.Location = new System.Drawing.Point(52, 17);
            this.labelHorizontalPos.Name = "labelHorizontalPos";
            this.labelHorizontalPos.Size = new System.Drawing.Size(71, 29);
            this.labelHorizontalPos.TabIndex = 19;
            this.labelHorizontalPos.Text = "Horizontal Position";
            this.labelHorizontalPos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveRight.Image")));
            this.buttonMoveRight.Location = new System.Drawing.Point(126, 17);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(34, 30);
            this.buttonMoveRight.TabIndex = 10;
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoveLeft.Image")));
            this.buttonMoveLeft.Location = new System.Drawing.Point(15, 16);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(34, 30);
            this.buttonMoveLeft.TabIndex = 9;
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // labelFreq
            // 
            this.labelFreq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFreq.AutoSize = true;
            this.labelFreq.Location = new System.Drawing.Point(535, 270);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(53, 13);
            this.labelFreq.TabIndex = 23;
            this.labelFreq.Text = "Freq (Hz):";
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFreq.Location = new System.Drawing.Point(593, 267);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.ReadOnly = true;
            this.textBoxFreq.Size = new System.Drawing.Size(48, 20);
            this.textBoxFreq.TabIndex = 24;
            // 
            // textBoxCh1pp
            // 
            this.textBoxCh1pp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCh1pp.Location = new System.Drawing.Point(596, 189);
            this.textBoxCh1pp.Name = "textBoxCh1pp";
            this.textBoxCh1pp.ReadOnly = true;
            this.textBoxCh1pp.Size = new System.Drawing.Size(45, 20);
            this.textBoxCh1pp.TabIndex = 26;
            // 
            // labelCH1PP
            // 
            this.labelCH1PP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCH1PP.AutoSize = true;
            this.labelCH1PP.Location = new System.Drawing.Point(535, 192);
            this.labelCH1PP.Name = "labelCH1PP";
            this.labelCH1PP.Size = new System.Drawing.Size(55, 13);
            this.labelCH1PP.TabIndex = 25;
            this.labelCH1PP.Text = "CH1 (p-p):";
            // 
            // textBoxCh2pp
            // 
            this.textBoxCh2pp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCh2pp.Location = new System.Drawing.Point(596, 215);
            this.textBoxCh2pp.Name = "textBoxCh2pp";
            this.textBoxCh2pp.ReadOnly = true;
            this.textBoxCh2pp.Size = new System.Drawing.Size(45, 20);
            this.textBoxCh2pp.TabIndex = 28;
            // 
            // labelCH2PP
            // 
            this.labelCH2PP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCH2PP.AutoSize = true;
            this.labelCH2PP.Location = new System.Drawing.Point(535, 218);
            this.labelCH2PP.Name = "labelCH2PP";
            this.labelCH2PP.Size = new System.Drawing.Size(55, 13);
            this.labelCH2PP.TabIndex = 27;
            this.labelCH2PP.Text = "CH2 (p-p):";
            // 
            // panelConsolPanel
            // 
            this.panelConsolPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelConsolPanel.Controls.Add(this.labelSerialData);
            this.panelConsolPanel.Controls.Add(this.richTextBoxConsol);
            this.panelConsolPanel.Controls.Add(this.buttonConsolClear);
            this.panelConsolPanel.Controls.Add(this.checkBoxConsolAutoScroll);
            this.panelConsolPanel.Location = new System.Drawing.Point(11, 453);
            this.panelConsolPanel.Name = "panelConsolPanel";
            this.panelConsolPanel.Size = new System.Drawing.Size(277, 106);
            this.panelConsolPanel.TabIndex = 29;
            // 
            // labelSerialData
            // 
            this.labelSerialData.AutoSize = true;
            this.labelSerialData.Location = new System.Drawing.Point(3, 18);
            this.labelSerialData.Name = "labelSerialData";
            this.labelSerialData.Size = new System.Drawing.Size(62, 13);
            this.labelSerialData.TabIndex = 5;
            this.labelSerialData.Text = "Serial Data:";
            // 
            // textBoxMesurePerSec
            // 
            this.textBoxMesurePerSec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMesurePerSec.Location = new System.Drawing.Point(612, 303);
            this.textBoxMesurePerSec.Name = "textBoxMesurePerSec";
            this.textBoxMesurePerSec.ReadOnly = true;
            this.textBoxMesurePerSec.Size = new System.Drawing.Size(29, 20);
            this.textBoxMesurePerSec.TabIndex = 31;
            // 
            // labelMeasurePerSec
            // 
            this.labelMeasurePerSec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMeasurePerSec.AutoSize = true;
            this.labelMeasurePerSec.Location = new System.Drawing.Point(535, 306);
            this.labelMeasurePerSec.Name = "labelMeasurePerSec";
            this.labelMeasurePerSec.Size = new System.Drawing.Size(71, 13);
            this.labelMeasurePerSec.TabIndex = 30;
            this.labelMeasurePerSec.Text = "mS/Measure:";
            // 
            // buttonZoomOutX
            // 
            this.buttonZoomOutX.Image = ((System.Drawing.Image)(resources.GetObject("buttonZoomOutX.Image")));
            this.buttonZoomOutX.Location = new System.Drawing.Point(126, 10);
            this.buttonZoomOutX.Name = "buttonZoomOutX";
            this.buttonZoomOutX.Size = new System.Drawing.Size(34, 30);
            this.buttonZoomOutX.TabIndex = 33;
            this.buttonZoomOutX.UseVisualStyleBackColor = true;
            this.buttonZoomOutX.Click += new System.EventHandler(this.buttonZoomOutX_Click);
            // 
            // buttonZoomInX
            // 
            this.buttonZoomInX.Image = ((System.Drawing.Image)(resources.GetObject("buttonZoomInX.Image")));
            this.buttonZoomInX.Location = new System.Drawing.Point(17, 10);
            this.buttonZoomInX.Name = "buttonZoomInX";
            this.buttonZoomInX.Size = new System.Drawing.Size(34, 30);
            this.buttonZoomInX.TabIndex = 32;
            this.buttonZoomInX.UseVisualStyleBackColor = true;
            this.buttonZoomInX.Click += new System.EventHandler(this.buttonZoomInX_Click);
            // 
            // labelVerticalZoom
            // 
            this.labelVerticalZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelVerticalZoom.Location = new System.Drawing.Point(8, 47);
            this.labelVerticalZoom.Name = "labelVerticalZoom";
            this.labelVerticalZoom.Size = new System.Drawing.Size(56, 29);
            this.labelVerticalZoom.TabIndex = 34;
            this.labelVerticalZoom.Text = "Vertical Zoom";
            this.labelVerticalZoom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelVertZoom
            // 
            this.panelVertZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVertZoom.BackColor = System.Drawing.SystemColors.Control;
            this.panelVertZoom.Controls.Add(this.labelVerticalZoom);
            this.panelVertZoom.Controls.Add(this.buttonZoomOutY);
            this.panelVertZoom.Controls.Add(this.buttonZoomInY);
            this.panelVertZoom.Location = new System.Drawing.Point(109, 7);
            this.panelVertZoom.Name = "panelVertZoom";
            this.panelVertZoom.Size = new System.Drawing.Size(75, 130);
            this.panelVertZoom.TabIndex = 35;
            // 
            // panelHorizZoom
            // 
            this.panelHorizZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHorizZoom.BackColor = System.Drawing.SystemColors.Control;
            this.panelHorizZoom.Controls.Add(this.labelHorizZoom);
            this.panelHorizZoom.Controls.Add(this.buttonZoomInX);
            this.panelHorizZoom.Controls.Add(this.buttonZoomOutX);
            this.panelHorizZoom.Location = new System.Drawing.Point(7, 273);
            this.panelHorizZoom.Name = "panelHorizZoom";
            this.panelHorizZoom.Size = new System.Drawing.Size(177, 53);
            this.panelHorizZoom.TabIndex = 36;
            // 
            // labelHorizZoom
            // 
            this.labelHorizZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelHorizZoom.Location = new System.Drawing.Point(52, 12);
            this.labelHorizZoom.Name = "labelHorizZoom";
            this.labelHorizZoom.Size = new System.Drawing.Size(71, 29);
            this.labelHorizZoom.TabIndex = 22;
            this.labelHorizZoom.Text = "Horizontal Zoom";
            this.labelHorizZoom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelChannelsSets
            // 
            this.panelChannelsSets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChannelsSets.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelChannelsSets.Controls.Add(this.panel1);
            this.panelChannelsSets.Controls.Add(this.panelHorizZoom);
            this.panelChannelsSets.Controls.Add(this.panelVertZoom);
            this.panelChannelsSets.Controls.Add(this.panelHorizPos);
            this.panelChannelsSets.Controls.Add(this.panelChangesStep);
            this.panelChannelsSets.Controls.Add(this.panelVertPos);
            this.panelChannelsSets.Location = new System.Drawing.Point(656, 46);
            this.panelChannelsSets.Name = "panelChannelsSets";
            this.panelChannelsSets.Size = new System.Drawing.Size(192, 388);
            this.panelChannelsSets.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonRefreshSignal);
            this.panel1.Location = new System.Drawing.Point(9, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 50);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ctrl+Space";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(62, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Refresh Signal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonRefreshSignal
            // 
            this.buttonRefreshSignal.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefreshSignal.Image")));
            this.buttonRefreshSignal.Location = new System.Drawing.Point(22, 16);
            this.buttonRefreshSignal.Name = "buttonRefreshSignal";
            this.buttonRefreshSignal.Size = new System.Drawing.Size(34, 30);
            this.buttonRefreshSignal.TabIndex = 9;
            this.buttonRefreshSignal.UseVisualStyleBackColor = true;
            this.buttonRefreshSignal.Click += new System.EventHandler(this.buttonRefreshSignal_Click);
            // 
            // buttonScanSerialPorts
            // 
            this.buttonScanSerialPorts.Location = new System.Drawing.Point(6, 16);
            this.buttonScanSerialPorts.Name = "buttonScanSerialPorts";
            this.buttonScanSerialPorts.Size = new System.Drawing.Size(75, 23);
            this.buttonScanSerialPorts.TabIndex = 18;
            this.buttonScanSerialPorts.Text = "Scan Ports";
            this.buttonScanSerialPorts.UseVisualStyleBackColor = true;
            this.buttonScanSerialPorts.Click += new System.EventHandler(this.buttonScanSerialPorts_Click);
            // 
            // comboBoxSerialPorts
            // 
            this.comboBoxSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialPorts.FormattingEnabled = true;
            this.comboBoxSerialPorts.Location = new System.Drawing.Point(93, 18);
            this.comboBoxSerialPorts.Name = "comboBoxSerialPorts";
            this.comboBoxSerialPorts.Size = new System.Drawing.Size(63, 21);
            this.comboBoxSerialPorts.Sorted = true;
            this.comboBoxSerialPorts.TabIndex = 38;
            // 
            // textBoxAxisXmax
            // 
            this.textBoxAxisXmax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAxisXmax.Location = new System.Drawing.Point(608, 371);
            this.textBoxAxisXmax.Name = "textBoxAxisXmax";
            this.textBoxAxisXmax.ReadOnly = true;
            this.textBoxAxisXmax.Size = new System.Drawing.Size(33, 20);
            this.textBoxAxisXmax.TabIndex = 39;
            // 
            // trackBarAxisXmax
            // 
            this.trackBarAxisXmax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarAxisXmax.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.trackBarAxisXmax.LargeChange = 1;
            this.trackBarAxisXmax.Location = new System.Drawing.Point(532, 365);
            this.trackBarAxisXmax.Maximum = 1000;
            this.trackBarAxisXmax.Minimum = 10;
            this.trackBarAxisXmax.Name = "trackBarAxisXmax";
            this.trackBarAxisXmax.Size = new System.Drawing.Size(78, 45);
            this.trackBarAxisXmax.TabIndex = 40;
            this.trackBarAxisXmax.Value = 100;
            this.trackBarAxisXmax.Scroll += new System.EventHandler(this.trackBarAxisXmax_Scroll);
            // 
            // labelAxisXmax
            // 
            this.labelAxisXmax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAxisXmax.AutoSize = true;
            this.labelAxisXmax.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelAxisXmax.Location = new System.Drawing.Point(541, 391);
            this.labelAxisXmax.Name = "labelAxisXmax";
            this.labelAxisXmax.Size = new System.Drawing.Size(62, 13);
            this.labelAxisXmax.TabIndex = 41;
            this.labelAxisXmax.Text = "X measures";
            // 
            // groupBoxMicrocontroller
            // 
            this.groupBoxMicrocontroller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxMicrocontroller.Controls.Add(this.buttonSetMicroTime);
            this.groupBoxMicrocontroller.Controls.Add(this.labelMicrocontrollerMS);
            this.groupBoxMicrocontroller.Controls.Add(this.labelMicroSetTime);
            this.groupBoxMicrocontroller.Controls.Add(this.textBoxMicroMs);
            this.groupBoxMicrocontroller.Controls.Add(this.trackBarMicroTime);
            this.groupBoxMicrocontroller.Location = new System.Drawing.Point(294, 440);
            this.groupBoxMicrocontroller.Name = "groupBoxMicrocontroller";
            this.groupBoxMicrocontroller.Size = new System.Drawing.Size(125, 120);
            this.groupBoxMicrocontroller.TabIndex = 42;
            this.groupBoxMicrocontroller.TabStop = false;
            this.groupBoxMicrocontroller.Text = "Hardware Settings";
            // 
            // buttonSetMicroTime
            // 
            this.buttonSetMicroTime.Location = new System.Drawing.Point(32, 22);
            this.buttonSetMicroTime.Name = "buttonSetMicroTime";
            this.buttonSetMicroTime.Size = new System.Drawing.Size(59, 23);
            this.buttonSetMicroTime.TabIndex = 40;
            this.buttonSetMicroTime.Text = "Set Time";
            this.buttonSetMicroTime.UseVisualStyleBackColor = true;
            this.buttonSetMicroTime.Click += new System.EventHandler(this.buttonSetMicroTime_Click);
            // 
            // labelMicrocontrollerMS
            // 
            this.labelMicrocontrollerMS.AutoSize = true;
            this.labelMicrocontrollerMS.Location = new System.Drawing.Point(94, 61);
            this.labelMicrocontrollerMS.Name = "labelMicrocontrollerMS";
            this.labelMicrocontrollerMS.Size = new System.Drawing.Size(20, 13);
            this.labelMicrocontrollerMS.TabIndex = 39;
            this.labelMicrocontrollerMS.Text = "ms";
            // 
            // labelMicroSetTime
            // 
            this.labelMicroSetTime.Location = new System.Drawing.Point(10, 53);
            this.labelMicroSetTime.Name = "labelMicroSetTime";
            this.labelMicroSetTime.Size = new System.Drawing.Size(53, 29);
            this.labelMicroSetTime.TabIndex = 20;
            this.labelMicroSetTime.Text = "Delay of hardware";
            this.labelMicroSetTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.labelMicroSetTime, "Smaller Values = Higher Signal Resolution");
            // 
            // textBoxMicroMs
            // 
            this.textBoxMicroMs.Location = new System.Drawing.Point(66, 58);
            this.textBoxMicroMs.Name = "textBoxMicroMs";
            this.textBoxMicroMs.ReadOnly = true;
            this.textBoxMicroMs.Size = new System.Drawing.Size(25, 20);
            this.textBoxMicroMs.TabIndex = 21;
            // 
            // trackBarMicroTime
            // 
            this.trackBarMicroTime.AutoSize = false;
            this.trackBarMicroTime.Location = new System.Drawing.Point(4, 82);
            this.trackBarMicroTime.Maximum = 100;
            this.trackBarMicroTime.Name = "trackBarMicroTime";
            this.trackBarMicroTime.Size = new System.Drawing.Size(118, 32);
            this.trackBarMicroTime.TabIndex = 17;
            this.toolTip.SetToolTip(this.trackBarMicroTime, "Smaller Values = Higher Signal Resolution");
            this.trackBarMicroTime.Value = 70;
            this.trackBarMicroTime.Scroll += new System.EventHandler(this.trackBarMicroTime_Scroll);
            // 
            // comboBoxDaudRate
            // 
            this.comboBoxDaudRate.FormattingEnabled = true;
            this.comboBoxDaudRate.Items.AddRange(new object[] {
            "115200",
            "9600"});
            this.comboBoxDaudRate.Location = new System.Drawing.Point(169, 18);
            this.comboBoxDaudRate.Name = "comboBoxDaudRate";
            this.comboBoxDaudRate.Size = new System.Drawing.Size(63, 21);
            this.comboBoxDaudRate.Sorted = true;
            this.comboBoxDaudRate.TabIndex = 43;
            // 
            // groupBoxSerialPort
            // 
            this.groupBoxSerialPort.Controls.Add(this.comboBoxDaudRate);
            this.groupBoxSerialPort.Controls.Add(this.comboBoxSerialPorts);
            this.groupBoxSerialPort.Controls.Add(this.buttonScanSerialPorts);
            this.groupBoxSerialPort.Location = new System.Drawing.Point(12, 2);
            this.groupBoxSerialPort.Name = "groupBoxSerialPort";
            this.groupBoxSerialPort.Size = new System.Drawing.Size(247, 44);
            this.groupBoxSerialPort.TabIndex = 44;
            this.groupBoxSerialPort.TabStop = false;
            this.groupBoxSerialPort.Text = "Serial Port Settings";
            // 
            // comboBoxScreenColor
            // 
            this.comboBoxScreenColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxScreenColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScreenColor.FormattingEnabled = true;
            this.comboBoxScreenColor.Items.AddRange(new object[] {
            "White",
            "Black",
            "Green"});
            this.comboBoxScreenColor.Location = new System.Drawing.Point(16, 37);
            this.comboBoxScreenColor.Name = "comboBoxScreenColor";
            this.comboBoxScreenColor.Size = new System.Drawing.Size(77, 21);
            this.comboBoxScreenColor.TabIndex = 45;
            this.comboBoxScreenColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxScreenColor_SelectedIndexChanged);
            // 
            // groupBoxScreen
            // 
            this.groupBoxScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxScreen.Controls.Add(this.buttonClearScreen);
            this.groupBoxScreen.Controls.Add(this.labelScreenStyle);
            this.groupBoxScreen.Controls.Add(this.comboBoxScreenColor);
            this.groupBoxScreen.Location = new System.Drawing.Point(425, 442);
            this.groupBoxScreen.Name = "groupBoxScreen";
            this.groupBoxScreen.Size = new System.Drawing.Size(103, 120);
            this.groupBoxScreen.TabIndex = 46;
            this.groupBoxScreen.TabStop = false;
            this.groupBoxScreen.Text = "Screen Settings";
            // 
            // labelScreenStyle
            // 
            this.labelScreenStyle.AutoSize = true;
            this.labelScreenStyle.Location = new System.Drawing.Point(13, 21);
            this.labelScreenStyle.Name = "labelScreenStyle";
            this.labelScreenStyle.Size = new System.Drawing.Size(77, 13);
            this.labelScreenStyle.TabIndex = 46;
            this.labelScreenStyle.Text = "Screen Theme";
            // 
            // buttonClearScreen
            // 
            this.buttonClearScreen.Location = new System.Drawing.Point(16, 70);
            this.buttonClearScreen.Name = "buttonClearScreen";
            this.buttonClearScreen.Size = new System.Drawing.Size(75, 38);
            this.buttonClearScreen.TabIndex = 47;
            this.buttonClearScreen.Text = "Clear Screen";
            this.buttonClearScreen.UseVisualStyleBackColor = true;
            this.buttonClearScreen.Click += new System.EventHandler(this.buttonClearScreen_Click);
            // 
            // checkBoxCH1Enable
            // 
            this.checkBoxCH1Enable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCH1Enable.AutoSize = true;
            this.checkBoxCH1Enable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxCH1Enable.Checked = true;
            this.checkBoxCH1Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCH1Enable.Location = new System.Drawing.Point(6, 3);
            this.checkBoxCH1Enable.Name = "checkBoxCH1Enable";
            this.checkBoxCH1Enable.Size = new System.Drawing.Size(47, 17);
            this.checkBoxCH1Enable.TabIndex = 47;
            this.checkBoxCH1Enable.Text = "CH1";
            this.checkBoxCH1Enable.UseVisualStyleBackColor = false;
            // 
            // checkBoxCH2Enable
            // 
            this.checkBoxCH2Enable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCH2Enable.AutoSize = true;
            this.checkBoxCH2Enable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxCH2Enable.Checked = true;
            this.checkBoxCH2Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCH2Enable.Location = new System.Drawing.Point(6, 25);
            this.checkBoxCH2Enable.Name = "checkBoxCH2Enable";
            this.checkBoxCH2Enable.Size = new System.Drawing.Size(47, 17);
            this.checkBoxCH2Enable.TabIndex = 48;
            this.checkBoxCH2Enable.Text = "CH2";
            this.checkBoxCH2Enable.UseVisualStyleBackColor = false;
            // 
            // panelCHEnable
            // 
            this.panelCHEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCHEnable.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelCHEnable.Controls.Add(this.checkBoxCH2Enable);
            this.panelCHEnable.Controls.Add(this.checkBoxCH1Enable);
            this.panelCHEnable.Location = new System.Drawing.Point(542, 118);
            this.panelCHEnable.Name = "panelCHEnable";
            this.panelCHEnable.Size = new System.Drawing.Size(56, 42);
            this.panelCHEnable.TabIndex = 49;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 562);
            this.Controls.Add(this.panelCHEnable);
            this.Controls.Add(this.groupBoxScreen);
            this.Controls.Add(this.groupBoxSerialPort);
            this.Controls.Add(this.groupBoxMicrocontroller);
            this.Controls.Add(this.labelAxisXmax);
            this.Controls.Add(this.textBoxAxisXmax);
            this.Controls.Add(this.trackBarAxisXmax);
            this.Controls.Add(this.panelChannelsSets);
            this.Controls.Add(this.textBoxMesurePerSec);
            this.Controls.Add(this.labelMeasurePerSec);
            this.Controls.Add(this.textBoxCh2pp);
            this.Controls.Add(this.labelCH2PP);
            this.Controls.Add(this.textBoxCh1pp);
            this.Controls.Add(this.labelCH1PP);
            this.Controls.Add(this.textBoxFreq);
            this.Controls.Add(this.labelFreq);
            this.Controls.Add(this.groupBoxGrid);
            this.Controls.Add(this.buttonAutoRange);
            this.Controls.Add(this.chartOsc);
            this.Controls.Add(this.buttonOpenSerial);
            this.Controls.Add(this.panelConsolPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(870, 600);
            this.Name = "FormMain";
            this.Text = "OpenSerialOscilloscope";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chartOsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoomScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGridY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGridX)).EndInit();
            this.groupBoxGrid.ResumeLayout(false);
            this.groupBoxGrid.PerformLayout();
            this.panelChangesStep.ResumeLayout(false);
            this.panelChangesStep.PerformLayout();
            this.panelVertPos.ResumeLayout(false);
            this.panelVertPos.PerformLayout();
            this.panelHorizPos.ResumeLayout(false);
            this.panelHorizPos.PerformLayout();
            this.panelConsolPanel.ResumeLayout(false);
            this.panelConsolPanel.PerformLayout();
            this.panelVertZoom.ResumeLayout(false);
            this.panelHorizZoom.ResumeLayout(false);
            this.panelChannelsSets.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAxisXmax)).EndInit();
            this.groupBoxMicrocontroller.ResumeLayout(false);
            this.groupBoxMicrocontroller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMicroTime)).EndInit();
            this.groupBoxSerialPort.ResumeLayout(false);
            this.groupBoxScreen.ResumeLayout(false);
            this.groupBoxScreen.PerformLayout();
            this.panelCHEnable.ResumeLayout(false);
            this.panelCHEnable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxConsol;
        private System.Windows.Forms.Button buttonOpenSerial;
        private System.Windows.Forms.CheckBox checkBoxConsolAutoScroll;
        private System.Windows.Forms.Button buttonConsolClear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOsc;
        private System.Windows.Forms.Button buttonZoomInY;
        private System.Windows.Forms.Button buttonZoomOutY;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.TrackBar trackBarZoomScale;
        private System.Windows.Forms.Button buttonAutoRange;
        private System.Windows.Forms.Label labelChange01;
        private System.Windows.Forms.Label labelChange05;
        private System.Windows.Forms.Label labelChange3;
        private System.Windows.Forms.TrackBar trackBarGridY;
        private System.Windows.Forms.TrackBar trackBarGridX;
        private System.Windows.Forms.GroupBox groupBoxGrid;
        private System.Windows.Forms.Label labelVerticalPos;
        private System.Windows.Forms.Panel panelChangesStep;
        private System.Windows.Forms.Panel panelVertPos;
        private System.Windows.Forms.Label labelMoveDownHint;
        private System.Windows.Forms.Label labelMoveUpHint;
        private System.Windows.Forms.Panel panelHorizPos;
        private System.Windows.Forms.Label labelMoveRightHint;
        private System.Windows.Forms.Label labelMoveLeftHint;
        private System.Windows.Forms.Label labelHorizontalPos;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.TextBox textBoxCh1pp;
        private System.Windows.Forms.Label labelCH1PP;
        private System.Windows.Forms.TextBox textBoxCh2pp;
        private System.Windows.Forms.Label labelCH2PP;
        private System.Windows.Forms.Panel panelConsolPanel;
        private System.Windows.Forms.TextBox textBoxMesurePerSec;
        private System.Windows.Forms.Label labelMeasurePerSec;
        private System.Windows.Forms.Button buttonZoomOutX;
        private System.Windows.Forms.Button buttonZoomInX;
        private System.Windows.Forms.Label labelVerticalZoom;
        private System.Windows.Forms.Panel panelVertZoom;
        private System.Windows.Forms.Panel panelHorizZoom;
        private System.Windows.Forms.Label labelHorizZoom;
        private System.Windows.Forms.Panel panelChannelsSets;
        private System.Windows.Forms.Label labelStepOfChange;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonScanSerialPorts;
        private System.Windows.Forms.ComboBox comboBoxSerialPorts;
        private System.Windows.Forms.Label labelSerialData;
        private System.Windows.Forms.TextBox textBoxYgridPerUnitVal;
        private System.Windows.Forms.Label labelYgridPerUnit;
        private System.Windows.Forms.TextBox textBoxXgridPerUnitVal;
        private System.Windows.Forms.Label labelXgridPerUnit;
        private System.Windows.Forms.Label labelXunits;
        private System.Windows.Forms.Label labelUnitY;
        private System.Windows.Forms.TextBox textBoxAxisXmax;
        private System.Windows.Forms.TrackBar trackBarAxisXmax;
        private System.Windows.Forms.Label labelAxisXmax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRefreshSignal;
        private System.Windows.Forms.GroupBox groupBoxMicrocontroller;
        private System.Windows.Forms.Label labelMicrocontrollerMS;
        private System.Windows.Forms.Label labelMicroSetTime;
        private System.Windows.Forms.TextBox textBoxMicroMs;
        private System.Windows.Forms.TrackBar trackBarMicroTime;
        private System.Windows.Forms.Button buttonSetMicroTime;
        private System.Windows.Forms.ComboBox comboBoxDaudRate;
        private System.Windows.Forms.GroupBox groupBoxSerialPort;
        private System.Windows.Forms.ComboBox comboBoxScreenColor;
        private System.Windows.Forms.GroupBox groupBoxScreen;
        private System.Windows.Forms.Button buttonClearScreen;
        private System.Windows.Forms.Label labelScreenStyle;
        private System.Windows.Forms.CheckBox checkBoxCH1Enable;
        private System.Windows.Forms.CheckBox checkBoxCH2Enable;
        private System.Windows.Forms.Panel panelCHEnable;
    }
}

