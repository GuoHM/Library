namespace Library
{
    partial class ParentForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAvaliabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miantainBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.maintainInformationToolStripMenuItem,
            this.checkAvaliabToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(93, 28);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(340, 30);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // maintainInformationToolStripMenuItem
            // 
            this.maintainInformationToolStripMenuItem.Name = "maintainInformationToolStripMenuItem";
            this.maintainInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.maintainInformationToolStripMenuItem.Size = new System.Drawing.Size(340, 30);
            this.maintainInformationToolStripMenuItem.Text = "Maintain Information";
            this.maintainInformationToolStripMenuItem.Click += new System.EventHandler(this.maintainInformationToolStripMenuItem_Click);
            // 
            // checkAvaliabToolStripMenuItem
            // 
            this.checkAvaliabToolStripMenuItem.Name = "checkAvaliabToolStripMenuItem";
            this.checkAvaliabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.checkAvaliabToolStripMenuItem.Size = new System.Drawing.Size(340, 30);
            this.checkAvaliabToolStripMenuItem.Text = "Check Availability";
            this.checkAvaliabToolStripMenuItem.Click += new System.EventHandler(this.checkAvaliabToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(340, 30);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.createBooksToolStripMenuItem,
            this.miantainBooksToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(73, 28);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // borrowBooksToolStripMenuItem
            // 
            this.borrowBooksToolStripMenuItem.Name = "borrowBooksToolStripMenuItem";
            this.borrowBooksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.borrowBooksToolStripMenuItem.Size = new System.Drawing.Size(391, 30);
            this.borrowBooksToolStripMenuItem.Text = "Borrow Books";
            this.borrowBooksToolStripMenuItem.Click += new System.EventHandler(this.borrowBooksToolStripMenuItem_Click);
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(391, 30);
            this.returnBooksToolStripMenuItem.Text = "Return Books";
            this.returnBooksToolStripMenuItem.Click += new System.EventHandler(this.returnBooksToolStripMenuItem_Click);
            // 
            // createBooksToolStripMenuItem
            // 
            this.createBooksToolStripMenuItem.Name = "createBooksToolStripMenuItem";
            this.createBooksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.createBooksToolStripMenuItem.Size = new System.Drawing.Size(391, 30);
            this.createBooksToolStripMenuItem.Text = "Input New Book";
            this.createBooksToolStripMenuItem.Click += new System.EventHandler(this.createBooksToolStripMenuItem_Click);
            // 
            // miantainBooksToolStripMenuItem
            // 
            this.miantainBooksToolStripMenuItem.Name = "miantainBooksToolStripMenuItem";
            this.miantainBooksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.miantainBooksToolStripMenuItem.Size = new System.Drawing.Size(391, 30);
            this.miantainBooksToolStripMenuItem.Text = "Maintain Book Information";
            this.miantainBooksToolStripMenuItem.Click += new System.EventHandler(this.miantainBooksToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfBooksToolStripMenuItem,
            this.managementReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(81, 28);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // listOfBooksToolStripMenuItem
            // 
            this.listOfBooksToolStripMenuItem.Name = "listOfBooksToolStripMenuItem";
            this.listOfBooksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.listOfBooksToolStripMenuItem.Size = new System.Drawing.Size(331, 30);
            this.listOfBooksToolStripMenuItem.Text = "List of Books";
            this.listOfBooksToolStripMenuItem.Click += new System.EventHandler(this.listOfBooksToolStripMenuItem_Click);
            // 
            // managementReportToolStripMenuItem
            // 
            this.managementReportToolStripMenuItem.Name = "managementReportToolStripMenuItem";
            this.managementReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.managementReportToolStripMenuItem.Size = new System.Drawing.Size(331, 30);
            this.managementReportToolStripMenuItem.Text = "Management Report";
            this.managementReportToolStripMenuItem.Click += new System.EventHandler(this.managementReportToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "Library Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem maintainInformationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem borrowBooksToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem miantainBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAvaliabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementReportToolStripMenuItem;
    }
}