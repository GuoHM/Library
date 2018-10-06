namespace Library
{
    partial class ReturnBookForm
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
            this.lblNRIC = new System.Windows.Forms.Label();
            this.txtNRIC = new System.Windows.Forms.TextBox();
            this.btnNRIC = new System.Windows.Forms.Button();
            this.lblBook = new System.Windows.Forms.Label();
            this.dvwBooks = new System.Windows.Forms.DataGridView();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvwBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNRIC
            // 
            this.lblNRIC.AutoSize = true;
            this.lblNRIC.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRIC.Location = new System.Drawing.Point(17, 141);
            this.lblNRIC.Name = "lblNRIC";
            this.lblNRIC.Size = new System.Drawing.Size(63, 23);
            this.lblNRIC.TabIndex = 1;
            this.lblNRIC.Text = "NRIC:";
            // 
            // txtNRIC
            // 
            this.txtNRIC.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRIC.Location = new System.Drawing.Point(87, 138);
            this.txtNRIC.Name = "txtNRIC";
            this.txtNRIC.Size = new System.Drawing.Size(184, 32);
            this.txtNRIC.TabIndex = 2;
            // 
            // btnNRIC
            // 
            this.btnNRIC.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNRIC.Location = new System.Drawing.Point(277, 138);
            this.btnNRIC.Name = "btnNRIC";
            this.btnNRIC.Size = new System.Drawing.Size(40, 34);
            this.btnNRIC.TabIndex = 3;
            this.btnNRIC.Text = "...";
            this.btnNRIC.UseVisualStyleBackColor = true;
            this.btnNRIC.Click += new System.EventHandler(this.btnNRIC_Click);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(18, 196);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(62, 23);
            this.lblBook.TabIndex = 4;
            this.lblBook.Text = "Book:";
            // 
            // dvwBooks
            // 
            this.dvwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwBooks.Location = new System.Drawing.Point(87, 196);
            this.dvwBooks.Name = "dvwBooks";
            this.dvwBooks.RowTemplate.Height = 28;
            this.dvwBooks.Size = new System.Drawing.Size(629, 302);
            this.dvwBooks.TabIndex = 5;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSearchBook.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchBook.Location = new System.Drawing.Point(345, 135);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(101, 41);
            this.btnSearchBook.TabIndex = 6;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.OliveDrab;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturn.Location = new System.Drawing.Point(617, 520);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 41);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Return Books";
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(793, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.dvwBooks);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.btnNRIC);
            this.Controls.Add(this.txtNRIC);
            this.Controls.Add(this.lblNRIC);
            this.Name = "ReturnBookForm";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.Controls.SetChildIndex(this.lblNRIC, 0);
            this.Controls.SetChildIndex(this.txtNRIC, 0);
            this.Controls.SetChildIndex(this.btnNRIC, 0);
            this.Controls.SetChildIndex(this.lblBook, 0);
            this.Controls.SetChildIndex(this.dvwBooks, 0);
            this.Controls.SetChildIndex(this.btnSearchBook, 0);
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dvwBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNRIC;
        private System.Windows.Forms.TextBox txtNRIC;
        private System.Windows.Forms.Button btnNRIC;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.DataGridView dvwBooks;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
    }
}
