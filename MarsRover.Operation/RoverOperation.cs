using MarsRover.Entity.Constants;
using MarsRover.Entity.Entities;
using MarsRover.Entity.Enums;
using System;

namespace MarsRover.Operation
{
    public static class RoverOperation
    {
        #region public methods
        public static void SetCoordinates(this RoverEntity rover, int x, int y, Direction direction)
        {
            rover.Coordinate.CoordinateX = x;
            rover.Coordinate.CoordinateY = y;
            rover.Direction = direction;
        }

        public static string GetCurrentCoordinates(this RoverEntity rover)
        {
            return rover.Coordinate.CoordinateX.ToString() + " " + rover.Coordinate.CoordinateY.ToString() + " " + rover.Direction.ToString();
        }

        public static void CallRover(this RoverEntity rover, string command)
        {
            for (int index = 0; index < command.Length; index++)
                rover.ControlRover(command[index]);
        }
        #endregion

        #region private methods
        private static void ControlRover(this RoverEntity rover, char command)
        {
            switch (command)
            {
                case Letter.L:
                    rover.RotateLeft();
                    break;
                case Letter.M:
                    if (!rover.MoveRover())
                        Console.WriteLine("Wrong way!");
                    break;
                case Letter.R:
                    rover.RotateRight();
                    break;
                default:
                    Console.WriteLine("The possible letters are 'L', 'R' and 'M'");
                    break;
            }
        }

        private static void RotateLeft(this RoverEntity rover)
        {
            rover.Direction = ((int)rover.Direction - 1) < (int)Direction.N ? Direction.W : (Direction)((int)rover.Direction - 1);
        }

        private static void RotateRight(this RoverEntity rover)
        {
            rover.Direction = ((int)rover.Direction + 1) > (int)Direction.W ? Direction.N : (Direction)((int)rover.Direction + 1);
        }

        private static bool MoveRover(this RoverEntity rover)
        {
            if (rover.Plateau.IsCorrectWay(rover.Coordinate))
            {
                switch (rover.Direction)
                {
                    case Direction.N:
                        rover.Coordinate.CoordinateY++;
                        break;
                    case Direction.E:
                        rover.Coordinate.CoordinateX++;
                        break;
                    case Direction.S:
                        rover.Coordinate.CoordinateY--;
                        break;
                    case Direction.W:
                        rover.Coordinate.CoordinateX--;
                        break;
                }
                return true;
            }

            return false;
        }
        #endregion
    }
}