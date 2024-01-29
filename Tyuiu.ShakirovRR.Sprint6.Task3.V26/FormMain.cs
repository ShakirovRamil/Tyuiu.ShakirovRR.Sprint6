using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShakirovRR.Sprint6.Task3.V26.Lib;

namespace Tyuiu.ShakirovRR.Sprint6.Task3.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { 16, 19, 17, 2, 8 },
                                     { -17, 8, -17, -8, 1 },
                                     { -7, 17, -2, 1, -3 },
                                     {-12, 0, -17, 15, 6 },
                                     { 17, -6, -17, 18, -19 } };

        private void buttonDone_SRR_Click(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dataGridViewOutput_SRR.ColumnCount = cols;
            dataGridViewOutput_SRR.RowCount = rows;

            int[,] newMtrx = ds.Calculate(matrix);

            for (int i = 0; i < cols; i++)
            {
                dataGridViewOutput_SRR.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewOutput_SRR.Rows[i].Cells[j].Value = Convert.ToString(newMtrx[i, j]);
                }
            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dataGridViewCondition_SRR.ColumnCount = cols;
            dataGridViewCondition_SRR.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewCondition_SRR.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewCondition_SRR.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonHelp_SRR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-23-1 Шакиров Рамиль Русланович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
