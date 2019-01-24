using System.Collections.Generic;
using DayOne.Bunnies;
using DayOne.Trackers;

namespace DayOne
{
    public static class PuzzleSolver
    {
        private static readonly IEnumerable<string> Input = new InputFormatter().GetInput();

        public static int SolvePartOne()
        {
            var bunny = new Bunny(new Tracker());

            foreach (var line in Input)
            {
                bunny.Execute(line.TrimStart());
            }

            return bunny.CalculateDistance();
        }

        public static int SolvePartTwo()
        {
            var advancedBunny = new Bunny(new AdvancedTracker());

            foreach (var line in Input)
            {
                advancedBunny.Execute(line.TrimStart());
                if (advancedBunny.ShouldShowDuplicate)
                {
                    break;
                }
            }

            return advancedBunny.CalculateDistance();
        }
    }
}
