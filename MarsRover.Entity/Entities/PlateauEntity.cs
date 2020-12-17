using MarsRover.Entity.Interfaces;

namespace MarsRover.Entity.Entities
{
    public class PlateauEntity : IPlateau
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int MinWidth { get; set; }

        public int MinHeight { get; set; }

        public PlateauEntity(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}