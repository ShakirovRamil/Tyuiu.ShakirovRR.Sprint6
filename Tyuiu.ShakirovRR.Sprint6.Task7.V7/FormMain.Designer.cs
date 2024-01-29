
namespace Tyuiu.ShakirovRR.Sprint6.Task7.V7
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
            this.groupBoxOutPut_SRR = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask_SRR = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask_SRR = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewInPut_SRR = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutPut_SRR = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_SRR.SuspendLayout();
            this.groupBoxInput_SRR.SuspendLayout();
            this.groupBoxOutPut_SRR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_SRR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SRR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_SRR
            // 
            this.buttonDone_SRR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SRR.Image")));
            this.buttonDone_SRR.Location = new System.Drawing.Point(12, 12);
            this.buttonDone_SRR.Name = "buttonDone_SRR";
            this.buttonDone_SRR.Size = new System.Drawing.Size(68, 45);
            this.buttonDone_SRR.TabIndex = 2;
            this.buttonDone_SRR.UseVisualStyleBackColor = true;
            this.buttonDone_SRR.Click += new System.EventHandler(this.buttonDone_SRR_Click);
            // 
            // buttonOpenFile_SRR
            // 
            this.buttonOpenFile_SRR.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SRR.Image")));
            this.buttonOpenFile_SRR.Location = new System.Drawing.Point(86, 12);
            this.buttonOpenFile_SRR.Name = "buttonOpenFile_SRR";
            this.buttonOpenFile_SRR.Size = new System.Drawing.Size(68, 45);
            this.buttonOpenFile_SRR.TabIndex = 4;
            this.buttonOpenFile_SRR.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SRR.Click += new System.EventHandler(this.buttonOpenFile_SRR_Click);
            // 
            // buttonHelp_SRR
            // 
            this.buttonHelp_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SRR.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelp_SRR.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SRR.Image")));
            this.buttonHelp_SRR.Location = new System.Drawing.Point(809, 12);
            this.buttonHelp_SRR.Name = "buttonHelp_SRR";
            this.buttonHelp_SRR.Size = new System.Drawing.Size(68, 45);
            this.buttonHelp_SRR.TabIndex = 5;
            this.buttonHelp_SRR.UseVisualStyleBackColor = false;
            this.buttonHelp_SRR.Click += new System.EventHandler(this.buttonHelp_SRR_Click);
            // 
            // groupBoxTask_SRR
            // 
            this.groupBoxTask_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_SRR.Controls.Add(this.textBoxTask_SRR);
            this.groupBoxTask_SRR.Location = new System.Drawing.Point(12, 63);
            this.groupBoxTask_SRR.Name = "groupBoxTask_SRR";
            this.groupBoxTask_SRR.Size = new System.Drawing.Size(865, 126);
            this.groupBoxTask_SRR.TabIndex = 6;
            this.groupBoxTask_SRR.TabStop = false;
            this.groupBoxTask_SRR.Text = "Условие";
            // 
            // textBoxTask_SRR
            // 
            this.textBoxTask_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_SRR.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SRR.Multiline = true;
            this.textBoxTask_SRR.Name = "textBoxTask_SRR";
            this.textBoxTask_SRR.ReadOnly = true;
            this.textBoxTask_SRR.Size = new System.Drawing.Size(853, 74);
            this.textBoxTask_SRR.TabIndex = 3;
            this.textBoxTask_SRR.Text = resources.GetString("textBoxTask_SRR.Text");
            // 
            // groupBoxInput_SRR
            // 
            this.groupBoxInput_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput_SRR.Controls.Add(this.dataGridViewInPut_SRR);
            this.groupBoxInput_SRR.Location = new System.Drawing.Point(18, 195);
            this.groupBoxInput_SRR.Name = "groupBoxInput_SRR";
            this.groupBoxInput_SRR.Size = new System.Drawing.Size(424, 349);
            this.groupBoxInput_SRR.TabIndex = 7;
            this.groupBoxInput_SRR.TabStop = false;
            this.groupBoxInput_SRR.Text = "Ввод:";
            // 
            // groupBoxOutPut_SRR
            // 
            this.groupBoxOutPut_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutPut_SRR.Controls.Add(this.dataGridViewOutPut_SRR);
            this.groupBoxOutPut_SRR.Location = new System.Drawing.Point(448, 195);
            this.groupBoxOutPut_SRR.Name = "groupBoxOutPut_SRR";
            this.groupBoxOutPut_SRR.Size = new System.Drawing.Size(429, 349);
            this.groupBoxOutPut_SRR.TabIndex = 8;
            this.groupBoxOutPut_SRR.TabStop = false;
            this.groupBoxOutPut_SRR.Text = "Вывод:";
            // 
            // openFileDialogTask_SRR
            // 
            this.openFileDialogTask_SRR.FileName = "openFileDialog1";
            // 
            // dataGridViewInPut_SRR
            // 
            this.dataGridViewInPut_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInPut_SRR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_SRR.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewInPut_SRR.Name = "dataGridViewInPut_SRR";
            this.dataGridViewInPut_SRR.Size = new System.Drawing.Size(412, 324);
            this.dataGridViewInPut_SRR.TabIndex = 1;
            // 
            // dataGridViewOutPut_SRR
            // 
            this.dataGridViewOutPut_SRR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOutPut_SRR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_SRR.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewOutPut_SRR.Name = "dataGridViewOutPut_SRR";
            this.dataGridViewOutPut_SRR.Size = new System.Drawing.Size(416, 323);
            this.dataGridViewOutPut_SRR.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 556);
            this.Controls.Add(this.groupBoxOutPut_SRR);
            this.Controls.Add(this.groupBoxInput_SRR);
            this.Controls.Add(this.groupBoxTask_SRR);
            this.Controls.Add(this.buttonHelp_SRR);
            this.Controls.Add(this.buttonOpenFile_SRR);
            this.Controls.Add(this.buttonDone_SRR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 7 | Шакиров Р.Р.";
            this.groupBoxTask_SRR.ResumeLayout(false);
            this.groupBoxTask_SRR.PerformLayout();
            this.groupBoxInput_SRR.ResumeLayout(false);
            this.groupBoxOutPut_SRR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_SRR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SRR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_SRR;
        private System.Windows.Forms.Button buttonOpenFile_SRR;
        private System.Windows.Forms.Button buttonHelp_SRR;
        private System.Windows.Forms.GroupBox groupBoxTask_SRR;
        private System.Windows.Forms.TextBox textBoxTask_SRR;
        private System.Windows.Forms.GroupBox groupBoxInput_SRR;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SRR;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SRR;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_SRR;
        private System.Windows.Forms.DataGridView dataGridViewInPut_SRR;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_SRR;
    }
}

