using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeshop_conversion
{
    public enum Roast { Light, Medium,Dark}
    public enum Temp { Hot, Iced, Warm}
    public enum BrewStrength {Mild,Balanced, Strong }
    public class Coffee : Beverages
    {
        public BrewStrength BrewStrength { get; set; }
        public Roast Roast { get; set; }
        public Temp Temp { get; set; }
        public bool InStock { get; set; }
        

    }
}
