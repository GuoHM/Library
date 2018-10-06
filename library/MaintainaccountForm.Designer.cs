namespace Library
{
    partial class MaintainaccountForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblNric = new System.Windows.Forms.Label();
            this.tbNRIC = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblContact = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 748);
            this.panel1.TabIndex = 42;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(265, 506);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(105, 30);
            this.lblAddress.TabIndex = 41;
            this.lblAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(428, 506);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(320, 131);
            this.tbAddress.TabIndex = 40;
            // 
            // lblNric
            // 
            this.lblNric.AutoSize = true;
            this.lblNric.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNric.Location = new System.Drawing.Point(292, 405);
            this.lblNric.Name = "lblNric";
            this.lblNric.Size = new System.Drawing.Size(72, 30);
            this.lblNric.TabIndex = 39;
            this.lblNric.Text = "NRIC";
            // 
            // tbNRIC
            // 
            this.tbNRIC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNRIC.Location = new System.Drawing.Point(428, 402);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.ReadOnly = true;
            this.tbNRIC.Size = new System.Drawing.Size(320, 37);
            this.tbNRIC.TabIndex = 38;
            this.tbNRIC.Validated += new System.EventHandler(this.tbNRIC_Validated);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(310, 668);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 50);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(258, 311);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(112, 30);
            this.lblContact.TabIndex = 36;
            this.lblContact.Text = "Contact";
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(428, 304);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(320, 37);
            this.tbContact.TabIndex = 35;
            this.tbContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContact_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(292, 215);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 30);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(428, 208);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(320, 37);
            this.tbEmail.TabIndex = 33;
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInfo.Location = new System.Drawing.Point(432, 57);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(249, 28);
            this.lblAccountInfo.TabIndex = 32;
            this.lblAccountInfo.Text = "Account Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(292, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 30);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(428, 124);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(320, 37);
            this.tbName.TabIndex = 30;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.Location = new System.Drawing.Point(776, 127);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(77, 34);
            this.btnSearchMember.TabIndex = 43;
            this.btnSearchMember.Text = "...";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(580, 668);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 50);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MaintainaccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(876, 781);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lblNric);
            this.Controls.Add(this.tbNRIC);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblAccountInfo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MaintainaccountForm";
            this.Controls.SetChildIndex(this.tbName, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblAccountInfo, 0);
            this.Controls.SetChildIndex(this.tbEmail, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.tbContact, 0);
            this.Controls.SetChildIndex(this.lblContact, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.tbNRIC, 0);
            this.Controls.SetChildIndex(this.lblNric, 0);
            this.Controls.SetChildIndex(this.tbAddress, 0);
            this.Controls.SetChildIndex(this.lblAddress, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnSearchMember, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblNric;
        private System.Windows.Forms.TextBox tbNRIC;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnDelete;
    }
}
