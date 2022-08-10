using SummerClass.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerClass.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public int Id { get; set; }
        public DateTime JoinDate { get; set; }
        public string Designation { get; set; }
    }
}
