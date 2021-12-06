using System.Collections.Generic;

namespace AdventOfCode2021.Data
{
    public class SubmarinePosition
    {
        //public IDictionary<string, int> Position { get; set; }
        public int Distance { get; set; }
        public int Depth { get; set; }
        public int Aim { get; set; }

        //public SubmarinePosition GetDefaultSubmarinePosition
        //    => new()
        //    {
        //        Position = new Dictionary<string, int>
        //        {
        //            {"Distance", 0},
        //            {"Depth", 0},
        //            {"Aim", 0}
        //        }
        //    };
    }
}
