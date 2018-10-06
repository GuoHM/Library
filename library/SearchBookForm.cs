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
    public partial class SearchBookForm : Library.ParentForm
    {
        public SearchBookForm()
        {
            InitializeComponent();
        }

        private void SearchBookForm_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LibraryEntity context = new LibraryEntity();
            var q = from x in context.vw_min_book
                    where x.Title.Contains(tbTitle.Text) && x.Author.Contains(tbAuthor.Text) && x.Genre.Contains(cmbGenre.Text)
                    select x;
            dvwBooks.DataSource = q.ToList();
            toolStripStatusLabel1.Text = q.Count().ToString() + " books found";
        }
    }
}
