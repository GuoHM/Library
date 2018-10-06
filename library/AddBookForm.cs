using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBookForm : Library.ParentForm
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LibraryEntity context = new LibraryEntity();
            Books b = new Books();
            try
            {
                b.Title = tbTitle.Text;
                b.Author = tbAuthor.Text;
                b.TotalStock = Convert.ToInt16(tbTotalStock.Text);
                b.Genre = cmbGenre.SelectedItem.ToString();
                b.CallNumber = tbCallNumber.Text;
                context.Books.Add(b);
                context.SaveChanges();
                MessageBox.Show("Update successfull");
                this.Close();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("fill in the all the details");
            }
        }

        private void tbCallNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Tools.isNumber(e))
            {
                e.Handled = true;
            }
        }

        private void tbTotalStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Tools.isNumber(e))
            {
                e.Handled = true;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
