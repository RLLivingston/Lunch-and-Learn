using System.Collections.Generic;
using System.Linq;

namespace DayOne
{
    public class InputFormatter
    {
        public IEnumerable<string> GetInput()
        {
            var reader = new FileReader();
            var results = reader.ReadFile("input.txt").ToArray();
            return results[0].Split(',');
        }
    }
}
