CREATE TABLE departments
(
	dno INT,
	dname VARCHAR(20),
	PRIMARY KEY (dno)
);

CREATE TABLE groups
(
	gno INT,
	gname VARCHAR(20),
	dno INT,
	gmonth INT,
	gnum INT CHECK (gnum < 81), -- 小科室人数不超过80
	PRIMARY KEY (gno),
	FOREIGN KEY (dno) REFERENCES departments(dno)
	  ON DELETE CASCADE ON UPDATE CASCADE -- 级联删除
);

CREATE TABLE patients 
(
	pid CHAR(10),
	pname VARCHAR(20) NOT NULL,
	pdate DATE,
	gno INT,
	PRIMARY KEY (pid),
	FOREIGN KEY (gno) REFERENCES groups(gno)
	  ON DELETE CASCADE ON UPDATE CASCADE
);