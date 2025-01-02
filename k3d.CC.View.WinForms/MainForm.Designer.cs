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
            helpToolStripMenuItem = new ToolStripMenuItem();
            uiLogOutMenuItem = new ToolStripMenuItem();
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
            uiMainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            uiMainMenuStrip.Location = new Point(0, 0);
            uiMainMenuStrip.Name = "uiMainMenuStrip";
            uiMainMenuStrip.Size = new Size(1562, 24);
            uiMainMenuStrip.TabIndex = 2;
            uiMainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uiLogOutMenuItem });
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
            uiTodayMainMenuItem.Name = "uiTodayMainMenuItem";
            uiTodayMainMenuItem.Size = new Size(105, 22);
            uiTodayMainMenuItem.Text = "&Today";
            uiTodayMainMenuItem.Click += uiTodayMainMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // uiLogOutMenuItem
            // 
            uiLogOutMenuItem.Enabled = false;
            uiLogOutMenuItem.Name = "uiLogOutMenuItem";
            uiLogOutMenuItem.Size = new Size(180, 22);
            uiLogOutMenuItem.Text = "Log &out";
            uiLogOutMenuItem.Click += uiLogOutMenuItem_Click;
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
        private ToolStripMenuItem uiLogOutMenuItem;
    }
}
