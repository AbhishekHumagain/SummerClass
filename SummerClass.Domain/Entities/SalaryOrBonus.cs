using SummerClass.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerClass.Domain.Entities
{
    public class SalaryOrBonus : BaseEntity
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public bool IsAnual { get; set; }
    }
}
