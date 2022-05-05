using CSConsole.Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSConsoleTest.Amazon_Test
{
    public class Question2_Test
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int[] value = new int[] { 1, 0, 0, 0, 0, 1, 0, 0 };
            int expectedResult = 1;

            //Act 
            int result = Question2.Solution();

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            int[] value = new int[] { 1, 0, 0, 0, 0, 1, 0, 0 };
            int expectedResult = 1;

            //Act 
            int result = Question2.Solution();

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
