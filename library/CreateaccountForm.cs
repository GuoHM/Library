using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class CreateaccountForm : Library.ParentForm
    {
        public CreateaccountForm()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            LibraryEntity context = new LibraryEntity();
            Member m = new Member();
            try
            {
                m.NRIC = tbNRIC.Text;
                m.MemberName = tbName.Text;
                m.Phone = tbContact.Text;
                m.Email = tbEmail.Text;
                m.Address = tbAddress.Text;
                ///
                ///The quota for every new member is 4
                ///
                m.Quota = 4;
                context.Member.Add(m);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("fill in the all the details");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Tools.isNumber(e))
            {
                e.Handled = true;
            }
        }

        private void tbNRIC_Validated(object sender, EventArgs e)
        {
            if (!Tools.isNRIC(tbNRIC.Text))
            {
                MessageBox.Show("Wrong NRIC format!");
            }
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            if (!Tools.isEmail(tbEmail.Text))
            {
                MessageBox.Show("Wrong Email format!");
            }
        }
    }
}
