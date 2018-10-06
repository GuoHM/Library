namespace Library
{
    partial class LendBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendBookForm));
            this.lblNRIC = new System.Windows.Forms.Label();
            this.txtNRIC = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnNRIC = new System.Windows.Forms.Button();
            this.btnBookID = new System.Windows.Forms.Button();
            this.lblDOI = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.dtpDOI = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnIssuebook = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbPrintReceipt = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNRIC
            // 
            this.lblNRIC.AutoSize = true;
            this.lblNRIC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRIC.Location = new System.Drawing.Point(236, 147);
            this.lblNRIC.Name = "lblNRIC";
            this.lblNRIC.Size = new System.Drawing.Size(72, 30);
            this.lblNRIC.TabIndex = 1;
            this.lblNRIC.Text = "NRIC";
            // 
            // txtNRIC
            // 
            this.txtNRIC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRIC.Location = new System.Drawing.Point(314, 144);
            this.txtNRIC.Name = "txtNRIC";
            this.txtNRIC.Size = new System.Drawing.Size(133, 37);
            this.txtNRIC.TabIndex = 2;
            // 
            // txtBookID
            // 
            this.txtBookID.Enabled = false;
            this.txtBookID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(682, 140);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(133, 37);
            this.txtBookID.TabIndex = 4;
            this.txtBookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookID_KeyPress);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(581, 147);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(95, 30);
            this.lblBookID.TabIndex = 3;
            this.lblBookID.Text = "BookID";
            // 
            // btnNRIC
            // 
            this.btnNRIC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNRIC.Location = new System.Drawing.Point(469, 145);
            this.btnNRIC.Name = "btnNRIC";
            this.btnNRIC.Size = new System.Drawing.Size(46, 34);
            this.btnNRIC.TabIndex = 5;
            this.btnNRIC.Text = "...";
            this.btnNRIC.UseVisualStyleBackColor = true;
            this.btnNRIC.Click += new System.EventHandler(this.btnNRIC_Click);
            // 
            // btnBookID
            // 
            this.btnBookID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookID.Location = new System.Drawing.Point(840, 140);
            this.btnBookID.Name = "btnBookID";
            this.btnBookID.Size = new System.Drawing.Size(43, 36);
            this.btnBookID.TabIndex = 6;
            this.btnBookID.Text = "...";
            this.btnBookID.UseVisualStyleBackColor = true;
            this.btnBookID.Click += new System.EventHandler(this.btnBookID_Click);
            // 
            // lblDOI
            // 
            this.lblDOI.AutoSize = true;
            this.lblDOI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOI.Location = new System.Drawing.Point(236, 244);
            this.lblDOI.Name = "lblDOI";
            this.lblDOI.Size = new System.Drawing.Size(166, 30);
            this.lblDOI.TabIndex = 7;
            this.lblDOI.Text = "Date of Issue";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(275, 314);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(127, 30);
            this.lblDueDate.TabIndex = 8;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(289, 384);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(113, 30);
            this.lblRemarks.TabIndex = 9;
            this.lblRemarks.Text = "Remarks";
            // 
            // dtpDOI
            // 
            this.dtpDOI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOI.Location = new System.Drawing.Point(444, 239);
            this.dtpDOI.Name = "dtpDOI";
            this.dtpDOI.Size = new System.Drawing.Size(345, 37);
            this.dtpDOI.TabIndex = 10;
            this.dtpDOI.ValueChanged += new System.EventHandler(this.dtpDOI_ValueChanged);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Location = new System.Drawing.Point(444, 309);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(345, 37);
            this.dtpDueDate.TabIndex = 11;
            this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpDueDate_ValueChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(444, 381);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(345, 117);
            this.txtRemarks.TabIndex = 12;
            // 
            // btnIssuebook
            // 
            this.btnIssuebook.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIssuebook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssuebook.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIssuebook.Location = new System.Drawing.Point(723, 545);
            this.btnIssuebook.Name = "btnIssuebook";
            this.btnIssuebook.Size = new System.Drawing.Size(160, 46);
            this.btnIssuebook.TabIndex = 13;
            this.btnIssuebook.Text = "Issue ";
            this.btnIssuebook.UseVisualStyleBackColor = false;
            this.btnIssuebook.Click += new System.EventHandler(this.btnIssuebook_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 613);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Issue Book ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(200, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(726, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // cbPrintReceipt
            // 
            this.cbPrintReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPrintReceipt.Location = new System.Drawing.Point(527, 526);
            this.cbPrintReceipt.Name = "cbPrintReceipt";
            this.cbPrintReceipt.Size = new System.Drawing.Size(190, 86);
            this.cbPrintReceipt.TabIndex = 17;
            this.cbPrintReceipt.Text = "Print Receipt";
            this.cbPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // LendBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(926, 645);
            this.Controls.Add(this.cbPrintReceipt);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIssuebook);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dtpDOI);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblDOI);
            this.Controls.Add(this.btnBookID);
            this.Controls.Add(this.btnNRIC);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.txtNRIC);
            this.Controls.Add(this.lblNRIC);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LendBookForm";
            this.Controls.SetChildIndex(this.lblNRIC, 0);
            this.Controls.SetChildIndex(this.txtNRIC, 0);
            this.Controls.SetChildIndex(this.lblBookID, 0);
            this.Controls.SetChildIndex(this.txtBookID, 0);
            this.Controls.SetChildIndex(this.btnNRIC, 0);
            this.Controls.SetChildIndex(this.btnBookID, 0);
            this.Controls.SetChildIndex(this.lblDOI, 0);
            this.Controls.SetChildIndex(this.lblDueDate, 0);
            this.Controls.SetChildIndex(this.lblRemarks, 0);
            this.Controls.SetChildIndex(this.dtpDOI, 0);
            this.Controls.SetChildIndex(this.dtpDueDate, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.btnIssuebook, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.cbPrintReceipt, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNRIC;
        private System.Windows.Forms.TextBox txtNRIC;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Button btnNRIC;
        private System.Windows.Forms.Button btnBookID;
        private System.Windows.Forms.Label lblDOI;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.DateTimePicker dtpDOI;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnIssuebook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox cbPrintReceipt;
    }
}
