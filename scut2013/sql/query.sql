SELECT tname AS 教师姓名, cname 课程名 FROM teachers t, courses c, works w
 WHERE w.tno = t.tno AND w.cno = c.cno 
 AND 1 < (SELECT COUNT(*) FROM works w2 WHERE w2.tno = t.tno);