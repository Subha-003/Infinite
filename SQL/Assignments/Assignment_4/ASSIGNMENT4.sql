--FACTORIAL-------------------------ASSIGNMENT 3(1 ST QUESTION)


DECLARE @num INT = 5;
DECLARE @i INT = 1;
DECLARE @fact BIGINT = 1;

WHILE @i <= @num
BEGIN
    SET @fact = @fact * @i;
    SET @i = @i + 1;
END

PRINT 'Factorial = ' + CAST(@fact AS VARCHAR);
--PROCEDURE------------------------ASSIGNMENT 3( 2 ND QUESTION)


GO
CREATE OR ALTER PROCEDURE sp_MultiplicationTable
    @num INT,
    @limit INT
AS
BEGIN
    DECLARE @i INT = 1;

    WHILE @i <= @limit
    BEGIN
        PRINT CAST(@num AS VARCHAR) + ' x ' + 
              CAST(@i AS VARCHAR) + ' = ' + 
              CAST(@num * @i AS VARCHAR);

        SET @i = @i + 1;
    END
END;
GO
EXEC sp_MultiplicationTable 5, 10;

--STUDENT TABLE------------------------ASSIGNMENT 3(3 RD QUESTION)

CREATE TABLE Student (
    Sid INT PRIMARY KEY,
    Sname VARCHAR(50)
);




CREATE TABLE Marks (
    Mid INT PRIMARY KEY,
    Sid INT,
    Score INT,
    FOREIGN KEY (Sid) REFERENCES Student(Sid)
);

-- =========================
-- INSERT DATA
-- =========================
INSERT INTO Student VALUES
(1,'Jack'),
(2,'Rithvik'),
(3,'Jaspreeth'),
(4,'Praveen'),
(5,'Bisa'),
(6,'Suraj');

INSERT INTO Marks VALUES
(1,1,23),
(2,6,95),
(3,4,98),
(4,2,17),
(5,3,53),
(6,5,13);

-- =========================
-- FUNCTION
-- =========================
GO
CREATE OR ALTER FUNCTION fn_ResultStatus (@score INT)
RETURNS VARCHAR(10)
AS
BEGIN
    RETURN (
        CASE 
            WHEN @score >= 50 THEN 'PASS'
            ELSE 'FAIL'
        END
    );
END;
GO

SELECT 
    S.Sid,
    S.Sname,
    M.Score,
    dbo.fn_ResultStatus(M.Score) AS Status
FROM Student S
JOIN Marks M ON S.Sid = M.Sid
ORDER BY S.Sid;
