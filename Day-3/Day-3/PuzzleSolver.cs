using System.Linq;

namespace Day_3
{
    public static class PuzzleSolver
    {
        public static int SolvePartOne()
        {
            //var linqList = new List<int> {0, 2, 3, 4, 5, 0};
            //var duplicateCount = linqList.Count(integerLooker => integerLooker == 1);
            //var fancy = linqList.Where(x => x == 1 || x == 2).;
            //var first = linqList.First(x => x == 1);
            //var firstButBetter = linqList.FirstOrDefault(x => x == 1);
            //var s = linqList.IndexOf(3);

            //var newList = new List<Triangle> {new Triangle(1, 2, 3), new Triangle(4, 5, 6)};

            //var trianleWithSideEqual2 = newList.FirstOrDefault(x => x.SideA == 2 || x.SideB == 2 || x.SideC == 2);

            //var counter = 0;

            //foreach (var entry in linqList)
            //{
            //    if (entry == 1)
            //    {
            //        counter++;
            //    }
            //}

            //var listOfTriangles = new InputParser().GetData();
            //return listOfTriangles.Count(x => x.IsValid());

           return new InputParser().GetData().Count(x => x.IsValid());
        }

        public static int SolvePartTwo()
        {
            return new InputParser().GetDataVertical().Count(x => x.IsValid());
        }
    }
}
