using MarsRover.Entity.Entities;
using MarsRover.Entity.Enums;

namespace MarsRover.Entity.Interfaces
{
    public interface IRover
    {
        PlateauEntity Plateau { get; set; }

        CoordinateEntity Coordinate { get; set; }

        Direction Direction { get; set; }
    }
}