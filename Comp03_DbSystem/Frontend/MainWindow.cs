using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Frontend
{
    public partial class MainWindow : Form
    {
        Api api;

        public MainWindow()
        {
            InitializeComponent();
            api = new Api("http://localhost:31415");
            UpdateSummary();
        }

        private void tvApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tvApp.SelectedIndex)
            {
                case 0: UpdateSummary();      break;
                case 1: UpdateUserList();     break;
                case 2: UpdateTasklistList(); break;
                case 3: UpdateTaskList();     break;
            }
        }

        List<Backend.User> SummaryUsers;
        List<Backend.User> Users;
        List<Backend.Tasklist> Tasklists;
        List<Backend.Task> Tasks;

        private void UpdateSummary()
        {
            cbSelectUserSummary.Items.Clear();

            //update combo box with users
            string err;
            SummaryUsers = api.GetUsers(out err);

            if (SummaryUsers == null)
                cbSelectUserSummary.Items.Add("fetch failed");
            else
                foreach (Backend.User u in SummaryUsers)
                {
                    cbSelectUserSummary.Items.Add(u.ToString());
                }
            if(cbSelectUserSummary.Items.Count == 0)
            {
                cbSelectUserSummary.Items.Add("no users found");
                return;
            }
            cbSelectUserSummary.SelectedIndex = 0; //UpdateSummaryRtb() gets called automatically through index changed event
        }

        void UpdateSummaryRtb()
        {
            rtbUserSummary.Clear();
            string err;

            if (SummaryUsers == null)
            {
                rtbUserSummary.AppendText("User fetch failed. Is the server running?");
                return;
            }

            Backend.User ParsedUser = SummaryUsers[cbSelectUserSummary.SelectedIndex];
            JObject Summary = api.GetUserSummary(ParsedUser, out err);
            if (Summary == null)
            {
                rtbUserSummary.AppendText("Summary fetch failed. Is the server running?");
                return;
            }

            rtbUserSummary.AppendText(string.Format("Showing summary for user {0}:\n\n", ParsedUser.Username));
            foreach(JObject a in Summary.GetValue("tasklists"))
            {
                rtbUserSummary.AppendText(string.Format("\tIn tasklist {0} (deadline on {1}):\n", a.GetValue("name"), Backend.Sysdata.DateFromTimestamp((int)a.GetValue("deadline")).ToString()));
                foreach (JObject b in a.GetValue("tasks"))
                    rtbUserSummary.AppendText(string.Format(
                        "\t\t{0} {1} (deadline on {2}):\n\t\t\t{3}\n\n",
                        (b.GetValue("status").ToString().Equals("1") ? "☑" : "☐"),
                        b.GetValue("name"),
                        Backend.Sysdata.DateFromTimestamp((int)b.GetValue("deadline")).ToString(),
                        b.GetValue("description")));

                rtbUserSummary.AppendText("\n");
            }
        }

        private void UpdateUserList()
        {
            string err;
            Users = api.GetUsers(out err);
            lbUsers.Items.Clear();

            if(Users == null)
                lbUsers.Items.Add("User fetch failed. Is the server running?");
            else
                foreach (Backend.User u in Users)
            {
                lbUsers.Items.Add(u.ToString());
            }

        }

        private void UpdateTasklistList()
        {
            string err;
            Tasklists = api.GetTasklists(out err);
            lbTasklists.Items.Clear();

            if (Tasklists == null)
                lbTasklists.Items.Add("Tasklist fetch failed. Is the server running?");
            else
                foreach (Backend.Tasklist u in Tasklists)
            {
                lbTasklists.Items.Add(u.ToString());
            }
        }

        private void UpdateTaskList()
        {
            string err;
            Tasks = api.GetTasks(out err);
            lbTasks.Items.Clear();

            if (Tasks == null)
                lbTasks.Items.Add("Task fetch failed. Is the server running?");
            else
                foreach (Backend.Task u in Tasks)
            {
                lbTasks.Items.Add(u.ToString());
            }
        }

        private void UpdateUser(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex < 0)
            {
                NothingSelected();
                return;
            }

            Backend.User TargetUser = Users[lbUsers.SelectedIndex];
            UserForm uf = new UserForm(TargetUser, DataAction.ReadAndModify, api);
            uf.ShowDialog();

            UpdateUserList();
        }

        private void AddUser(object sender, EventArgs e)
        {
            Backend.User TargetUser = new Backend.User();
            UserForm uf = new UserForm(TargetUser, DataAction.AddNew, api);
            uf.ShowDialog();

            UpdateUserList();
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex < 0)
            {
                NothingSelected();
                return;
            }

            Backend.User TargetUser = Users[lbUsers.SelectedIndex];
            UserForm uf = new UserForm(TargetUser, DataAction.ConfirmDelete, api);
            uf.ShowDialog();

            UpdateUserList();
        }

        private void NothingSelected() { MessageBox.Show("Nothing selected!"); }

        private void AddTasklist(object sender, EventArgs e)
        {
            Backend.Tasklist TargetTasklist = new Backend.Tasklist();
            TasklistForm tf = new TasklistForm(TargetTasklist, DataAction.AddNew, api);
            tf.ShowDialog();

            UpdateTasklistList();
        }

        private void EditTasklist(object sender, EventArgs e)
        {
            if (lbTasklists.SelectedIndex < 0)
            {
                NothingSelected();
                return;
            }

            Backend.Tasklist TargetTasklist = Tasklists[lbTasklists.SelectedIndex];
            TasklistForm tf = new TasklistForm(TargetTasklist, DataAction.ReadAndModify, api);
            tf.ShowDialog();

            UpdateTasklistList();
        }

        private void DeleteTasklist(object sender, EventArgs e)
        {
            if (lbTasklists.SelectedIndex < 0)
            {
                NothingSelected();
                return;
            }

            Backend.Tasklist TargetTasklist = Tasklists[lbTasklists.SelectedIndex];
            TasklistForm tf = new TasklistForm(TargetTasklist, DataAction.ConfirmDelete, api);
            tf.ShowDialog();

            UpdateTasklistList();
        }

        private void AddTask(object sender, EventArgs e)
        {
            Backend.Task TargetTask = new Backend.Task();
            TaskForm tf = new TaskForm(TargetTask, DataAction.AddNew, api);
            tf.ShowDialog();

            UpdateTaskList();
        }

        private void EditTask(object sender, EventArgs e)
        {
            if (lbTasks.SelectedIndex < 0)
            {
                NothingSelected();
                return;
            }

            Backend.Task TargetTask = Tasks[lbTasks.SelectedIndex];
            TaskForm tf = new TaskForm(TargetTask, DataAction.ReadAndModify, api);
            tf.ShowDialog();

            UpdateTaskList();
        }

        private void DeleteTask(object sender, EventArgs e)
        {
            if (lbTasks.SelectedIndex < 0)
            {
                NothingSelected();
                return;
            }

            Backend.Task TargetTask = Tasks[lbTasks.SelectedIndex];
            TaskForm tf = new TaskForm(TargetTask, DataAction.ConfirmDelete, api);
            tf.ShowDialog();

            UpdateTaskList();
        }

        private void cbSelectUserSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSummaryRtb();
        }
    }
}
