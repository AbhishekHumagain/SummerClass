using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SummerClass.Application.Common.Interface;
using SummerClass.Application.DTOs;
using SummerClass.Domain.Entities;

namespace SummerClass.Controllers
{
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeDetails _employeeDetails;

        public EmployeeController(IEmployeeDetails employeeDetails)
        {
            _employeeDetails = employeeDetails;
        }

        [HttpGet]
        [Route("/api/employee/all-employee")]
        public async Task<List<Employee>> GetAllEmployeeDetails()
        {
            var data =  await _employeeDetails.GetAllUserAsync();
            return data;
        }

        [HttpPost]
        [Route("/api/employee/add-employee")]
        public async Task<Employee> AddEmployeeDetails(EmployeeRequestDTO employee)
        {
            var data = await _employeeDetails.AddEmployeeDetails(employee);
            return data;
        }
    }
}
