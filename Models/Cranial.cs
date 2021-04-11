using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex_Remix.Models
{
    public partial class Cranial
    {
        public string BurialId { get; set; }
        public string BurialLocationNs { get; set; }
        public double? LowPairNs { get; set; }
        public string BurialLocationEw { get; set; }
        public double? LowPairEw { get; set; }
        public string BurialSubplot { get; set; }
        public double? BurialNumber { get; set; }
        public double? SampleNumber { get; set; }
        public double? MaximumCranialLength { get; set; }
        public double? MaximumCranialBreadth { get; set; }
        public double? BasionBregmaHeight { get; set; }
        public double? BasionNasion { get; set; }
        public double? BasionProsthionLength { get; set; }
        public double? BizygomaticDiameter { get; set; }
        public double? NasionProsthion { get; set; }
        public double? MaximumNasalBreadth { get; set; }
        public double? InterorbitalBreadth { get; set; }
        public double? BurialDepth { get; set; }
        public string BurialArtifactDescription { get; set; }
        public bool BuriedWithArtifacts { get; set; }
        public string GilesGender { get; set; }
        public string BodyGender { get; set; }
    }
}
