namespace DayOne.Bunnies
{
    public class BunnyCoordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool FoundDuplicate = false;

        public BunnyCoordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string GenerateHash()
        {
            return $"{X},{Y}";
        }
    }
}
