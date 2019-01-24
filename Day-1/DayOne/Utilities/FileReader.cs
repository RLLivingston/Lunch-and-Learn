using System.Collections.Generic;
using System.IO;

namespace DayOne
{
    public class FileReader
    {
        public IEnumerable<string> ReadFile(string filename)
        {
            using (var stream = new StreamReader(filename))
            {
                string line;
                while (null != (line = stream.ReadLine()))
                {
                    yield return line;
                }
            }
        }
    }
}
