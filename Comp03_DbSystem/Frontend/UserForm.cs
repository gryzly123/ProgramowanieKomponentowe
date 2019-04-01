using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class UserForm : Form
    {
        DataForm df;
        Backend.User User;
        Api a;

        public UserForm(Backend.User _User, DataAction DA, Api _a)
        {
            InitializeComponent();
            df = new DataForm(DA);
            User = _User;
            a = _a;
            lWarning.Visible = !df.FieldAccess;

            tbId.Text = User.Id.ToString();

            tbUsername.Text = User.Username;
            tbUsername.Enabled = df.FieldAccess;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            User.Username = tbUsername.Text;

            string Error;
            switch(df.da)
            {
                case DataAction.AddNew:
                    if (a.AddUser(User, out Error)) Close();
                    else
                        MessageBox.Show("Error updating user: " + Error);
                    break;

                case DataAction.ConfirmDelete:
                    if (a.DeleteUser(User, out Error)) Close();
                    else
                        MessageBox.Show("Error deleting user: " + Error);
                    break;

                case DataAction.ReadAndModify:
                    if (a.UpdateUser(User, out Error)) Close();
                    else
                        MessageBox.Show("Error updating user: " + Error);
                    break;

            }
        }
    }
}
