using Xunit;

namespace DataLoader.Tests
{
    public class WebsiteReaderTests
    {
        [Theory]
        [ClassData(typeof(TestFiles))]
        public void ReadTitle_Test(WebsiteTestCase testCase)
        {
            var reader = new WebsiteReader();
            Assert.Equal(testCase.CorrectTitle, reader.GetTitle(testCase.TestSource));
        }
    }
}
