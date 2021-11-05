using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class EquivalentStringTestData : IEnumerable<object[]>
    {

        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new[] { "Abcd" };
            yield return new[] { "cd ef" };
            yield return new[] { "cD eD" };
            yield return new[] { "Dc Ef" };


        }
       

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
