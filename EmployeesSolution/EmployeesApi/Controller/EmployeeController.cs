
namespace EmployeesApi.Controller
{
    public class EmployeeController : ControllerBase
    {
        // Get Employee

        [HttpGet("/employees")]
        public async Task<ActionResult> GetAllEmployees(string dept)
        {
            var response = new EmployeeSummaryResponse(18, 10, 8, dept);
            return Ok(response);
        }
    }
}
