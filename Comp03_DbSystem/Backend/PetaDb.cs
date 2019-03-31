﻿using System;
using System.Data.Common;
using System.IO;

namespace Backend
{
    [PetaPoco.TableName("Users")]
    [PetaPoco.PrimaryKey("id")]
    public partial class User
    {
        [PetaPoco.Column("id")] public Int64 Id { get; set; }
        [PetaPoco.Column("username")] public String Username{ get; set; }

        public static string sqlGet(Int64 id) => string.Format("SELECT * FROM Users WHERE id='{0}'", id);
        public static string sqlGetAll()      => string.Format("SELECT * FROM Users");
    }

    [PetaPoco.TableName("Tasklists")]
    [PetaPoco.PrimaryKey("id")]
    public partial class Tasklist
    {
        [PetaPoco.Column("id")] public Int64 Id { get; set; }
        [PetaPoco.Column("name")] public String Name { get; set; }
        [PetaPoco.Column("deadline")] public Int32 Deadline { get; set; }

        public static string sqlGet(Int64 id) => string.Format("SELECT * FROM Tasklists WHERE id='{0}'", id);
        public static string sqlGetAll() => string.Format("SELECT * FROM Tasklists");
    }

    [PetaPoco.TableName("Tasks")]
    [PetaPoco.PrimaryKey("id")]
    public partial class Task
    {
        [PetaPoco.Column("id")] public Int64 Id { get; set; }
        [PetaPoco.Column("name")] public String Name { get; set; }
        [PetaPoco.Column("description")] public String Description { get; set; }
        [PetaPoco.Column("deadline")] public Int32 Deadline { get; set; }
        [PetaPoco.Column("status")] public Int32 Status { get; set; }
        [PetaPoco.Column("owner_tasklist")] public Int64 Owner_Tasklist { get; set; }
        [PetaPoco.Column("assignee_user")] public Int64 Assignee_User { get; set; }

        public static string sqlGet(Int64 id) => string.Format("SELECT * FROM Tasks WHERE id='{0}'", id);
        public static string sqlGetAll() => string.Format("SELECT * FROM Tasks");
    }

    //helper class for checking if user table exists before initializing db
    public partial class Table
    {
        [PetaPoco.Column("name")] public String Name { get; set; }
    }

    public static class Sysdata
    {
        private static PetaPoco.Database db = null;

        public static PetaPoco.Database Get()
        {
            if (db != null) return db;

            string Filename = "tasklist.db";

            db = new PetaPoco.Database(
                String.Format("Data Source={0}", Filename),
                new System.Data.SQLite.SQLiteFactory());

            InitializeDb();

            return db;
        }

        private static void InitializeDb()
        {
            foreach(Table t in db.Query<Table>("SELECT name FROM sqlite_master WHERE type='table' AND name='Users'"))
            {
                //we went inside the loop, meaning that the table exists
                return;
            }

            String sql = @"CREATE TABLE Users
                           (
                               id INTEGER PRIMARY KEY NOT NULL,
                               username TEXT NOT NULL
                           );
                           CREATE TABLE Tasklists
                           (
                               id INTEGER  PRIMARY KEY NOT NULL,
                               name TEXT NOT NULL,
                               deadline INTEGER NOT NULL DEFAULT (strftime('%s', 'now'))
                           );
                           CREATE TABLE Tasks
                           (
                               id INTEGER PRIMARY KEY NOT NULL,
                               name TEXT NOT NULL,
                               description TEXT NOT NULL,
                               deadline INTEGER NOT NULL DEFAULT (strftime('%s', 'now')),
                               status INTEGER NOT NULL DEFAULT 0,
                               owner_tasklist INTEGER NOT NULL,
                               assignee_user INTEGER NOT NULL,
                               FOREIGN KEY(owner_tasklist) REFERENCES Tasklists(id),
                               FOREIGN KEY(owner_tasklist) REFERENCES Users(id)
                           );";

            #if DEBUG
            sql += @"INSERT INTO Users (username) VALUES
                        ('uzytkownik 1'),
                        ('superuzytkownik')
                    ;
                    
                    INSERT INTO Tasklists(name, deadline) VALUES
                        ('First tasklist', (strftime('%s', 'now'))),
                        ('Production tasklist', (strftime('%s', 'now')))
                    ;
                    
                    INSERT INTO Tasks(name, description, deadline, status, owner_tasklist, assignee_user) VALUES
                        ('Research platform', 'Check this new tasklist software and learn its features', (strftime('%s', 'now')), 1, '1', '1'),
                        ('Create user accounts', 'Not all users have accounts on the platform yet. Create the accounts and notify coworkers', (strftime('%s', 'now')), 0, '1', '2'),
                        ('Run unit tests', 'Run the tests for final deploy', (strftime('%s', 'now')), 0, '2', '1'),
                        ('Prepare for deployment', 'Deploy to production should happen as soon as the tests are complete', (strftime('%s', 'now')), 0, '2', '2')
                    ; ";
            #endif

            db.Execute(sql);

        }
    }
}
