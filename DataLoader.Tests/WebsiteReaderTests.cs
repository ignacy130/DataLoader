using Xunit;

namespace DataLoader.Tests
{
    public class WebsiteReaderTests
    {
        [Theory]
        [ClassData(typeof(TestFiles))]
        public void ReadTitle_Test(string source, string correctTitle)
        {
            var reader = new WebsiteReader();
            Assert.Equal(correctTitle, reader.GetTitle(source));
        }
    }
}
