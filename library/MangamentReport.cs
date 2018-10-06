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
    public partial class MangamentReport : Form
    {
        public MangamentReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LibDataSet context = new LibDataSet();
            LibDataSetTableAdapters.BooksTableAdapter b = new LibDataSetTableAdapters.BooksTableAdapter();
            LibDataSetTableAdapters.BorrowTableAdapter c = new LibDataSetTableAdapters.BorrowTableAdapter();
            b.Fill(context.Books);
            c.Fill(context.Borrow);

            BorrowReport cr1 = new BorrowReport();
            cr1.SetDataSource(context);
            crystalReportViewer1.ReportSource = cr1;
        }
    }
}
