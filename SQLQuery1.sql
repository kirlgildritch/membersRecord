CREATE TABLE employees
(
		full_name VARCHAR(MAX) NOT NULL,
		Age INT NULL,
        DateOfBirth DATE NULL,
        Address VARCHAR(255) NULL,
        DateOfMembership DATE NULL,
        ShareCapital DECIMAL(10, 2) NULL,
        Attendance VARCHAR(255) NULL

);

CREATE TABLE Members(
	FullName VARCHAR(MAX) NOT NULL,
	Gender VARCHAR(10),
	Age INT,
	DateOfBirth DATE,
	Address VARCHAR(255),
	DateOfMembership DATE,
	ShareCapital DECIMAL(10,2),
	Attendance VARCHAR(255)
);

