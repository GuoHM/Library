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
    public partial class LendBookForm : Library.ParentForm
    {

        public LendBookForm()
        {
            InitializeComponent();
        }

        private void btnBookID_Click(object sender, EventArgs e)
        {
            SearchBooksDialogue searchBooksDialogue = new SearchBooksDialogue();
            searchBooksDialogue.ShowDialog();
            if (searchBooksDialogue.DialogResult == DialogResult.OK)
            {
                txtBookID.Text = searchBooksDialogue.booksid.ToString();
            }
        }

        private void btnNRIC_Click(object sender, EventArgs e)
        {
            SearchMemberDialogue searchMemberDialogue = new SearchMemberDialogue(txtNRIC.Text);
            searchMemberDialogue.ShowDialog();
            if (searchMemberDialogue.DialogResult == DialogResult.OK)
            {
                txtNRIC.Text = searchMemberDialogue.NRIC.ToString();
            }
        }

        private void txtBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Tools.isNumber(e))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Insert a record into borrow table
        /// </summary>
        private void Borrow()
        {
            LibraryEntity context = new LibraryEntity();
            Borrow bo = new Borrow();
            Member me = context.Member.Where(x => x.NRIC == txtNRIC.Text).First();
            int bookID = Convert.ToInt32(txtBookID.Text);
            Books bok = context.Books.Where(x => x.BookID == bookID).First();
            bo.Member = me;
            bo.Books = bok;
            bo.BookID = bok.BookID;
            bo.NRIC = me.NRIC;
            bo.RentalStatus = "out";
            bo.DateIssue = dtpDOI.Value;
            bo.DateDue = dtpDueDate.Value;
            bo.Remarks = txtRemarks.Text;
            context.Borrow.Add(bo);
            context.SaveChanges();
        }

        /// <summary>
        /// Total stock in book table minus 1
        /// </summary>
        private void TotalStockminus()
        {
            LibraryEntity context = new LibraryEntity();
            int bookID = Convert.ToInt32(txtBookID.Text);
            try
            {
                Books bok = context.Books.Where(x => x.BookID == bookID).First();
                bok.TotalStock = (short)(bok.TotalStock - 1);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// Quota for the member minus 1
        /// </summary>
        private void Quotaminus()
        {
            LibraryEntity context = new LibraryEntity();
            Member me = context.Member.Where(x => x.NRIC == txtNRIC.Text).First();
            me.Quota = me.Quota - 1;
            context.SaveChanges();
        }

        /// <summary>
        /// Issue borrow book: Insert a borrow record to the borrow table, the total stock of the book minus 1, the quota for member minus 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIssuebook_Click(object sender, EventArgs e)
        {
            LibraryEntity context = new LibraryEntity();
            try
            {
                using (TransactionScope transScope = new TransactionScope())
                {
                    int bookID = Convert.ToInt32(txtBookID.Text);
                    Books bok = context.Books.Where(x => x.BookID == bookID).First();
                    Member mem = context.Member.Where(x => x.NRIC == txtNRIC.Text).First();
                    if (bok.TotalStock > 0 && mem.Quota > 0)
                    {
                        this.Borrow();
                        this.TotalStockminus();
                        this.Quotaminus();
                        toolStripStatusLabel1.Text = "Lend successfully";
                        // Auto increment column, the last record is the newest record
                        int Count = context.Borrow.Count();
                        Borrow bor = context.Borrow.ToList()[Count - 1];
                        int TraID = bor.TransactionID;
                        if (cbPrintReceipt.CheckState == CheckState.Checked)
                        {
                            // The receipt form should given a tranID
                            ReceiptForm rececipt = new ReceiptForm(TraID);
                            rececipt.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check the totalstock of " + bok.Title + "or the quota of" + mem.MemberName);
                    }
                    transScope.Complete();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your NRIC or BookID");
            }
        }

        /// <summary>
        /// Date validation: If selected date before today than show error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDOI_ValueChanged(object sender, EventArgs e)
        {
            DateTime DOI = dtpDOI.Value;
            DateTime DD = dtpDueDate.Value;
            if (DOI > DD)
            {
                MessageBox.Show("Wrong date!!");
                dtpDOI.Value = DateTime.Now.Date;
            }
        }

        /// <summary>
        /// Date validation: If selected date before today than show error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime DOI = dtpDOI.Value.Date;
            DateTime DD = dtpDueDate.Value.Date;
            if (DD < DOI)
            {
                MessageBox.Show("Wrong date！！");
                dtpDueDate.Value = DateTime.Now.Date;
            }
        }
    }
}
