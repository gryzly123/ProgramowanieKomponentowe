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
    public partial class Form1 : Form
    {
        Api api;

        public Form1()
        {
            InitializeComponent();
            api = new Api("http://localhost:31415");
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

        List<Backend.User> Users;
        List<Backend.Tasklist> Tasklists;
        List<Backend.Task> Tasks;

        private void UpdateSummary()
        {
            //todo
            throw new NotImplementedException();
        }

        private void UpdateUserList()
        {
            string err;
            Users = api.GetUsers(out err);
            lbUsers.Items.Clear();

            foreach(Backend.User u in Users)
            {
                lbUsers.Items.Add(u.ToString());
            }

        }

        private void UpdateTaskList()
        {
            string err;
            Tasklists = api.GetTasklists(out err);
            lbTasklists.Items.Clear();

            foreach (Backend.Tasklist u in Tasklists)
            {
                lbTasklists.Items.Add(u.ToString());
            }
        }

        private void UpdateTasklistList()
        {
            string err;
            Tasks = api.GetTasks(out err);
            lbTasks.Items.Clear();

            foreach (Backend.Task u in Tasks)
            {
                lbTasks.Items.Add(u.ToString());
            }
        }

    }
}
