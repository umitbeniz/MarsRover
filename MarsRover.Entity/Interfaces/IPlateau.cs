namespace MarsRover.Entity.Interfaces
{
    public interface IPlateau
    {
        int Width { get; set; }

        int Height { get; set; }

        int MinWidth { get; set; }

        int MinHeight { get; set; }
    }
}