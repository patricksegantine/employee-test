using Employee.Core.DTOs;
using Employee.Core.Interfaces;
using Employee.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Entities.Employee> _repo;
        private readonly INotification _notification;

        public EmployeeService(IRepository<Entities.Employee> repo, INotification notification)
        {
            _repo = repo;
            _notification = notification;
        }

        public async Task<IEnumerable<GetEmployeeSalaryResponse>> Get2ndHeighEmployeeSalaryByDepartment(GetEmployeeSalaryRequest filter)
        {
            IEnumerable<Entities.Employee> employees;

            if (!string.IsNullOrWhiteSpace(filter?.DepartmentName))
                employees = await _repo.GetAll(s => s.DepartmentName.Equals(filter.DepartmentName, System.StringComparison.InvariantCultureIgnoreCase));
            else
                employees = await _repo.GetAll(null);

            if (employees == null || !employees.Any())
            {
                _notification.AddNotification("No data found");
                return default;
            }

            var groupedData = employees
                .GroupBy(g => g.DepartmentName,
                (key, g) => new
                {
                    Department = key,
                    Employee = g.OrderByDescending(p => p.Salary).Take(2).Last()
                }).ToList();

            var result = new List<GetEmployeeSalaryResponse>();
            foreach (var item in groupedData)
            {
                result.Add(new GetEmployeeSalaryResponse
                {
                    DepartmentName = item.Department,
                    EmployeeName = item.Employee.GetFullName(),
                    Salary = item.Employee.Salary
                });
            }

            return result;
        }
    }
}
