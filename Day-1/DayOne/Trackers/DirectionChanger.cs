using System;

namespace DayOne.Trackers
{
    public class DirectionChanger
    {
        public Direction ChangeDirection(char turn, Direction currentDirection)
        {
            var newDirection = turn == 'R' ? TurnRight(currentDirection) : TurnLeft(currentDirection);

            return newDirection;
        }

        public Direction TurnRight(Direction currentDirection)
        {
            switch (currentDirection)
            {
                case Direction.North:
                    return Direction.East;
                case Direction.East:
                    return Direction.South;
                case Direction.South:
                    return Direction.West;
                case Direction.West:
                    return Direction.North;
            }

            throw new ArgumentOutOfRangeException();
        }

        public Direction TurnLeft(Direction currentDirection)
        {
            switch (currentDirection)
            {
                case Direction.North:
                    return Direction.West;
                case Direction.East:
                    return Direction.North;
                case Direction.South:
                    return Direction.East;
                case Direction.West:
                    return Direction.South;
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
