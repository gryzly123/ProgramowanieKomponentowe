using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class TasklistForm : Form
    {
        DataForm df;
        Backend.Tasklist Tasklist;
        Api a;

        public TasklistForm(Backend.Tasklist _Tasklist, DataAction DA, Api _a)
        {
            InitializeComponent();
            df = new DataForm(DA);
            Tasklist = _Tasklist;
            a = _a;
            lWarning.Visible = !df.FieldAccess;

            tbId.Text = Tasklist.Id.ToString();

            tbName.Text = Tasklist.Name;
            tbName.Enabled = df.FieldAccess;

            tbDeadline.Text = Backend.Sysdata.DateFromTimestamp(Tasklist.Deadline).ToString();
            tbDeadline.Enabled = df.FieldAccess;
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
                    Tasklist.Name = tbName.Text;
                    Tasklist.Deadline = Backend.Sysdata.TimpestampFromDate(DateTime.Parse(tbDeadline.Text));
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
                    if (a.AddTasklist(Tasklist, out Error)) Close();
                    else
                        MessageBox.Show("Error updating tasklist: " + Error);
                    break;

                case DataAction.ConfirmDelete:
                    if (a.DeleteTasklist(Tasklist, out Error)) Close();
                    else
                        MessageBox.Show("Error deleting tasklist: " + Error);
                    break;

                case DataAction.ReadAndModify:
                    if (a.UpdateTasklist(Tasklist, out Error)) Close();
                    else
                        MessageBox.Show("Error updating tasklist: " + Error);
                    break;

            }
        }
    }
}
