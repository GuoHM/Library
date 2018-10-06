using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Library
{
    public partial class QueryForm : Library.ParentForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Search for all the borrow record accord to the input conditions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryEntity context = new LibraryEntity();
                if (String.IsNullOrEmpty(tbBookID.Text))
                {
                    var q = from x in context.Borrow
                            where x.NRIC.Contains(tbNRIC.Text)
                            && (x.DateIssue >= dtpIssueDate.Value.Date && x.DateDue <= dtpDueDate.Value.Date)
                            && x.RentalStatus == "out"
                            select new { x.TransactionID, x.Books.Title, x.Member.NRIC, x.Member.MemberName };
                    dvwMemberBorrows.DataSource = q.ToList();
                }
                else
                {
                    int bookid = Convert.ToInt32(tbBookID.Text);

                    var q = from x in context.Borrow
                            where x.BookID == bookid
                            && x.NRIC.Contains(tbNRIC.Text)
                            && (x.DateIssue >= dtpIssueDate.Value.Date && x.DateDue <= dtpDueDate.Value.Date)
                            && x.RentalStatus == "out"
                            select new { x.TransactionID, x.Books.Title, x.Member.NRIC, x.Member.MemberName };
                    dvwMemberBorrows.DataSource = q.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please input booksid!");

            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            SearchMemberDialogue searchMember = new SearchMemberDialogue(tbNRIC.Text);
            searchMember.ShowDialog();
            if (searchMember.DialogResult == DialogResult.OK)
            {
                tbNRIC.Text = searchMember.NRIC;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchBooksDialogue searchBooks = new SearchBooksDialogue();
            searchBooks.ShowDialog();
            if (searchBooks.DialogResult == DialogResult.OK)
            {
                tbBookID.Text = searchBooks.booksid.ToString();
            }
        }

        /// <summary>
        /// Search for all the borrow record for a given member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckMember_Click(object sender, EventArgs e)
        {
            LibraryEntity context = new LibraryEntity();
            var q = from x in context.Borrow
                    where x.NRIC == tbNRIC.Text
                    select new { x.TransactionID, x.Books.Title, x.Member.NRIC, x.Member.MemberName, x.DateIssue, x.DateDue };
            dvwMemberBorrows.DataSource = q.ToList();
        }

        /// <summary>
        /// Search for all the borrow record for a given member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckBook_Click_1(object sender, EventArgs e)
        {
            try
            {
                LibraryEntity context = new LibraryEntity();
                int bookid = Convert.ToInt32(tbBookID.Text);
                dvwMemberBorrows.DataSource = context.Borrow.Where(x => x.BookID == bookid).ToList();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please select a book!");
            }
        }

    }
}
