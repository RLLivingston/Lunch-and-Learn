namespace Day_3
{
    public class TriangleChecker
    {
        public bool IsValidTriangle(Triangle triangle)
        {
            return (triangle.SideA + triangle.SideB > triangle.SideC &&
                    triangle.SideB + triangle.SideC > triangle.SideA &&
                    triangle.SideC + triangle.SideA > triangle.SideB);
        }
    }
}
