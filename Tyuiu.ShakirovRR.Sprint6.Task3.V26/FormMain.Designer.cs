
namespace Tyuiu.ShakirovRR.Sprint6.Task3.V26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_SRR = new System.Windows.Forms.GroupBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.dataGridViewCondition_SRR = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_SRR = new System.Windows.Forms.GroupBox();
            this.labelResult_SRR = new System.Windows.Forms.Label();
            this.buttonHelp_SRR = new System.Windows.Forms.Button();
            this.buttonDone_SRR = new System.Windows.Forms.Button();
            this.dataGridViewOutput_SRR = new System.Windows.Forms.DataGridView();
            this.groupBoxCondition_SRR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCondition_SRR)).BeginInit();
            this.groupBoxResult_SRR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SRR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SRR
            // 
            this.groupBoxCondition_SRR.Controls.Add(this.dataGridViewCondition_SRR);
            this.groupBoxCondition_SRR.Controls.Add(this.labelCondition);
            this.groupBoxCondition_SRR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_SRR.Name = "groupBoxCondition_SRR";
            this.groupBoxCondition_SRR.Size = new System.Drawing.Size(798, 417);
            this.groupBoxCondition_SRR.TabIndex = 4;
            this.groupBoxCondition_SRR.TabStop = false;
            this.groupBoxCondition_SRR.Text = "Условие";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(7, 20);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(422, 208);
            this.labelCondition.TabIndex = 0;
            this.labelCondition.Text = resources.GetString("labelCondition.Text");
            // 
            // dataGridViewCondition_SRR
            // 
            this.dataGridViewCondition_SRR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCondition_SRR.Location = new System.Drawing.Point(435, 19);
            this.dataGridViewCondition_SRR.Name = "dataGridViewCondition_SRR";
            this.dataGridViewCondition_SRR.RowHeadersVisible = false;
            this.dataGridViewCondition_SRR.Size = new System.Drawing.Size(357, 357);
            this.dataGridViewCondition_SRR.TabIndex = 4;
            // 
            // groupBoxResult_SRR
            // 
            this.groupBoxResult_SRR.Controls.Add(this.dataGridViewOutput_SRR);
            this.groupBoxResult_SRR.Controls.Add(this.labelResult_SRR);
            this.groupBoxResult_SRR.Location = new System.Drawing.Point(816, 12);
            this.groupBoxResult_SRR.Name = "groupBoxResult_SRR";
            this.groupBoxResult_SRR.Size = new System.Drawing.Size(336, 369);
            this.groupBoxResult_SRR.TabIndex = 5;
            this.groupBoxResult_SRR.TabStop = false;
            this.groupBoxResult_SRR.Text = "Вывод данных";
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
            // buttonHelp_SRR
            // 
            this.buttonHelp_SRR.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp_SRR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHelp_SRR.Location = new System.Drawing.Point(816, 387);
            this.buttonHelp_SRR.Name = "buttonHelp_SRR";
            this.buttonHelp_SRR.Size = new System.Drawing.Size(45, 42);
            this.buttonHelp_SRR.TabIndex = 6;
            this.buttonHelp_SRR.Text = "?";
            this.buttonHelp_SRR.UseVisualStyleBackColor = false;
            this.buttonHelp_SRR.Click += new System.EventHandler(this.buttonHelp_SRR_Click);
            // 
            // buttonDone_SRR
            // 
            this.buttonDone_SRR.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_SRR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDone_SRR.Location = new System.Drawing.Point(1008, 387);
            this.buttonDone_SRR.Name = "buttonDone_SRR";
            this.buttonDone_SRR.Size = new System.Drawing.Size(144, 42);
            this.buttonDone_SRR.TabIndex = 7;
            this.buttonDone_SRR.Text = "Выполнить";
            this.buttonDone_SRR.UseVisualStyleBackColor = false;
            this.buttonDone_SRR.Click += new System.EventHandler(this.buttonDone_SRR_Click);
            // 
            // dataGridViewOutput_SRR
            // 
            this.dataGridViewOutput_SRR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_SRR.Location = new System.Drawing.Point(10, 45);
            this.dataGridViewOutput_SRR.Name = "dataGridViewOutput_SRR";
            this.dataGridViewOutput_SRR.RowHeadersVisible = false;
            this.dataGridViewOutput_SRR.Size = new System.Drawing.Size(300, 300);
            this.dataGridViewOutput_SRR.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 441);
            this.Controls.Add(this.buttonDone_SRR);
            this.Controls.Add(this.buttonHelp_SRR);
            this.Controls.Add(this.groupBoxResult_SRR);
            this.Controls.Add(this.groupBoxCondition_SRR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 26 | Шакиров Р.Р.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_SRR.ResumeLayout(false);
            this.groupBoxCondition_SRR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCondition_SRR)).EndInit();
            this.groupBoxResult_SRR.ResumeLayout(false);
            this.groupBoxResult_SRR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SRR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SRR;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.DataGridView dataGridViewCondition_SRR;
        private System.Windows.Forms.GroupBox groupBoxResult_SRR;
        private System.Windows.Forms.Label labelResult_SRR;
        private System.Windows.Forms.Button buttonHelp_SRR;
        private System.Windows.Forms.Button buttonDone_SRR;
        private System.Windows.Forms.DataGridView dataGridViewOutput_SRR;
    }
}

