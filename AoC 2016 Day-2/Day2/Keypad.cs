using System.Text;

namespace Day2
{
    public class Keypad
    {
        public static int[,] keypad = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        public static int row = 1;
        public static int col = 1;
        public int currentPosition;
        public StringBuilder sb = new StringBuilder();

        public void Execute(string instructions)
        {
            foreach (var command in instructions)
            {
                switch (command)
                {
                    case 'U': MoveUp();
                        break;
                    case 'D': MoveDown();
                        break;
                    case 'R': MoveRight();
                        break;
                    case 'L': MoveLeft();
                        break;
                }

                SetPosition(row, col);
            }

            sb.Append(currentPosition);
        }

        public string GetCode()
        {
            return sb.ToString();
        }

        public void MoveUp()
        {
            var tempRow = row - 1;

            if (tempRow < 0)
            {
                return;
            }

            row = tempRow;
        }

        private void SetPosition(int row, int col)
        {
            currentPosition = keypad[row, col];
        }

        public void MoveDown()
        {
            var tempRow = row + 1;

            if (tempRow > 2)
            {
                return;
            }

            row = tempRow;
        }

        public void MoveLeft()
        {
            var tempCol = col - 1;

            if (tempCol < 0)
            {
                return;
            }

            col = tempCol;
        }

        public void MoveRight()
        {
            var tempCol = col + 1;

            if (tempCol > 2)
            {
                return;
            }

            col = tempCol;
        }
    }
}
