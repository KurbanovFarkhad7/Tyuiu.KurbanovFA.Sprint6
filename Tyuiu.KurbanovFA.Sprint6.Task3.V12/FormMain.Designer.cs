namespace Tyuiu.KurbanovFA.Sprint6.Task3.V12
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
            groupBoxResult_KFA = new GroupBox();
            labelCondition1_KFA = new Label();
            buttonResult_KFA = new Button();
            dataGridViewResult_KFA = new DataGridView();
            dataGridViewSorted_KFA = new DataGridView();
            groupBoxResult_KFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KFA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSorted_KFA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxResult_KFA
            // 
            groupBoxResult_KFA.Controls.Add(labelCondition1_KFA);
            groupBoxResult_KFA.Location = new Point(12, 12);
            groupBoxResult_KFA.Name = "groupBoxResult_KFA";
            groupBoxResult_KFA.Size = new Size(339, 301);
            groupBoxResult_KFA.TabIndex = 0;
            groupBoxResult_KFA.TabStop = false;
            groupBoxResult_KFA.Text = "Условие";
            // 
            // labelCondition1_KFA
            // 
            labelCondition1_KFA.AutoSize = true;
            labelCondition1_KFA.Location = new Point(21, 28);
            labelCondition1_KFA.Name = "labelCondition1_KFA";
            labelCondition1_KFA.Size = new Size(168, 15);
            labelCondition1_KFA.TabIndex = 0;
            labelCondition1_KFA.Text = "Четные на 0 в первой строке ";
            // 
            // buttonResult_KFA
            // 
            buttonResult_KFA.Location = new Point(219, 319);
            buttonResult_KFA.Name = "buttonResult_KFA";
            buttonResult_KFA.Size = new Size(132, 66);
            buttonResult_KFA.TabIndex = 1;
            buttonResult_KFA.Text = "GOGOGO";
            buttonResult_KFA.UseVisualStyleBackColor = true;
            buttonResult_KFA.Click += buttonResult_KFA_Click;
            // 
            // dataGridViewResult_KFA
            // 
            dataGridViewResult_KFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KFA.Location = new Point(364, 44);
            dataGridViewResult_KFA.Name = "dataGridViewResult_KFA";
            dataGridViewResult_KFA.Size = new Size(240, 150);
            dataGridViewResult_KFA.TabIndex = 2;
            // 
            // dataGridViewSorted_KFA
            // 
            dataGridViewSorted_KFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSorted_KFA.Location = new Point(364, 217);
            dataGridViewSorted_KFA.Name = "dataGridViewSorted_KFA";
            dataGridViewSorted_KFA.Size = new Size(240, 150);
            dataGridViewSorted_KFA.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewSorted_KFA);
            Controls.Add(dataGridViewResult_KFA);
            Controls.Add(buttonResult_KFA);
            Controls.Add(groupBoxResult_KFA);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxResult_KFA.ResumeLayout(false);
            groupBoxResult_KFA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KFA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSorted_KFA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxResult_KFA;
        private Label labelCondition1_KFA;
        private Button buttonResult_KFA;
        private DataGridView dataGridViewResult_KFA;
        private DataGridView dataGridViewSorted_KFA;
    }
}
