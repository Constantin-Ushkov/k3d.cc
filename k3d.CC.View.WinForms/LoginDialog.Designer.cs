﻿namespace k3d.CC.View.WinForms
{
    partial class LoginDialog
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
            uiDataLocationText = new TextBox();
            uiBrowseDataLocationButton = new Button();
            label2 = new Label();
            uiAccountNameComboBox = new ComboBox();
            label3 = new Label();
            uiPasswordText = new TextBox();
            uiLoginButton = new Button();
            uiCancelButton = new Button();
            uiNewAccountButton = new Button();
            uiDataLocationFolderDialog = new FolderBrowserDialog();
            uiShowPasswordButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Data location";
            // 
            // uiDataLocationText
            // 
            uiDataLocationText.Enabled = false;
            uiDataLocationText.Location = new Point(12, 27);
            uiDataLocationText.Name = "uiDataLocationText";
            uiDataLocationText.Size = new Size(286, 23);
            uiDataLocationText.TabIndex = 1;
            // 
            // uiBrowseDataLocationButton
            // 
            uiBrowseDataLocationButton.Enabled = false;
            uiBrowseDataLocationButton.Location = new Point(304, 26);
            uiBrowseDataLocationButton.Name = "uiBrowseDataLocationButton";
            uiBrowseDataLocationButton.Size = new Size(24, 23);
            uiBrowseDataLocationButton.TabIndex = 2;
            uiBrowseDataLocationButton.Text = "...";
            uiBrowseDataLocationButton.UseVisualStyleBackColor = true;
            uiBrowseDataLocationButton.Click += uiBrowseDataLocationButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "Account name";
            // 
            // uiAccountNameComboBox
            // 
            uiAccountNameComboBox.FormattingEnabled = true;
            uiAccountNameComboBox.Location = new Point(12, 72);
            uiAccountNameComboBox.Name = "uiAccountNameComboBox";
            uiAccountNameComboBox.Size = new Size(156, 23);
            uiAccountNameComboBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // uiPasswordText
            // 
            uiPasswordText.Location = new Point(12, 116);
            uiPasswordText.Name = "uiPasswordText";
            uiPasswordText.PasswordChar = '*';
            uiPasswordText.Size = new Size(156, 23);
            uiPasswordText.TabIndex = 6;
            // 
            // uiLoginButton
            // 
            uiLoginButton.Location = new Point(206, 145);
            uiLoginButton.Name = "uiLoginButton";
            uiLoginButton.Size = new Size(122, 23);
            uiLoginButton.TabIndex = 7;
            uiLoginButton.Text = "Log in";
            uiLoginButton.UseVisualStyleBackColor = true;
            uiLoginButton.Click += uiLoginButton_Click;
            // 
            // uiCancelButton
            // 
            uiCancelButton.Location = new Point(206, 116);
            uiCancelButton.Name = "uiCancelButton";
            uiCancelButton.Size = new Size(122, 23);
            uiCancelButton.TabIndex = 8;
            uiCancelButton.Text = "Cancel";
            uiCancelButton.UseVisualStyleBackColor = true;
            uiCancelButton.Click += uiCancelButton_Click;
            // 
            // uiNewAccountButton
            // 
            uiNewAccountButton.Location = new Point(206, 88);
            uiNewAccountButton.Name = "uiNewAccountButton";
            uiNewAccountButton.Size = new Size(122, 23);
            uiNewAccountButton.TabIndex = 9;
            uiNewAccountButton.Text = "New Account";
            uiNewAccountButton.UseVisualStyleBackColor = true;
            uiNewAccountButton.Click += uiNewAccountButton_Click;
            // 
            // uiShowPasswordButton
            // 
            uiShowPasswordButton.Location = new Point(12, 145);
            uiShowPasswordButton.Name = "uiShowPasswordButton";
            uiShowPasswordButton.Size = new Size(156, 23);
            uiShowPasswordButton.TabIndex = 10;
            uiShowPasswordButton.Text = "Show Password";
            uiShowPasswordButton.UseVisualStyleBackColor = true;
            uiShowPasswordButton.MouseDown += uiShowPasswordButton_MouseDown;
            uiShowPasswordButton.MouseUp += uiShowPasswordButton_MouseUp;
            // 
            // LoginDialog
            // 
            AcceptButton = uiLoginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = uiCancelButton;
            ClientSize = new Size(340, 178);
            Controls.Add(uiShowPasswordButton);
            Controls.Add(uiNewAccountButton);
            Controls.Add(uiCancelButton);
            Controls.Add(uiLoginButton);
            Controls.Add(uiPasswordText);
            Controls.Add(label3);
            Controls.Add(uiAccountNameComboBox);
            Controls.Add(label2);
            Controls.Add(uiBrowseDataLocationButton);
            Controls.Add(uiDataLocationText);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Logging in...";
            FormClosing += LoginForm_FormClosing;
            Shown += LoginDialog_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox uiDataLocationText;
        private Button uiBrowseDataLocationButton;
        private Label label2;
        private ComboBox uiAccountNameComboBox;
        private Label label3;
        private TextBox uiPasswordText;
        private Button uiLoginButton;
        private Button uiCancelButton;
        private Button uiNewAccountButton;
        private FolderBrowserDialog uiDataLocationFolderDialog;
        private Button uiShowPasswordButton;
    }
}