using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace DataLoader.Tests
{
    public class DataLoaderTests
    {
        [Fact]
        public void ReadTitle_()
        {

        }
    }

    public class WebsiteReaderTests
    {
        [Theory]
        [ClassData(typeof(TestFiles))]
        public void ReadTitle_Test(string source)
        {
            var reader = new WebsiteReader();
            reader.GetTitle(source);
        }
    }

    public class TestFiles : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var files = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data"));
            foreach (var item in files)
            {
                yield return new string[] { File.ReadAllText(item) };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
