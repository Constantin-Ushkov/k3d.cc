namespace k3d.CC.View.WinForms
{
    partial class MainForm
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
            uiMainStatusStrip = new StatusStrip();
            uiMainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            uiTodayMainMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            uiUserLoginMenuItem = new ToolStripMenuItem();
            uiUserLogoutMenuItem = new ToolStripMenuItem();
            uiUserRenameMenuItem = new ToolStripMenuItem();
            uiUserChangePasswordMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            uiQuitMenuItem = new ToolStripMenuItem();
            uiMainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // uiMainStatusStrip
            // 
            uiMainStatusStrip.Location = new Point(0, 994);
            uiMainStatusStrip.Name = "uiMainStatusStrip";
            uiMainStatusStrip.Size = new Size(1562, 22);
            uiMainStatusStrip.TabIndex = 1;
            uiMainStatusStrip.Text = "statusStrip1";
            // 
            // uiMainMenuStrip
            // 
            uiMainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, userToolStripMenuItem, helpToolStripMenuItem });
            uiMainMenuStrip.Location = new Point(0, 0);
            uiMainMenuStrip.Name = "uiMainMenuStrip";
            uiMainMenuStrip.Size = new Size(1562, 24);
            uiMainMenuStrip.TabIndex = 2;
            uiMainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uiQuitMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uiTodayMainMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // uiTodayMainMenuItem
            // 
            uiTodayMainMenuItem.Enabled = false;
            uiTodayMainMenuItem.Name = "uiTodayMainMenuItem";
            uiTodayMainMenuItem.Size = new Size(180, 22);
            uiTodayMainMenuItem.Text = "&Today";
            uiTodayMainMenuItem.Click += uiTodayMainMenuItem_Click;
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uiUserLoginMenuItem, uiUserLogoutMenuItem, uiUserRenameMenuItem, uiUserChangePasswordMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(42, 20);
            userToolStripMenuItem.Text = "&User";
            // 
            // uiUserLoginMenuItem
            // 
            uiUserLoginMenuItem.Name = "uiUserLoginMenuItem";
            uiUserLoginMenuItem.Size = new Size(180, 22);
            uiUserLoginMenuItem.Text = "&Login";
            uiUserLoginMenuItem.Click += uiUserLoginMenuItem_Click;
            // 
            // uiUserLogoutMenuItem
            // 
            uiUserLogoutMenuItem.Name = "uiUserLogoutMenuItem";
            uiUserLogoutMenuItem.Size = new Size(180, 22);
            uiUserLogoutMenuItem.Text = "&Logout";
            uiUserLogoutMenuItem.Click += uiUserLogoutMenuItem_Click;
            // 
            // uiUserRenameMenuItem
            // 
            uiUserRenameMenuItem.Name = "uiUserRenameMenuItem";
            uiUserRenameMenuItem.Size = new Size(180, 22);
            uiUserRenameMenuItem.Text = "&Rename";
            uiUserRenameMenuItem.Click += uiUserRenameMenuItem_Click;
            // 
            // uiUserChangePasswordMenuItem
            // 
            uiUserChangePasswordMenuItem.Name = "uiUserChangePasswordMenuItem";
            uiUserChangePasswordMenuItem.Size = new Size(180, 22);
            uiUserChangePasswordMenuItem.Text = "&Change Password";
            uiUserChangePasswordMenuItem.Click += uiUserChangePasswordMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // uiQuitMenuItem
            // 
            uiQuitMenuItem.Name = "uiQuitMenuItem";
            uiQuitMenuItem.Size = new Size(180, 22);
            uiQuitMenuItem.Text = "&Quit";
            uiQuitMenuItem.Click += uiQuitMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1562, 1016);
            Controls.Add(uiMainStatusStrip);
            Controls.Add(uiMainMenuStrip);
            IsMdiContainer = true;
            MainMenuStrip = uiMainMenuStrip;
            Name = "MainForm";
            Text = "Control Center";
            FormClosing += MainForm_FormClosing;
            Shown += MainForm_Shown;
            uiMainMenuStrip.ResumeLayout(false);
            uiMainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip uiMainStatusStrip;
        private MenuStrip uiMainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem uiTodayMainMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem uiUserLoginMenuItem;
        private ToolStripMenuItem uiUserLogoutMenuItem;
        private ToolStripMenuItem uiUserRenameMenuItem;
        private ToolStripMenuItem uiUserChangePasswordMenuItem;
        private ToolStripMenuItem uiQuitMenuItem;
    }
}
