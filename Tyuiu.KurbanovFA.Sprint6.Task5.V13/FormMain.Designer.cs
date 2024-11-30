namespace Tyuiu.KurbanovFA.Sprint6.Task5.V13
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
            dataGridViewResult_KFA = new DataGridView();
            buttonResult_KFA = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KFA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResult_KFA
            // 
            dataGridViewResult_KFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KFA.Location = new Point(202, 63);
            dataGridViewResult_KFA.Name = "dataGridViewResult_KFA";
            dataGridViewResult_KFA.Size = new Size(240, 256);
            dataGridViewResult_KFA.TabIndex = 0;
            // 
            // buttonResult_KFA
            // 
            buttonResult_KFA.Location = new Point(26, 192);
            buttonResult_KFA.Name = "buttonResult_KFA";
            buttonResult_KFA.Size = new Size(128, 76);
            buttonResult_KFA.TabIndex = 1;
            buttonResult_KFA.Text = "EEEEEE!";
            buttonResult_KFA.UseVisualStyleBackColor = true;
            buttonResult_KFA.Click += buttonResult_KFA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 450);
            Controls.Add(buttonResult_KFA);
            Controls.Add(dataGridViewResult_KFA);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KFA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewResult_KFA;
        private Button buttonResult_KFA;
    }
}
