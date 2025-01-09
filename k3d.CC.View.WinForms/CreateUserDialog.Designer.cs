namespace k3d.CC.View.WinForms
{
    partial class CreateUserDialog
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
            uiAccountNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            uiPasswordTextBox = new TextBox();
            label3 = new Label();
            uiPassword2TextBox = new TextBox();
            uiShowPasswordButton = new Button();
            uiCreateAccountButton = new Button();
            uiCancelButton = new Button();
            SuspendLayout();
            // 
            // uiAccountNameTextBox
            // 
            uiAccountNameTextBox.Location = new Point(12, 27);
            uiAccountNameTextBox.Name = "uiAccountNameTextBox";
            uiAccountNameTextBox.Size = new Size(233, 23);
            uiAccountNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Account name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // uiPasswordTextBox
            // 
            uiPasswordTextBox.Location = new Point(12, 71);
            uiPasswordTextBox.Name = "uiPasswordTextBox";
            uiPasswordTextBox.PasswordChar = '*';
            uiPasswordTextBox.Size = new Size(233, 23);
            uiPasswordTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 4;
            label3.Text = "Repeat password";
            // 
            // uiPassword2TextBox
            // 
            uiPassword2TextBox.Location = new Point(12, 115);
            uiPassword2TextBox.Name = "uiPassword2TextBox";
            uiPassword2TextBox.PasswordChar = '*';
            uiPassword2TextBox.Size = new Size(233, 23);
            uiPassword2TextBox.TabIndex = 5;
            // 
            // uiShowPasswordButton
            // 
            uiShowPasswordButton.Location = new Point(267, 27);
            uiShowPasswordButton.Name = "uiShowPasswordButton";
            uiShowPasswordButton.Size = new Size(144, 23);
            uiShowPasswordButton.TabIndex = 6;
            uiShowPasswordButton.Text = "Show password";
            uiShowPasswordButton.UseVisualStyleBackColor = true;
            uiShowPasswordButton.MouseDown += uiShowPasswordButton_MouseDown;
            uiShowPasswordButton.MouseUp += uiShowPasswordButton_MouseUp;
            // 
            // uiCreateAccountButton
            // 
            uiCreateAccountButton.Location = new Point(267, 71);
            uiCreateAccountButton.Name = "uiCreateAccountButton";
            uiCreateAccountButton.Size = new Size(144, 23);
            uiCreateAccountButton.TabIndex = 7;
            uiCreateAccountButton.Text = "Create account";
            uiCreateAccountButton.UseVisualStyleBackColor = true;
            uiCreateAccountButton.Click += uiCreateAccountButton_Click;
            // 
            // uiCancelButton
            // 
            uiCancelButton.Location = new Point(267, 115);
            uiCancelButton.Name = "uiCancelButton";
            uiCancelButton.Size = new Size(144, 23);
            uiCancelButton.TabIndex = 8;
            uiCancelButton.Text = "Cancel";
            uiCancelButton.UseVisualStyleBackColor = true;
            // 
            // CreateAccountForm
            // 
            AcceptButton = uiCreateAccountButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = uiCancelButton;
            ClientSize = new Size(437, 160);
            Controls.Add(uiCancelButton);
            Controls.Add(uiCreateAccountButton);
            Controls.Add(uiShowPasswordButton);
            Controls.Add(uiPassword2TextBox);
            Controls.Add(label3);
            Controls.Add(uiPasswordTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(uiAccountNameTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CreateAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox uiAccountNameTextBox;
        private Label label1;
        private Label label2;
        private TextBox uiPasswordTextBox;
        private Label label3;
        private TextBox uiPassword2TextBox;
        private Button uiShowPasswordButton;
        private Button uiCreateAccountButton;
        private Button uiCancelButton;
    }
}