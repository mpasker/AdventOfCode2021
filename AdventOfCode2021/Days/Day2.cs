using System;
using System.Collections.Generic;
using AdventOfCode2021.Data;

namespace AdventOfCode2021.Days
{
    public class Day2 : IDay
    {
        public void Solve()
        {
            var parser = new Parser();
            var initialSubPosition = new SubmarinePosition();
            var submarinePositionChangeCollection = parser.ParseSubmarinePositionChangesFromInput();

            var finalSubPosition =
                UpdatePositionValuesOfSub(initialSubPosition, submarinePositionChangeCollection);

            Console.WriteLine($"Part 1: {finalSubPosition.Aim * finalSubPosition.Distance}");
            Console.WriteLine($"Part 2: {finalSubPosition.Depth * finalSubPosition.Distance}");
        }

        private SubmarinePosition UpdatePositionValuesOfSub(SubmarinePosition position, IEnumerable<string[]> positionChanges)
        {
            foreach (var positionChange in positionChanges)
            {
                var movement = positionChange[0];
                var value = int.Parse(positionChange[1]);
                switch (movement.ToUpper())
                {
                    case "FORWARD":
                        position.Distance += value;
                        position.Depth += position.Aim * value;
                        break;
                    case "DOWN":
                        position.Aim += value;
                        break;
                    default:
                        position.Aim -= value;
                        break;
                }
            }

            return position;
        }
    }
}
