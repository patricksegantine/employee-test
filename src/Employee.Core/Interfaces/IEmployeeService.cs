using Employee.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.Core.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<GetEmployeeSalaryResponse>> Get2ndHeighEmployeeSalaryByDepartment(GetEmployeeSalaryRequest filter);
    }
}
