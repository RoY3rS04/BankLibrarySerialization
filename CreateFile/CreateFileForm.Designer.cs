namespace CreateFile
{
    partial class CreateFileForm
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
            saveBtn = new Button();
            xmlRadioBtn = new RadioButton();
            jsonRadioBtn = new RadioButton();
            serializeLbl = new Label();
            saveClientBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(272, 298);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(106, 52);
            saveBtn.TabIndex = 8;
            saveBtn.Text = "Save As";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // xmlRadioBtn
            // 
            xmlRadioBtn.AutoSize = true;
            xmlRadioBtn.Location = new Point(105, 328);
            xmlRadioBtn.Name = "xmlRadioBtn";
            xmlRadioBtn.Size = new Size(49, 19);
            xmlRadioBtn.TabIndex = 9;
            xmlRadioBtn.TabStop = true;
            xmlRadioBtn.Text = "XML";
            xmlRadioBtn.UseVisualStyleBackColor = true;
            // 
            // jsonRadioBtn
            // 
            jsonRadioBtn.AutoSize = true;
            jsonRadioBtn.Location = new Point(105, 356);
            jsonRadioBtn.Name = "jsonRadioBtn";
            jsonRadioBtn.Size = new Size(53, 19);
            jsonRadioBtn.TabIndex = 10;
            jsonRadioBtn.TabStop = true;
            jsonRadioBtn.Text = "JSON";
            jsonRadioBtn.UseVisualStyleBackColor = true;
            // 
            // serializeLbl
            // 
            serializeLbl.AutoSize = true;
            serializeLbl.Location = new Point(97, 298);
            serializeLbl.Name = "serializeLbl";
            serializeLbl.Size = new Size(65, 15);
            serializeLbl.TabIndex = 11;
            serializeLbl.Text = "Serialize As";
            serializeLbl.Click += label1_Click;
            // 
            // saveClientBtn
            // 
            saveClientBtn.Enabled = false;
            saveClientBtn.Location = new Point(391, 298);
            saveClientBtn.Name = "saveClientBtn";
            saveClientBtn.Size = new Size(97, 52);
            saveClientBtn.TabIndex = 12;
            saveClientBtn.Text = "Save Client";
            saveClientBtn.UseVisualStyleBackColor = true;
            saveClientBtn.Click += saveClientBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(272, 360);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(216, 23);
            exitBtn.TabIndex = 13;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // CreateFileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 454);
            Controls.Add(exitBtn);
            Controls.Add(saveClientBtn);
            Controls.Add(serializeLbl);
            Controls.Add(jsonRadioBtn);
            Controls.Add(xmlRadioBtn);
            Controls.Add(saveBtn);
            Name = "CreateFileForm";
            Text = "CreateFileForm";
            Load += CreateFileForm_Load;
            Controls.SetChildIndex(saveBtn, 0);
            Controls.SetChildIndex(xmlRadioBtn, 0);
            Controls.SetChildIndex(jsonRadioBtn, 0);
            Controls.SetChildIndex(serializeLbl, 0);
            Controls.SetChildIndex(saveClientBtn, 0);
            Controls.SetChildIndex(exitBtn, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private RadioButton xmlRadioBtn;
        private RadioButton jsonRadioBtn;
        private Label serializeLbl;
        private Button saveClientBtn;
        private Button exitBtn;
    }
}