CREATE PROCEDURE sp_GetEmployeeCountByDepartment
@DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS EmployeeCount
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;



EXEC sp_GetEmployeeCountByDepartment @DepartmentID = 1; 