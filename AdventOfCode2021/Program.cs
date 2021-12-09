using System;
using AdventOfCode2021.Days;

namespace AdventOfCode2021
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var parser = new Parser();

            Console.WriteLine("Advent of Code 2021");
            var input = -1;
            while (input == -1)
            {
                input = PromptForDay(parser);
                IDay day;

                switch (input)
                {
                    case 1:
                        day = new DayOne(parser);
                        day.Solve();
                        break;
                    case 2:
                        day = new Day2(parser);
                        day.Solve();
                        break;
                    case 3:
                        day = new Day3(parser);
                        day.Solve();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Day is not valid. Try again.");
                        break;
                }
            }
        }

        private static int PromptForDay(Parser parser)
        {
            Console.WriteLine("Enter a day (1-25). Enter 0 to exit");
            var userInput = Console.ReadLine();
            return parser.ParseUserInput(userInput);
        }
    }
}
