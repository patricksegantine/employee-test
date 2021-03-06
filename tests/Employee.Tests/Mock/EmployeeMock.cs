using Employee.Core.DTOs;
using System;
using System.Collections.Generic;

namespace Employee.Tests.Mock
{
    public class EmployeeMock
    {
        internal static IEnumerable<Entity.Models.Employee> GetFakeData()
        {
            var result = new List<Entity.Models.Employee>()
            {
                new Entity.Models.Employee {Id = 666, GivenName = "Cleo", Surname = "Skinn", DepartmentName = "HR", Salary = 4195 },
                new Entity.Models.Employee {Id = 17, GivenName = "Thatch", Surname = "Loraine", DepartmentName = "HR", Salary = 4278 },
                new Entity.Models.Employee {Id = 386, GivenName = "Frieda", Surname = "Smallbone", DepartmentName = "HR", Salary = 4069 },
                new Entity.Models.Employee {Id = 919, GivenName = "Dun", Surname = "Auchinleck", DepartmentName = "HR", Salary = 3966 },
                new Entity.Models.Employee {Id = 456, GivenName = "Law", Surname = "Shorto", DepartmentName = "HR", Salary = 3841 },
                new Entity.Models.Employee {Id = 930, GivenName = "Joli", Surname = "Arnholtz", DepartmentName = "TI", Salary = 3493 },
                new Entity.Models.Employee {Id = 120, GivenName = "Jordan", Surname = "Finlan", DepartmentName = "TI", Salary = 3591 },
                new Entity.Models.Employee {Id = 581, GivenName = "Colly", Surname = "Derl", DepartmentName = "TI", Salary = 3387 },
                new Entity.Models.Employee {Id = 936, GivenName = "Margarita", Surname = "Gowen", DepartmentName = "TI", Salary = 3469 },
                new Entity.Models.Employee {Id = 816, GivenName = "Clarissa", Surname = "Gregolin", DepartmentName = "Marketing", Salary = 3361 },
                new Entity.Models.Employee {Id = 66, GivenName = "Genevra", Surname = "Morman", DepartmentName = "Marketing", Salary = 3447 },
                new Entity.Models.Employee {Id = 794, GivenName = "Matias", Surname = "MacPhail", DepartmentName = "Marketing", Salary = 3422 },
                new Entity.Models.Employee {Id = 708, GivenName = "Sergei", Surname = "Sandwich", DepartmentName = "Sales", Salary = 3491 },
                new Entity.Models.Employee {Id = 83, GivenName = "Nicholle", Surname = "Risborough", DepartmentName = "Sales", Salary = 3575 },
                new Entity.Models.Employee {Id = 199, GivenName = "Dolorita", Surname = "Sheeran", DepartmentName = "Sales", Salary = 3363 },
                new Entity.Models.Employee {Id = 741, GivenName = "Thomasin", Surname = "Coverley", DepartmentName = "Sales", Salary = 3659 },
            };

            return result;
        }

        internal static IEnumerable<GetEmployeeSalaryResponse> GetAll2ndHeighEmployeeSalaryByDepartment()
        {
            var result = new List<GetEmployeeSalaryResponse>
            {
                new GetEmployeeSalaryResponse { DepartmentName = "HR", EmployeeName = "Cleo Skinn", Salary = 4195 },
                new GetEmployeeSalaryResponse { DepartmentName = "TI", EmployeeName = "Joli Arnholtz", Salary = 3493 },
                new GetEmployeeSalaryResponse { DepartmentName = "Marketing", EmployeeName = "Matias MacPhail", Salary = 3422 },
                new GetEmployeeSalaryResponse { DepartmentName = "Sales", EmployeeName = "Nicholle Risborough", Salary = 3575 },
            };

            return result;
        }

        internal static IEnumerable<GetEmployeeSalaryResponse> Get2ndHeighEmployeeSalaryFromTIOnly()
        {
            var result = new List<GetEmployeeSalaryResponse>
            {
                new GetEmployeeSalaryResponse { DepartmentName = "TI", EmployeeName = "Joli Arnholtz", Salary = 3493 },
            };

            return result;
        }
    }
}
