using Xunit;
using CSConsole.Codility;

namespace CSConsoleTest.Codility_Test
{
    public class ParkingBill_Test
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            string enter = "10:00";
            string left = "13:21";
            int expectedResult = 17;

            //Act 
            int result = ParkingBill.solution(enter, left);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            string enter = "09:42";
            string left = "11:42";
            int expectedResult = 9;

            //Act 
            int result = ParkingBill.solution(enter, left);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
