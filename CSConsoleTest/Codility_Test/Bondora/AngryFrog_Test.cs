using Xunit;
using CSConsole.Codility.Bondora;

namespace CSConsoleTest.Codility_Test.Bondora
{
    public class AngryFrog_Test
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int[] value = new int[] { 9, 8, 7, 2, 4, 6, 18 };
            int expectedResult = 7;

            //Act 
            int result = AngryFrog.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            int[] value = new int[] { 1, 2, 9, 8, 7, 2, 4, 6, 18, 2, 1 };
            int expectedResult = 7;

            //Act 
            int result = AngryFrog.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            int[] value = new int[] { 1, 1, 1, 1, 1 };
            int expectedResult = 5;

            //Act 
            int result = AngryFrog.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test4()
        {
            //Arrange
            int[] value = new int[] { 3, 2, 1, 1, 1 };
            int expectedResult = 5;

            //Act 
            int result = AngryFrog.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test5()
        {
            //Arrange
            int[] value = new int[] { 1, 2, 3, 4, 5 };
            int expectedResult = 5;

            //Act 
            int result = AngryFrog.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test6()
        {
            //Arrange
            int[] value = new int[] { 1, 2, 2, 3, 4, 5, 1, 4 };
            int expectedResult = 6;

            //Act 
            int result = AngryFrog.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test7()
        {
            //Arrange
            int[] value = new int[] { 3, 9, 3, 1, 0, 0, 3, 0, 0, 9, 9 };
            int expectedResult = 6;

            //Act 
            int result = AngryFrog.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test8()
        {
            //Arrange
            int[] value = new int[] { 9, 9, 4, 9, 5, 7, 9, 3, 1, 1, 4, 0, 0, 6, 0, 0, 5, 9, 1, 9, 1, 0, 8, 1, 9, 0, 2, 6, 5, 3, 4, 0, 9, 9, 3, 5, 0, 4, 2, 5, 0, 2, 6, 4, 2, 1, 6, 8, 2, 3, 8, 7, 3, 3, 5, 9, 4, 9, 1, 9, 9, 1, 3, 8, 3, 9, 8, 1, 9, 6, 6, 0, 1, 0, 7, 6, 3, 2, 7, 3, 7, 8, 2, 1, 0, 2, 3, 1, 6, 0, 7, 8, 6, 1, 5, 4, 7, 2, 1, 8 };
            int expectedResult = 6;

            //Act 
            int result = AngryFrog.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test9()
        {
            //Arrange
            int[] value = new int[] { 2, 6, 8, 5 };
            int expectedResult = 3;

            //Act 
            int result = AngryFrog.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test10()
        {
            //Arrange
            int[] value = new int[] { 1, 5, 5, 2, 6 };
            int expectedResult = 4;

            //Act 
            int result = AngryFrog.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test11()
        {
            //Arrange
            int[] value = new int[] { 1, 1 };
            int expectedResult = 2;

            //Act 
            int result = AngryFrog.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
