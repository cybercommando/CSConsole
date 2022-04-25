using Xunit;
using CSConsole.Codility;

namespace CSConsoleTest.Codility_Test
{
    public class ParityDegree_Test
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int value = 24;
            int expectedResult = 3;

            //Act 
            int result = ParityDegree.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
