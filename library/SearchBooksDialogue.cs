using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;

namespace Library
{
    public partial class SearchBooksDialogue : Library.ParentDialogue
    {
        public int booksid
        {
            get
            {
                try
                {
                    return Convert.ToInt32(dvwBooks.CurrentRow.Cells["bookid"].Value.ToString());
                }
                catch(System.NullReferenceException)
                {
                    MessageBox.Show("Valid bookID");
                    return 0;
                }
            }
        }

        public SearchBooksDialogue()
        {
            InitializeComponent();
        }

        private void btnBooksSearch_Click(object sender, EventArgs e)
        {
            LibraryEntity context = new LibraryEntity();
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string callNumber = tbCallNumber.Text;
            var q = from x in context.Books
                    where x.Title.Contains(title) && x.Author.Contains(author) && x.CallNumber.Contains(callNumber) && x.Genre.Contains(cmbGenre.Text)
                    select x;
            dvwBooks.DataSource = q.ToList();
            toolStripStatusLabel1.Text = q.Count().ToString() + " books found";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
          
        }

        private void tbTotalStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Tools.isNumber(e))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
