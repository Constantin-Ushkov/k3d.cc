namespace k3d.CC.View.WinForms
{
    partial class ChangePasswordDialog
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
            label1 = new Label();
            uiCurrentPasswordText = new TextBox();
            label2 = new Label();
            uiNewPasswordText = new TextBox();
            label3 = new Label();
            uiNewPasswordRepeatText = new TextBox();
            uiShowPasswordButton = new Button();
            uiCancelButton = new Button();
            uiChangePasswordButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Current password";
            // 
            // uiCurrentPasswordText
            // 
            uiCurrentPasswordText.Location = new Point(12, 27);
            uiCurrentPasswordText.Name = "uiCurrentPasswordText";
            uiCurrentPasswordText.PasswordChar = '*';
            uiCurrentPasswordText.Size = new Size(199, 23);
            uiCurrentPasswordText.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "New password";
            // 
            // uiNewPasswordText
            // 
            uiNewPasswordText.Location = new Point(12, 71);
            uiNewPasswordText.Name = "uiNewPasswordText";
            uiNewPasswordText.PasswordChar = '*';
            uiNewPasswordText.Size = new Size(199, 23);
            uiNewPasswordText.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 4;
            label3.Text = "Repeat new password";
            // 
            // uiNewPasswordRepeatText
            // 
            uiNewPasswordRepeatText.Location = new Point(12, 115);
            uiNewPasswordRepeatText.Name = "uiNewPasswordRepeatText";
            uiNewPasswordRepeatText.PasswordChar = '*';
            uiNewPasswordRepeatText.Size = new Size(199, 23);
            uiNewPasswordRepeatText.TabIndex = 5;
            // 
            // uiShowPasswordButton
            // 
            uiShowPasswordButton.Location = new Point(217, 26);
            uiShowPasswordButton.Name = "uiShowPasswordButton";
            uiShowPasswordButton.Size = new Size(130, 23);
            uiShowPasswordButton.TabIndex = 6;
            uiShowPasswordButton.Text = "Show Password";
            uiShowPasswordButton.UseVisualStyleBackColor = true;
            uiShowPasswordButton.MouseDown += uiShowPasswordButton_MouseDown;
            uiShowPasswordButton.MouseUp += uiShowPasswordButton_MouseUp;
            // 
            // uiCancelButton
            // 
            uiCancelButton.Location = new Point(217, 55);
            uiCancelButton.Name = "uiCancelButton";
            uiCancelButton.Size = new Size(130, 23);
            uiCancelButton.TabIndex = 7;
            uiCancelButton.Text = "Cancel";
            uiCancelButton.UseVisualStyleBackColor = true;
            uiCancelButton.Click += uiCancelButton_Click;
            // 
            // uiChangePasswordButton
            // 
            uiChangePasswordButton.Location = new Point(217, 84);
            uiChangePasswordButton.Name = "uiChangePasswordButton";
            uiChangePasswordButton.Size = new Size(130, 23);
            uiChangePasswordButton.TabIndex = 8;
            uiChangePasswordButton.Text = "Change Password";
            uiChangePasswordButton.UseVisualStyleBackColor = true;
            uiChangePasswordButton.Click += uiChangePasswordButton_Click;
            // 
            // ChangePasswordDialog
            // 
            AcceptButton = uiChangePasswordButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = uiCancelButton;
            ClientSize = new Size(365, 153);
            Controls.Add(uiChangePasswordButton);
            Controls.Add(uiCancelButton);
            Controls.Add(uiShowPasswordButton);
            Controls.Add(uiNewPasswordRepeatText);
            Controls.Add(label3);
            Controls.Add(uiNewPasswordText);
            Controls.Add(label2);
            Controls.Add(uiCurrentPasswordText);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ChangePasswordDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox uiCurrentPasswordText;
        private Label label2;
        private TextBox uiNewPasswordText;
        private Label label3;
        private TextBox uiNewPasswordRepeatText;
        private Button uiShowPasswordButton;
        private Button uiCancelButton;
        private Button uiChangePasswordButton;
    }
}