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
    public partial class MaintainBooksForm : Library.ParentForm
    {
        LibraryEntity context = new LibraryEntity();
        public MaintainBooksForm()
        {
            InitializeComponent();
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            SearchBooksDialogue searchBooksDialogue = new SearchBooksDialogue();
            searchBooksDialogue.ShowDialog();
            if (searchBooksDialogue.DialogResult == DialogResult.OK)
            {
                Books books = context.Books.Where(x => x.BookID == searchBooksDialogue.booksid).First();
                tbBooksID.Text = books.BookID.ToString();
                tbTitle.Text = books.Title.ToString();
                tbAuthor.Text = books.Author.ToString();
                tbCallNumber.Text = books.CallNumber.ToString();
                cmbGenre.Text = books.Genre.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int booksID = Convert.ToInt32(tbBooksID.Text);
                Books books = context.Books.Where(x => x.BookID == booksID).First();
                books.Title = tbTitle.Text;
                books.Author = tbAuthor.Text;
                books.CallNumber = tbCallNumber.Text;
                books.Genre = cmbGenre.Text;
                context.SaveChanges();
                MessageBox.Show("Update successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("fill in the all the details");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbBooksID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
