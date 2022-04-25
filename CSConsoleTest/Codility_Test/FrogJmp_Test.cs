using Xunit;
using CSConsole.Codility;

namespace CSConsoleTest.Codility_Test
{
    public class FrogJmp_Test
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int X = 10;
            int Y = 85;
            int D = 30;
            int expectedResult = 3;

            //Act 
            int result = FrogJmp.solution(X, Y, D);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
