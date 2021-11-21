using DataLoader.Tests.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DataLoader.Tests
{

    public class TestFiles : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            foreach (var item in Titles.TitlesWithSource)
            {
                yield return new object[] { item };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
