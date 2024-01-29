
namespace Tyuiu.ShakirovRR.Sprint6.Task6.V21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonDone_SRR = new System.Windows.Forms.Button();
            this.buttonOpenFile_SRR = new System.Windows.Forms.Button();
            this.buttonHelp_SRR = new System.Windows.Forms.Button();
            this.groupBoxTask_SRR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SRR = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SRR = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_SRR = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_SRR = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_SRR = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_SRR = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxTask_SRR.SuspendLayout();
            this.groupBoxInput_SRR.SuspendLayout();
            this.groupBoxOutPut_SRR.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_SRR
            // 
            this.buttonDone_SRR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SRR.Image")));
            this.buttonDone_SRR.Location = new System.Drawing.Point(12, 12);
            this.buttonDone_SRR.Name = "buttonDone_SRR";
            this.buttonDone_SRR.Size = new System.Drawing.Size(68, 45);
            this.buttonDone_SRR.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonDone_SRR, "выполнить задачу\r\nНажмите чтобы запустить программу\r\n");
            this.buttonDone_SRR.UseVisualStyleBackColor = true;
            this.buttonDone_SRR.Click += new System.EventHandler(this.buttonDone_SRR_Click);
            // 
            // buttonOpenFile_SRR
            // 
            this.buttonOpenFile_SRR.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SRR.Image")));
            this.buttonOpenFile_SRR.Location = new System.Drawing.Point(86, 12);
            this.buttonOpenFile_SRR.Name = "buttonOpenFile_SRR";
            this.buttonOpenFile_SRR.Size = new System.Drawing.Size(68, 45);
            this.buttonOpenFile_SRR.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonOpenFile_SRR, "открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_SRR.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SRR.Click += new System.EventHandler(this.buttonOpenFile_SRR_Click);
            // 
            // buttonHelp_SRR
            // 
            this.buttonHelp_SRR.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelp_SRR.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SRR.Image")));
            this.buttonHelp_SRR.Location = new System.Drawing.Point(769, 12);
            this.buttonHelp_SRR.Name = "buttonHelp_SRR";
            this.buttonHelp_SRR.Size = new System.Drawing.Size(68, 45);
            this.buttonHelp_SRR.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buttonHelp_SRR, "справка\r\nвыводит информацию об авторских правах и авторе");
            this.buttonHelp_SRR.UseVisualStyleBackColor = false;
            this.buttonHelp_SRR.Click += new System.EventHandler(this.buttonHelp_SRR_Click);
            // 
            // groupBoxTask_SRR
            // 
            this.groupBoxTask_SRR.Controls.Add(this.textBoxTask_SRR);
            this.groupBoxTask_SRR.Location = new System.Drawing.Point(12, 63);
            this.groupBoxTask_SRR.Name = "groupBoxTask_SRR";
            this.groupBoxTask_SRR.Size = new System.Drawing.Size(825, 100);
            this.groupBoxTask_SRR.TabIndex = 5;
            this.groupBoxTask_SRR.TabStop = false;
            this.groupBoxTask_SRR.Text = "Условие";
            // 
            // textBoxTask_SRR
            // 
            this.textBoxTask_SRR.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SRR.Multiline = true;
            this.textBoxTask_SRR.Name = "textBoxTask_SRR";
            this.textBoxTask_SRR.ReadOnly = true;
            this.textBoxTask_SRR.Size = new System.Drawing.Size(813, 75);
            this.textBoxTask_SRR.TabIndex = 3;
            this.textBoxTask_SRR.Text = "Вывести слова в которых встречается g в результирующею строку и вывести ее в text" +
    "BoxOut.";
            // 
            // groupBoxInput_SRR
            // 
            this.groupBoxInput_SRR.Controls.Add(this.textBoxInPut_SRR);
            this.groupBoxInput_SRR.Location = new System.Drawing.Point(18, 169);
            this.groupBoxInput_SRR.Name = "groupBoxInput_SRR";
            this.groupBoxInput_SRR.Size = new System.Drawing.Size(390, 394);
            this.groupBoxInput_SRR.TabIndex = 6;
            this.groupBoxInput_SRR.TabStop = false;
            this.groupBoxInput_SRR.Text = "Ввод:";
            // 
            // textBoxInPut_SRR
            // 
            this.textBoxInPut_SRR.Location = new System.Drawing.Point(6, 19);
            this.textBoxInPut_SRR.Multiline = true;
            this.textBoxInPut_SRR.Name = "textBoxInPut_SRR";
            this.textBoxInPut_SRR.Size = new System.Drawing.Size(378, 369);
            this.textBoxInPut_SRR.TabIndex = 0;
            // 
            // groupBoxOutPut_SRR
            // 
            this.groupBoxOutPut_SRR.Controls.Add(this.textBoxOutPut_SRR);
            this.groupBoxOutPut_SRR.Location = new System.Drawing.Point(414, 169);
            this.groupBoxOutPut_SRR.Name = "groupBoxOutPut_SRR";
            this.groupBoxOutPut_SRR.Size = new System.Drawing.Size(417, 394);
            this.groupBoxOutPut_SRR.TabIndex = 7;
            this.groupBoxOutPut_SRR.TabStop = false;
            this.groupBoxOutPut_SRR.Text = "Вывод:";
            // 
            // textBoxOutPut_SRR
            // 
            this.textBoxOutPut_SRR.Location = new System.Drawing.Point(6, 19);
            this.textBoxOutPut_SRR.Multiline = true;
            this.textBoxOutPut_SRR.Name = "textBoxOutPut_SRR";
            this.textBoxOutPut_SRR.ReadOnly = true;
            this.textBoxOutPut_SRR.Size = new System.Drawing.Size(384, 369);
            this.textBoxOutPut_SRR.TabIndex = 1;
            // 
            // openFileDialogTask_SRR
            // 
            this.openFileDialogTask_SRR.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 591);
            this.Controls.Add(this.groupBoxOutPut_SRR);
            this.Controls.Add(this.groupBoxInput_SRR);
            this.Controls.Add(this.groupBoxTask_SRR);
            this.Controls.Add(this.buttonHelp_SRR);
            this.Controls.Add(this.buttonOpenFile_SRR);
            this.Controls.Add(this.buttonDone_SRR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 21 | Шакиров Р.Р.";
            this.groupBoxTask_SRR.ResumeLayout(false);
            this.groupBoxTask_SRR.PerformLayout();
            this.groupBoxInput_SRR.ResumeLayout(false);
            this.groupBoxInput_SRR.PerformLayout();
            this.groupBoxOutPut_SRR.ResumeLayout(false);
            this.groupBoxOutPut_SRR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_SRR;
        private System.Windows.Forms.Button buttonOpenFile_SRR;
        private System.Windows.Forms.Button buttonHelp_SRR;
        private System.Windows.Forms.GroupBox groupBoxTask_SRR;
        private System.Windows.Forms.TextBox textBoxTask_SRR;
        private System.Windows.Forms.GroupBox groupBoxInput_SRR;
        private System.Windows.Forms.TextBox textBoxInPut_SRR;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SRR;
        private System.Windows.Forms.TextBox textBoxOutPut_SRR;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SRR;
    }
}

