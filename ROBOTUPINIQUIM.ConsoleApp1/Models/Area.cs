namespace Tupiniquim.Models
{
    public class Area
    {
        public int MaxX { get; }
        public int MaxY { get; }

        public Area(int maxX, int maxY)
        {
            if (maxX < 0 || maxY < 0)
                throw new ArgumentException("Coordenadas da área devem ser positivas.");

            MaxX = maxX;
            MaxY = maxY;
        }

        public bool DentroDoLimite(int x, int y)
        {
            return x >= 0 && x <= MaxX && y >= 0 && y <= MaxY;
        }
    }
}
