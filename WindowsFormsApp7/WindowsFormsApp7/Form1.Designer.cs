namespace MathNETFFT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.trkSecond = new System.Windows.Forms.TrackBar();
            this.trkThird = new System.Windows.Forms.TrackBar();
            this.trkPHSecond = new System.Windows.Forms.TrackBar();
            this.trkPHThird = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFFT = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMagThird = new System.Windows.Forms.Label();
            this.lblMagSecond = new System.Windows.Forms.Label();
            this.lblPHSecond = new System.Windows.Forms.Label();
            this.lblPHThird = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPHSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPHThird)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Waveform";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Second Harmonic";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Third Harmonic";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(670, 206);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Waveform";
            this.chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 233);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Frequency";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Angle";
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(670, 206);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(803, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(170, 29);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Signal";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(742, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(803, 57);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(741, 278);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(802, 277);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // trkSecond
            // 
            this.trkSecond.Location = new System.Drawing.Point(727, 114);
            this.trkSecond.Name = "trkSecond";
            this.trkSecond.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkSecond.Size = new System.Drawing.Size(45, 104);
            this.trkSecond.TabIndex = 7;
            this.trkSecond.Scroll += new System.EventHandler(this.trkSecond_Scroll);
            // 
            // trkThird
            // 
            this.trkThird.Location = new System.Drawing.Point(788, 114);
            this.trkThird.Name = "trkThird";
            this.trkThird.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkThird.Size = new System.Drawing.Size(45, 104);
            this.trkThird.TabIndex = 8;
            this.trkThird.Scroll += new System.EventHandler(this.trkThird_Scroll);
            // 
            // trkPHSecond
            // 
            this.trkPHSecond.Location = new System.Drawing.Point(727, 335);
            this.trkPHSecond.Name = "trkPHSecond";
            this.trkPHSecond.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkPHSecond.Size = new System.Drawing.Size(45, 104);
            this.trkPHSecond.TabIndex = 9;
            this.trkPHSecond.Scroll += new System.EventHandler(this.trkPHSecond_Scroll);
            // 
            // trkPHThird
            // 
            this.trkPHThird.Location = new System.Drawing.Point(788, 335);
            this.trkPHThird.Name = "trkPHThird";
            this.trkPHThird.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkPHThird.Size = new System.Drawing.Size(45, 104);
            this.trkPHThird.TabIndex = 10;
            this.trkPHThird.Scroll += new System.EventHandler(this.trkPHThird_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(823, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Magnitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "120 Hz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "180 Hz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(823, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phase (degrees)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(724, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "120 Hz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(791, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "180 Hz";
            // 
            // btnFFT
            // 
            this.btnFFT.Location = new System.Drawing.Point(366, 463);
            this.btnFFT.Name = "btnFFT";
            this.btnFFT.Size = new System.Drawing.Size(76, 29);
            this.btnFFT.TabIndex = 21;
            this.btnFFT.Text = "FFT";
            this.btnFFT.UseVisualStyleBackColor = true;
            this.btnFFT.Click += new System.EventHandler(this.btnFFT_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(914, 471);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 21);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMagThird
            // 
            this.lblMagThird.AutoSize = true;
            this.lblMagThird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMagThird.Location = new System.Drawing.Point(803, 78);
            this.lblMagThird.MinimumSize = new System.Drawing.Size(13, 13);
            this.lblMagThird.Name = "lblMagThird";
            this.lblMagThird.Size = new System.Drawing.Size(13, 15);
            this.lblMagThird.TabIndex = 23;
            // 
            // lblMagSecond
            // 
            this.lblMagSecond.AutoSize = true;
            this.lblMagSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMagSecond.Location = new System.Drawing.Point(742, 79);
            this.lblMagSecond.MinimumSize = new System.Drawing.Size(13, 13);
            this.lblMagSecond.Name = "lblMagSecond";
            this.lblMagSecond.Size = new System.Drawing.Size(13, 15);
            this.lblMagSecond.TabIndex = 24;
            // 
            // lblPHSecond
            // 
            this.lblPHSecond.AutoSize = true;
            this.lblPHSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPHSecond.Location = new System.Drawing.Point(741, 301);
            this.lblPHSecond.MinimumSize = new System.Drawing.Size(13, 13);
            this.lblPHSecond.Name = "lblPHSecond";
            this.lblPHSecond.Size = new System.Drawing.Size(13, 15);
            this.lblPHSecond.TabIndex = 25;
            // 
            // lblPHThird
            // 
            this.lblPHThird.AutoSize = true;
            this.lblPHThird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPHThird.Location = new System.Drawing.Point(802, 301);
            this.lblPHThird.MinimumSize = new System.Drawing.Size(13, 13);
            this.lblPHThird.Name = "lblPHThird";
            this.lblPHThird.Size = new System.Drawing.Size(13, 15);
            this.lblPHThird.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(898, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "EN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(934, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "УКР";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 478);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 13);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Autors";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 504);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPHThird);
            this.Controls.Add(this.lblPHSecond);
            this.Controls.Add(this.lblMagSecond);
            this.Controls.Add(this.lblMagThird);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFFT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkPHThird);
            this.Controls.Add(this.trkPHSecond);
            this.Controls.Add(this.trkThird);
            this.Controls.Add(this.trkSecond);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "FFT Signal analysis";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPHSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPHThird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TrackBar trkSecond;
        private System.Windows.Forms.TrackBar trkThird;
        private System.Windows.Forms.TrackBar trkPHSecond;
        private System.Windows.Forms.TrackBar trkPHThird;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFFT;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMagThird;
        private System.Windows.Forms.Label lblMagSecond;
        private System.Windows.Forms.Label lblPHSecond;
        private System.Windows.Forms.Label lblPHThird;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

