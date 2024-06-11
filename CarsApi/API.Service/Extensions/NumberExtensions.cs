using API.Service.ConfigSections;

namespace API.Service.Extensions
{
    public static class NumberExtensions
    {
        public static bool IsVaidYear(this int year, int minYear) =>
            year <= DateTime.Now.Year && year >= minYear;

        public static bool IsVaidAmount(this decimal amount, AmountSection info) =>
            amount >= info.MinValue && amount <= info.MaxValue;
    }
}
