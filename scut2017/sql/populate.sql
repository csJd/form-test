-- pupulate departments
INSERT INTO departments VALUES (111, '内科');
INSERT INTO departments VALUES (222, '外科');
INSERT INTO departments VALUES (333, '中医科');

-- populate groups
INSERT INTO groups VALUES (11, '心内科', 111, 3, 32);
INSERT INTO groups VALUES (12, '呼吸内科', 111, 4, 45);
INSERT INTO groups VALUES (13, '中医保健科', 333, 3, 68);
INSERT INTO groups VALUES (14, '骨科', 222, 4, 28);
INSERT INTO groups VALUES (15, '心外科', 222, 4, 56);

-- pupulate patients
INSERT INTO patients VALUES ('880101', '李一', '1980-6-1', 11);
INSERT INTO patients VALUES ('880102', '王二', '1978-2-3', 15);
INSERT INTO patients VALUES ('880103', '张三', '1969-11-2', 13);
INSERT INTO patients VALUES ('880104', '刘四', '1975-7-20', 13);
INSERT INTO patients VALUES ('880105', '陈五', '1986-5-16', 14);
INSERT INTO patients VALUES ('880106', '杨六', '1998-4-23', 15);
INSERT INTO patients VALUES ('880107', '赵七', '2000-3-1', 12);
INSERT INTO patients VALUES ('880108', '周八', '1992-7-5', 11);
