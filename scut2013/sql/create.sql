--CREATE DATABASE scut2013;
USE scut2013;

CREATE TABLE teachers
(
	tno VARCHAR(5),
	tname VARCHAR(10),
	tsex CHAR(2),
	PRIMARY KEY (tno)
);

CREATE TABLE courses
(
	cno VARCHAR(5),
	cname VARCHAR(20),
	ctime INT,
	PRIMARY KEY (cno)
);

CREATE TABLE works
(
	tno VARCHAR(5),
	cno VARCHAR(5),
	wyear INT,
	wxq CHAR(2),
	PRIMARY KEY (tno, cno),
	FOREIGN KEY (tno) REFERENCES teachers(tno),
	FOREIGN KEY (cno) REFERENCES courses(cno)
);
