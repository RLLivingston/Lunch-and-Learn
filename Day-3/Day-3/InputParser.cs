using System.Collections.Generic;

namespace Day_3
{
    public class InputParser
    {
        public IEnumerable<Triangle> GetData()
        {
            var fileReader = new FileReader();
            var rawInput = fileReader.ReadFile("input.txt");
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
    }
}
