using CSConsole.Codility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSConsoleTest.Codility_Test
{
    public class Demo_Test
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int[] value = new int[] { 0 };
            int expectedResult = 1;

            //Act 
            int result = Demo.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            int[] value = new int[] { 4 };
            int expectedResult = 1;

            //Act 
            int result = Demo.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            int[] value = new int[] { -1, 4, 5 };
            int expectedResult = 1;

            //Act 
            int result = Demo.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test4()
        {
            //Arrange
            int[] value = new int[] { 1, 2 };
            int expectedResult = 3;

            //Act 
            int result = Demo.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test5()
        {
            //Arrange
            int[] value = new int[] { 1, 1, 1, 1, 1 };
            int expectedResult = 2;

            //Act 
            int result = Demo.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test6()
        {
            //Arrange
            int[] value = new int[] { -1, -2, -3, -1, -5, -4 };
            int expectedResult = 1;

            //Act 
            int result = Demo.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test7()
        {
            //Arrange
            int[] value = new int[] { 1, 2, 3, 1, 5, 4 };
            int expectedResult = 6;

            //Act 
            int result = Demo.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test8()
        {
            //Arrange
            int[] value = new int[] { };
            int expectedResult = 1;

            //Act 
            int result = Demo.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test9()
        {
            //Arrange
            int[] value = new int[] { 1, 4, 3, 1, 5 };
            int expectedResult = 2;

            //Act 
            int result = Demo.solution(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
