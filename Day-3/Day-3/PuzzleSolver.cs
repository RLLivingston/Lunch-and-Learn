namespace Day_3
{
    public static class PuzzleSolver
    {
        public static int SolvePartOne()
        {
            var counter = 0;
            var triangles = new InputParser().GetData();
            var checker = new TriangleChecker();

            foreach (var triangle in triangles)
            {
                if (checker.IsValidTriangle(triangle))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
