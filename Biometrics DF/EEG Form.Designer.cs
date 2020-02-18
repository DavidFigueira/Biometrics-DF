namespace SensorDisplay
{
    partial class EEGForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LOG = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ShockButton = new System.Windows.Forms.Button();
            this.ComPortComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.ClearButton = new System.Windows.Forms.Button();
            this.TagTextBox = new System.Windows.Forms.TextBox();
            this.TagButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScreenShotButton = new System.Windows.Forms.Button();
            this.ScreenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.zoomout = new System.Windows.Forms.Button();
            this.zoomin = new System.Windows.Forms.Button();
            this.timerangelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea4.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea4.CursorX.SelectionColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(43, 33);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Black;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1573, 398);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // LOG
            // 
            this.LOG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LOG.Location = new System.Drawing.Point(619, 562);
            this.LOG.Name = "LOG";
            this.LOG.ReadOnly = true;
            this.LOG.Size = new System.Drawing.Size(516, 223);
            this.LOG.TabIndex = 1;
            this.LOG.Text = "";
            this.LOG.TextChanged += new System.EventHandler(this.LOG_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Location = new System.Drawing.Point(43, 525);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(228, 51);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopButton.Location = new System.Drawing.Point(43, 599);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(228, 51);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ShockButton
            // 
            this.ShockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShockButton.Location = new System.Drawing.Point(289, 525);
            this.ShockButton.Name = "ShockButton";
            this.ShockButton.Size = new System.Drawing.Size(228, 51);
            this.ShockButton.TabIndex = 4;
            this.ShockButton.Text = "Shock";
            this.ShockButton.UseVisualStyleBackColor = true;
            this.ShockButton.Click += new System.EventHandler(this.ShockButton_Click);
            // 
            // ComPortComboBox
            // 
            this.ComPortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComPortComboBox.FormattingEnabled = true;
            this.ComPortComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.ComPortComboBox.Location = new System.Drawing.Point(43, 485);
            this.ComPortComboBox.Name = "ComPortComboBox";
            this.ComPortComboBox.Size = new System.Drawing.Size(228, 24);
            this.ComPortComboBox.TabIndex = 5;
            this.ComPortComboBox.SelectedIndexChanged += new System.EventHandler(this.ComPortComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "SELECCIONE EL PUERTO";
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.Location = new System.Drawing.Point(289, 599);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(228, 51);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TagTextBox
            // 
            this.TagTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TagTextBox.Location = new System.Drawing.Point(43, 684);
            this.TagTextBox.Name = "TagTextBox";
            this.TagTextBox.Size = new System.Drawing.Size(228, 22);
            this.TagTextBox.TabIndex = 8;
            // 
            // TagButton
            // 
            this.TagButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TagButton.Location = new System.Drawing.Point(289, 670);
            this.TagButton.Name = "TagButton";
            this.TagButton.Size = new System.Drawing.Size(228, 51);
            this.TagButton.TabIndex = 9;
            this.TagButton.Text = "Etiqueta";
            this.TagButton.UseVisualStyleBackColor = true;
            this.TagButton.Click += new System.EventHandler(this.TagButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos .txt (*.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos .txt (*.txt)|*.txt";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "LOG";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1818, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.testToolStripMenuItem.Text = "Archivo";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.openFileToolStripMenuItem.Text = "Abrir";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // ScreenShotButton
            // 
            this.ScreenShotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ScreenShotButton.Location = new System.Drawing.Point(289, 739);
            this.ScreenShotButton.Name = "ScreenShotButton";
            this.ScreenShotButton.Size = new System.Drawing.Size(228, 46);
            this.ScreenShotButton.TabIndex = 15;
            this.ScreenShotButton.Text = "Captura de Pantalla";
            this.ScreenShotButton.UseVisualStyleBackColor = true;
            this.ScreenShotButton.Click += new System.EventHandler(this.ScreenShot_Click);
            // 
            // ScreenTextBox
            // 
            this.ScreenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ScreenTextBox.Location = new System.Drawing.Point(43, 751);
            this.ScreenTextBox.Name = "ScreenTextBox";
            this.ScreenTextBox.Size = new System.Drawing.Size(228, 22);
            this.ScreenTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 664);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre de Etiqueta";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 731);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre de Captura";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefreshButton.Location = new System.Drawing.Point(289, 454);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(228, 55);
            this.RefreshButton.TabIndex = 19;
            this.RefreshButton.Text = "REFRESCAR LISTA DE PUERTOS";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // zoomout
            // 
            this.zoomout.Location = new System.Drawing.Point(634, 454);
            this.zoomout.Name = "zoomout";
            this.zoomout.Size = new System.Drawing.Size(209, 55);
            this.zoomout.TabIndex = 20;
            this.zoomout.Text = "<<<<     ALEJAR     >>>>";
            this.zoomout.UseVisualStyleBackColor = true;
            this.zoomout.Click += new System.EventHandler(this.zoomout_Click);
            // 
            // zoomin
            // 
            this.zoomin.Location = new System.Drawing.Point(926, 454);
            this.zoomin.Name = "zoomin";
            this.zoomin.Size = new System.Drawing.Size(209, 55);
            this.zoomin.TabIndex = 21;
            this.zoomin.Text = ">>>>     AMPLIAR     <<<<";
            this.zoomin.UseVisualStyleBackColor = true;
            this.zoomin.Click += new System.EventHandler(this.zoomin_Click);
            // 
            // timerangelabel
            // 
            this.timerangelabel.AutoSize = true;
            this.timerangelabel.Location = new System.Drawing.Point(869, 473);
            this.timerangelabel.Name = "timerangelabel";
            this.timerangelabel.Size = new System.Drawing.Size(27, 17);
            this.timerangelabel.TabIndex = 22;
            this.timerangelabel.Text = "3 s";
            // 
            // EEGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1818, 870);
            this.Controls.Add(this.timerangelabel);
            this.Controls.Add(this.zoomin);
            this.Controls.Add(this.zoomout);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScreenTextBox);
            this.Controls.Add(this.ScreenShotButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TagButton);
            this.Controls.Add(this.TagTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComPortComboBox);
            this.Controls.Add(this.ShockButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LOG);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EEGForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox LOG;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ShockButton;
        private System.Windows.Forms.ComboBox ComPortComboBox;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort aSerialPort;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox TagTextBox;
        private System.Windows.Forms.Button TagButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Button ScreenShotButton;
        private System.Windows.Forms.TextBox ScreenTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button zoomout;
        private System.Windows.Forms.Button zoomin;
        private System.Windows.Forms.Label timerangelabel;
    }
}

