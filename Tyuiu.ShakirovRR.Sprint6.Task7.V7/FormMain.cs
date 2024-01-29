using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShakirovRR.Sprint6.Task7.V7.Lib;
using System.IO;

namespace Tyuiu.ShakirovRR.Sprint6.Task7.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SRR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogTask_SRR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }
        private void buttonDone_SRR_Click(object sender, EventArgs e)
        {
            openFileDialog_SRR.ShowDialog();
            openFile = openFileDialog_SRR.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInPutData_SRR.RowCount = rows;
            dataGridViewInPutData_SRR.ColumnCount = columns;
            dataGridViewOutPutData_SRR.RowCount = rows;
            dataGridViewOutPutData_SRR.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_SRR.Columns[i].Width = 50;
                dataGridViewOutPutData_SRR.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPutData_KEE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_KEE.Enabled = true;
        }

        private void buttonOpenFile_SRR_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_SRR_Click(object sender, EventArgs e)
        {

        }
    }
}
