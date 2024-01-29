using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShakirovRR.Sprint6.Task6.V21.Lib;
using System.IO;

namespace Tyuiu.ShakirovRR.Sprint6.Task6.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath_SRR;
        private void buttonDone_SRR_Click(object sender, EventArgs e)
        {
            string str = "g";
            textBoxOutPut_SRR.Text = ds.CollectTextFromFile(str, openFilePath_SRR);

        }

        private void buttonOpenFile_SRR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SRR.ShowDialog();
            openFilePath_SRR = openFileDialogTask_SRR.FileName;
            textBoxInPut_SRR.Text = File.ReadAllText(openFilePath_SRR);
            groupBoxInput_SRR.Text = groupBoxInput_SRR.Text + " " + openFileDialogTask_SRR.FileName;
            buttonDone_SRR.Enabled = true;
        }

        private void buttonHelp_SRR_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}
