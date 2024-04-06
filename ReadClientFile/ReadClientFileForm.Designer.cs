namespace ReadClientFile
{
    partial class ReadClientFileForm
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
            fileBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // fileBtn
            // 
            fileBtn.Location = new Point(97, 310);
            fileBtn.Name = "fileBtn";
            fileBtn.Size = new Size(193, 52);
            fileBtn.TabIndex = 13;
            fileBtn.Text = "Open File";
            fileBtn.UseVisualStyleBackColor = true;
            fileBtn.Click += fileBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(308, 310);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(180, 52);
            exitBtn.TabIndex = 14;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // ReadClientFileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 450);
            Controls.Add(exitBtn);
            Controls.Add(fileBtn);
            Name = "ReadClientFileForm";
            Text = "ReadClientFileForm";
            Controls.SetChildIndex(fileBtn, 0);
            Controls.SetChildIndex(exitBtn, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button fileBtn;
        private Button exitBtn;
    }
}