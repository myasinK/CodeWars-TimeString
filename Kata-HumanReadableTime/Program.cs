using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //Write a function, which takes a non-negative integer(seconds) as input and returns the time in a human-readable format(HH:MM:SS)

    //HH = hours, padded to 2 digits, range: 00 - 99
    //MM = minutes, padded to 2 digits, range: 00 - 59
    //SS = seconds, padded to 2 digits, range: 00 - 59
    //The maximum time never exceeds 359999 (99:59:59)

    //You can find some examples in the test fixtures.

namespace Kata_HumanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = 0;
            var timeString = TimeFormat.GetReadableTime(t);
            Console.WriteLine(timeString);
        }
    }
}
