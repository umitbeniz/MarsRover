using MarsRover.Entity.Entities;
using MarsRover.Entity.Enums;
using Xunit;

namespace MarsRover.Operation.UnitTest
{
    public class PlateauOperationUnitTests : UnitTestBase
    {
        [Theory]
        [InlineData(new object[] { 1, 2, true })]
        [InlineData(new object[] { 6, 6, false })]
        public void CallRover_ReturnSuccess(int x, int y, bool expected)
        {
            //Arrange
            PlateauEntity plateau = new PlateauEntity(5, 5);
            CoordinateEntity coordinate = new CoordinateEntity(x, y);

            //Act            
            bool actual = PlateauOperation.IsCorrectWay(plateau, coordinate);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}