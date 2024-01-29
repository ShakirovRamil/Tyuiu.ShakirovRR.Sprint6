
namespace Tyuiu.ShakirovRR.Sprint6.Task5.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SRR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SRR = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_SRR = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_SRR = new System.Windows.Forms.DataGridView();
            this.buttonDone_SRR = new System.Windows.Forms.Button();
            this.buttonSave_SRR = new System.Windows.Forms.Button();
            this.buttonHelp_SRR = new System.Windows.Forms.Button();
            this.chartDiag_SRR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_SRR.SuspendLayout();
            this.groupBoxOutPut_SRR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_SRR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SRR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SRR
            // 
            this.groupBoxTask_SRR.Controls.Add(this.textBoxTask_SRR);
            this.groupBoxTask_SRR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SRR.Name = "groupBoxTask_SRR";
            this.groupBoxTask_SRR.Size = new System.Drawing.Size(431, 76);
            this.groupBoxTask_SRR.TabIndex = 1;
            this.groupBoxTask_SRR.TabStop = false;
            this.groupBoxTask_SRR.Text = "Условие";
            // 
            // textBoxTask_SRR
            // 
            this.textBoxTask_SRR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SRR.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SRR.Multiline = true;
            this.textBoxTask_SRR.Name = "textBoxTask_SRR";
            this.textBoxTask_SRR.ReadOnly = true;
            this.textBoxTask_SRR.Size = new System.Drawing.Size(419, 51);
            this.textBoxTask_SRR.TabIndex = 0;
            this.textBoxTask_SRR.Text = "Прочитать данные из файла InPutFileTask5V4.txt. Вывести в dataGridView. Вывести в" +
    "се целые числа.";
            // 
            // groupBoxOutPut_SRR
            // 
            this.groupBoxOutPut_SRR.Controls.Add(this.dataGridViewNums_SRR);
            this.groupBoxOutPut_SRR.Location = new System.Drawing.Point(12, 94);
            this.groupBoxOutPut_SRR.Name = "groupBoxOutPut_SRR";
            this.groupBoxOutPut_SRR.Size = new System.Drawing.Size(200, 350);
            this.groupBoxOutPut_SRR.TabIndex = 2;
            this.groupBoxOutPut_SRR.TabStop = false;
            this.groupBoxOutPut_SRR.Text = "Вывод данных:";
            // 
            // dataGridViewNums_SRR
            // 
            this.dataGridViewNums_SRR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_SRR.ColumnHeadersVisible = false;
            this.dataGridViewNums_SRR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_SRR.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNums_SRR.Name = "dataGridViewNums_SRR";
            this.dataGridViewNums_SRR.ReadOnly = true;
            this.dataGridViewNums_SRR.RowHeadersVisible = false;
            this.dataGridViewNums_SRR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNums_SRR.Size = new System.Drawing.Size(194, 331);
            this.dataGridViewNums_SRR.TabIndex = 0;
            // 
            // buttonDone_SRR
            // 
            this.buttonDone_SRR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDone_SRR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDone_SRR.Location = new System.Drawing.Point(448, 11);
            this.buttonDone_SRR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_SRR.Name = "buttonDone_SRR";
            this.buttonDone_SRR.Size = new System.Drawing.Size(78, 50);
            this.buttonDone_SRR.TabIndex = 9;
            this.buttonDone_SRR.Text = "Выполнить";
            this.buttonDone_SRR.UseVisualStyleBackColor = false;
            this.buttonDone_SRR.Click += new System.EventHandler(this.buttonDone_SRR_Click);
            // 
            // buttonSave_SRR
            // 
            this.buttonSave_SRR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSave_SRR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSave_SRR.Location = new System.Drawing.Point(530, 11);
            this.buttonSave_SRR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave_SRR.Name = "buttonSave_SRR";
            this.buttonSave_SRR.Size = new System.Drawing.Size(78, 50);
            this.buttonSave_SRR.TabIndex = 10;
            this.buttonSave_SRR.Text = "Сохранить";
            this.buttonSave_SRR.UseVisualStyleBackColor = false;
            this.buttonSave_SRR.Click += new System.EventHandler(this.buttonSave_SRR_Click);
            // 
            // buttonHelp_SRR
            // 
            this.buttonHelp_SRR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonHelp_SRR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHelp_SRR.Location = new System.Drawing.Point(736, 11);
            this.buttonHelp_SRR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_SRR.Name = "buttonHelp_SRR";
            this.buttonHelp_SRR.Size = new System.Drawing.Size(53, 50);
            this.buttonHelp_SRR.TabIndex = 11;
            this.buttonHelp_SRR.Text = "?";
            this.buttonHelp_SRR.UseVisualStyleBackColor = false;
            this.buttonHelp_SRR.Click += new System.EventHandler(this.buttonHelp_SRR_Click);
            // 
            // chartDiag_SRR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDiag_SRR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDiag_SRR.Legends.Add(legend1);
            this.chartDiag_SRR.Location = new System.Drawing.Point(219, 95);
            this.chartDiag_SRR.Name = "chartDiag_SRR";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_SRR.Series.Add(series1);
            this.chartDiag_SRR.Size = new System.Drawing.Size(569, 343);
            this.chartDiag_SRR.TabIndex = 12;
            this.chartDiag_SRR.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartDiag_SRR);
            this.Controls.Add(this.buttonHelp_SRR);
            this.Controls.Add(this.buttonSave_SRR);
            this.Controls.Add(this.buttonDone_SRR);
            this.Controls.Add(this.groupBoxOutPut_SRR);
            this.Controls.Add(this.groupBoxTask_SRR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 4 | Шакиров Р.Р.";
            this.groupBoxTask_SRR.ResumeLayout(false);
            this.groupBoxTask_SRR.PerformLayout();
            this.groupBoxOutPut_SRR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_SRR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SRR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SRR;
        private System.Windows.Forms.TextBox textBoxTask_SRR;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SRR;
        private System.Windows.Forms.DataGridView dataGridViewNums_SRR;
        private System.Windows.Forms.Button buttonDone_SRR;
        private System.Windows.Forms.Button buttonSave_SRR;
        private System.Windows.Forms.Button buttonHelp_SRR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SRR;
    }
}

