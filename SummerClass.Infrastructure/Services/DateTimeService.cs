using SummerClass.Application.Common.Interface;

namespace SummerClass.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.UtcNow;
    }
}
