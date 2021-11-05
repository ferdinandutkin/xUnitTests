using System;
using System.Linq;

namespace StringExtensions
{
    public static class StringExtensions
    {
        
        public static string ToTitleCase(this string @string)
            => string.Join(' ', (@string ?? throw new ArgumentNullException(nameof(@string))).
                ToLower().
                Split().
                Select(s => char.ToUpper(s[0]) + s[1..]));

        public static string ToAbbreviation(this string @string)
            => string.Concat((@string ?? throw new ArgumentNullException(nameof(@string))).
                ToLower().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(s => char.ToUpper(s[0])));

        public static string InvertCase(this string @string)
            => new(@string.Select(CharExtensions.InvertCase).ToArray());

        public static string Reverse(this string @string)
            => (@string ?? throw new ArgumentNullException(nameof(@string))).Length > 0 ? @string[^1] + @string[..^1].Reverse() : @string;


    }
}
