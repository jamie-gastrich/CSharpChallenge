using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FormattedNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "0.232567" }; //True
            //string[] arr = { "2,567.00.2" }; //False
            //string[] arr = { "1,093,222.04" }; //True
            //string[] arr = { "1,093,22.04" }; //False
            Console.WriteLine(FormattedNumber(arr));
        }
        public static string FormattedNumber(string[] arr)
        {
            var regex = new Regex(@"(^(\d+|\d{1,3}(,\d{3})*)(\.\d+)?$)");
            var Matches = regex.Matches(arr[0]).OfType<Match>();
            bool IsTrue = Matches.Any();

            return IsTrue.ToString();

        }
    }
}
