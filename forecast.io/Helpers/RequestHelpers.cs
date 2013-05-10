using System;
using System.Linq;

namespace ForecastIO
{
    public static class RequestHelpers
    {
        static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        static readonly double MaxUnixSeconds = (DateTime.MaxValue - UnixEpoch).TotalSeconds;

        public static DateTime UnixTimeStampToDateTime(this long unixTimeStamp)
        {
            return unixTimeStamp > MaxUnixSeconds
                ? UnixEpoch.AddMilliseconds((unixTimeStamp))
                : UnixEpoch.AddSeconds(unixTimeStamp);
        }

        public static string FormatResponse(string _input)
        {
            _input = _input.Replace("isd-stations", "isd_stations");
            _input = _input.Replace("lamp-stations", "lamp_stations");
            _input = _input.Replace("metar-stations", "metar_stations");
            _input = _input.Replace("darksky-stations", "darksky_stations");
            return _input;
        }

        public static string FormatExcludeString(Exclude[] _input)
        {
            return string.Join(",", _input.Select(i => Enum.GetName(typeof(Exclude), i)));
        }

        public static string FormatUTCString(DateTime _input)
        {
            var milliseconds = _input.ToUniversalTime().Subtract(
                new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

            return Convert.ToInt64(milliseconds).ToString();
        }
    }
}
