using DayOne.Bunnies;

namespace DayOne.Trackers
{
    public class AdvancedTracker: ITracker
    {
        private readonly DuplicateLocationTracker _locationTracker;

        public AdvancedTracker()
        {
            _locationTracker = new DuplicateLocationTracker();
        }

        public BunnyCoordinate MoveRight(int numberToMove, BunnyCoordinate currentCoordinate)
        {
            for (var i = 1; i <= numberToMove; i++)
            {
                var tempLocation = _locationTracker.HasDuplicateLocation(new BunnyCoordinate(currentCoordinate.X + i,
                    currentCoordinate.Y));

                if (tempLocation.FoundDuplicate)
                {
                    return tempLocation;
                }
            }

            return new BunnyCoordinate(currentCoordinate.X + numberToMove, currentCoordinate.Y);
        }

        public BunnyCoordinate MoveLeft(int numberToMove, BunnyCoordinate currentCoordinate)
        {
            for (var i = 1; i <= numberToMove; i++)
            {
               var tempLocation = _locationTracker.HasDuplicateLocation(new BunnyCoordinate(currentCoordinate.X - i,
                    currentCoordinate.Y));

                if (tempLocation.FoundDuplicate)
                {
                    return tempLocation;
                }
            }

            return new BunnyCoordinate(currentCoordinate.X - numberToMove, currentCoordinate.Y);
        }

        public BunnyCoordinate MoveUp(int numberToMove, BunnyCoordinate currentCoordinate)
        {

            for (var i = 1; i <= numberToMove; i++)
            {
                var tempLocation = _locationTracker.HasDuplicateLocation(new BunnyCoordinate(currentCoordinate.X,
                    currentCoordinate.Y + i));

                if (tempLocation.FoundDuplicate)
                {
                    return tempLocation;
                }
            }

            return new BunnyCoordinate(currentCoordinate.X, currentCoordinate.Y + numberToMove);
        }

        public BunnyCoordinate MoveDown(int numberToMove, BunnyCoordinate currentCoordinate)
        {
            for (var i = 1; i <= numberToMove; i++)
            {
                var tempLocation = _locationTracker.HasDuplicateLocation(new BunnyCoordinate(currentCoordinate.X,
                    currentCoordinate.Y - i));

                if (tempLocation.FoundDuplicate)
                {
                    return tempLocation;
                }
            }

            return new BunnyCoordinate(currentCoordinate.X, currentCoordinate.Y - numberToMove);
        }
    }
}