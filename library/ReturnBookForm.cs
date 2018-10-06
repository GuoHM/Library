using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Transactions;


namespace Library
{
    public partial class ReturnBookForm : Library.ParentForm
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            LibraryEntity context = new LibraryEntity();
            dvwBooks.DataSource = context.Borrow.Where(x => x.NRIC == txtNRIC.Text && x.RentalStatus == "out").ToList();
        }

        private void btnNRIC_Click(object sender, EventArgs e)
        {
            SearchMemberDialogue mems = new SearchMemberDialogue(txtNRIC.Text);
            mems.ShowDialog();
            if (mems.DialogResult == DialogResult.OK)
            {
                this.txtNRIC.Text = mems.NRIC;
            }
        }

        /// <summary>
        /// Set status to 'in'
        /// </summary>
        private void BookReturn()
        {
            LibraryEntity context = new LibraryEntity();
            string TranID = dvwBooks.CurrentRow.Cells["TransactionID"].Value.ToString();
            int TransID = Convert.ToInt32(TranID);
            Borrow bor = context.Borrow.Where(x => x.TransactionID == TransID).First();
            bor.RentalStatus = "in";
            bor.DateActualReturn = DateTime.Now;
            context.SaveChanges();
        }

        /// <summary>
        /// Total stock plus 1
        /// </summary>
        private void Addtotalstock()
        {
            LibraryEntity context = new LibraryEntity();
            string BokID = dvwBooks.CurrentRow.Cells["BookID"].Value.ToString();
            int BookID = Convert.ToInt32(BokID);
            Books bok = context.Books.Where(x => x.BookID == BookID).First();
            bok.TotalStock = (short)(bok.TotalStock + 1);
            context.SaveChanges();
        }

        /// <summary>
        /// Quotq plus 1
        /// </summary>
        private void AddQuota()
        {
            LibraryEntity context = new LibraryEntity();
            Member mem = context.Member.Where(x => x.NRIC == txtNRIC.Text).First();
            mem.Quota = mem.Quota + 1;
            context.SaveChanges();
        }

        /// <summary>
        /// Return book: Set the status in borrow table to 'in', total stock for the book plus 1, quota for the memebr plus 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope transScope = new TransactionScope())
                {
                    this.BookReturn();
                    this.Addtotalstock();
                    this.AddQuota();
                    MessageBox.Show("Return successfully!!");
                    transScope.Complete();
                }
            }
            catch
            {
                MessageBox.Show("failed!!Please check your NRIC");
            }
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
