namespace Tyuiu.KurbanovFA.Sprint6.Task6.V2
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
            buttonAddFile_KFA = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            textBoxLoadFromFile = new TextBox();
            groupBoxOutPutData = new GroupBox();
            buttonDone_KFA = new Button();
            textBoxResult = new TextBox();
            groupBoxOutPutData.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddFile_KFA
            // 
            buttonAddFile_KFA.Location = new Point(12, 24);
            buttonAddFile_KFA.Name = "buttonAddFile_KFA";
            buttonAddFile_KFA.Size = new Size(81, 54);
            buttonAddFile_KFA.TabIndex = 0;
            buttonAddFile_KFA.Text = "AddFile";
            toolTip.SetToolTip(buttonAddFile_KFA, "Открыть файл\r\nВыберите файл");
            buttonAddFile_KFA.UseVisualStyleBackColor = true;
            buttonAddFile_KFA.Click += buttonAddFile_KFA_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Advice";
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(22, 22);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.Size = new Size(287, 202);
            textBoxLoadFromFile.TabIndex = 1;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(textBoxResult);
            groupBoxOutPutData.Controls.Add(textBoxLoadFromFile);
            groupBoxOutPutData.Location = new Point(113, 24);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(675, 414);
            groupBoxOutPutData.TabIndex = 2;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Da";
            // 
            // buttonDone_KFA
            // 
            buttonDone_KFA.Location = new Point(16, 101);
            buttonDone_KFA.Name = "buttonDone_KFA";
            buttonDone_KFA.Size = new Size(77, 56);
            buttonDone_KFA.TabIndex = 3;
            buttonDone_KFA.Text = "Done";
            buttonDone_KFA.UseVisualStyleBackColor = true;
            buttonDone_KFA.Click += buttonDone_KFA_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(331, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(319, 202);
            textBoxResult.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_KFA);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(buttonAddFile_KFA);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddFile_KFA;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
        private TextBox textBoxLoadFromFile;
        private GroupBox groupBoxOutPutData;
        private Button buttonDone_KFA;
        private TextBox textBoxResult;
    }
}
