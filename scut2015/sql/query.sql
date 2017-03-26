SELECT e.eno 员工号, ename 姓名, cname 公司名, salary 工资
 FROM employees e LEFT JOIN works w ON w.eno = e.eno LEFT JOIN companies c ON c.cno = w.cno
 ORDER BY salary DESC;

-- 统计年龄至少为 40 岁员工的总工资，工资按从大到小顺序排列
SELECT ename 员工姓名, eage 年龄, SUM(salary) 总工资
 FROM employees e, works w
 WHERE e.eno = w.eno AND eage > 39
 GROUP BY ename, eage;

-- 查询至少具有两份工作员工的姓名和其公司名
SELECT ename 员工姓名, cname 公司名
 FROM employees e, works w, companies c
 WHERE w.eno = e.eno AND c.cno = w.cno
 AND (SELECT COUNT(*) FROM works w1 WHERE w1.eno = e.eno) > 1 