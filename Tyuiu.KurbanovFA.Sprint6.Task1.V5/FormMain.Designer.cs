namespace Tyuiu.KurbanovFA.Sprint6.Task1.V5
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
            buttonResult_KFA = new Button();
            textBoxStartStep_KFA = new TextBox();
            textBoxStopStep_KFA = new TextBox();
            labelStartStep_KFA = new Label();
            labelStopStep_KFA = new Label();
            SuspendLayout();
            // 
            // textBoxResult_KFA
            // 
            textBoxResult_KFA.Location = new Point(227, 12);
            textBoxResult_KFA.Multiline = true;
            textBoxResult_KFA.Name = "textBoxResult_KFA";
            textBoxResult_KFA.Size = new Size(197, 426);
            textBoxResult_KFA.TabIndex = 0;
            // 
            // buttonResult_KFA
            // 
            buttonResult_KFA.Location = new Point(12, 76);
            buttonResult_KFA.Name = "buttonResult_KFA";
            buttonResult_KFA.Size = new Size(209, 95);
            buttonResult_KFA.TabIndex = 1;
            buttonResult_KFA.Text = "DoSomeMagic";
            buttonResult_KFA.UseVisualStyleBackColor = true;
            buttonResult_KFA.Click += buttonResult_KFA_Click;
            // 
            // textBoxStartStep_KFA
            // 
            textBoxStartStep_KFA.Location = new Point(12, 35);
            textBoxStartStep_KFA.Name = "textBoxStartStep_KFA";
            textBoxStartStep_KFA.Size = new Size(100, 23);
            textBoxStartStep_KFA.TabIndex = 2;
            // 
            // textBoxStopStep_KFA
            // 
            textBoxStopStep_KFA.Location = new Point(121, 35);
            textBoxStopStep_KFA.Name = "textBoxStopStep_KFA";
            textBoxStopStep_KFA.Size = new Size(100, 23);
            textBoxStopStep_KFA.TabIndex = 3;
            // 
            // labelStartStep_KFA
            // 
            labelStartStep_KFA.AutoSize = true;
            labelStartStep_KFA.Location = new Point(12, 12);
            labelStartStep_KFA.Name = "labelStartStep_KFA";
            labelStartStep_KFA.Size = new Size(54, 15);
            labelStartStep_KFA.TabIndex = 4;
            labelStartStep_KFA.Text = "StartStep";
            // 
            // labelStopStep_KFA
            // 
            labelStopStep_KFA.AutoSize = true;
            labelStopStep_KFA.Location = new Point(144, 12);
            labelStopStep_KFA.Name = "labelStopStep_KFA";
            labelStopStep_KFA.Size = new Size(54, 15);
            labelStopStep_KFA.TabIndex = 5;
            labelStopStep_KFA.Text = "StopStep";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 450);
            Controls.Add(labelStopStep_KFA);
            Controls.Add(labelStartStep_KFA);
            Controls.Add(textBoxStopStep_KFA);
            Controls.Add(textBoxStartStep_KFA);
            Controls.Add(buttonResult_KFA);
            Controls.Add(textBoxResult_KFA);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult_KFA;
        private Button buttonResult_KFA;
        private TextBox textBoxStartStep_KFA;
        private TextBox textBoxStopStep_KFA;
        private Label labelStartStep_KFA;
        private Label labelStopStep_KFA;
    }
}
