using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2021
{
    public class Parser
    {
        public IEnumerable<string[]> ParseSubmarinePositionChangesFromInput()
        {
            return File.ReadAllLines("../../../PuzzleInputs/daytwo.txt")
                .Select(p => p.Trim().Split(" ", 2));

        }

        public char[][] ParseDiagnosticReport()
        {
            return File.ReadAllLines("../../../PuzzleInputs/daythree.txt")
                .Select(x => x.ToCharArray())
                .ToArray();
        }
    }
}
