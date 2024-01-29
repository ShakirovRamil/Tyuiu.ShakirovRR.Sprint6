using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShakirovRR.Sprint6.Task2.V15.Lib;

namespace Tyuiu.ShakirovRR.Sprint6.Task2.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_SRR_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SRR.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SRR.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_SRR.Titles.Add("График функции");
                this.chartFunction_SRR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SRR.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFuction_SRR.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_SRR.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SRR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСТНб-23-1 Шакиров Рамиль Русланович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartFunction_SRR_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_SRR_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SRR.BackColor = Color.Red;
        }

        private void buttonDone_SRR_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SRR.BackColor = Color.Green;
        }

        private void buttonDone_SRR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SRR.BackColor = Color.Blue;
        }
    }
}
