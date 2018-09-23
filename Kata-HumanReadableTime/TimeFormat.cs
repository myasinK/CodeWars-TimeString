using System;

namespace Kata_HumanReadableTime
{
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds == 0)
            {
                return "00:00:00";
            }
            else if (seconds >= 359999)
            {
                return "99:59:59";
            }
            else
            {
                var secondsInHr = 60 * 60;
                var secondsInMin = 60;
                var HH = ( seconds / secondsInHr ).ToString("D2");
                var MM = ( (seconds % secondsInHr) / secondsInMin ).ToString("D2");
                var SS = ( (seconds % secondsInHr) % secondsInMin ).ToString("D2");
                return $"{HH}:{MM}:{SS}";

            }

        }
    }
}
