using MarsRover.Entity.Interfaces;

namespace MarsRover.Entity.Entities
{
    public class CoordinateEntity : ICoordinate
    {
        public int CoordinateX { get; set; }

        public int CoordinateY { get; set; }

        public CoordinateEntity(int x, int y)
        {
            this.CoordinateX = x;
            this.CoordinateY = y;
        }
    }
}