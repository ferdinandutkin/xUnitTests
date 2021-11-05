using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class ToAbbreviationTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new[] { "abcd", "A" };
            yield return new[] { "cd ef", "CE" };
            yield return new[] { "alpha beta gamma", "ABG" };
            yield return new[] { "twice upon a time", "TUAT" };

        }


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
