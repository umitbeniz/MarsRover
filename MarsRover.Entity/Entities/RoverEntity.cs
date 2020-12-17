using MarsRover.Entity.Enums;
using MarsRover.Entity.Interfaces;

namespace MarsRover.Entity.Entities
{
    public class RoverEntity : IRover
    {
        public PlateauEntity Plateau { get; set; }

        public CoordinateEntity Coordinate { get; set; }

        public Direction Direction { get; set; }

        public RoverEntity(PlateauEntity plateau, CoordinateEntity coordinate, Direction direction)
        {
            this.Plateau = plateau;
            this.Coordinate = coordinate;
            this.Direction = direction;
        }
    }
}