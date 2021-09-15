using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using System.Numerics;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace MathNETFFT
{
    public partial class Form1 : Form
    {
        static int numSamples = 1000;
        static int sampleRate = 2000;
        static int magSecond;
        static int magThird;
        static double PHSecond;
        static double PHThird;
        Complex[] samples = new Complex[numSamples];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            PlotWaveform(0, 0, 0, 0);
        }

        public void PlotWaveform(int secondHarm, int thirdHarm, double secondPH, double thirdPH)
        {
            chart1.Series["Waveform"].Points.Clear();
            chart1.Series["Second Harmonic"].Points.Clear();
            chart1.Series["Third Harmonic"].Points.Clear();
            double[] fundamental = Generate.Sinusoidal(numSamples, sampleRate, 60, 10.0);
            double[] second = Generate.Sinusoidal(numSamples, sampleRate, 120, secondHarm, 0.0, secondPH);
            double[] third = Generate.Sinusoidal(numSamples, sampleRate, 180, thirdHarm, 0.0, thirdPH);

            for (int i = 0; i < numSamples; i++)
            {
                samples[i] = new Complex(fundamental[i] + second[i] + third[i], 0);
            }
            for (int i = 0; i < samples.Length / 5; i++)
            {
                double time = ((i + 1.0) / numSamples) / 2;

                chart1.Series["Waveform"].LegendText = "Waveform";
                chart1.Series["Waveform"].ChartType = SeriesChartType.Line;

                chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 14.0f);
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Seconds";

                if (checkBox1.Checked)
                {
                    chart1.Series["Second Harmonic"].Points.AddXY
                        (time, second[i]);
                }

                if (checkBox2.Checked)
                {
                    chart1.Series["Third Harmonic"].Points.AddXY
                        (time, third[i]);
                }

                chart1.Series["Waveform"].Points.AddXY
                        (time, samples[i].Real);
            }

        }
        private void PlotFFT()
        {
            chart2.Series["Frequency"].Points.Clear();

            Fourier.Forward(samples, FourierOptions.NoScaling);

            for (int i = 1; i<samples.Length/10; i++)
            {
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Hz";
                chart2.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 14.0f);
                chart2.ChartAreas["ChartArea1"].AxisX.MajorTickMark.Enabled = true;

                double mag = (2.0 / numSamples) * (Math.Abs(Math.Sqrt(Math.Pow(samples[i].Real, 2) +
                    Math.Pow(samples[i].Imaginary, 2))));

                double hzPerSamle = sampleRate / numSamples;

                chart2.Series["Frequency"].Points.AddXY
                    (hzPerSamle * i, mag);
            }
        }

        private void trkSecond_Scroll(object sender, EventArgs e)
        {
            trkPHSecond.Enabled = true;
            magSecond = trkSecond.Value;
            lblMagSecond.Text = magSecond.ToString("F0");
            PlotWaveform(magSecond, magThird, PHSecond, PHThird);
            PlotFFT();
        }

        private void trkThird_Scroll(object sender, EventArgs e)
        {
            trkPHThird.Enabled = true;
            magThird = trkThird.Value;
            lblMagThird.Text = magThird.ToString("F0");
            PlotWaveform(magSecond, magThird, PHSecond, PHThird);
            PlotFFT();
        }

        private void trkPHSecond_Scroll(object sender, EventArgs e)
        {
            PHSecond = 2.0 * Math.PI * (trkPHSecond.Value / (double)trkPHSecond.Maximum);
            double angle = PHSecond * 360.0 / (2.0 * Math.PI);
            lblPHSecond.Text = angle.ToString("F1");
            PlotWaveform(magSecond, magThird, PHSecond, PHThird);
            PlotFFT();
        }

        private void trkPHThird_Scroll(object sender, EventArgs e)
        {
            PHThird = 2.0 * Math.PI * (trkPHThird.Value / (double)trkPHThird.Maximum);
            double angle = PHThird * 360.0 / (2.0 * Math.PI);
            lblPHThird.Text = angle.ToString("F1");
            PlotWaveform(magSecond, magThird, PHSecond, PHThird);
            PlotFFT();
        }

        private void btnFFT_Click(object sender, EventArgs e)
        {
            PlotFFT();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Magnitude";
            btnLoad.Text = "Load Signal";
            label4.Text = "Phase(degrees)";
            btnFFT.Text = "FTT";
            btnExit.Text = "EXIT";
            label2.Text = "120 Hz";
            label3.Text = "180 Hz";
            label5.Text = "120 Hz";
            label6.Text = "180 Hz";
            linkLabel1.Text = "Autors";

            chart1.Series["Waveform"].LegendText = "Waveform";
            chart1.Series["Second Harmonic"].LegendText = "Second Harmonic";
            chart1.Series["Third Harmonic"].LegendText = "Third Harmonic";
            chart2.Series["Frequency"].LegendText = "Frequency";
            chart2.Series["Angle"].LegendText = "Angle";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Seconds";
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Hz";
            this.Text = "FFT Signal analysis";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Величина";
            btnLoad.Text = "Завантажити сигнал";
            label4.Text = "Фаза(градуси)";
            btnFFT.Text = "БПФ";
            btnExit.Text = "ВИХІД";
            label2.Text = "120 Гц";
            label3.Text = "180 Гц";
            label5.Text = "120 Гц";
            label6.Text = "180 Гц";
            linkLabel1.Text = "Автори";

            chart1.Series["Waveform"].LegendText = "Форма Хвилі";
            chart1.Series["Second Harmonic"].LegendText = "Друга Гармоніка";
            chart1.Series["Third Harmonic"].LegendText = "Третя Гармоніка";
            chart2.Series["Frequency"].LegendText = "Частота";
            chart2.Series["Angle"].LegendText = "Кут";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Секунди";
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Гц";
            this.Text = "БПФ Аналіз сигналу";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Студенти:" + "\r\n" +
                            "Мільке Денис, Поляков Євген, Мелешко Сергій" + "\r\n" +
                            "Група СЕ-307а" + "\r\n" +
                            "Кафедра електроніки" + "\r\n" +
                            "ННІАЕТ" + "\r\n" +
                            "НАУ" +"\r\n" +
                            "Україна, Київ",
                            "Реквізити авторів:",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
        }
    }
}
