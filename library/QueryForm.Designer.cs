namespace Library
{
    partial class QueryForm
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.dvwMemberBorrows = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNRIC = new System.Windows.Forms.TextBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnCheckMember = new System.Windows.Forms.Button();
            this.btnCheckBook = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvwMemberBorrows)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCheck.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheck.Location = new System.Drawing.Point(736, 290);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(253, 43);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Borrow Record";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvwMemberBorrows
            // 
            this.dvwMemberBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwMemberBorrows.Location = new System.Drawing.Point(72, 365);
            this.dvwMemberBorrows.Name = "dvwMemberBorrows";
            this.dvwMemberBorrows.RowTemplate.Height = 28;
            this.dvwMemberBorrows.Size = new System.Drawing.Size(817, 351);
            this.dvwMemberBorrows.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "NRIC";
            // 
            // tbNRIC
            // 
            this.tbNRIC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNRIC.Location = new System.Drawing.Point(267, 93);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.Size = new System.Drawing.Size(256, 37);
            this.tbNRIC.TabIndex = 5;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.Location = new System.Drawing.Point(556, 97);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(74, 35);
            this.btnSearchMember.TabIndex = 6;
            this.btnSearchMember.Text = "...";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(555, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbBookID
            // 
            this.tbBookID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookID.Location = new System.Drawing.Point(267, 165);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(256, 37);
            this.tbBookID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "BookID";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.Location = new System.Drawing.Point(267, 228);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(421, 37);
            this.dtpIssueDate.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date Issue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Due Date";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Location = new System.Drawing.Point(267, 298);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(421, 37);
            this.dtpDueDate.TabIndex = 12;
            // 
            // btnCheckMember
            // 
            this.btnCheckMember.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCheckMember.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckMember.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheckMember.Location = new System.Drawing.Point(736, 100);
            this.btnCheckMember.Name = "btnCheckMember";
            this.btnCheckMember.Size = new System.Drawing.Size(253, 43);
            this.btnCheckMember.TabIndex = 17;
            this.btnCheckMember.Text = "Check Member";
            this.btnCheckMember.UseVisualStyleBackColor = false;
            this.btnCheckMember.Click += new System.EventHandler(this.btnCheckMember_Click);
            // 
            // btnCheckBook
            // 
            this.btnCheckBook.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCheckBook.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBook.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheckBook.Location = new System.Drawing.Point(736, 164);
            this.btnCheckBook.Name = "btnCheckBook";
            this.btnCheckBook.Size = new System.Drawing.Size(253, 43);
            this.btnCheckBook.TabIndex = 18;
            this.btnCheckBook.Text = "Retrieve Book Details";
            this.btnCheckBook.UseVisualStyleBackColor = false;
            this.btnCheckBook.Click += new System.EventHandler(this.btnCheckBook_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Records";
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1011, 738);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCheckBook);
            this.Controls.Add(this.btnCheckMember);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbBookID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.tbNRIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvwMemberBorrows);
            this.Controls.Add(this.btnCheck);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QueryForm";
            this.Controls.SetChildIndex(this.btnCheck, 0);
            this.Controls.SetChildIndex(this.dvwMemberBorrows, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbNRIC, 0);
            this.Controls.SetChildIndex(this.btnSearchMember, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbBookID, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.dtpIssueDate, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtpDueDate, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnCheckMember, 0);
            this.Controls.SetChildIndex(this.btnCheckBook, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dvwMemberBorrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView dvwMemberBorrows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNRIC;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnCheckMember;
        private System.Windows.Forms.Button btnCheckBook;
        private System.Windows.Forms.Label label5;
    }
}
