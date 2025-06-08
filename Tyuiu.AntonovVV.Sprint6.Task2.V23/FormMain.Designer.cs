namespace Tyuiu.AntonovVV.Sprint6.Task2.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxOne_AVV = new GroupBox();
            labelCondition_AVV = new Label();
            groupBoxTwo_AVV = new GroupBox();
            buttonPerform_AVV = new Button();
            buttonReference_AVV = new Button();
            textBoxInputEnd_AVV = new TextBox();
            textBoxInputStart_AVV = new TextBox();
            labelEnd_AVV = new Label();
            labelStart_AVV = new Label();
            groupBoxThree_AVV = new GroupBox();
            chartFunction_AVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_AVV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            labelResult_AVV = new Label();
            groupBoxOne_AVV.SuspendLayout();
            groupBoxTwo_AVV.SuspendLayout();
            groupBoxThree_AVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AVV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AVV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOne_AVV
            // 
            groupBoxOne_AVV.Controls.Add(labelCondition_AVV);
            groupBoxOne_AVV.Font = new Font("Segoe UI", 12F);
            groupBoxOne_AVV.Location = new Point(12, 12);
            groupBoxOne_AVV.Name = "groupBoxOne_AVV";
            groupBoxOne_AVV.Size = new Size(535, 341);
            groupBoxOne_AVV.TabIndex = 0;
            groupBoxOne_AVV.TabStop = false;
            groupBoxOne_AVV.Text = "Условие";
            // 
            // labelCondition_AVV
            // 
            labelCondition_AVV.AutoSize = true;
            labelCondition_AVV.Location = new Point(6, 25);
            labelCondition_AVV.Name = "labelCondition_AVV";
            labelCondition_AVV.Size = new Size(416, 63);
            labelCondition_AVV.TabIndex = 0;
            labelCondition_AVV.Text = "Протабуллировать функцию (x) на заданном диапазоне.\r\nРезультат вывести в форме таблицы\r\n\r\n";
            // 
            // groupBoxTwo_AVV
            // 
            groupBoxTwo_AVV.Controls.Add(buttonPerform_AVV);
            groupBoxTwo_AVV.Controls.Add(buttonReference_AVV);
            groupBoxTwo_AVV.Controls.Add(textBoxInputEnd_AVV);
            groupBoxTwo_AVV.Controls.Add(textBoxInputStart_AVV);
            groupBoxTwo_AVV.Controls.Add(labelEnd_AVV);
            groupBoxTwo_AVV.Controls.Add(labelStart_AVV);
            groupBoxTwo_AVV.Font = new Font("Segoe UI", 12F);
            groupBoxTwo_AVV.Location = new Point(12, 359);
            groupBoxTwo_AVV.Name = "groupBoxTwo_AVV";
            groupBoxTwo_AVV.Size = new Size(535, 79);
            groupBoxTwo_AVV.TabIndex = 1;
            groupBoxTwo_AVV.TabStop = false;
            groupBoxTwo_AVV.Text = "Вывод данных";
            // 
            // buttonPerform_AVV
            // 
            buttonPerform_AVV.BackColor = Color.Green;
            buttonPerform_AVV.Location = new Point(381, 18);
            buttonPerform_AVV.Name = "buttonPerform_AVV";
            buttonPerform_AVV.Size = new Size(148, 55);
            buttonPerform_AVV.TabIndex = 6;
            buttonPerform_AVV.Text = "Выполнить";
            buttonPerform_AVV.UseVisualStyleBackColor = false;
            buttonPerform_AVV.Click += buttonPerform_AVV_Click;
            // 
            // buttonReference_AVV
            // 
            buttonReference_AVV.BackColor = Color.FromArgb(0, 192, 192);
            buttonReference_AVV.Location = new Point(294, 18);
            buttonReference_AVV.Name = "buttonReference_AVV";
            buttonReference_AVV.Size = new Size(81, 55);
            buttonReference_AVV.TabIndex = 5;
            buttonReference_AVV.Text = "Справка";
            buttonReference_AVV.UseVisualStyleBackColor = false;
            buttonReference_AVV.Click += buttonReference_AVV_Click;
            // 
            // textBoxInputEnd_AVV
            // 
            textBoxInputEnd_AVV.Location = new Point(151, 49);
            textBoxInputEnd_AVV.Multiline = true;
            textBoxInputEnd_AVV.Name = "textBoxInputEnd_AVV";
            textBoxInputEnd_AVV.Size = new Size(121, 30);
            textBoxInputEnd_AVV.TabIndex = 3;
            // 
            // textBoxInputStart_AVV
            // 
            textBoxInputStart_AVV.Location = new Point(0, 49);
            textBoxInputStart_AVV.Multiline = true;
            textBoxInputStart_AVV.Name = "textBoxInputStart_AVV";
            textBoxInputStart_AVV.Size = new Size(124, 30);
            textBoxInputStart_AVV.TabIndex = 2;
            // 
            // labelEnd_AVV
            // 
            labelEnd_AVV.AutoSize = true;
            labelEnd_AVV.Location = new Point(151, 28);
            labelEnd_AVV.Name = "labelEnd_AVV";
            labelEnd_AVV.Size = new Size(97, 21);
            labelEnd_AVV.TabIndex = 1;
            labelEnd_AVV.Text = "Конец шага:";
            // 
            // labelStart_AVV
            // 
            labelStart_AVV.AutoSize = true;
            labelStart_AVV.Location = new Point(6, 25);
            labelStart_AVV.Name = "labelStart_AVV";
            labelStart_AVV.Size = new Size(93, 21);
            labelStart_AVV.TabIndex = 0;
            labelStart_AVV.Text = "Старт шага:";
            // 
            // groupBoxThree_AVV
            // 
            groupBoxThree_AVV.Controls.Add(chartFunction_AVV);
            groupBoxThree_AVV.Controls.Add(dataGridViewFunction_AVV);
            groupBoxThree_AVV.Controls.Add(labelResult_AVV);
            groupBoxThree_AVV.Font = new Font("Segoe UI", 12F);
            groupBoxThree_AVV.Location = new Point(562, 12);
            groupBoxThree_AVV.Name = "groupBoxThree_AVV";
            groupBoxThree_AVV.Size = new Size(621, 426);
            groupBoxThree_AVV.TabIndex = 1;
            groupBoxThree_AVV.TabStop = false;
            groupBoxThree_AVV.Text = "Вывод данных";
            // 
            // chartFunction_AVV
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_AVV.ChartAreas.Add(chartArea2);
            chartFunction_AVV.Location = new Point(227, 49);
            chartFunction_AVV.Name = "chartFunction_AVV";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            chartFunction_AVV.Series.Add(series2);
            chartFunction_AVV.Size = new Size(388, 371);
            chartFunction_AVV.TabIndex = 2;
            chartFunction_AVV.Text = "chart1";
            // 
            // dataGridViewFunction_AVV
            // 
            dataGridViewFunction_AVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_AVV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewFunction_AVV.Location = new Point(6, 49);
            dataGridViewFunction_AVV.Name = "dataGridViewFunction_AVV";
            dataGridViewFunction_AVV.RowHeadersVisible = false;
            dataGridViewFunction_AVV.Size = new Size(202, 371);
            dataGridViewFunction_AVV.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.Name = "Column2";
            // 
            // labelResult_AVV
            // 
            labelResult_AVV.AutoSize = true;
            labelResult_AVV.Location = new Point(6, 25);
            labelResult_AVV.Name = "labelResult_AVV";
            labelResult_AVV.Size = new Size(83, 21);
            labelResult_AVV.TabIndex = 0;
            labelResult_AVV.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 450);
            Controls.Add(groupBoxTwo_AVV);
            Controls.Add(groupBoxThree_AVV);
            Controls.Add(groupBoxOne_AVV);
            Name = "Form1";
            Text = "Form1";
            groupBoxOne_AVV.ResumeLayout(false);
            groupBoxOne_AVV.PerformLayout();
            groupBoxTwo_AVV.ResumeLayout(false);
            groupBoxTwo_AVV.PerformLayout();
            groupBoxThree_AVV.ResumeLayout(false);
            groupBoxThree_AVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AVV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AVV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOne_AVV;
        private Label labelCondition_AVV;
        private GroupBox groupBoxTwo_AVV;
        private GroupBox groupBoxThree_AVV;
        private Label labelResult_AVV;
        private Label labelEnd_AVV;
        private Label labelStart_AVV;
        private Button buttonPerform_AVV;
        private Button buttonReference_AVV;
        private TextBox textBoxInputEnd_AVV;
        private TextBox textBoxInputStart_AVV;
        private DataGridView dataGridViewFunction_AVV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AVV;
    }
}