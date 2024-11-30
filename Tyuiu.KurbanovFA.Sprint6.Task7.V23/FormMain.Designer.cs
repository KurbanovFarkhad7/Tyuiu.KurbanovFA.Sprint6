namespace Tyuiu.KurbanovFA.Sprint6.Task7.V23
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
            groupBoxInPutData = new GroupBox();
            panelMainMenu = new Panel();
            buttonAddFile = new Button();
            panelCondition = new Panel();
            groupBoxOutPutData = new GroupBox();
            panelMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInPutData
            // 
            groupBoxInPutData.Location = new Point(2, 195);
            groupBoxInPutData.Name = "groupBoxInPutData";
            groupBoxInPutData.Size = new Size(399, 243);
            groupBoxInPutData.TabIndex = 0;
            groupBoxInPutData.TabStop = false;
            groupBoxInPutData.Text = "Ввод:";
            // 
            // panelMainMenu
            // 
            panelMainMenu.Controls.Add(buttonAddFile);
            panelMainMenu.Location = new Point(2, 2);
            panelMainMenu.Name = "panelMainMenu";
            panelMainMenu.Size = new Size(796, 96);
            panelMainMenu.TabIndex = 1;
            // 
            // buttonAddFile
            // 
            buttonAddFile.Location = new Point(10, 10);
            buttonAddFile.Name = "buttonAddFile";
            buttonAddFile.Size = new Size(83, 70);
            buttonAddFile.TabIndex = 0;
            buttonAddFile.Text = "Add";
            buttonAddFile.UseVisualStyleBackColor = true;
            buttonAddFile.Click += buttonAddFile_Click;
            // 
            // panelCondition
            // 
            panelCondition.Location = new Point(2, 104);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(796, 85);
            panelCondition.TabIndex = 2;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Location = new Point(407, 195);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(381, 243);
            groupBoxOutPutData.TabIndex = 3;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Вывод:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(panelCondition);
            Controls.Add(panelMainMenu);
            Controls.Add(groupBoxInPutData);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 23 | Курбанов Ф.А.";
            Load += FormMain_Load;
            panelMainMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInPutData;
        private Panel panelMainMenu;
        private Button buttonAddFile;
        private Panel panelCondition;
        private GroupBox groupBoxOutPutData;
    }
}
