namespace TreehouseDefense
{
    class Map
    {
        public readonly int Width; //field of Width for new class of Map
        public readonly int Height; //field of Height for new class of Map

        public Map(int width, int height) //constructor method that applies width and height to the fields of Width and Height
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point) //public method, type BOOLEAN, name OnMap, assigns the TYPE Point to the VARIABLE point & checks to see if given point is on the map
        {
            return point.X >= 0 && point.X < Width && 
                   point.Y >= 0 && point.Y < Height;
        }
    }
}