namespace Frontend
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvApp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddTasklist = new System.Windows.Forms.Button();
            this.btnEditTasklist = new System.Windows.Forms.Button();
            this.btnDeleteTasklist = new System.Windows.Forms.Button();
            this.lbTasklists = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.tvApp.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvApp
            // 
            this.tvApp.Controls.Add(this.tabPage1);
            this.tvApp.Controls.Add(this.tabPage2);
            this.tvApp.Controls.Add(this.tabPage3);
            this.tvApp.Controls.Add(this.tabPage4);
            this.tvApp.Location = new System.Drawing.Point(12, 12);
            this.tvApp.Name = "tvApp";
            this.tvApp.SelectedIndex = 0;
            this.tvApp.Size = new System.Drawing.Size(609, 426);
            this.tvApp.TabIndex = 0;
            this.tvApp.SelectedIndexChanged += new System.EventHandler(this.tvApp_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddUser);
            this.tabPage2.Controls.Add(this.btnEditUser);
            this.tabPage2.Controls.Add(this.btnDeleteUser);
            this.tabPage2.Controls.Add(this.lbUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(358, 367);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Create";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.AddUser);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(439, 367);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 23);
            this.btnEditUser.TabIndex = 3;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.UpdateUser);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(520, 367);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.DeleteUser);
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.Location = new System.Drawing.Point(6, 6);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(589, 355);
            this.lbUsers.TabIndex = 0;
            this.lbUsers.DoubleClick += new System.EventHandler(this.UpdateUser);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddTasklist);
            this.tabPage3.Controls.Add(this.btnEditTasklist);
            this.tabPage3.Controls.Add(this.btnDeleteTasklist);
            this.tabPage3.Controls.Add(this.lbTasklists);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(601, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tasklists";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddTasklist
            // 
            this.btnAddTasklist.Location = new System.Drawing.Point(358, 367);
            this.btnAddTasklist.Name = "btnAddTasklist";
            this.btnAddTasklist.Size = new System.Drawing.Size(75, 23);
            this.btnAddTasklist.TabIndex = 8;
            this.btnAddTasklist.Text = "Create";
            this.btnAddTasklist.UseVisualStyleBackColor = true;
            this.btnAddTasklist.Click += new System.EventHandler(this.AddTasklist);
            // 
            // btnEditTasklist
            // 
            this.btnEditTasklist.Location = new System.Drawing.Point(439, 367);
            this.btnEditTasklist.Name = "btnEditTasklist";
            this.btnEditTasklist.Size = new System.Drawing.Size(75, 23);
            this.btnEditTasklist.TabIndex = 7;
            this.btnEditTasklist.Text = "Edit";
            this.btnEditTasklist.UseVisualStyleBackColor = true;
            this.btnEditTasklist.Click += new System.EventHandler(this.EditTasklist);
            // 
            // btnDeleteTasklist
            // 
            this.btnDeleteTasklist.Location = new System.Drawing.Point(520, 367);
            this.btnDeleteTasklist.Name = "btnDeleteTasklist";
            this.btnDeleteTasklist.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTasklist.TabIndex = 6;
            this.btnDeleteTasklist.Text = "Delete";
            this.btnDeleteTasklist.UseVisualStyleBackColor = true;
            this.btnDeleteTasklist.Click += new System.EventHandler(this.DeleteTasklist);
            // 
            // lbTasklists
            // 
            this.lbTasklists.FormattingEnabled = true;
            this.lbTasklists.Location = new System.Drawing.Point(6, 6);
            this.lbTasklists.Name = "lbTasklists";
            this.lbTasklists.Size = new System.Drawing.Size(589, 355);
            this.lbTasklists.TabIndex = 5;
            this.lbTasklists.DoubleClick += new System.EventHandler(this.EditTasklist);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCreateTask);
            this.tabPage4.Controls.Add(this.btnEditTask);
            this.tabPage4.Controls.Add(this.btnDeleteTask);
            this.tabPage4.Controls.Add(this.lbTasks);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(601, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tasks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(358, 367);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTask.TabIndex = 12;
            this.btnCreateTask.Text = "Create";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.AddTask);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(439, 367);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(75, 23);
            this.btnEditTask.TabIndex = 11;
            this.btnEditTask.Text = "Edit";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.EditTask);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(520, 367);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 10;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.DeleteTask);
            // 
            // lbTasks
            // 
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.Location = new System.Drawing.Point(6, 6);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(589, 355);
            this.lbTasks.TabIndex = 9;
            this.lbTasks.DoubleClick += new System.EventHandler(this.EditTask);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.tvApp);
            this.Name = "Form1";
            this.Text = "Networked Tasklist (K. Niedzwiecki)";
            this.tvApp.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tvApp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddTasklist;
        private System.Windows.Forms.Button btnEditTasklist;
        private System.Windows.Forms.Button btnDeleteTasklist;
        private System.Windows.Forms.ListBox lbTasklists;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.ListBox lbTasks;
    }
}

