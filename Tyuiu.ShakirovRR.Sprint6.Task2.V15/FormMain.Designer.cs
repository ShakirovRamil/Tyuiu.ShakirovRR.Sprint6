
namespace Tyuiu.ShakirovRR.Sprint6.Task2.V15
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
            this.buttonDone_SRR = new System.Windows.Forms.Button();
            this.buttonHelp_SRR = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SRR = new System.Windows.Forms.TextBox();
            this.textBoxStart_SRR = new System.Windows.Forms.TextBox();
            this.labelStop_SRR = new System.Windows.Forms.Label();
            this.labelStart_SRR = new System.Windows.Forms.Label();
            this.groupBoxCondition_SRR = new System.Windows.Forms.GroupBox();
            this.pictureBox_SRR = new System.Windows.Forms.PictureBox();
            this.groupBoxResult_SRR = new System.Windows.Forms.GroupBox();
            this.dataGridViewFuction_SRR = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_SRR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_SRR = new System.Windows.Forms.Label();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxCondition_SRR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SRR)).BeginInit();
            this.groupBoxResult_SRR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuction_SRR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SRR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_SRR
            // 
            this.buttonDone_SRR.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_SRR.Location = new System.Drawing.Point(678, 449);
            this.buttonDone_SRR.Name = "buttonDone_SRR";
            this.buttonDone_SRR.Size = new System.Drawing.Size(173, 95);
            this.buttonDone_SRR.TabIndex = 2;
            this.buttonDone_SRR.Text = "Выполнить";
            this.buttonDone_SRR.UseVisualStyleBackColor = false;
            this.buttonDone_SRR.Click += new System.EventHandler(this.buttonDone_SRR_Click);
            this.buttonDone_SRR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SRR_MouseDown);
            this.buttonDone_SRR.MouseEnter += new System.EventHandler(this.buttonDone_SRR_MouseEnter);
            this.buttonDone_SRR.MouseLeave += new System.EventHandler(this.buttonDone_SRR_MouseLeave);
            // 
            // buttonHelp_SRR
            // 
            this.buttonHelp_SRR.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp_SRR.Location = new System.Drawing.Point(537, 449);
            this.buttonHelp_SRR.Name = "buttonHelp_SRR";
            this.buttonHelp_SRR.Size = new System.Drawing.Size(135, 95);
            this.buttonHelp_SRR.TabIndex = 3;
            this.buttonHelp_SRR.Text = "Справка";
            this.buttonHelp_SRR.UseVisualStyleBackColor = false;
            this.buttonHelp_SRR.Click += new System.EventHandler(this.buttonHelp_SRR_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxStop_SRR);
            this.groupBoxInput.Controls.Add(this.textBoxStart_SRR);
            this.groupBoxInput.Controls.Add(this.labelStop_SRR);
            this.groupBoxInput.Controls.Add(this.labelStart_SRR);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 449);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(519, 95);
            this.groupBoxInput.TabIndex = 4;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxStop_SRR
            // 
            this.textBoxStop_SRR.Location = new System.Drawing.Point(254, 36);
            this.textBoxStop_SRR.Name = "textBoxStop_SRR";
            this.textBoxStop_SRR.Size = new System.Drawing.Size(160, 20);
            this.textBoxStop_SRR.TabIndex = 2;
            // 
            // textBoxStart_SRR
            // 
            this.textBoxStart_SRR.Location = new System.Drawing.Point(10, 37);
            this.textBoxStart_SRR.Name = "textBoxStart_SRR";
            this.textBoxStart_SRR.Size = new System.Drawing.Size(160, 20);
            this.textBoxStart_SRR.TabIndex = 2;
            // 
            // labelStop_SRR
            // 
            this.labelStop_SRR.AutoSize = true;
            this.labelStop_SRR.Location = new System.Drawing.Point(251, 20);
            this.labelStop_SRR.Name = "labelStop_SRR";
            this.labelStop_SRR.Size = new System.Drawing.Size(69, 13);
            this.labelStop_SRR.TabIndex = 1;
            this.labelStop_SRR.Text = "Конец шага:";
            // 
            // labelStart_SRR
            // 
            this.labelStart_SRR.AutoSize = true;
            this.labelStart_SRR.Location = new System.Drawing.Point(7, 20);
            this.labelStart_SRR.Name = "labelStart_SRR";
            this.labelStart_SRR.Size = new System.Drawing.Size(67, 13);
            this.labelStart_SRR.TabIndex = 0;
            this.labelStart_SRR.Text = "Старт шага:";
            // 
            // groupBoxCondition_SRR
            // 
            this.groupBoxCondition_SRR.Controls.Add(this.pictureBox_SRR);
            this.groupBoxCondition_SRR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_SRR.Name = "groupBoxCondition_SRR";
            this.groupBoxCondition_SRR.Size = new System.Drawing.Size(839, 431);
            this.groupBoxCondition_SRR.TabIndex = 5;
            this.groupBoxCondition_SRR.TabStop = false;
            this.groupBoxCondition_SRR.Text = "Условие";
            // 
            // pictureBox_SRR
            // 
            this.pictureBox_SRR.ErrorImage = null;
            this.pictureBox_SRR.Image = global::Tyuiu.ShakirovRR.Sprint6.Task2.V15.Properties.Resources.t2v15;
            this.pictureBox_SRR.InitialImage = null;
            this.pictureBox_SRR.Location = new System.Drawing.Point(7, 20);
            this.pictureBox_SRR.Name = "pictureBox_SRR";
            this.pictureBox_SRR.Size = new System.Drawing.Size(642, 205);
            this.pictureBox_SRR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_SRR.TabIndex = 0;
            this.pictureBox_SRR.TabStop = false;
            // 
            // groupBoxResult_SRR
            // 
            this.groupBoxResult_SRR.Controls.Add(this.dataGridViewFuction_SRR);
            this.groupBoxResult_SRR.Controls.Add(this.chartFunction_SRR);
            this.groupBoxResult_SRR.Controls.Add(this.labelResult_SRR);
            this.groupBoxResult_SRR.Location = new System.Drawing.Point(857, 13);
            this.groupBoxResult_SRR.Name = "groupBoxResult_SRR";
            this.groupBoxResult_SRR.Size = new System.Drawing.Size(635, 576);
            this.groupBoxResult_SRR.TabIndex = 6;
            this.groupBoxResult_SRR.TabStop = false;
            this.groupBoxResult_SRR.Text = "Вывод данных";
            // 
            // dataGridViewFuction_SRR
            // 
            this.dataGridViewFuction_SRR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuction_SRR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnF});
            this.dataGridViewFuction_SRR.Location = new System.Drawing.Point(10, 36);
            this.dataGridViewFuction_SRR.Name = "dataGridViewFuction_SRR";
            this.dataGridViewFuction_SRR.RowHeadersVisible = false;
            this.dataGridViewFuction_SRR.Size = new System.Drawing.Size(134, 495);
            this.dataGridViewFuction_SRR.TabIndex = 3;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.Width = 50;
            // 
            // ColumnF
            // 
            this.ColumnF.HeaderText = "F(X)";
            this.ColumnF.Name = "ColumnF";
            this.ColumnF.Width = 50;
            // 
            // chartFunction_SRR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SRR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SRR.Legends.Add(legend1);
            this.chartFunction_SRR.Location = new System.Drawing.Point(150, 36);
            this.chartFunction_SRR.Name = "chartFunction_SRR";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SRR.Series.Add(series1);
            this.chartFunction_SRR.Size = new System.Drawing.Size(479, 314);
            this.chartFunction_SRR.TabIndex = 2;
            this.chartFunction_SRR.Text = "chart1";
            this.chartFunction_SRR.Click += new System.EventHandler(this.chartFunction_SRR_Click);
            // 
            // labelResult_SRR
            // 
            this.labelResult_SRR.AutoSize = true;
            this.labelResult_SRR.Location = new System.Drawing.Point(7, 20);
            this.labelResult_SRR.Name = "labelResult_SRR";
            this.labelResult_SRR.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SRR.TabIndex = 1;
            this.labelResult_SRR.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 601);
            this.Controls.Add(this.groupBoxResult_SRR);
            this.Controls.Add(this.groupBoxCondition_SRR);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.buttonHelp_SRR);
            this.Controls.Add(this.buttonDone_SRR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 15 | Шакиров Р.Р.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxCondition_SRR.ResumeLayout(false);
            this.groupBoxCondition_SRR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SRR)).EndInit();
            this.groupBoxResult_SRR.ResumeLayout(false);
            this.groupBoxResult_SRR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuction_SRR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SRR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_SRR;
        private System.Windows.Forms.Button buttonHelp_SRR;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxStop_SRR;
        private System.Windows.Forms.TextBox textBoxStart_SRR;
        private System.Windows.Forms.Label labelStop_SRR;
        private System.Windows.Forms.Label labelStart_SRR;
        private System.Windows.Forms.GroupBox groupBoxCondition_SRR;
        private System.Windows.Forms.PictureBox pictureBox_SRR;
        private System.Windows.Forms.GroupBox groupBoxResult_SRR;
        private System.Windows.Forms.Label labelResult_SRR;
        private System.Windows.Forms.DataGridView dataGridViewFuction_SRR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SRR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF;
    }
}

