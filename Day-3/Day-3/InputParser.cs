using System.Collections.Generic;
using System.Linq;

namespace Day_3
{
    public class InputParser
    {
        public IEnumerable<Triangle> GetData()
        {
            var fileReader = new FileReader();
            var rawInput = fileReader.ReadFile("input.txt").ToArray();
            var triangleList = new List<Triangle>();

            foreach (var line in rawInput)
            {
                var parsedInput = line.Split(',');
                var sideA = int.Parse(parsedInput[0]);
                var sideB = int.Parse(parsedInput[1]);
                var sideC = int.Parse(parsedInput[2]);

                triangleList.Add(new Triangle(sideA, sideB, sideC));
            }

            return triangleList;
        }

        public IEnumerable<Triangle> GetDataVertical()
        {
            var fileReader = new FileReader();
            var rawInput = fileReader.ReadFile("input.txt").ToArray();
            var triangleList = new List<Triangle>();

            for (var i = 0; i < rawInput.Length - 2; i += 3)
            {
                var line1 = rawInput[i];
                var parsedInput = line1.Split(',');

                var line2 = rawInput[i + 1];
                var parsedInput2 = line2.Split(',');

                var line3 = rawInput[i + 2];
                var parsedInput3 = line3.Split(',');

                var triangle1 = new Triangle();
                triangle1.SideA = int.Parse(parsedInput[0]);
                triangle1.SideB = int.Parse(parsedInput2[0]);
                triangle1.SideC = int.Parse(parsedInput3[0]);

                var triangle2 = new Triangle();
                triangle2.SideA = int.Parse(parsedInput[1]);
                triangle2.SideB = int.Parse(parsedInput2[1]);
                triangle2.SideC = int.Parse(parsedInput3[1]);

                var triangle3 = new Triangle();
                triangle3.SideA = int.Parse(parsedInput[2]);
                triangle3.SideB = int.Parse(parsedInput2[2]);
                triangle3.SideC = int.Parse(parsedInput3[2]);

                triangleList.Add(triangle1);
                triangleList.Add(triangle2);
                triangleList.Add(triangle3);
            }

            return triangleList;
        }
    }
}
