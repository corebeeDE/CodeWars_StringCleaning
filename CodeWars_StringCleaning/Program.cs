using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars_StringCleaning
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/57e1e61ba396b3727c000251/
        }

        // First solution
        public static string StringClean(string s)
        {
            return new string(s.ToCharArray().Where(x => !char.IsDigit(x)).ToArray());
        }

        // Refactored solution
        public static string StringCleanTwo(string s) => Regex.Replace(s, @"\d", "");
    }
}
