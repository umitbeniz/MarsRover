using MarsRover.Entity.Entities;
using System;
using AutoFixture;
using Xunit;
using MarsRover.Entity.Enums;

namespace MarsRover.Operation.UnitTest
{
    public class RoverOperationUnitTests : UnitTestBase
    {
        [Fact]
        public void SetCoordinates_ReturnSuccess()
        {
            //Arrange
            RoverEntity rover = new RoverEntity(new PlateauEntity(5, 5), new CoordinateEntity(1, 2), Direction.N);
            int x = this.Fixture.Create<int>();
            int y = this.Fixture.Create<int>();

            //Act
            var exception = Record.Exception(() => rover.SetCoordinates(x, y, Direction.N));

            //Assert
            Assert.Null(exception);
        }

        [Theory]
        [InlineData(new object[] { "LMLMLMLMM", 1, 2, Direction.N, "1 3 N" })]
        [InlineData(new object[] { "MMRMMRMRRM", 3, 3, Direction.E, "5 1 E" })]
        public void GetCurrentCoordinates_ReturnSuccess(string command, int x, int y, Direction direction, string expected)
        {
            //Arrange
            RoverEntity rover = new RoverEntity(new PlateauEntity(5, 5), new CoordinateEntity(x, y), direction);
            
            //Act
            rover.CallRover(command);
            string currentCoordinates = rover.GetCurrentCoordinates();
            
            //Assert
            Assert.Equal(expected, currentCoordinates);
        }

        [Fact]
        public void CallRover_ReturnSuccess()
        {
            //Arrange
            RoverEntity rover = new RoverEntity(new PlateauEntity(5, 5), new CoordinateEntity(1, 2), Direction.N);
            string command = "LMLMLMLMM";

            //Act
            rover.CallRover(command);

            //Assert
            Assert.Null((object)Record.Exception((Action)(() => rover.CallRover(command))));
        }
    }
}