using MarsRover.Entity.Entities;
using MarsRover.Entity.Enums;
using MarsRover.Operation;
using System;

namespace MarsRover.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            PlateauEntity plateau = new PlateauEntity(5, 5);
            CoordinateEntity coordinate = new CoordinateEntity(1, 2);
            RoverEntity rover = new RoverEntity(plateau, coordinate, Direction.N);

            //RoverOperation.CallRover(rover, "LMLMLMLMM");
            //Console.WriteLine(RoverOperation.GetCurrentCoordinates(rover));

            rover.CallRover("LMLMLMLMM");
            Console.WriteLine(RoverOperation.GetCurrentCoordinates(rover));


            rover.SetCoordinates(3, 3, Direction.E);
            rover.CallRover("MMRMMRMRRM");

            //rover.SetCoordinates(3, 3, Direction.E);
            //RoverOperation.CallRover(rover, "MMRMMRMRRM");
            Console.WriteLine(RoverOperation.GetCurrentCoordinates(rover));

            Console.ReadKey();
        }
    }
}