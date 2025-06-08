namespace Tyuiu.AntonovVV.Sprint6.Task5.V14
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_AVV = new System.Windows.Forms.Panel();
            this.panelLeft_AVV = new System.Windows.Forms.Panel();
            this.panelFill_AVV = new System.Windows.Forms.Panel();
            this.groupBoxUsl_AVV = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOpen_AVV = new System.Windows.Forms.Button();
            this.buttonInfo_AVV = new System.Windows.Forms.Button();
            this.buttonDone_AVV = new System.Windows.Forms.Button();
            this.groupBoxInPut_AVV = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_AVV = new System.Windows.Forms.DataGridView();
            this.chartInPut_AVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_AVV.SuspendLayout();
            this.panelLeft_AVV.SuspendLayout();
            this.panelFill_AVV.SuspendLayout();
            this.groupBoxUsl_AVV.SuspendLayout();
            this.groupBoxInPut_AVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_AVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInPut_AVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_AVV
            // 
            this.panelTop_AVV.Controls.Add(this.buttonInfo_AVV);
            this.panelTop_AVV.Controls.Add(this.buttonDone_AVV);
            this.panelTop_AVV.Controls.Add(this.buttonOpen_AVV);
            this.panelTop_AVV.Controls.Add(this.groupBoxUsl_AVV);
            this.panelTop_AVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AVV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AVV.Name = "panelTop_AVV";
            this.panelTop_AVV.Size = new System.Drawing.Size(872, 116);
            this.panelTop_AVV.TabIndex = 0;
            // 
            // panelLeft_AVV
            // 
            this.panelLeft_AVV.Controls.Add(this.groupBoxInPut_AVV);
            this.panelLeft_AVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AVV.Location = new System.Drawing.Point(0, 116);
            this.panelLeft_AVV.Name = "panelLeft_AVV";
            this.panelLeft_AVV.Size = new System.Drawing.Size(201, 412);
            this.panelLeft_AVV.TabIndex = 1;
            // 
            // panelFill_AVV
            // 
            this.panelFill_AVV.Controls.Add(this.chartInPut_AVV);
            this.panelFill_AVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_AVV.Location = new System.Drawing.Point(201, 116);
            this.panelFill_AVV.Name = "panelFill_AVV";
            this.panelFill_AVV.Size = new System.Drawing.Size(671, 412);
            this.panelFill_AVV.TabIndex = 2;
            // 
            // groupBoxUsl_AVV
            // 
            this.groupBoxUsl_AVV.Controls.Add(this.textBox1);
            this.groupBoxUsl_AVV.Location = new System.Drawing.Point(4, 4);
            this.groupBoxUsl_AVV.Name = "groupBoxUsl_AVV";
            this.groupBoxUsl_AVV.Size = new System.Drawing.Size(473, 101);
            this.groupBoxUsl_AVV.TabIndex = 0;
            this.groupBoxUsl_AVV.TabStop = false;
            this.groupBoxUsl_AVV.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(458, 73);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V14.txt. Вывести в datagridView числа, бо" +
        "льше или равные 10. Построить диаграмму по этим значениям.";
            // 
            // buttonOpen_AVV
            // 
            this.buttonOpen_AVV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonOpen_AVV.Location = new System.Drawing.Point(615, 12);
            this.buttonOpen_AVV.Name = "buttonOpen_AVV";
            this.buttonOpen_AVV.Size = new System.Drawing.Size(113, 92);
            this.buttonOpen_AVV.TabIndex = 2;
            this.buttonOpen_AVV.Text = "Открыть файл";
            this.buttonOpen_AVV.UseVisualStyleBackColor = false;
            this.buttonOpen_AVV.Click += new System.EventHandler(this.buttonOpen_AVV_Click);
            // 
            // buttonInfo_AVV
            // 
            this.buttonInfo_AVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_AVV.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonInfo_AVV.Location = new System.Drawing.Point(747, 12);
            this.buttonInfo_AVV.Name = "buttonInfo_AVV";
            this.buttonInfo_AVV.Size = new System.Drawing.Size(113, 92);
            this.buttonInfo_AVV.TabIndex = 2;
            this.buttonInfo_AVV.Text = "Справка";
            this.buttonInfo_AVV.UseVisualStyleBackColor = false;
            this.buttonInfo_AVV.Click += new System.EventHandler(this.buttonInfo_AVV_Click);
            // 
            // buttonDone_AVV
            // 
            this.buttonDone_AVV.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDone_AVV.Location = new System.Drawing.Point(496, 12);
            this.buttonDone_AVV.Name = "buttonDone_AVV";
            this.buttonDone_AVV.Size = new System.Drawing.Size(113, 92);
            this.buttonDone_AVV.TabIndex = 2;
            this.buttonDone_AVV.Text = "Выполнить";
            this.buttonDone_AVV.UseVisualStyleBackColor = false;
            this.buttonDone_AVV.Click += new System.EventHandler(this.buttonDone_AVV_Click);
            // 
            // groupBoxInPut_AVV
            // 
            this.groupBoxInPut_AVV.Controls.Add(this.dataGridViewInPut_AVV);
            this.groupBoxInPut_AVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_AVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_AVV.Name = "groupBoxInPut_AVV";
            this.groupBoxInPut_AVV.Size = new System.Drawing.Size(201, 412);
            this.groupBoxInPut_AVV.TabIndex = 0;
            this.groupBoxInPut_AVV.TabStop = false;
            this.groupBoxInPut_AVV.Text = "Вывод данных";
            // 
            // dataGridViewInPut_AVV
            // 
            this.dataGridViewInPut_AVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_AVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_AVV.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInPut_AVV.Name = "dataGridViewInPut_AVV";
            this.dataGridViewInPut_AVV.RowHeadersWidth = 51;
            this.dataGridViewInPut_AVV.RowTemplate.Height = 24;
            this.dataGridViewInPut_AVV.Size = new System.Drawing.Size(195, 391);
            this.dataGridViewInPut_AVV.TabIndex = 0;
            // 
            // chartInPut_AVV
            // 
            chartArea2.Name = "ChartArea1";
            this.chartInPut_AVV.ChartAreas.Add(chartArea2);
            this.chartInPut_AVV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartInPut_AVV.Legends.Add(legend2);
            this.chartInPut_AVV.Location = new System.Drawing.Point(0, 0);
            this.chartInPut_AVV.Name = "chartInPut_AVV";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartInPut_AVV.Series.Add(series2);
            this.chartInPut_AVV.Size = new System.Drawing.Size(671, 412);
            this.chartInPut_AVV.TabIndex = 0;
            this.chartInPut_AVV.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 528);
            this.Controls.Add(this.panelFill_AVV);
            this.Controls.Add(this.panelLeft_AVV);
            this.Controls.Add(this.panelTop_AVV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Таск 5  | Вариант 14  | Антонов В.В.";
            this.panelTop_AVV.ResumeLayout(false);
            this.panelLeft_AVV.ResumeLayout(false);
            this.panelFill_AVV.ResumeLayout(false);
            this.groupBoxUsl_AVV.ResumeLayout(false);
            this.groupBoxUsl_AVV.PerformLayout();
            this.groupBoxInPut_AVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_AVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInPut_AVV)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AVV;
        private System.Windows.Forms.Button buttonInfo_AVV;
        private System.Windows.Forms.Button buttonDone_AVV;
        private System.Windows.Forms.Button buttonOpen_AVV;
        private System.Windows.Forms.GroupBox groupBoxUsl_AVV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelLeft_AVV;
        private System.Windows.Forms.GroupBox groupBoxInPut_AVV;
        private System.Windows.Forms.DataGridView dataGridViewInPut_AVV;
        private System.Windows.Forms.Panel panelFill_AVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInPut_AVV;
    }
}