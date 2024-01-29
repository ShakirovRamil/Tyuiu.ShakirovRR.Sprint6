using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShakirovRR.Sprint6.Task1.V1.Lib;

namespace Tyuiu.ShakirovRR.Sprint6.Task1.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_SRR_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = int.Parse(textBoxStart_SRR.Text);
                int stopStep = int.Parse(textBoxStop_SRR.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_SRR.Text = "";
                textBoxResult_SRR.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_SRR.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_SRR.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++, startStep++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_SRR.AppendText(strLine + Environment.NewLine);
                }

                textBoxResult_SRR.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SRR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-23-1 Шакиров Рамиль Русланович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_SRR_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_SRR_Click(object sender, EventArgs e)
        {

        }
    }
}
