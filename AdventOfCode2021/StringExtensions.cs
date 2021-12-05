namespace AdventOfCode2021
{
    public static class StringExtensions
    {
        public static int ParseInput(this string input)
        {
            var isValid = int.TryParse(input, out var number);
            if (!isValid) return -1;

            return number;
        }
    }
}
