using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSConsole.Amazon;

namespace CSConsoleTest.Amazon_Test
{
    public class Demo_Test
    {
        // ==========================================================================================
        // Cell Compete
        // ==========================================================================================
        [Fact]
        public void cellComplete1()
        {
            //Arrange
            int[] value = new int[] { 1, 0, 0, 0, 0, 1, 0, 0 };
            int Iterations = 1;
            int[] expectedResult = new int[] { 0, 1, 0, 0, 1, 0, 1, 0 };

            //Act 
            int[] result = Demo.cellComplete(value, Iterations);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void cellComplete2()
        {
            //Arrange
            int[] value = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };
            int Iterations = 2;
            int[] expectedResult = new int[] { 0, 0, 0, 0, 0, 1, 1, 0 };

            //Act 
            int[] result = Demo.cellComplete(value, Iterations);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void cellComplete3()
        {
            //Arrange
            int[] value = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };
            int Iterations = 3;
            int[] expectedResult = new int[] { 0, 0, 0, 0, 1, 1, 1, 1 };

            //Act 
            int[] result = Demo.cellComplete(value, Iterations);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void cellComplete4()
        {
            //Arrange
            int[] value = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };
            int Iterations = 4;
            int[] expectedResult = new int[] { 0, 0, 0, 1, 1, 0, 0, 1 };

            //Act 
            int[] result = Demo.cellComplete(value, Iterations);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        // ==========================================================================================
        // Greatest Common Divisor
        // ==========================================================================================

        [Fact]
        public void GCD1()
        {
            //Arrange
            int[] Array = new int[] { 2, 3, 4, 5, 6 };
            int nums = 5;
            int expectedResult = 1;

            //Act 
            int result = Demo.GCD(Array, nums);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GCD2()
        {
            //Arrange
            int[] Array = new int[] { 2, 4, 6, 8, 10 };
            int nums = 5;
            int expectedResult = 2;

            //Act 
            int result = Demo.GCD(Array, nums);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
