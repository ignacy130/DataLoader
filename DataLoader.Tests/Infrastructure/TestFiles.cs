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
            var dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            foreach (var item in Titles.TitlesWithSource)
            {
                yield return new string[] { File.ReadAllText(Path.Combine(dataDir, item.Key)), item.Value };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
