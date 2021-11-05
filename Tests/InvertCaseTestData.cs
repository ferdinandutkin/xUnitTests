using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tests
{
    public class InvertCaseTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {

             
            var values = JsonSerializer.
                Deserialize<List<TestData>>(File.
                    ReadAllText("../../../invertCaseTestData.json"));



            return values!.Select(v => new []{ v.Input, v.Expected }).GetEnumerator();


        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
