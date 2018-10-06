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
    public partial class MaintainaccountForm : Library.ParentForm
    {
        public MaintainaccountForm()
        {
            InitializeComponent();
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            LibraryEntity context = new LibraryEntity();
            SearchMemberDialogue searchMember = new SearchMemberDialogue();
            searchMember.ShowDialog();
            if (searchMember.DialogResult == DialogResult.OK)
            {
                Member member = context.Member.Where(x => x.NRIC == searchMember.NRIC).First();
                tbNRIC.Text = member.NRIC.ToString();
                tbName.Text = member.MemberName.ToString();
                tbEmail.Text = member.Email.ToString();
                tbContact.Text = member.Phone.ToString();
                tbAddress.Text = member.Address.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LibraryEntity context = new LibraryEntity();
            try
            {
                Member m = context.Member.Where(x => x.NRIC == tbNRIC.Text).First();
                if (tbName.Text != "" && tbContact.Text != "" && tbEmail.Text != "" && m.Address != "")
                {
                    m.MemberName = tbName.Text;
                    m.Phone = tbContact.Text;
                    m.Email = tbEmail.Text;
                    m.Address = tbAddress.Text;
                    context.SaveChanges();
                    MessageBox.Show("Update successfully!");
                }
                else
                {
                    MessageBox.Show("Fill in the all the details");
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Fill in the all the details");
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Invalid NRIC");
            }
        }

        private void tbNRIC_Validated(object sender, EventArgs e)
        {
            if (!Tools.isNRIC(tbNRIC.Text))
            {
                MessageBox.Show("Wrong NRIC format!");
            }
        }

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Tools.isNumber(e))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Delete the member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            LibraryEntity context = new LibraryEntity();
            try
            {
                Member member = context.Member.Where(x => x.NRIC == tbNRIC.Text).First();
                context.Member.Remove(member);
                context.SaveChanges();
                MessageBox.Show("successful");
                tbNRIC.Text = null;
                tbName.Text = null;
                tbEmail.Text = null;
                tbContact.Text = null;
                tbAddress.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid NRIC");
            }
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            if (!Tools.isEmail(tbEmail.Text))
            {
                MessageBox.Show("Wrong Email Format!");
            }
        }
    }
}
