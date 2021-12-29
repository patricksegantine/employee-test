using Employee.Core.DTOs;
using Employee.Core.Interfaces;
using Employee.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/employees")]
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService, INotification notification) : base(notification)
        {
            _employeeService = employeeService;
        }

        [HttpGet("get-2nd-heights-employee-salary")]
        public async Task<IActionResult> Get2ndHeightsEmployeeSalary([FromQuery]GetEmployeeSalaryRequest filter)
        {
            var response = await _employeeService.Get2ndHeighEmployeeSalaryByDepartment(filter);

            if (response == null || !response.Any())
            {
                return CreateResponse(null, System.Net.HttpStatusCode.BadRequest);
            }

            return CreateResponse(response);
        }
    }
}
