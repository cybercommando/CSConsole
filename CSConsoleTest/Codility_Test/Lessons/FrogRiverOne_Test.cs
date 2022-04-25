using Xunit;
using CSConsole.Codility.Lessons;

namespace CSConsoleTest.Codility_Test.Lessons
{
    public class FrogRiverOne_Test
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int[] value = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
            int X = 5;
            int expectedResult = 6;

            //Act 
            int result = FrogRiverOne.solution(X, value);

            //Assert
            Assert.Equal(result, expectedResult);
        }

    }
}
