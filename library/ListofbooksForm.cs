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
    public partial class ListofbooksForm : Form
    {
        public ListofbooksForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LibDataSet context = new LibDataSet();
            LibDataSetTableAdapters.BooksTableAdapter b = new LibDataSetTableAdapters.BooksTableAdapter();
            b.Fill(context.Books);

            ListofBooks2 cr = new ListofBooks2();
            cr.SetDataSource(context);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
