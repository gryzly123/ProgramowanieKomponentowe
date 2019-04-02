CREATE TABLE Users
(
	id INTEGER PRIMARY KEY NOT NULL,
	username TEXT NOT NULL
);

CREATE TABLE Tasklists
(
id INTEGER  PRIMARY KEY NOT NULL,
name TEXT NOT NULL,
deadline INTEGER NOT NULL DEFAULT CURRENT_TIMESTAMP
);


CREATE TABLE Tasks
(
id INTEGER PRIMARY KEY NOT NULL,
name TEXT NOT NULL,
description TEXT NOT NULL,
deadline INTEGER NOT NULL DEFAULT CURRENT_TIMESTAMP,
status INTEGER NOT NULL DEFAULT 0,
owner_tasklist INTEGER NOT NULL,
assignee_user INTEGER NOT NULL,
FOREIGN KEY(owner_tasklist) REFERENCES Tasklists(id),
FOREIGN KEY(owner_tasklist) REFERENCES Users(id)
);

INSERT INTO Users (username) VALUES
	('uzytkownik 1'),
	('superuzytkownik')
;

INSERT INTO Tasklists (name, deadline) VALUES
	('First tasklist', CURRENT_TIMESTAMP),
	('Production tasklist', CURRENT_TIMESTAMP)
;

INSERT INTO Tasks (name, description, deadline, status, owner_tasklist, assignee_user) VALUES
	('Research platform', 'Check this new tasklist software and learn its features', CURRENT_TIMESTAMP, 1, '1', '1'),
	('Create user accounts', 'Not all users have accounts on the platform yet. Create the accounts and notify coworkers', CURRENT_TIMESTAMP, 0, '1', '2'),
	('Run unit tests', 'Run the tests for final deploy', CURRENT_TIMESTAMP, 0, '2', '1'),
	('Prepare for deployment', 'Deploy to production should happen as soon as the tests are complete', CURRENT_TIMESTAMP, 0, '2', '2')
;

--superusers' tasks:
--SELECT Tasks.name, Tasks.status FROM Tasks INNER JOIN Users ON Users.id=Tasks.assignee_user WHERE Users.id=2
