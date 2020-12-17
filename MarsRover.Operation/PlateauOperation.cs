using MarsRover.Entity.Entities;

namespace MarsRover.Operation
{
    public static class PlateauOperation
    {
        public static bool IsCorrectWay(this PlateauEntity plateau, CoordinateEntity coordinate) { 
            bool result = plateau.MinWidth <= coordinate.CoordinateX 
                       && plateau.MinHeight <= coordinate.CoordinateY 
                       && coordinate.CoordinateX <= plateau.Width 
                       && coordinate.CoordinateY <= plateau.Height;

            return result;
        }
    }
}