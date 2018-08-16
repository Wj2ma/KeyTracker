using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyTracker {
    public class Config {
        public string Left { get; set; }
        public string Down { get; set; }
        public string Up { get; set; }
        public string Right { get; set; }
        public bool Overlay { get; set; }
        public bool KpsColours { get; set; }
        public int Tier0 { get; set; }
        public int Tier1 { get; set; }
        public int Tier2 { get; set; }
        public int Tier3 { get; set; }
        public int Tier4 { get; set; }
    }
}
