namespace Tyuiu.AntonovVV.Sprint6.Task7.V18
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_AVV = new System.Windows.Forms.Label();
            this.buttonOk_AVV = new System.Windows.Forms.Button();
            this.pictureBox_AVV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AVV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_AVV
            // 
            this.labelInfo_AVV.AutoSize = true;
            this.labelInfo_AVV.Location = new System.Drawing.Point(342, 29);
            this.labelInfo_AVV.Name = "labelInfo_AVV";
            this.labelInfo_AVV.Size = new System.Drawing.Size(284, 130);
            this.labelInfo_AVV.TabIndex = 0;
            this.labelInfo_AVV.Text = resources.GetString("labelInfo_AVV.Text");
            // 
            // buttonOk_AVV
            // 
            this.buttonOk_AVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_AVV.Location = new System.Drawing.Point(604, 311);
            this.buttonOk_AVV.Name = "buttonOk_AVV";
            this.buttonOk_AVV.Size = new System.Drawing.Size(57, 35);
            this.buttonOk_AVV.TabIndex = 1;
            this.buttonOk_AVV   .Text = "Ок";
            this.buttonOk_AVV.UseVisualStyleBackColor = true;
            this.buttonOk_AVV.Click += new System.EventHandler(this.buttonOk_AVV_Click);
            // 
            // pictureBox_AVV
            // 
            
            this.pictureBox_AVV.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_AVV.Name = "pictureBox_AVV";
            this.pictureBox_AVV.Size = new System.Drawing.Size(295, 288);
            this.pictureBox_AVV.TabIndex = 2;
            this.pictureBox_AVV.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 358);
            this.Controls.Add(this.pictureBox_AVV);
            this.Controls.Add(this.buttonOk_AVV);
            this.Controls.Add(this.labelInfo_AVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_AVV;
        private System.Windows.Forms.Button buttonOk_AVV;
        private System.Windows.Forms.PictureBox pictureBox_AVV;
    }
}