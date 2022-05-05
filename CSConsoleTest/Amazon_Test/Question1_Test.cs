using CSConsole.Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSConsoleTest.Amazon_Test
{
    public class Question1_Test
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int[] value = new int[] { 4, 3, 5, 4, 3 };
            int expectedResult = 9;

            //Act 
            int result = Question1.countDecreasingRatings(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            int[] value = new int[] { 4, 2, 3, 1 };
            int expectedResult = 4;

            //Act 
            int result = Question1.countDecreasingRatings(value);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
