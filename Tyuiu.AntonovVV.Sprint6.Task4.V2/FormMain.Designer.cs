namespace Tyuiu.AntonovVV.Sprint6.Task4.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelCondition = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.labelEnd = new System.Windows.Forms.Label();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.groupBoxTextCondition = new System.Windows.Forms.GroupBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.panelGraphic = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelCondition.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxTextCondition.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.panelGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCondition
            // 
            this.panelCondition.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCondition.Controls.Add(this.buttonInfo);
            this.panelCondition.Controls.Add(this.buttonSave);
            this.panelCondition.Controls.Add(this.buttonResult);
            this.panelCondition.Controls.Add(this.groupBoxInput);
            this.panelCondition.Controls.Add(this.groupBoxCondition);
            this.panelCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition.Location = new System.Drawing.Point(0, 0);
            this.panelCondition.Name = "panelCondition";
            this.panelCondition.Size = new System.Drawing.Size(891, 81);
            this.panelCondition.TabIndex = 0;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonInfo.Location = new System.Drawing.Point(812, 12);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(72, 58);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSave.Location = new System.Drawing.Point(734, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(72, 58);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonResult.Location = new System.Drawing.Point(656, 12);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(72, 58);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = "Выполнить";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxEnd);
            this.groupBoxInput.Controls.Add(this.labelEnd);
            this.groupBoxInput.Controls.Add(this.textBoxStart);
            this.groupBoxInput.Controls.Add(this.labelStart);
            this.groupBoxInput.Location = new System.Drawing.Point(398, 4);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(252, 74);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных:";
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(125, 37);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd.TabIndex = 3;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(122, 18);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(69, 13);
            this.labelEnd.TabIndex = 2;
            this.labelEnd.Text = "Конец шага:";
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(10, 37);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart.TabIndex = 1;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(7, 20);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(67, 13);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Старт шага:";
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxCondition.Controls.Add(this.groupBoxTextCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(395, 75);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // groupBoxTextCondition
            // 
            this.groupBoxTextCondition.Controls.Add(this.labelCondition);
            this.groupBoxTextCondition.Location = new System.Drawing.Point(10, 19);
            this.groupBoxTextCondition.Name = "groupBoxTextCondition";
            this.groupBoxTextCondition.Size = new System.Drawing.Size(379, 53);
            this.groupBoxTextCondition.TabIndex = 0;
            this.groupBoxTextCondition.TabStop = false;
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(7, 8);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(360, 52);
            this.labelCondition.TabIndex = 0;
            this.labelCondition.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и сохранить\r\nв файл OutPutFileTask.txt по нажати" +
    "ю.\r\n\r\n";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelLeft.Controls.Add(this.groupBoxOutput);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 81);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft.Size = new System.Drawing.Size(242, 421);
            this.panelLeft.TabIndex = 1;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxOutput.Controls.Add(this.textBoxResult);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(232, 411);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(226, 392);
            this.textBoxResult.TabIndex = 0;
            // 
            // panelGraphic
            // 
            this.panelGraphic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelGraphic.Controls.Add(this.chartResult);
            this.panelGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraphic.Location = new System.Drawing.Point(242, 81);
            this.panelGraphic.Name = "panelGraphic";
            this.panelGraphic.Size = new System.Drawing.Size(649, 421);
            this.panelGraphic.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(242, 81);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 421);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // chartResult
            // 
            chartArea3.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea3);
            this.chartResult.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartResult.Legends.Add(legend3);
            this.chartResult.Location = new System.Drawing.Point(0, 0);
            this.chartResult.Name = "chartResult";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartResult.Series.Add(series3);
            this.chartResult.Size = new System.Drawing.Size(649, 421);
            this.chartResult.TabIndex = 0;
            this.chartResult.Text = "chartFunction";
            title3.Name = "Title1";
            title3.Text = "График функции";
            this.chartResult.Titles.Add(title3);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 502);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelGraphic);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelCondition);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 2 | Антонов В. В.";
            this.panelCondition.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxTextCondition.ResumeLayout(false);
            this.groupBoxTextCondition.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.panelGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCondition;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelGraphic;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxTextCondition;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
    }
}