namespace API.Service.Extensions
{
    public static class StringExtensions
    {
        public static bool IsValidStatus(this string status) => 
            !string.IsNullOrEmpty(status.Trim());

    }
}
