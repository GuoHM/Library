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
    public partial class ReceiptForm : Form
    {
        /// <summary>
        /// Should give a tranid value to generate a receipt
        /// </summary>
        /// <param name="TranID">The vlaue which pass form the pervious form</param>
        public ReceiptForm(int TranID)
        {
            InitializeComponent();
            this.TranID = TranID;
        }
        private int TranID;
      
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LibDataSet context = new LibDataSet();
            LibDataSetTableAdapters.BooksTableAdapter b = new LibDataSetTableAdapters.BooksTableAdapter();
            LibDataSetTableAdapters.BorrowTableAdapter c = new LibDataSetTableAdapters.BorrowTableAdapter();
            LibDataSetTableAdapters.MemberTableAdapter d = new LibDataSetTableAdapters.MemberTableAdapter();
           
            b.Fill(context.Books);
            c.Fill(context.Borrow);
            d.Fill(context.Member);
            receiptCrystalReport cr1 = new receiptCrystalReport();
            cr1.SetDataSource(context);
            crystalReportViewer1.ReportSource = cr1;
            ///
            /// select a transcation shown on the receipt
            ///
            crystalReportViewer1.SelectionFormula = "{Borrow.TransactionID} = "+TranID;
        }
    }
}
