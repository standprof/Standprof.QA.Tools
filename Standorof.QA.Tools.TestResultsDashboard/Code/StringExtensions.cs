using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestResultsDashboard.Code
{
    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, bool bCaseInsensitive)
        {
            return source.IndexOf(toCheck, bCaseInsensitive ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal) >= 0;
        }
    }
}
