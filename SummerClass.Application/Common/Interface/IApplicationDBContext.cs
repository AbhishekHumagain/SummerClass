using Microsoft.EntityFrameworkCore;
using SummerClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerClass.Application.Common.Interface
{
    public interface IApplicationDBContext
    {
        DbSet<Employee> Employee { get; set; }
        DbSet<Department> Department { get; set; }
        DbSet<SalaryOrBonus> SalaryOrBonus { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
