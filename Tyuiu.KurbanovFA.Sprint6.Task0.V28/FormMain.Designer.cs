namespace Tyuiu.KurbanovFA.Sprint6.Task0.V28
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
            textBoxResult_KFA = new TextBox();
            SuspendLayout();
            // 
            // textBoxResult_KFA
            // 
            textBoxResult_KFA.Location = new Point(284, 186);
            textBoxResult_KFA.Name = "textBoxResult_KFA";
            textBoxResult_KFA.Size = new Size(185, 23);
            textBoxResult_KFA.TabIndex = 0;
            textBoxResult_KFA.TextChanged += textBoxResult_KFA_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult_KFA);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult_KFA;
    }
}
