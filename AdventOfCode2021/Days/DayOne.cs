using System;
using System.Linq;

namespace AdventOfCode2021.Days
{
    public class DayOne : IDay
    {
        private static Parser _parser;

        public DayOne(Parser parser)
        {
            _parser = parser;
        }

        public void Solve()
        {
            Console.WriteLine($"Part 1: {ReportMeasurementIncreases()}");
            Console.WriteLine($"Part 2: {ReportMeasurementIncreases(3)}");
        }

        private static int ReportMeasurementIncreases(int windowSize = 1)
        {
            var reportEntities = LoadReportEntries();
            return reportEntities
                .Skip(windowSize)
                .Select((e, i) => e > reportEntities[i])
                .Count(x => x);
        }

        private static int[] LoadReportEntries()
        {
            return _parser.ParsePuzzleInput("../../../PuzzleInputs/dayone.txt")
                .Select(int.Parse)
                .ToArray();
        }
    }
}
