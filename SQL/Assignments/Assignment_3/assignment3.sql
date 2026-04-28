-- =========================
-- SET II QUERIES
-- =========================
-- 1. List of MANAGERS
SELECT * 
FROM EM 
WHERE JOB = 'MANAGER';

-- 2. Employees earning > 1000
SELECT ENAME, SAL 
FROM EM 
WHERE SAL > 1000;

-- 3. All employees except JAMES
SELECT ENAME, SAL 
FROM EM 
WHERE ENAME <> 'JAMES';

-- 4. Names begin with 'S'
SELECT * 
FROM EM 
WHERE ENAME LIKE 'S%';

-- 5. Names having 'A' anywhere
SELECT ENAME 
FROM EM 
WHERE ENAME LIKE '%A%';

-- 6. 'L' as third character
SELECT ENAME 
FROM EM 
WHERE ENAME LIKE '__L%';

-- 7. Daily salary of JONES (assuming 30 days)
SELECT ENAME, SAL/30 AS Daily_Salary 
FROM EM 
WHERE ENAME = 'JONES';

-- 8. Total monthly salary
SELECT SUM(SAL) AS Total_Monthly_Salary 
FROM EM;

-- 9. Average annual salary
SELECT AVG(SAL * 12) AS Avg_Annual_Salary 
FROM EM;

-- 10. Exclude SALESMAN from dept 30
SELECT ENAME, JOB, SAL, DEPTNO 
FROM EM 
WHERE DEPTNO = 30 
  AND JOB <> 'SALESMAN';

-- 11. Unique departments
SELECT DISTINCT DEPTNO 
FROM EM;

-- 12. Salary >1500 and dept 10 or 30 (with alias)
SELECT ENAME AS Employee, SAL AS [Monthly Salary]
FROM EM
WHERE SAL > 1500 
  AND DEPTNO IN (10, 30);

-- 13. MANAGER/ANALYST but salary not 1000,3000,5000
SELECT ENAME, JOB, SAL
FROM EM
WHERE JOB IN ('MANAGER', 'ANALYST')
  AND SAL NOT IN (1000, 3000, 5000);

-- 14. Commission > salary + 10%
SELECT ENAME, SAL, COMM
FROM EM
WHERE COMM IS NOT NULL
  AND COMM > SAL * 1.10;

-- 15. Two Ls in name AND (dept 30 OR mgr 7782)
SELECT ENAME
FROM EM
WHERE ENAME LIKE '%L%L%'
  AND (DEPTNO = 30 OR MGR = 7782);

-- 16. Experience between 30 and 40 years + count
SELECT ENAME, 
       DATEDIFF(YEAR, HIREDATE, GETDATE()) AS Experience_Years
FROM EM
WHERE DATEDIFF(YEAR, HIREDATE, GETDATE()) BETWEEN 30 AND 40;

SELECT COUNT(*) AS Total_Employees 
FROM EM;

-- 17. Dept names ASC, employees DESC
SELECT D.DNAME, E.ENAME
FROM DPT D
JOIN EM E ON D.DEPTNO = E.DEPTNO
ORDER BY D.DNAME ASC, E.ENAME DESC;

-- 18. Experience of MILLER
SELECT ENAME,
       DATEDIFF(YEAR, HIREDATE, GETDATE()) AS Experience_Years
FROM EM
WHERE ENAME = 'MILLER';