using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void maintainInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintainaccountForm maintainaccount = new MaintainaccountForm();
            maintainaccount.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void quToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBookForm searchBook = new SearchBookForm();
            searchBook.Show();
        }

        private void borrowBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LendBookForm lendBook = new LendBookForm();
            lendBook.Show();
        }

        private void miantainBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintainBooksForm maintainBooks = new MaintainBooksForm();
            maintainBooks.Show();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateaccountForm createaccount = new CreateaccountForm();
            createaccount.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkAvaliabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
        }

        private void createBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm addBook = new AddBookForm();
            addBook.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnbooks = new ReturnBookForm();
            returnbooks.Show();
        }

        private void listOfBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListofbooksForm report = new ListofbooksForm();
            report.ShowDialog();
        }

        private void managementReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MangamentReport report = new MangamentReport();
            report.ShowDialog();
        }
    }
}
