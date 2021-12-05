using System;
using AdventOfCode2021.Data;

namespace AdventOfCode2021.Days
{
    public class Day2 : IDay
    {
        public void Start()
        {
            var parser = new Parser();
            var submarinePosition = new SubmarinePosition().GetDefaultSubmarinePosition;
            var submarinePositionChangeCollection = parser.ParseSubmarinePositionChangesFromInput();

            foreach (var positionChange in submarinePositionChangeCollection)
            {
                var movement = positionChange[0];
                var value = int.Parse(positionChange[1]);
                switch (movement.ToUpper())
                {
                    case "FORWARD":
                        submarinePosition.Position["HorizontalPosition"] += value;
                        break;
                    case "DOWN":
                        submarinePosition.Position["Depth"] += value;
                        break;
                    default:
                        submarinePosition.Position["Depth"] -= value;
                        break;
                }
            }

            Console.WriteLine($"Part 1: {submarinePosition.Position["HorizontalPosition"] * submarinePosition.Position["Depth"]}");
        }
    }
}
