using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex_Remix.Models
{
    public partial class Bio
    {
        public string BurialId { get; set; }
        public string BurialLocationNs { get; set; }
        public double? LowPairNs { get; set; }
        public string BurialLocationEw { get; set; }
        public double? LowPairEw { get; set; }
        public string BurialSubplot { get; set; }
        public double? BurialNumber { get; set; }
        public double? Rack { get; set; }
        public string Bag { get; set; }
        public string Cluster { get; set; }
        public string Date { get; set; }
        public string PreviouslySampled { get; set; }
        public string Notes { get; set; }
        public string Initials { get; set; }
    }
}
