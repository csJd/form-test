-- query
SELECT dname 大科室, gname 小科室, pname 姓名
 FROM patients p, departments d, groups g
 WHERE p.gno = g.gno AND d.dno = g.dno
 ORDER BY dname DESC, gname , pname;

-- 统计每个大科室病人人数
SELECT dname 大科室名, COUNT(*) 病人人数
 FROM departments d, groups g, patients p
 WHERE p.gno = g.gno AND d.dno = g.dno
 GROUP BY dname;

-- 实现按小科室得统计月份来计算每月病人人数
SELECT gmonth 月份, COUNT(*) 病人人数
 FROM departments d, groups g, patients p 
 WHERE p.gno = g.gno AND d.dno = g.dno
 GROUP BY gmonth;