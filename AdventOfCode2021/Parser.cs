using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2021
{
    public class Parser
    {
        public IEnumerable<string> ParsePuzzleInput(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        public int ParseUserInput(string input)
        {
            var isValid = int.TryParse(input, out var number);
            if (!isValid) return -1;

            return number;
        }
    }
}
