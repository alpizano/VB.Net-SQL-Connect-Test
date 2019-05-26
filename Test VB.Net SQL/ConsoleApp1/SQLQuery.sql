CREATE TABLE Policy (
UniqID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
UniqPolicy int NOT NULL,
UniqEntity int NOT NULL,
Name varchar(20)
);