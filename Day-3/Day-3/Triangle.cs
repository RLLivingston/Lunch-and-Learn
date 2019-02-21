namespace Day_3
{
    public class Triangle
    {
        public Triangle()
        {

        }

        public Triangle(int a, int b, int c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }

        public bool IsValid()
        {
            return (SideA + SideB > SideC &&
                    SideB + SideC > SideA &&
                    SideC + SideA > SideB);
        }
    }
}
