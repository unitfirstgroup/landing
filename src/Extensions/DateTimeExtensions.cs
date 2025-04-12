namespace UnitFirst.Landing.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToDateTimeString(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy HH:mm:ss.fff");
        }
    }
}
