namespace Tyuiu.KurbanovFA.Sprint6.Task2.V5
{
    partial class Form1
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
            buttonDone_KFA = new Button();
            dataGridViewResult_KFA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            textBoxStartStep_KFA = new TextBox();
            textBoxStopStep_KFA = new TextBox();
            labelStartStep_KFA = new Label();
            labelStopStep_KFA = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KFA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_KFA
            // 
            buttonDone_KFA.Location = new Point(12, 59);
            buttonDone_KFA.Name = "buttonDone_KFA";
            buttonDone_KFA.Size = new Size(87, 67);
            buttonDone_KFA.TabIndex = 0;
            buttonDone_KFA.Text = "RUN!";
            buttonDone_KFA.UseVisualStyleBackColor = true;
            buttonDone_KFA.Click += buttonDone_KFA_Click;
            // 
            // dataGridViewResult_KFA
            // 
            dataGridViewResult_KFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KFA.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewResult_KFA.Location = new Point(222, 12);
            dataGridViewResult_KFA.Name = "dataGridViewResult_KFA";
            dataGridViewResult_KFA.Size = new Size(145, 426);
            dataGridViewResult_KFA.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // textBoxStartStep_KFA
            // 
            textBoxStartStep_KFA.Location = new Point(12, 30);
            textBoxStartStep_KFA.Name = "textBoxStartStep_KFA";
            textBoxStartStep_KFA.Size = new Size(100, 23);
            textBoxStartStep_KFA.TabIndex = 2;
            // 
            // textBoxStopStep_KFA
            // 
            textBoxStopStep_KFA.Location = new Point(116, 30);
            textBoxStopStep_KFA.Name = "textBoxStopStep_KFA";
            textBoxStopStep_KFA.Size = new Size(100, 23);
            textBoxStopStep_KFA.TabIndex = 3;
            // 
            // labelStartStep_KFA
            // 
            labelStartStep_KFA.AutoSize = true;
            labelStartStep_KFA.Location = new Point(10, 12);
            labelStartStep_KFA.Name = "labelStartStep_KFA";
            labelStartStep_KFA.Size = new Size(31, 15);
            labelStartStep_KFA.TabIndex = 4;
            labelStartStep_KFA.Text = "Start";
            // 
            // labelStopStep_KFA
            // 
            labelStopStep_KFA.AutoSize = true;
            labelStopStep_KFA.Location = new Point(116, 12);
            labelStopStep_KFA.Name = "labelStopStep_KFA";
            labelStopStep_KFA.Size = new Size(31, 15);
            labelStopStep_KFA.TabIndex = 5;
            labelStopStep_KFA.Text = "Stop";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(labelStopStep_KFA);
            Controls.Add(labelStartStep_KFA);
            Controls.Add(textBoxStopStep_KFA);
            Controls.Add(textBoxStartStep_KFA);
            Controls.Add(dataGridViewResult_KFA);
            Controls.Add(buttonDone_KFA);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KFA).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_KFA;
        private DataGridView dataGridViewResult_KFA;
        private TextBox textBoxStartStep_KFA;
        private TextBox textBoxStopStep_KFA;
        private Label labelStartStep_KFA;
        private Label labelStopStep_KFA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
