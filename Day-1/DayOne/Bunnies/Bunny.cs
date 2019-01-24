using System;
using DayOne.Trackers;

namespace DayOne.Bunnies
{
    public class Bunny
    {
        private BunnyCoordinate _currentCoordinate = new BunnyCoordinate(0, 0);
        private readonly DirectionChanger _directionChanger = new DirectionChanger();
        private Direction _direction = Direction.North;
        private readonly ITracker _tracker;
        public bool ShouldShowDuplicate;

        public Bunny(ITracker tracker)
        {
            _tracker = tracker;
        }

        public void Execute(string command)
        {
            var newFacing = command[0];
            var number = command.Substring(1);
            var numberToMove = int.Parse(number);

            _direction = _directionChanger.ChangeDirection(newFacing, _direction);
            Move(numberToMove);
        }

        public void Move(int numberToMove)
        {
            switch (_direction)
            {
                case Direction.North:
                    _currentCoordinate = _tracker.MoveUp(numberToMove, _currentCoordinate);
                    ShouldShowDuplicate = _currentCoordinate.FoundDuplicate;
                    break;
                case Direction.East:
                    _currentCoordinate = _tracker.MoveRight(numberToMove, _currentCoordinate);
                    ShouldShowDuplicate = _currentCoordinate.FoundDuplicate;
                    break;
                case Direction.South:
                    _currentCoordinate = _tracker.MoveDown(numberToMove, _currentCoordinate);
                    ShouldShowDuplicate = _currentCoordinate.FoundDuplicate;
                    break;
                case Direction.West:
                    _currentCoordinate = _tracker.MoveLeft(numberToMove, _currentCoordinate);
                    ShouldShowDuplicate = _currentCoordinate.FoundDuplicate;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public int CalculateDistance()
        {
            return Math.Abs(_currentCoordinate.X) + Math.Abs(_currentCoordinate.Y);
        }
    }
}