namespace Tyuiu.AntonovVV.Sprint6.Task3.V1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCondition_AVV = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_AVV = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_AVV = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_AVV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_AVV = new System.Windows.Forms.TextBox();
            this.buttonHelp_AVV = new System.Windows.Forms.Button();
            this.buttonToDo_AVV = new System.Windows.Forms.Button();
            this.groupBoxCondition_AVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_AVV)).BeginInit();
            this.groupBoxResult_AVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_AVV
            // 
            this.groupBoxCondition_AVV.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBoxCondition_AVV.Controls.Add(this.textBoxCondition_AVV);
            this.groupBoxCondition_AVV.Location = new System.Drawing.Point(10, 11);
            this.groupBoxCondition_AVV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCondition_AVV.Name = "groupBoxCondition_AVV";
            this.groupBoxCondition_AVV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCondition_AVV.Size = new System.Drawing.Size(206, 275);
            this.groupBoxCondition_AVV.TabIndex = 0;
            this.groupBoxCondition_AVV.TabStop = false;
            this.groupBoxCondition_AVV.Text = "Условие";
            // 
            // textBoxCondition_AVV
            // 
            this.textBoxCondition_AVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_AVV.Location = new System.Drawing.Point(4, 42);
            this.textBoxCondition_AVV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCondition_AVV.Multiline = true;
            this.textBoxCondition_AVV.Name = "textBoxCondition_AVV";
            this.textBoxCondition_AVV.ReadOnly = true;
            this.textBoxCondition_AVV.Size = new System.Drawing.Size(198, 152);
            this.textBoxCondition_AVV.TabIndex = 0;
            this.textBoxCondition_AVV.Text = "Дана матрица 5 на 5\r\n -7   34  -2  25  5\r\n-16 -12  30 -3 17\r\n  3  -15  12  5  -5\r" +
            "\n 17   22 -3  32 -11\r\n  9    28  1  -9  -2\r\nВыполнить сортировку по возрастанию " +
            "\r\nво втором столбце  ";
            // 
            // dataGridViewMatrix_AVV
            // 
            this.dataGridViewMatrix_AVV.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridViewMatrix_AVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_AVV.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_AVV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMatrix_AVV.Location = new System.Drawing.Point(20, 42);
            this.dataGridViewMatrix_AVV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMatrix_AVV.Name = "dataGridViewMatrix_AVV";
            this.dataGridViewMatrix_AVV.ReadOnly = true;
            this.dataGridViewMatrix_AVV.RowHeadersVisible = false;
            this.dataGridViewMatrix_AVV.RowHeadersWidth = 51;
            this.dataGridViewMatrix_AVV.RowTemplate.Height = 24;
            this.dataGridViewMatrix_AVV.Size = new System.Drawing.Size(291, 290);
            this.dataGridViewMatrix_AVV.TabIndex = 1;
            // 
            // groupBoxResult_AVV
            // 
            this.groupBoxResult_AVV.Controls.Add(this.textBoxResult_AVV);
            this.groupBoxResult_AVV.Controls.Add(this.dataGridViewMatrix_AVV);
            this.groupBoxResult_AVV.Location = new System.Drawing.Point(225, 11);
            this.groupBoxResult_AVV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxResult_AVV.Name = "groupBoxResult_AVV";
            this.groupBoxResult_AVV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxResult_AVV.Size = new System.Drawing.Size(330, 345);
            this.groupBoxResult_AVV.TabIndex = 2;
            this.groupBoxResult_AVV.TabStop = false;
            this.groupBoxResult_AVV.Text = "Вывод данных";
            // 
            // textBoxResult_AVV
            // 
            this.textBoxResult_AVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_AVV.Location = new System.Drawing.Point(20, 18);
            this.textBoxResult_AVV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult_AVV.Name = "textBoxResult_AVV";
            this.textBoxResult_AVV.ReadOnly = true;
            this.textBoxResult_AVV.Size = new System.Drawing.Size(100, 13);
            this.textBoxResult_AVV.TabIndex = 2;
            this.textBoxResult_AVV.Text = "Результат:";
            // 
            // buttonHelp_AVV
            // 
            this.buttonHelp_AVV.Location = new System.Drawing.Point(10, 291);
            this.buttonHelp_AVV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp_AVV.Name = "buttonHelp_AVV";
            this.buttonHelp_AVV.Size = new System.Drawing.Size(82, 65);
            this.buttonHelp_AVV.TabIndex = 3;
            this.buttonHelp_AVV.Text = "Справка";
            this.buttonHelp_AVV.UseVisualStyleBackColor = true;
            this.buttonHelp_AVV.Click += new System.EventHandler(this.buttonHelp_AVV_Click);
            // 
            // buttonToDo_AVV
            // 
            this.buttonToDo_AVV.Location = new System.Drawing.Point(96, 291);
            this.buttonToDo_AVV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonToDo_AVV.Name = "buttonToDo_AVV";
            this.buttonToDo_AVV.Size = new System.Drawing.Size(119, 65);
            this.buttonToDo_AVV.TabIndex = 4;
            this.buttonToDo_AVV.Text = "Выполнить";
            this.buttonToDo_AVV.UseVisualStyleBackColor = true;
            this.buttonToDo_AVV.Click += new System.EventHandler(this.buttonToDo_AVV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 366);
            this.Controls.Add(this.buttonToDo_AVV);
            this.Controls.Add(this.buttonHelp_AVV);
            this.Controls.Add(this.groupBoxResult_AVV);
            this.Controls.Add(this.groupBoxCondition_AVV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 1 |Антонов В.В. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_AVV.ResumeLayout(false);
            this.groupBoxCondition_AVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_AVV)).EndInit();
            this.groupBoxResult_AVV.ResumeLayout(false);
            this.groupBoxResult_AVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_AVV;
        private System.Windows.Forms.TextBox textBoxCondition_AVV;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_AVV;
        private System.Windows.Forms.GroupBox groupBoxResult_AVV;
        private System.Windows.Forms.TextBox textBoxResult_AVV;
        private System.Windows.Forms.Button buttonHelp_AVV;
        private System.Windows.Forms.Button buttonToDo_AVV;
    }
}