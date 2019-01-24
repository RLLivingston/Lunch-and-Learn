using DayOne.Bunnies;

namespace DayOne.Trackers
{
    public class Tracker: ITracker
    {
        public BunnyCoordinate MoveRight(int numberToMove, BunnyCoordinate currentCoordinate)
        {
            return new BunnyCoordinate(currentCoordinate.X + numberToMove, currentCoordinate.Y);
        }

        public BunnyCoordinate MoveLeft(int numberToMove, BunnyCoordinate currentCoordinate)
        {
            return new BunnyCoordinate(currentCoordinate.X - numberToMove, currentCoordinate.Y);
        }

        public BunnyCoordinate MoveUp(int numberToMove, BunnyCoordinate currentCoordinate)
        {
            return new BunnyCoordinate(currentCoordinate.X, currentCoordinate.Y + numberToMove);
        }

        public BunnyCoordinate MoveDown(int numberToMove, BunnyCoordinate currentCoordinate)
        {
            return new BunnyCoordinate(currentCoordinate.X, currentCoordinate.Y - numberToMove);
        }
    }
}