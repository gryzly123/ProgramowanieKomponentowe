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
    public partial class TaskForm : Form
    {
        DataForm df;
        Backend.Task Task;
        Api a;

        List<Backend.User> Users;
        List<Backend.Tasklist> Tasklists;

        private bool FillAndDefaultComboBoxes()
        {
            string err;
            Users     = a.GetUsers(out err);
            Tasklists = a.GetTasklists(out err);

            if(Users == null || Tasklists == null)
            {
                MessageBox.Show("Could not fetch users and tasklists required for this window. Closing...");
                Close();
                return false;
            }

            long defUser = 0, defTask = 0;

            for (int i = 0; i < Users.Count; ++i)
            {
                Backend.User u = Users[i];
                cbAssignee.Items.Add(string.Format("{0} ({1})", u.Username, u.Id));
                if (u.Id == Task.Assignee_User) defUser = i;
            }
            for (int i = 0; i < Tasklists.Count; ++i)
            {
                Backend.Tasklist t = Tasklists[i];
                cbTasklist.Items.Add(string.Format("{0} ({1})", t.Name, t.Id));
                if (t.Id == Task.Assignee_User) defTask = i;
            }

            cbAssignee.SelectedIndex = (int)defUser;
            cbTasklist.SelectedIndex = (int)defTask;
            return true;
        }

        public TaskForm(Backend.Task _Task, DataAction DA, Api _a)
        {
            InitializeComponent();
            df = new DataForm(DA);
            Task = _Task;
            a = _a;
            lWarning.Visible = !df.FieldAccess;

            if (!FillAndDefaultComboBoxes()) return;

            tbId.Text = Task.Id.ToString();

            tbName.Text = Task.Name;
            tbDeadline.Text = Backend.Sysdata.DateFromTimestamp(Task.Deadline).ToString();
            tbDescription.Text = Task.Description;
            cbStatus.Checked = (Task.Status == 1);

            tbName.Enabled        = df.FieldAccess;
            tbDeadline.Enabled    = df.FieldAccess;
            tbDescription.Enabled = df.FieldAccess;
            cbStatus.Enabled      = df.FieldAccess;
            cbTasklist.Enabled    = df.FieldAccess;
            cbAssignee.Enabled    = df.FieldAccess;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (df.FieldAccess)
            {
                try
                {
                    Task.Name = tbName.Text;
                    Task.Deadline = Backend.Sysdata.TimpestampFromDate(DateTime.Parse(tbDeadline.Text));
                    Task.Description = tbDescription.Text;
                    Task.Status = cbStatus.Checked ? 1 : 0;
                    Task.Owner_Tasklist = Tasklists[cbTasklist.SelectedIndex].Id;
                    Task.Assignee_User = Users[cbAssignee.SelectedIndex].Id;

                }
                catch (Exception)
                {
                    MessageBox.Show("Data error: invalid deadline date format");
                    return;
                }
            }

            string Error;
            switch(df.da)
            {
                case DataAction.AddNew:
                    if (a.AddTask(Task, out Error)) Close();
                    else
                        MessageBox.Show("Error updating task: " + Error);
                    break;

                case DataAction.ConfirmDelete:
                    if (a.DeleteTask(Task, out Error)) Close();
                    else
                        MessageBox.Show("Error deleting task: " + Error);
                    break;

                case DataAction.ReadAndModify:
                    if (a.UpdateTask(Task, out Error)) Close();
                    else
                        MessageBox.Show("Error updating task: " + Error);
                    break;

            }
        }
    }
}
