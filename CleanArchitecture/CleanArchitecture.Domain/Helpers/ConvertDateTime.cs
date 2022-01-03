using System;

namespace CleanArchitecture.Domain.Helpers
{
    public class ConvertDateTime
    {
        public static DateTime? ConvertToDateTime(int? unixTimeStamp)
        {
            if (!unixTimeStamp.HasValue) return null;

            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp.Value).ToLocalTime();
            return dtDateTime;
        }

        public static int? ConvertToUnixTimeStamp(DateTime? dateTime)
        {
            if (!dateTime.HasValue) return null;

            var date = DateTime.SpecifyKind(dateTime.Value, DateTimeKind.Unspecified);
            var dateTimeOffset = new DateTimeOffset(date);
            return (int)dateTimeOffset.ToLocalTime().ToUnixTimeSeconds();
        }
    }
}
