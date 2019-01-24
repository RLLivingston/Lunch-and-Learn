using DayOne.Bunnies;

namespace DayOne.Trackers
{
    public interface ITracker
    {
        BunnyCoordinate MoveRight(int numberToMove, BunnyCoordinate currentCoordinate);
        BunnyCoordinate MoveLeft(int numberToMove, BunnyCoordinate currentCoordinate);
        BunnyCoordinate MoveUp(int numberToMove, BunnyCoordinate currentCoordinate);
        BunnyCoordinate MoveDown(int numberToMove, BunnyCoordinate currentCoordinate);
    }
}