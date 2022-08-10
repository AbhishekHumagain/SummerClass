using SummerClass.Application.DTOs;
using SummerClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerClass.Application.Common.Interface
{
    public interface IEmployeeDetails
    {
        Task<List<Employee>> GetAllUserAsync();
        Task<Employee> AddEmployeeDetails(EmployeeRequestDTO employee);
    }
}
