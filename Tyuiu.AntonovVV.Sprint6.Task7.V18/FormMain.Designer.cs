namespace Tyuiu.AntonovVV.Sprint6.Task7.V18
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelUp_AVV = new System.Windows.Forms.Panel();
            this.buttonSaveFile_AVV = new System.Windows.Forms.Button();
            this.buttonSpravka_AVV = new System.Windows.Forms.Button();
            this.buttonDoneClick_AVV = new System.Windows.Forms.Button();
            this.buttonOpenFile_AVV = new System.Windows.Forms.Button();
            this.panelUpTwo_AVV = new System.Windows.Forms.Panel();
            this.groupBoxCondition_AVV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_AVV = new System.Windows.Forms.TextBox();
            this.panelLeft_AVV = new System.Windows.Forms.Panel();
            this.groupBoxInput_AVV = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_AVV = new System.Windows.Forms.DataGridView();
            this.panelMiddle_AVV = new System.Windows.Forms.Panel();
            this.groupBoxOutput_AVV = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix_AVV = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_AVV = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.splitter_AVV = new System.Windows.Forms.Splitter();
            this.panelUp_AVV.SuspendLayout();
            this.panelUpTwo_AVV.SuspendLayout();
            this.groupBoxCondition_AVV.SuspendLayout();
            this.panelLeft_AVV.SuspendLayout();
            this.groupBoxInput_AVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_AVV)).BeginInit();
            this.panelMiddle_AVV.SuspendLayout();
            this.groupBoxOutput_AVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_AVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_AVV
            // 
            this.panelUp_AVV.BackColor = System.Drawing.SystemColors.Control;
            this.panelUp_AVV.Controls.Add(this.buttonSaveFile_AVV);
            this.panelUp_AVV.Controls.Add(this.buttonSpravka_AVV);
            this.panelUp_AVV.Controls.Add(this.buttonDoneClick_AVV);
            this.panelUp_AVV.Controls.Add(this.buttonOpenFile_AVV);
            this.panelUp_AVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_AVV.Location = new System.Drawing.Point(0, 0);
            this.panelUp_AVV.Name = "panelUp_AVV";
            this.panelUp_AVV.Size = new System.Drawing.Size(1172, 70);
            this.panelUp_AVV.TabIndex = 0;
            // 
            // buttonSaveFile_AVV
            // 
            
            this.buttonSaveFile_AVV.Location = new System.Drawing.Point(157, 6);
            this.buttonSaveFile_AVV.Name = "buttonSaveFile_AVV";
            this.buttonSaveFile_AVV.Size = new System.Drawing.Size(71, 58);
            this.buttonSaveFile_AVV.TabIndex = 3;
            this.toolTipButton.SetToolTip(this.buttonSaveFile_AVV, "Сохраняет полученную матрицу");
            this.buttonSaveFile_AVV.UseVisualStyleBackColor = true;
            this.buttonSaveFile_AVV.Click += new System.EventHandler(this.buttonSaveFile_AVV_Click);
            this.buttonSaveFile_AVV.MouseEnter += new System.EventHandler(this.buttonSaveFile_AVV_MouseEnter);
            // 
            // buttonSpravka_AVV
            // 
            this.buttonSpravka_AVV.Dock = System.Windows.Forms.DockStyle.Right;
            
            this.buttonSpravka_AVV.Location = new System.Drawing.Point(1101, 0);
            this.buttonSpravka_AVV.Name = "buttonSpravka_AVV";
            this.buttonSpravka_AVV.Size = new System.Drawing.Size(71, 70);
            this.buttonSpravka_AVV.TabIndex = 2;
            this.toolTipButton.SetToolTip(this.buttonSpravka_AVV, "Информация о программе");
            this.buttonSpravka_AVV.UseVisualStyleBackColor = true;
            this.buttonSpravka_AVV.Click += new System.EventHandler(this.buttonSpravka_AVV_Click);
            this.buttonSpravka_AVV.MouseEnter += new System.EventHandler(this.buttonSpravka_AVV_MouseEnter);
            // 
            // buttonDoneClick_AVV
            // 
            
            this.buttonDoneClick_AVV.Location = new System.Drawing.Point(80, 6);
            this.buttonDoneClick_AVV.Name = "buttonDoneClick_AVV";
            this.buttonDoneClick_AVV.Size = new System.Drawing.Size(71, 58);
            this.buttonDoneClick_AVV.TabIndex = 1;
            this.toolTipButton.SetToolTip(this.buttonDoneClick_AVV, "Изменяет в девятом столбце значения не равные 11 на 11");
            this.buttonDoneClick_AVV.UseVisualStyleBackColor = true;
            this.buttonDoneClick_AVV.Click += new System.EventHandler(this.buttonDoneClick_AVV_Click);
            this.buttonDoneClick_AVV.MouseEnter += new System.EventHandler(this.buttonDoneClick_AVV_MouseEnter);
            // 
            // buttonOpenFile_AVV
            // 
            
            this.buttonOpenFile_AVV.Location = new System.Drawing.Point(3, 6);
            this.buttonOpenFile_AVV.Name = "buttonOpenFile_AVV";
            this.buttonOpenFile_AVV.Size = new System.Drawing.Size(71, 58);
            this.buttonOpenFile_AVV.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.buttonOpenFile_AVV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n\r\n");
            this.buttonOpenFile_AVV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_AVV.Click += new System.EventHandler(this.buttonOpenFile_AVV_Click);
            this.buttonOpenFile_AVV.MouseEnter += new System.EventHandler(this.buttonOpenFile_AVV_MouseEnter);
            // 
            // panelUpTwo_AVV
            // 
            this.panelUpTwo_AVV.Controls.Add(this.groupBoxCondition_AVV);
            this.panelUpTwo_AVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpTwo_AVV.Location = new System.Drawing.Point(0, 70);
            this.panelUpTwo_AVV.Name = "panelUpTwo_AVV";
            this.panelUpTwo_AVV.Size = new System.Drawing.Size(1172, 100);
            this.panelUpTwo_AVV.TabIndex = 1;
            // 
            // groupBoxCondition_AVV
            // 
            this.groupBoxCondition_AVV.Controls.Add(this.textBoxTask_AVV);
            this.groupBoxCondition_AVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCondition_AVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCondition_AVV.Name = "groupBoxCondition_AVV";
            this.groupBoxCondition_AVV.Size = new System.Drawing.Size(1172, 100);
            this.groupBoxCondition_AVV.TabIndex = 0;
            this.groupBoxCondition_AVV.TabStop = false;
            this.groupBoxCondition_AVV.Text = "Условие";
            // 
            // textBoxTask_AVV
            // 
            this.textBoxTask_AVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_AVV.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_AVV.Multiline = true;
            this.textBoxTask_AVV.Name = "textBoxTask_AVV";
            this.textBoxTask_AVV.ReadOnly = true;
            this.textBoxTask_AVV.Size = new System.Drawing.Size(1166, 81);
            this.textBoxTask_AVV.TabIndex = 0;
            this.textBoxTask_AVV.Text = resources.GetString("textBoxTask_AVV.Text");
            // 
            // panelLeft_AVV
            // 
            this.panelLeft_AVV.Controls.Add(this.groupBoxInput_AVV);
            this.panelLeft_AVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AVV.Location = new System.Drawing.Point(0, 170);
            this.panelLeft_AVV.Name = "panelLeft_AVV";
            this.panelLeft_AVV.Size = new System.Drawing.Size(559, 445);
            this.panelLeft_AVV.TabIndex = 2;
            // 
            // groupBoxInput_AVV
            // 
            this.groupBoxInput_AVV.Controls.Add(this.dataGridViewInMatrix_AVV);
            this.groupBoxInput_AVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_AVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_AVV.Name = "groupBoxInput_AVV";
            this.groupBoxInput_AVV.Size = new System.Drawing.Size(559, 445);
            this.groupBoxInput_AVV.TabIndex = 0;
            this.groupBoxInput_AVV.TabStop = false;
            this.groupBoxInput_AVV.Text = "Ввод данных";
            // 
            // dataGridViewInMatrix_AVV
            // 
            this.dataGridViewInMatrix_AVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_AVV.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix_AVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix_AVV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInMatrix_AVV.Name = "dataGridViewInMatrix_AVV";
            this.dataGridViewInMatrix_AVV.ReadOnly = true;
            this.dataGridViewInMatrix_AVV.RowHeadersVisible = false;
            this.dataGridViewInMatrix_AVV.Size = new System.Drawing.Size(553, 426);
            this.dataGridViewInMatrix_AVV.TabIndex = 0;
            // 
            // panelMiddle_AVV
            // 
            this.panelMiddle_AVV.Controls.Add(this.groupBoxOutput_AVV);
            this.panelMiddle_AVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle_AVV.Location = new System.Drawing.Point(562, 170);
            this.panelMiddle_AVV.Name = "panelMiddle_AVV";
            this.panelMiddle_AVV.Size = new System.Drawing.Size(610, 445);
            this.panelMiddle_AVV.TabIndex = 4;
            // 
            // groupBoxOutput_AVV
            // 
            this.groupBoxOutput_AVV.Controls.Add(this.dataGridViewOutMatrix_AVV);
            this.groupBoxOutput_AVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_AVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_AVV.Name = "groupBoxOutput_AVV";
            this.groupBoxOutput_AVV.Size = new System.Drawing.Size(610, 445);
            this.groupBoxOutput_AVV.TabIndex = 0;
            this.groupBoxOutput_AVV.TabStop = false;
            this.groupBoxOutput_AVV.Text = "Вывод данных";
            // 
            // dataGridViewOutMatrix_AVV
            // 
            this.dataGridViewOutMatrix_AVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_AVV.ColumnHeadersVisible = false;
            this.dataGridViewOutMatrix_AVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutMatrix_AVV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutMatrix_AVV.Name = "dataGridViewOutMatrix_AVV";
            this.dataGridViewOutMatrix_AVV.ReadOnly = true;
            this.dataGridViewOutMatrix_AVV.RowHeadersVisible = false;
            this.dataGridViewOutMatrix_AVV.Size = new System.Drawing.Size(604, 426);
            this.dataGridViewOutMatrix_AVV.TabIndex = 0;
            // 
            // openFileDialogTask_AVV
            // 
            this.openFileDialogTask_AVV.FileName = "openFileDialogTask_AVV";
            // 
            // toolTipButton
            // 
            this.toolTipButton.IsBalloon = true;
            this.toolTipButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // splitter_AVV
            // 
            this.splitter_AVV.Location = new System.Drawing.Point(559, 170);
            this.splitter_AVV.Name = "splitter_AVV";
            this.splitter_AVV.Size = new System.Drawing.Size(3, 445);
            this.splitter_AVV.TabIndex = 3;
            this.splitter_AVV.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 615);
            this.Controls.Add(this.panelMiddle_AVV);
            this.Controls.Add(this.splitter_AVV);
            this.Controls.Add(this.panelLeft_AVV);
            this.Controls.Add(this.panelUpTwo_AVV);
            this.Controls.Add(this.panelUp_AVV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 18 | Антонов В.В";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelUp_AVV.ResumeLayout(false);
            this.panelUpTwo_AVV.ResumeLayout(false);
            this.groupBoxCondition_AVV.ResumeLayout(false);
            this.groupBoxCondition_AVV.PerformLayout();
            this.panelLeft_AVV.ResumeLayout(false);
            this.groupBoxInput_AVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_AVV)).EndInit();
            this.panelMiddle_AVV.ResumeLayout(false);
            this.groupBoxOutput_AVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_AVV)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelUp_AVV;
        private System.Windows.Forms.Button buttonSpravka_AVV;
        private System.Windows.Forms.Button buttonDoneClick_AVV;
        private System.Windows.Forms.Button buttonOpenFile_AVV;
        private System.Windows.Forms.Panel panelUpTwo_AVV;
        private System.Windows.Forms.GroupBox groupBoxCondition_AVV;
        private System.Windows.Forms.TextBox textBoxTask_AVV;
        private System.Windows.Forms.Panel panelLeft_AVV;
        private System.Windows.Forms.GroupBox groupBoxInput_AVV;
        private System.Windows.Forms.Panel panelMiddle_AVV;
        private System.Windows.Forms.GroupBox groupBoxOutput_AVV;
        private System.Windows.Forms.Button buttonSaveFile_AVV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_AVV;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_AVV;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_AVV;
        private System.Windows.Forms.Splitter splitter_AVV;
    }
}