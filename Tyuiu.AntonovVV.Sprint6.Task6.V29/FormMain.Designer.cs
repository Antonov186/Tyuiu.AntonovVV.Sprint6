namespace Tyuiu.AntonovVV.Sprint6.Task6.V29
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
            components = new System.ComponentModel.Container();
            panelUP_AVV = new Panel();
            buttonHelp_AVV = new Button();
            buttonLoad_AVV = new Button();
            buttonStart_AVV = new Button();
            groupBoxTask_AVV = new GroupBox();
            textBoxTask_AVV = new TextBox();
            panelFill_AVV = new Panel();
            groupBoxOutput_AVV = new GroupBox();
            textBoxOutput_AVV = new TextBox();
            panelLeft_AVV = new Panel();
            groupBoxInput_AVV = new GroupBox();
            textBoxInput_AVV = new TextBox();
            splitter1 = new Splitter();
            openFileDialog_AVV = new OpenFileDialog();
            toolTipHelp_AVV = new ToolTip(components);
            panelUP_AVV.SuspendLayout();
            groupBoxTask_AVV.SuspendLayout();
            panelFill_AVV.SuspendLayout();
            groupBoxOutput_AVV.SuspendLayout();
            panelLeft_AVV.SuspendLayout();
            groupBoxInput_AVV.SuspendLayout();
            SuspendLayout();
            // 
            // panelUP_AVV
            // 
            panelUP_AVV.Controls.Add(buttonHelp_AVV);
            panelUP_AVV.Controls.Add(buttonLoad_AVV);
            panelUP_AVV.Controls.Add(buttonStart_AVV);
            panelUP_AVV.Controls.Add(groupBoxTask_AVV);
            panelUP_AVV.Dock = DockStyle.Top;
            panelUP_AVV.Location = new Point(0, 0);
            panelUP_AVV.Name = "panelUP_AVV";
            panelUP_AVV.Size = new Size(784, 162);
            panelUP_AVV.TabIndex = 0;
            // 
            // buttonHelp_AVV
            // 
            buttonHelp_AVV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_AVV.Location = new Point(692, 12);
            buttonHelp_AVV.Name = "buttonHelp_AVV";
            buttonHelp_AVV.Size = new Size(80, 80);
            buttonHelp_AVV.TabIndex = 2;
            buttonHelp_AVV.Text = "Справка";
            toolTipHelp_AVV.SetToolTip(buttonHelp_AVV, "Информация об авторе приложения");
            buttonHelp_AVV.UseVisualStyleBackColor = true;
           
            // 
            // buttonLoad_AVV
            // 
            buttonLoad_AVV.Location = new Point(12, 12);
            buttonLoad_AVV.Name = "buttonLoad_AVV";
            buttonLoad_AVV.Size = new Size(80, 80);
            buttonLoad_AVV.TabIndex = 2;
            buttonLoad_AVV.Text = "Загрузить";
            toolTipHelp_AVV.SetToolTip(buttonLoad_AVV, "Загрузка файла");
            buttonLoad_AVV.UseVisualStyleBackColor = true;
            buttonLoad_AVV.Click += buttonLoad_AVV_Click;
            // 
            // buttonStart_AVV
            // 
            buttonStart_AVV.Enabled = false;
            buttonStart_AVV.Location = new Point(98, 12);
            buttonStart_AVV.Name = "buttonStart_AVV";
            buttonStart_AVV.Size = new Size(80, 80);
            buttonStart_AVV.TabIndex = 2;
            buttonStart_AVV.Text = "Выполнить";
            toolTipHelp_AVV.SetToolTip(buttonStart_AVV, "Запуск обработки файла");
            buttonStart_AVV.UseVisualStyleBackColor = true;
            buttonStart_AVV.Click += buttonStart_AVV_Click;
            // 
            // groupBoxTask_AVV
            // 
            groupBoxTask_AVV.Controls.Add(textBoxTask_AVV);
            groupBoxTask_AVV.Dock = DockStyle.Bottom;
            groupBoxTask_AVV.Location = new Point(0, 98);
            groupBoxTask_AVV.Name = "groupBoxTask_AVV";
            groupBoxTask_AVV.Size = new Size(784, 64);
            groupBoxTask_AVV.TabIndex = 0;
            groupBoxTask_AVV.TabStop = false;
            groupBoxTask_AVV.Text = "Условие";
            // 
            // textBoxTask_AVV
            // 
            textBoxTask_AVV.BackColor = SystemColors.Control;
            textBoxTask_AVV.BorderStyle = BorderStyle.None;
            textBoxTask_AVV.Dock = DockStyle.Fill;
            textBoxTask_AVV.Location = new Point(3, 19);
            textBoxTask_AVV.Multiline = true;
            textBoxTask_AVV.Name = "textBoxTask_AVV";
            textBoxTask_AVV.ReadOnly = true;
            textBoxTask_AVV.Size = new Size(778, 42);
            textBoxTask_AVV.TabIndex = 0;
            // 
            // panelFill_AVV
            // 
            panelFill_AVV.Controls.Add(groupBoxOutput_AVV);
            panelFill_AVV.Dock = DockStyle.Fill;
            panelFill_AVV.Location = new Point(394, 162);
            panelFill_AVV.Name = "panelFill_AVV";
            panelFill_AVV.Size = new Size(390, 349);
            panelFill_AVV.TabIndex = 1;
            // 
            // groupBoxOutput_AVV
            // 
            groupBoxOutput_AVV.Controls.Add(textBoxOutput_AVV);
            groupBoxOutput_AVV.Dock = DockStyle.Fill;
            groupBoxOutput_AVV.Location = new Point(0, 0);
            groupBoxOutput_AVV.Name = "groupBoxOutput_AVV";
            groupBoxOutput_AVV.Size = new Size(390, 349);
            groupBoxOutput_AVV.TabIndex = 0;
            groupBoxOutput_AVV.TabStop = false;
            groupBoxOutput_AVV.Text = "Вывод:";
            // 
            // textBoxOutput_AVV
            // 
            textBoxOutput_AVV.BackColor = SystemColors.Window;
            textBoxOutput_AVV.Dock = DockStyle.Fill;
            textBoxOutput_AVV.Location = new Point(3, 19);
            textBoxOutput_AVV.Multiline = true;
            textBoxOutput_AVV.Name = "textBoxOutput_AVV";
            textBoxOutput_AVV.ReadOnly = true;
            textBoxOutput_AVV.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_AVV.Size = new Size(384, 327);
            textBoxOutput_AVV.TabIndex = 0;
            textBoxOutput_AVV.TextChanged += textBoxOutput_AVV_TextChanged;
            // 
            // panelLeft_AVV
            // 
            panelLeft_AVV.Controls.Add(groupBoxInput_AVV);
            panelLeft_AVV.Dock = DockStyle.Left;
            panelLeft_AVV.Location = new Point(0, 162);
            panelLeft_AVV.Name = "panelLeft_AVV";
            panelLeft_AVV.Size = new Size(391, 349);
            panelLeft_AVV.TabIndex = 2;
            // 
            // groupBoxInput_AVV
            // 
            groupBoxInput_AVV.Controls.Add(textBoxInput_AVV);
            groupBoxInput_AVV.Dock = DockStyle.Fill;
            groupBoxInput_AVV.Location = new Point(0, 0);
            groupBoxInput_AVV.Name = "groupBoxInput_AVV";
            groupBoxInput_AVV.Size = new Size(391, 349);
            groupBoxInput_AVV.TabIndex = 0;
            groupBoxInput_AVV.TabStop = false;
            groupBoxInput_AVV.Text = "Ввод:";
            // 
            // textBoxInput_AVV
            // 
            textBoxInput_AVV.BackColor = SystemColors.Window;
            textBoxInput_AVV.Dock = DockStyle.Fill;
            textBoxInput_AVV.Location = new Point(3, 19);
            textBoxInput_AVV.Multiline = true;
            textBoxInput_AVV.Name = "textBoxInput_AVV";
            textBoxInput_AVV.ReadOnly = true;
            textBoxInput_AVV.ScrollBars = ScrollBars.Vertical;
            textBoxInput_AVV.Size = new Size(385, 327);
            textBoxInput_AVV.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(391, 162);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 349);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // openFileDialog_AVV
            // 
            openFileDialog_AVV.FileName = "openFileDialogLoad";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 511);
            Controls.Add(panelFill_AVV);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_AVV);
            Controls.Add(panelUP_AVV);
            MinimumSize = new Size(800, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 29 | Антонов В. В.";
            panelUP_AVV.ResumeLayout(false);
            groupBoxTask_AVV.ResumeLayout(false);
            groupBoxTask_AVV.PerformLayout();
            panelFill_AVV.ResumeLayout(false);
            groupBoxOutput_AVV.ResumeLayout(false);
            groupBoxOutput_AVV.PerformLayout();
            panelLeft_AVV.ResumeLayout(false);
            groupBoxInput_AVV.ResumeLayout(false);
            groupBoxInput_AVV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUP_AVV;
        private Panel panelFill_AVV;
        private Panel panelLeft_AVV;
        private Splitter splitter1;
        private GroupBox groupBoxTask_AVV;
        private TextBox textBoxTask_AVV;
        private GroupBox groupBoxInput_AVV;
        private TextBox textBoxInput_AVV;
        private Button buttonHelp_AVV;
        private Button buttonLoad_AVV;
        private Button buttonStart_AVV;
        private GroupBox groupBoxOutput_AVV;
        private TextBox textBoxOutput_AVV;
        private OpenFileDialog openFileDialog_AVV;
        private ToolTip toolTipHelp_AVV;
    }
}