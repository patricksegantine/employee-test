using Employee.Core.Contracts;
using Employee.Core.DTOs;
using Employee.Core.Services;
using Employee.Repo.Contracts;
using FluentAssertions;
using Moq;
using Moq.AutoMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Employee.Tests.UnitTests
{
    public class EmployeeServiceTests
    {
        private readonly AutoMocker _mocker;
        private readonly EmployeeService _employeeServiceMock;

        public EmployeeServiceTests()
        {
            _mocker = new AutoMocker();
            _employeeServiceMock = _mocker.CreateInstance<EmployeeService>();
        }

        [Fact]
        public async Task WhenDepartmentNameIsNullShouldReturnAllDepartmentsWithEmployeeSalary()
        {
            _mocker.GetMock<INotification>()
                .Setup(s => s.AddNotification(It.IsAny<string>()))
                .Verifiable();

            _mocker.GetMock<IRepository<Entity.Models.Employee>>()
                .Setup(s => s.GetAll(It.IsAny<Func<Entity.Models.Employee, bool>>()))
                .ReturnsAsync(() => Mock.EmployeeMock.GetFakeData());

            var expected = Mock.EmployeeMock.GetAll2ndHeighEmployeeSalaryByDepartment();

            var result = await _employeeServiceMock.Get2ndHeighEmployeeSalaryByDepartment(null);

            _mocker.GetMock<INotification>().Verify(s => s.AddNotification(It.IsAny<string>()), Times.Never);
            result.Should()
                .HaveCount(expected.Count())
                .And.Equal(expected, (e1, e2) => e1.DepartmentName == e2.DepartmentName && e1.EmployeeName == e2.EmployeeName && e1.Salary == e2.Salary);
        }

        [Fact]
        public async Task WhenDepartmentNameIsFilledShouldReturnEmployeeSalaryFromDepartmentOnly()
        {
            const string departmentName = "TI";
            
            _mocker.GetMock<INotification>()
                .Setup(s => s.AddNotification(It.IsAny<string>()))
                .Verifiable();

            _mocker.GetMock<IRepository<Entity.Models.Employee>>()
                .Setup(s => s.GetAll(It.IsAny<Func<Entity.Models.Employee, bool>>()))
                .ReturnsAsync(() => Mock.EmployeeMock.GetFakeData().Where(d => d.DepartmentName == departmentName));

            var expected = Mock.EmployeeMock.Get2ndHeighEmployeeSalaryFromTIOnly();

            var result = await _employeeServiceMock.Get2ndHeighEmployeeSalaryByDepartment(new GetEmployeeSalaryRequest { DepartmentName = departmentName });

            _mocker.GetMock<INotification>().Verify(s => s.AddNotification(It.IsAny<string>()), Times.Never);
            result.Should()
                .HaveCount(1)
                .And.Equal(expected, (e1, e2) => e1.DepartmentName == e2.DepartmentName && e1.EmployeeName == e2.EmployeeName && e1.Salary == e2.Salary);
        }

        [Fact]
        public async Task WhenNoDataIsFoundNotShouldThrowsException()
        {
            const string departmentName = "Accounting";

            _mocker.GetMock<INotification>()
                .Setup(s => s.AddNotification(It.IsAny<string>()))
                .Verifiable();

            _mocker.GetMock<IRepository<Entity.Models.Employee>>()
                .Setup(s => s.GetAll(It.IsAny<Func<Entity.Models.Employee, bool>>()))
                .ReturnsAsync(() => null);

            Func<Task<IEnumerable<GetEmployeeSalaryResponse>>> func = async () => await _employeeServiceMock.Get2ndHeighEmployeeSalaryByDepartment(new GetEmployeeSalaryRequest { DepartmentName = departmentName });
            
            _ = func.Should().NotThrowAsync();
            _mocker.GetMock<INotification>().Verify(s => s.AddNotification(It.IsAny<string>()), Times.Once);
            Assert.True(true);
        }
    }
}
