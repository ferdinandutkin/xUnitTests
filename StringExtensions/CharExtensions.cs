using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class CharExtensions
    {
        public static char InvertCase(this char @char)
            => char.IsUpper(@char) ? char.ToLower(@char) : char.ToUpper(@char);

    }
}
