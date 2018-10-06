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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void lblMemberID_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LibraryEntity context = new LibraryEntity();
            if (tbMemberID.Text == "Venkat")
            {
                if (tbPassword.Text == "P@ssword1")
                {
                    SearchBookForm form = new SearchBookForm();
                    form.ShowDialog(this);
                    this.Close();
                }
                else
                    MessageBox.Show("Incorect password!");
            }
            else
            {
                int id = Convert.ToInt32(tbMemberID.Text);
                string password = tbPassword.Text;
                try
                {
                    Staff staff = context.Staff.Where(x => x.StaffID == id && x.Password == password).First();
                    if (staff != null)
                    {
                        SearchBookForm form = new SearchBookForm();
                        form.ShowDialog(this);
                        this.Close();
                    }

                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show("Incorect password!", "ERROR");
                }
            }
        }
    }
}
