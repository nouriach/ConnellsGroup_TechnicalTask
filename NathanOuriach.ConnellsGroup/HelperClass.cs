using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NathanOuriach.ConnellsGroup
{
    internal static class HelperClass
    {
        public static bool IsValidValue(int value)
        {
            return value >= 4 && value <= 9;
        }

        public static bool HasUserEnteredSubmit(out string line)
        {
            return (line = Console.ReadLine()) == "s";
        }
    }
}
