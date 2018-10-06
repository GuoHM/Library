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
    public partial class SearchMemberDialogue : Library.ParentDialogue
    {
        public string NRIC
        {
            get { return dvwMember.CurrentRow.Cells["NRIC"].Value.ToString(); }
        }

        private string value;

        public SearchMemberDialogue(string NRIC)
        {
            InitializeComponent();
            this.value = NRIC;
            this.SearchMember();
        }

        public SearchMemberDialogue()
        {
            InitializeComponent();
            this.value = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.SearchMember();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Tools.isNumber(e))
            {
                e.Handled = true;
            }
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            if (!Tools.isEmail(tbEmail.Text))
            {
                MessageBox.Show("Incorrect Email format!");
            }
        }

        private void SearchMember()
        {
            LibraryEntity context = new LibraryEntity();
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            string NRIC = this.value;
            var q = from x in context.Member
                    where x.NRIC.Contains(NRIC) && x.MemberName.Contains(name) && x.Phone.Contains(phone) && x.Email.Contains(email) && x.Address.Contains(address)
                    select x;
            dvwMember.DataSource = q.ToList();
        }

        private void SearchMemberDialogue_Load(object sender, EventArgs e)
        {

        }
    }
}
