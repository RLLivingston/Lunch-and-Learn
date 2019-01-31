using System.Text;

namespace Day2
{
    public class AdvancedKeypad
    {
        private readonly char[,] _keypad =
        {
            { ' ', ' ', '1', ' ', ' ' },
            { ' ', '2', '3', '4', ' ' },
            { '5', '6', '7', '8', '9' },
            { ' ', 'A', 'B', 'C', ' ' },
            { ' ', ' ', 'D', ' ', ' ' }
        };

        private int _row = 2;
        private int _col = 0;
        private char _currentPosition;
        public StringBuilder sb = new StringBuilder();

        public void Execute(string instructions)
        {
            foreach (var command in instructions)
            {
                switch (command)
                {
                    case 'U':
                        MoveUp();
                        break;
                    case 'D':
                        MoveDown();
                        break;
                    case 'R':
                        MoveRight();
                        break;
                    case 'L':
                        MoveLeft();
                        break;
                }

                SetPosition(_row, _col);
            }

            sb.Append(_currentPosition);
        }

        public string GetCode()
        {
            return sb.ToString();
        }

        public void MoveUp()
        {
            var temp_row = _row - 1;

            if (temp_row < 0 || _keypad[temp_row, _col] == ' ')
            {
                return;
            }

            _row = temp_row;
        }

        private void SetPosition(int row, int col)
        {
            _currentPosition = _keypad[row, col];
        }

        public void MoveDown()
        {
            var temp_row = _row + 1;

            if (temp_row > 4 || _keypad[temp_row, _col] == ' ')
            {
                return;
            }

            _row = temp_row;
        }

        public void MoveLeft()
        {
            var temp_col = _col - 1;

            if (temp_col < 0 || _keypad[_row, temp_col] == ' ')
            {
                return;
            }

            _col = temp_col;
        }

        public void MoveRight()
        {
            var temp_col = _col + 1;

            if (temp_col > 4 || _keypad[_row,temp_col] == ' ')
            {
                return;
            }

            _col = temp_col;
        }
    }
}
