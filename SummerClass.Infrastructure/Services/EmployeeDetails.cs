using SummerClass.Application.Common.Interface;
using SummerClass.Application.DTOs;
using SummerClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerClass.Infrastructure.Services
{
    public class EmployeeDetails : IEmployeeDetails
    {
        private readonly IApplicationDBContext _dbContext;
        public EmployeeDetails(IApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<Employee> AddEmployeeDetails(EmployeeRequestDTO employee)
        {
            var employeeDetails = new Employee()
            {
                JoinDate = employee.JoinDate,
                Designation = employee.Designation
            };
            await _dbContext.Employees.AddAsync(employeeDetails);
            await _dbContext.SaveChangesAsync(default(CancellationToken));
            return employeeDetails;
        }

        public async Task<List<Employee>> GetAllUserAsync()
        {
            var data = _dbContext.Employees.Select(e => new Employee() 
            {
                 Id = e.Id,
                 Designation = e.Designation,
                 JoinDate = e.JoinDate,
                 Created = e.Created,
                 LastModified = e.LastModified
            }).ToList();
            return data;
        }
    }
}
