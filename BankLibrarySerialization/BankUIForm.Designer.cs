namespace BankLibrarySerialization
{
    partial class BankUIForm
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
            accountLabel = new Label();
            accountTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            balanceTextBox = new TextBox();
            balanceLabel = new Label();
            SuspendLayout();
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Location = new Point(97, 75);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(58, 15);
            accountLabel.TabIndex = 0;
            accountLabel.Text = "Account: ";
            // 
            // accountTextBox
            // 
            accountTextBox.Location = new Point(272, 67);
            accountTextBox.Name = "accountTextBox";
            accountTextBox.Size = new Size(216, 23);
            accountTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(272, 124);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(216, 23);
            firstNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(97, 132);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(73, 15);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name:  ";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(272, 175);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(216, 23);
            lastNameTextBox.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(97, 183);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(69, 15);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name: ";
            // 
            // balanceTextBox
            // 
            balanceTextBox.Location = new Point(272, 252);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(216, 23);
            balanceTextBox.TabIndex = 7;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(97, 260);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(57, 15);
            balanceLabel.TabIndex = 6;
            balanceLabel.Text = "Amount: ";
            // 
            // BankUIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 383);
            Controls.Add(balanceTextBox);
            Controls.Add(balanceLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(accountTextBox);
            Controls.Add(accountLabel);
            Name = "BankUIForm";
            Text = "BankUIForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label accountLabel;
        private TextBox accountTextBox;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox balanceTextBox;
        private Label balanceLabel;
    }
}