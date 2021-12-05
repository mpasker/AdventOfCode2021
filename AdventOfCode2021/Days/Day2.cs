using System;
using System.Collections.Generic;
using AdventOfCode2021.Data;

namespace AdventOfCode2021.Days
{
    public class Day2 : IDay
    {
        public void Start()
        {
            var parser = new Parser();
            var initialSubPosition = new SubmarinePosition().GetDefaultSubmarinePosition;
            var submarinePositionChangeCollection = parser.ParseSubmarinePositionChangesFromInput();

            var finalSubPosition =
                CalculateHorizontalPositionAndDepth(initialSubPosition, submarinePositionChangeCollection);

            Console.WriteLine($"Part 1: {finalSubPosition.Position["Aim"] * finalSubPosition.Position["Distance"]}");
            Console.WriteLine($"Part 2: {finalSubPosition.Position["Depth"] * finalSubPosition.Position["Distance"]}");
        }

        private SubmarinePosition CalculateHorizontalPositionAndDepth(SubmarinePosition position, IEnumerable<string[]> positionChanges)
        {
            foreach (var positionChange in positionChanges)
            {
                var movement = positionChange[0];
                var value = int.Parse(positionChange[1]);
                switch (movement.ToUpper())
                {
                    case "FORWARD":
                        position.Position["Distance"] += value;
                        position.Position["Depth"] += position.Position["Aim"] * value;
                        break;
                    case "DOWN":
                        position.Position["Aim"] += value;
                        break;
                    default:
                        position.Position["Aim"] -= value;
                        break;
                }
            }

            return position;
        }
    }
}
