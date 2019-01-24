using System;
using System.Collections.Generic;
using DayOne.Bunnies;

namespace DayOne.Trackers
{
    public class DuplicateLocationTracker
    {
        private readonly HashSet<string> _coordinateSet = new HashSet<string>();

        public DuplicateLocationTracker()
        {
            _coordinateSet.Add("0,0");
        }

        public BunnyCoordinate HasDuplicateLocation(BunnyCoordinate location)
        {
            if (_coordinateSet.Contains(location.GenerateHash()))
            {
                location.FoundDuplicate = true;
                return location;
            }

            _coordinateSet.Add(location.GenerateHash());
            return location;
        }
    }
}
