-- 统计只上一门课的教师，要求输出该教师的教师名以及该课程的信息
SELECT tname 教师姓名, cname 课程名, ctime 课程时间
 FROM teachers t, courses c
 WHERE t.tno = c.tno AND (SELECT COUNT(*) FROM courses c1
						  WHERE c1.tno = t.tno) < 2;

-- 统计每个教师的总薪酬，要求输出每个教师的教师名、总薪酬并按总薪酬高低排序
SELECT tname 教师姓名, SUM(rwage * ctime) 总薪酬
 FROM teachers t JOIN courses c ON t.tno = c.tno JOIN remunerations r ON t.rno = r.rno
 GROUP BY tname
 ORDER BY SUM(rwage * ctime) DESC;

SELECT tname 教师姓名, SUM(rwage * ctime) 总薪酬
 FROM teachers t, courses c, remunerations r
 WHERE t.rno = r.rno AND c.tno = t.tno
 GROUP BY tname
 ORDER BY SUM(rwage * ctime) DESC; 

--SELECT * FROM teachers t, courses c, remunerations r
-- WHERE t.rno = r.rno AND c.tno = t.tno
-- ORDER BY t.tno;