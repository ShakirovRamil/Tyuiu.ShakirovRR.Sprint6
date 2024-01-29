
namespace Tyuiu.ShakirovRR.Sprint6.Task1.V1
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
            this.buttonHelp_SRR = new System.Windows.Forms.Button();
            this.buttonDone_SRR = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SRR = new System.Windows.Forms.TextBox();
            this.textBoxStart_SRR = new System.Windows.Forms.TextBox();
            this.labelStop_SRR = new System.Windows.Forms.Label();
            this.labelStart_SRR = new System.Windows.Forms.Label();
            this.groupBoxCondition_SRR = new System.Windows.Forms.GroupBox();
            this.pictureBox_SRR = new System.Windows.Forms.PictureBox();
            this.groupBoxResult_SRR = new System.Windows.Forms.GroupBox();
            this.labelResult_SRR = new System.Windows.Forms.Label();
            this.textBoxResult_SRR = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxInput.SuspendLayout();
            this.groupBoxCondition_SRR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SRR)).BeginInit();
            this.groupBoxResult_SRR.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHelp_SRR
            // 
            this.buttonHelp_SRR.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp_SRR.Location = new System.Drawing.Point(538, 574);
            this.buttonHelp_SRR.Name = "buttonHelp_SRR";
            this.buttonHelp_SRR.Size = new System.Drawing.Size(135, 95);
            this.buttonHelp_SRR.TabIndex = 0;
            this.buttonHelp_SRR.Text = "Справка";
            this.buttonHelp_SRR.UseVisualStyleBackColor = false;
            this.buttonHelp_SRR.Click += new System.EventHandler(this.buttonHelp_SRR_Click);
            // 
            // buttonDone_SRR
            // 
            this.buttonDone_SRR.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_SRR.Location = new System.Drawing.Point(680, 574);
            this.buttonDone_SRR.Name = "buttonDone_SRR";
            this.buttonDone_SRR.Size = new System.Drawing.Size(173, 95);
            this.buttonDone_SRR.TabIndex = 1;
            this.buttonDone_SRR.Text = "Выполнить";
            this.buttonDone_SRR.UseVisualStyleBackColor = false;
            this.buttonDone_SRR.Click += new System.EventHandler(this.buttonDone_SRR_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxStop_SRR);
            this.groupBoxInput.Controls.Add(this.textBoxStart_SRR);
            this.groupBoxInput.Controls.Add(this.labelStop_SRR);
            this.groupBoxInput.Controls.Add(this.labelStart_SRR);
            this.groupBoxInput.Location = new System.Drawing.Point(13, 574);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(519, 95);
            this.groupBoxInput.TabIndex = 2;
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
            this.textBoxStart_SRR.TextChanged += new System.EventHandler(this.textBoxStart_SRR_TextChanged);
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
            this.groupBoxCondition_SRR.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_SRR.Name = "groupBoxCondition_SRR";
            this.groupBoxCondition_SRR.Size = new System.Drawing.Size(840, 555);
            this.groupBoxCondition_SRR.TabIndex = 3;
            this.groupBoxCondition_SRR.TabStop = false;
            this.groupBoxCondition_SRR.Text = "Условие";
            // 
            // pictureBox_SRR
            // 
            this.pictureBox_SRR.ErrorImage = null;
            this.pictureBox_SRR.Image = global::Tyuiu.ShakirovRR.Sprint6.Task1.V1.Properties.Resources.t1v1;
            this.pictureBox_SRR.InitialImage = null;
            this.pictureBox_SRR.Location = new System.Drawing.Point(7, 20);
            this.pictureBox_SRR.Name = "pictureBox_SRR";
            this.pictureBox_SRR.Size = new System.Drawing.Size(634, 208);
            this.pictureBox_SRR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_SRR.TabIndex = 0;
            this.pictureBox_SRR.TabStop = false;
            this.pictureBox_SRR.Click += new System.EventHandler(this.pictureBox_SRR_Click);
            // 
            // groupBoxResult_SRR
            // 
            this.groupBoxResult_SRR.Controls.Add(this.labelResult_SRR);
            this.groupBoxResult_SRR.Controls.Add(this.textBoxResult_SRR);
            this.groupBoxResult_SRR.Location = new System.Drawing.Point(860, 13);
            this.groupBoxResult_SRR.Name = "groupBoxResult_SRR";
            this.groupBoxResult_SRR.Size = new System.Drawing.Size(392, 656);
            this.groupBoxResult_SRR.TabIndex = 4;
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
            // textBoxResult_SRR
            // 
            this.textBoxResult_SRR.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SRR.Location = new System.Drawing.Point(10, 36);
            this.textBoxResult_SRR.Multiline = true;
            this.textBoxResult_SRR.Name = "textBoxResult_SRR";
            this.textBoxResult_SRR.ReadOnly = true;
            this.textBoxResult_SRR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SRR.Size = new System.Drawing.Size(376, 614);
            this.textBoxResult_SRR.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBoxResult_SRR);
            this.Controls.Add(this.groupBoxCondition_SRR);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.buttonDone_SRR);
            this.Controls.Add(this.buttonHelp_SRR);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 1 | Шакиров Р.Р.";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxCondition_SRR.ResumeLayout(false);
            this.groupBoxCondition_SRR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SRR)).EndInit();
            this.groupBoxResult_SRR.ResumeLayout(false);
            this.groupBoxResult_SRR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_SRR;
        private System.Windows.Forms.Button buttonDone_SRR;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxStop_SRR;
        private System.Windows.Forms.TextBox textBoxStart_SRR;
        private System.Windows.Forms.Label labelStop_SRR;
        private System.Windows.Forms.Label labelStart_SRR;
        private System.Windows.Forms.GroupBox groupBoxCondition_SRR;
        private System.Windows.Forms.GroupBox groupBoxResult_SRR;
        private System.Windows.Forms.Label labelResult_SRR;
        private System.Windows.Forms.TextBox textBoxResult_SRR;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox_SRR;
    }
}

