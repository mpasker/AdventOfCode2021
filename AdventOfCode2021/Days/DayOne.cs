using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2021.Days
{
    public class DayOne : IDay

    {
    private readonly int[] _reportEntries;

    public DayOne()
    {
        _reportEntries = LoadReportEntries();
    }

    public void Start()
    {
        Console.WriteLine($"Part 1: {ReportMeasurementIncreases()}");
        Console.WriteLine($"Part 2: {ReportMeasurementIncreases(3)}");
    }

    private int ReportMeasurementIncreases(int windowSize = 1)
    {
        return _reportEntries
            .Skip(windowSize)
            .Select((e, i) => e > _reportEntries[i])
            .Count(x => x);
    }

    private static int[] LoadReportEntries()
    {
        return File.ReadAllLines("../../../PuzzleInputs/dayone.txt")
            .Select(int.Parse)
            .ToArray();
    }
    }
}
