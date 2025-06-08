namespace Tyuiu.AntonovVV.Sprint6.Task1.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBoxTask_AVV = new PictureBox();
            buttonDone_AVV = new Button();
            buttonHelp_AVV = new Button();
            textBoxStartValue_AVV = new TextBox();
            textBoxStopValue_AVV = new TextBox();
            labelStart_AVV = new Label();
            labelStop_AVV = new Label();
            labelResult_AVV = new Label();
            textBoxResult_AVV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_AVV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTask_AVV
            // 
            pictureBoxTask_AVV.Image = (Image)resources.GetObject("pictureBoxTask_AVV.Image");
            pictureBoxTask_AVV.Location = new Point(0, -1);
            pictureBoxTask_AVV.Name = "pictureBoxTask_AVV";
            pictureBoxTask_AVV.Size = new Size(644, 209);
            pictureBoxTask_AVV.TabIndex = 0;
            pictureBoxTask_AVV.TabStop = false;
            // 
            // buttonDone_AVV
            // 
            buttonDone_AVV.Location = new Point(410, 404);
            buttonDone_AVV.Name = "buttonDone_AVV";
            buttonDone_AVV.Size = new Size(234, 55);
            buttonDone_AVV.TabIndex = 1;
            buttonDone_AVV.Text = "Выполнить";
            buttonDone_AVV.UseVisualStyleBackColor = true;
            buttonDone_AVV.Click += buttonDone_AVV_Click;
            // 
            // buttonHelp_AVV
            // 
            buttonHelp_AVV.Location = new Point(329, 420);
            buttonHelp_AVV.Name = "buttonHelp_AVV";
            buttonHelp_AVV.Size = new Size(75, 39);
            buttonHelp_AVV.TabIndex = 2;
            buttonHelp_AVV.Text = "?";
            buttonHelp_AVV.UseVisualStyleBackColor = true;
            buttonHelp_AVV.Click += buttonHelp_AVV_Click;
            // 
            // textBoxStartValue_AVV
            // 
            textBoxStartValue_AVV.Location = new Point(12, 291);
            textBoxStartValue_AVV.Name = "textBoxStartValue_AVV";
            textBoxStartValue_AVV.Size = new Size(100, 23);
            textBoxStartValue_AVV.TabIndex = 3;
            textBoxStartValue_AVV.TextChanged += textBoxStartValue_AVV_TextChanged;
            // 
            // textBoxStopValue_AVV
            // 
            textBoxStopValue_AVV.Location = new Point(118, 291);
            textBoxStopValue_AVV.Name = "textBoxStopValue_AVV";
            textBoxStopValue_AVV.Size = new Size(100, 23);
            textBoxStopValue_AVV.TabIndex = 4;
            textBoxStopValue_AVV.TextChanged += textBoxStopValue_AVV_TextChanged;
            // 
            // labelStart_AVV
            // 
            labelStart_AVV.AutoSize = true;
            labelStart_AVV.Location = new Point(12, 273);
            labelStart_AVV.Name = "labelStart_AVV";
            labelStart_AVV.Size = new Size(69, 15);
            labelStart_AVV.TabIndex = 5;
            labelStart_AVV.Text = "Старт шага";
            // 
            // labelStop_AVV
            // 
            labelStop_AVV.AutoSize = true;
            labelStop_AVV.Location = new Point(118, 273);
            labelStop_AVV.Name = "labelStop_AVV";
            labelStop_AVV.Size = new Size(75, 15);
            labelStop_AVV.TabIndex = 6;
            labelStop_AVV.Text = "Конец шага:";
            // 
            // labelResult_AVV
            // 
            labelResult_AVV.AutoSize = true;
            labelResult_AVV.Location = new Point(717, 24);
            labelResult_AVV.Name = "labelResult_AVV";
            labelResult_AVV.Size = new Size(63, 15);
            labelResult_AVV.TabIndex = 7;
            labelResult_AVV.Text = "Результат:";
            // 
            // textBoxResult_AVV
            // 
            textBoxResult_AVV.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_AVV.Location = new Point(717, 42);
            textBoxResult_AVV.Multiline = true;
            textBoxResult_AVV.Name = "textBoxResult_AVV";
            textBoxResult_AVV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_AVV.Size = new Size(340, 448);
            textBoxResult_AVV.TabIndex = 8;
            textBoxResult_AVV.TextChanged += textBoxResult_AVV_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 502);
            Controls.Add(textBoxResult_AVV);
            Controls.Add(labelResult_AVV);
            Controls.Add(labelStop_AVV);
            Controls.Add(labelStart_AVV);
            Controls.Add(textBoxStopValue_AVV);
            Controls.Add(textBoxStartValue_AVV);
            Controls.Add(buttonHelp_AVV);
            Controls.Add(buttonDone_AVV);
            Controls.Add(pictureBoxTask_AVV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 25 | Антонов В. В.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_AVV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxTask_AVV;
        private Button buttonDone_AVV;
        private Button buttonHelp_AVV;
        private TextBox textBoxStartValue_AVV;
        private TextBox textBoxStopValue_AVV;
        private Label labelStart_AVV;
        private Label labelStop_AVV;
        private Label labelResult_AVV;
        private TextBox textBoxResult_AVV;
    }