using System.Collections.Generic;

namespace AdventOfCode2021.Data
{
    public class SubmarinePosition
    {
        public IDictionary<string, int> Position { get; set; }

        public SubmarinePosition GetDefaultSubmarinePosition
            => new()
            {
                Position = new Dictionary<string, int>
                {
                    {"HorizontalPosition", 0},
                    {"Depth", 0}
                }
            };
    }
}
