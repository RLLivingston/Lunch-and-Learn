using System.Collections.Generic;
using DayOne.Bunnies;
using DayOne.Trackers;

namespace DayOne.Utilities
{
    public class Solver
    {
        public int SolvePartOne(IEnumerable<string> input)
        {
            var bunny = new Bunny(new Tracker());
            foreach (var line in input)
            {
                bunny.Execute(line.TrimStart());
            }

            return bunny.CalculateDistance();
        }

        public int SolvePartTwo(IEnumerable<string> input)
        {
            var bunny = new Bunny(new AdvancedTracker());
            foreach (var line in input)
            {
                bunny.Execute(line.TrimStart());

                if (bunny.ShouldShowDuplicate)
                {
                    return bunny.CalculateDistance();
                }
            }

            return bunny.CalculateDistance();
        }
    }
}
