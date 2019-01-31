namespace Day2
{
    public static class PuzzleSolver
    {
        public static string SolvePartOne()
        {
            var reader = new FileReader();
            var input = reader.ReadFile("input.txt");
            var keypad = new Keypad();

            foreach (var line in input)
            {
                keypad.Execute(line);
            }

            return keypad.GetCode();
        }

        public static string SolvePartTwo()
        {
            var reader = new FileReader();
            var input = reader.ReadFile("input.txt");
            var keypad = new AdvancedKeypad();

            foreach (var line in input)
            {
                keypad.Execute(line);
            }

            return keypad.GetCode();
        }
    }
}
