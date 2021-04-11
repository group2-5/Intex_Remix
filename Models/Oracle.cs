using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex_Remix.Models
{
    public partial class Oracle
    {
        public string BurialId { get; set; }
        public double? Gamous { get; set; }
        public double? LowPairNs { get; set; }
        public string BurialLocationNs { get; set; }
        public double? LowPairEw { get; set; }
        public string BurialLocationEw { get; set; }
        public string BurialSubplot { get; set; }
        public double? BurialNumber { get; set; }
        public double? WestToHead { get; set; }
        public double? WestToFeet { get; set; }
        public double? SouthToHead { get; set; }
        public double? SouthToFeet { get; set; }
        public double? Depth { get; set; }
        public string Preservation { get; set; }
        public string BurialIcon { get; set; }
        public string BurialIcon2 { get; set; }
        public string Sex { get; set; }
        public string SexMethod { get; set; }
        public string AgeAtDeath { get; set; }
        public string AgeMethod { get; set; }
        public string HairColor { get; set; }
        public string Sample { get; set; }
    }
}
