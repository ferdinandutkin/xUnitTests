using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{


    internal class ReverseTestData : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new[] { "12345", "54321" };
            yield return new[] { "abcd", "dcba" };
            yield return new[] { "string", "gnirts" };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
