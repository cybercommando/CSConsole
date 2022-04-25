using Xunit;
using CSConsole.Codility.Lessons;

namespace CSConsoleTest.Codility_Test.Lessons
{
    public class BinaryGap_Test
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int value = 1041;
            int expectedResult = 5;

            //Act 
            int result = BinaryGap.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            int value = 32;
            int expectedResult = 0;

            //Act 
            int result = BinaryGap.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            int value = 9;
            int expectedResult = 2;

            //Act 
            int result = BinaryGap.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test4()
        {
            //Arrange
            int value = 529;
            int expectedResult = 4;

            //Act 
            int result = BinaryGap.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test5()
        {
            //Arrange
            int value = 20;
            int expectedResult = 1;

            //Act 
            int result = BinaryGap.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        
        [Fact]
        public void Test6()
        {
            //Arrange
            int value = 15;
            int expectedResult = 0;

            //Act 
            int result = BinaryGap.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
