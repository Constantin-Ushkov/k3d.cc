namespace k3d.CC.View.WinForms
{
    partial class RenameUserDialog
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
            uiNameTextBox = new TextBox();
            label2 = new Label();
            uiPasswordTextBox = new TextBox();
            uiOkButton = new Button();
            uiCancelButton = new Button();
            uiShowPasswordButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "New name";
            // 
            // uiNameTextBox
            // 
            uiNameTextBox.Location = new Point(12, 27);
            uiNameTextBox.Name = "uiNameTextBox";
            uiNameTextBox.Size = new Size(201, 23);
            uiNameTextBox.TabIndex = 1;
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
            uiPasswordTextBox.Size = new Size(201, 23);
            uiPasswordTextBox.TabIndex = 3;
            // 
            // uiOkButton
            // 
            uiOkButton.Location = new Point(138, 129);
            uiOkButton.Name = "uiOkButton";
            uiOkButton.Size = new Size(75, 23);
            uiOkButton.TabIndex = 4;
            uiOkButton.Text = "Ok";
            uiOkButton.UseVisualStyleBackColor = true;
            uiOkButton.Click += uiOkButton_Click;
            // 
            // uiCancelButton
            // 
            uiCancelButton.Location = new Point(57, 129);
            uiCancelButton.Name = "uiCancelButton";
            uiCancelButton.Size = new Size(75, 23);
            uiCancelButton.TabIndex = 5;
            uiCancelButton.Text = "Cancel";
            uiCancelButton.UseVisualStyleBackColor = true;
            uiCancelButton.Click += uiCancelButton_Click;
            // 
            // uiShowPasswordButton
            // 
            uiShowPasswordButton.Location = new Point(12, 100);
            uiShowPasswordButton.Name = "uiShowPasswordButton";
            uiShowPasswordButton.Size = new Size(201, 23);
            uiShowPasswordButton.TabIndex = 6;
            uiShowPasswordButton.Text = "Show Password";
            uiShowPasswordButton.UseVisualStyleBackColor = true;
            uiShowPasswordButton.MouseDown += uiShowPasswordButton_MouseDown;
            uiShowPasswordButton.MouseUp += uiShowPasswordButton_MouseUp;
            // 
            // RenameUserDialog
            // 
            AcceptButton = uiOkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = uiCancelButton;
            ClientSize = new Size(228, 163);
            Controls.Add(uiShowPasswordButton);
            Controls.Add(uiCancelButton);
            Controls.Add(uiOkButton);
            Controls.Add(uiPasswordTextBox);
            Controls.Add(label2);
            Controls.Add(uiNameTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RenameUserDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rename User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox uiNameTextBox;
        private Label label2;
        private TextBox uiPasswordTextBox;
        private Button uiOkButton;
        private Button uiCancelButton;
        private Button uiShowPasswordButton;
    }
}