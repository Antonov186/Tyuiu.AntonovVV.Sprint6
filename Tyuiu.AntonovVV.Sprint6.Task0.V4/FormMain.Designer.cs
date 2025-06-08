namespace Tyuiu.AntonovVV.Sprint6.Task0.V4
{
    partial class FormMain_AVV
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
            this.groupBoxCondition_AVV = new System.Windows.Forms.GroupBox();
            this.groupBoxInputData_AVV = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputData_AVV = new System.Windows.Forms.GroupBox();
            this.buttonGet_AVV = new System.Windows.Forms.Button();
            this.labelCondition_AVV = new System.Windows.Forms.Label();
            this.labelExample_AVV = new System.Windows.Forms.Label();
            this.labelVarX_AVV = new System.Windows.Forms.Label();
            this.textBoxVarX_AVV = new System.Windows.Forms.TextBox();
            this.textBoxResult_AVV = new System.Windows.Forms.TextBox();
            this.labelResult_AVV = new System.Windows.Forms.Label();
            this.groupBoxCondition_AVV.SuspendLayout();
            this.groupBoxInputData_AVV.SuspendLayout();
            this.groupBoxOutputData_AVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_AVV
            // 
            this.groupBoxCondition_AVV.Controls.Add(this.labelExample_AVV);
            this.groupBoxCondition_AVV.Controls.Add(this.labelCondition_AVV);
            this.groupBoxCondition_AVV.Location = new System.Drawing.Point(10, 12);
            this.groupBoxCondition_AVV.Name = "groupBoxCondition_AVV";
            this.groupBoxCondition_AVV.Size = new System.Drawing.Size(778, 259);
            this.groupBoxCondition_AVV.TabIndex = 0;
            this.groupBoxCondition_AVV.TabStop = false;
            this.groupBoxCondition_AVV.Text = "Условие";
            // 
            // groupBoxInputData_AVV
            // 
            this.groupBoxInputData_AVV.Controls.Add(this.textBoxVarX_AVV);
            this.groupBoxInputData_AVV.Controls.Add(this.labelVarX_AVV);
            this.groupBoxInputData_AVV.Location = new System.Drawing.Point(12, 277);
            this.groupBoxInputData_AVV.Name = "groupBoxInputData_AVV";
            this.groupBoxInputData_AVV.Size = new System.Drawing.Size(523, 100);
            this.groupBoxInputData_AVV.TabIndex = 1;
            this.groupBoxInputData_AVV.TabStop = false;
            this.groupBoxInputData_AVV.Text = "Ввод данных";
            // 
            // groupBoxOutputData_AVV
            // 
            this.groupBoxOutputData_AVV.Controls.Add(this.labelResult_AVV);
            this.groupBoxOutputData_AVV.Controls.Add(this.textBoxResult_AVV);
            this.groupBoxOutputData_AVV.Location = new System.Drawing.Point(541, 277);
            this.groupBoxOutputData_AVV.Name = "groupBoxOutputData_AVV";
            this.groupBoxOutputData_AVV.Size = new System.Drawing.Size(247, 100);
            this.groupBoxOutputData_AVV.TabIndex = 2;
            this.groupBoxOutputData_AVV.TabStop = false;
            this.groupBoxOutputData_AVV.Text = "Вывод данных";
            // 
            // buttonGet_AVV
            // 
            this.buttonGet_AVV.Location = new System.Drawing.Point(541, 383);
            this.buttonGet_AVV.Name = "buttonGet_AVV";
            this.buttonGet_AVV.Size = new System.Drawing.Size(247, 41);
            this.buttonGet_AVV.TabIndex = 3;
            this.buttonGet_AVV.Text = "Выполнить";
            this.buttonGet_AVV.UseVisualStyleBackColor = true;
            this.buttonGet_AVV.Click += new System.EventHandler(this.buttonGet_AVV_Click);
            // 
            // labelCondition_AVV
            // 
            this.labelCondition_AVV.AutoSize = true;
            this.labelCondition_AVV.Location = new System.Drawing.Point(7, 33);
            this.labelCondition_AVV.Name = "labelCondition_AVV";
            this.labelCondition_AVV.Size = new System.Drawing.Size(241, 17);
            this.labelCondition_AVV.TabIndex = 0;
            this.labelCondition_AVV.Text = "Вычислить выражение по формуле";
            // 
            // labelExample_AVV
            // 
            this.labelExample_AVV.AutoSize = true;
            this.labelExample_AVV.Location = new System.Drawing.Point(7, 50);
            this.labelExample_AVV.Name = "labelExample_AVV";
            this.labelExample_AVV.Size = new System.Drawing.Size(221, 17);
            this.labelExample_AVV.TabIndex = 1;
            this.labelExample_AVV.Text = "F(x) = 2.4x^3 + 0.4x^2 - 1.4x + 4.1";
            // 
            // labelVarX_AVV
            // 
            this.labelVarX_AVV.AutoSize = true;
            this.labelVarX_AVV.Location = new System.Drawing.Point(4, 33);
            this.labelVarX_AVV.Name = "labelVarX_AVV";
            this.labelVarX_AVV.Size = new System.Drawing.Size(104, 17);
            this.labelVarX_AVV.TabIndex = 0;
            this.labelVarX_AVV.Text = "Переменная X";
            // 
            // textBoxVarX_AVV
            // 
            this.textBoxVarX_AVV.Location = new System.Drawing.Point(8, 53);
            this.textBoxVarX_AVV.Name = "textBoxVarX_AVV";
            this.textBoxVarX_AVV.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarX_AVV.TabIndex = 1;
            this.textBoxVarX_AVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_AVV_KeyPress);
            // 
            // textBoxResult_AVV
            // 
            this.textBoxResult_AVV.Location = new System.Drawing.Point(6, 53);
            this.textBoxResult_AVV.Name = "textBoxResult_AVV";
            this.textBoxResult_AVV.ReadOnly = true;
            this.textBoxResult_AVV.Size = new System.Drawing.Size(235, 22);
            this.textBoxResult_AVV.TabIndex = 0;
            // 
            // labelResult_AVV
            // 
            this.labelResult_AVV.AutoSize = true;
            this.labelResult_AVV.Location = new System.Drawing.Point(6, 33);
            this.labelResult_AVV.Name = "labelResult_AVV";
            this.labelResult_AVV.Size = new System.Drawing.Size(76, 17);
            this.labelResult_AVV.TabIndex = 1;
            this.labelResult_AVV.Text = "Результат";
            // 
            // FormMain_AVV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGet_AVV);
            this.Controls.Add(this.groupBoxOutputData_AVV);
            this.Controls.Add(this.groupBoxInputData_AVV);
            this.Controls.Add(this.groupBoxCondition_AVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_AVV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 4 | Коротченко Д.М.";
            this.groupBoxCondition_AVV.ResumeLayout(false);
            this.groupBoxCondition_AVV.PerformLayout();
            this.groupBoxInputData_AVV.ResumeLayout(false);
            this.groupBoxInputData_AVV.PerformLayout();
            this.groupBoxOutputData_AVV.ResumeLayout(false);
            this.groupBoxOutputData_AVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_AVV;
        private System.Windows.Forms.Label labelExample_AVV;
        private System.Windows.Forms.Label labelCondition_AVV;
        private System.Windows.Forms.GroupBox groupBoxInputData_AVV;
        private System.Windows.Forms.TextBox textBoxVarX_AVV;
        private System.Windows.Forms.Label labelVarX_AVV;
        private System.Windows.Forms.GroupBox groupBoxOutputData_AVV;
        private System.Windows.Forms.Label labelResult_AVV;
        private System.Windows.Forms.TextBox textBoxResult_AVV;
        private System.Windows.Forms.Button buttonGet_AVV;
    }