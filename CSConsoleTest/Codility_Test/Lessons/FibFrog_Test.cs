using Xunit;
using CSConsole.Codility.Lessons;

namespace CSConsoleTest.Codility_Test.Lessons
{
    public class FibFrog_Test
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int[] value = new int[] { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 };
            int expectedResult = 3;

            //Act 
            int result = FibFrog.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
