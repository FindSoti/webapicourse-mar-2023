namespace EmployeesApi.Models;


public record EmployeeSummaryResponse(int total, int fulltime, int PartTime, string DepartmentFilter);
