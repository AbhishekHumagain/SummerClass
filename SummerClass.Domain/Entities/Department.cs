using SummerClass.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerClass.Domain.Entities
{
    public class Department : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
