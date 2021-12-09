using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2021.Days
{
    public class Day3 : IDay
    {
        private static Parser _parser;

        public Day3(Parser parser)
        {
            _parser = parser;
        }
        public void Solve()
        {
            var diagnosticReport = _parser.ParsePuzzleInput("../../../PuzzleInputs/daythree.txt")
                .Select(x => x.ToCharArray())
                .ToArray();

            var columnIndex = 0;
            var diagnosticReportWidth = diagnosticReport[0].Length;
            var gammaRate = new StringBuilder();
            var epsilonRate = new StringBuilder();

            do
            {
                var bitWithMostOccurrences = GetBitThatOccursMostInColumn(columnIndex, diagnosticReport);
                gammaRate.Append(bitWithMostOccurrences);
                epsilonRate.Append(bitWithMostOccurrences == '1' ? '0' : '1');

                columnIndex++;
            } while (columnIndex < diagnosticReportWidth);

            Console.WriteLine($"Part 1: {Convert.ToInt32(gammaRate.ToString(), 2) * Convert.ToInt32(epsilonRate.ToString(), 2)}");
        }

        private static char GetBitThatOccursMostInColumn(int columnIndex, IReadOnlyCollection<char[]> diagnosticReport)
        {
            var bitCount = diagnosticReport.Sum(number => number[columnIndex] == '1' ? 1 : 0);
            return bitCount >= diagnosticReport.Count - bitCount ? '1' : '0';
        }
    }
}
