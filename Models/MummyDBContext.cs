using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex_Remix.Models
{
    public partial class MummyDBContext : DbContext
    {
        public MummyDBContext()
        {
        }

        public MummyDBContext(DbContextOptions<MummyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bio> Bios { get; set; }
        public virtual DbSet<Carbon> Carbons { get; set; }
        public virtual DbSet<Cranial> Cranials { get; set; }
        public virtual DbSet<Main> Burials { get; set; }
        public virtual DbSet<Oracle> Oracles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = intex2.chocwqhmp0h9.us-east-1.rds.amazonaws.com;Initial Catalog=MummyDB;User ID =admin;Password=PokemonHangman;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bio$");

                entity.Property(e => e.Bag)
                    .HasColumnName("bag_#")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialId)
                    .HasColumnName("burial_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialLocationEw)
                    .HasColumnName("burial_location_EW")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialLocationNs)
                    .HasColumnName("burial_location_NS")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialSubplot)
                    .HasColumnName("burial_subplot")
                    .HasMaxLength(255);

                entity.Property(e => e.Cluster)
                    .HasColumnName("cluster_#")
                    .HasMaxLength(255);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(255);

                entity.Property(e => e.Initials)
                    .HasColumnName("initials")
                    .HasMaxLength(255);

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(255);

                entity.Property(e => e.PreviouslySampled)
                    .HasColumnName("previously_sampled")
                    .HasMaxLength(255);

                entity.Property(e => e.Rack).HasColumnName("rack_#");
            });

            modelBuilder.Entity<Carbon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Carbon$");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialId)
                    .HasColumnName("burial_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialLocationEw)
                    .HasColumnName("burial_location_EW")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialLocationNs)
                    .HasColumnName("burial_location_NS")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialSubplot)
                    .HasColumnName("burial_subplot")
                    .HasMaxLength(255);

                entity.Property(e => e.C14Sample2017).HasColumnName("c14_sample_2017");

                entity.Property(e => e.Calibrated95CalendarDateAvg)
                    .HasColumnName("calibrated_95%_calendar_date_avg")
                    .HasMaxLength(255);

                entity.Property(e => e.Calibrated95CalendarDateMax)
                    .HasColumnName("calibrated_95%_calendar_date_max")
                    .HasMaxLength(255);

                entity.Property(e => e.Calibrated95CalendarDateMin)
                    .HasColumnName("calibrated_95%_calendar_date_min")
                    .HasMaxLength(255);

                entity.Property(e => e.Calibrated95CalendarDateSpan).HasColumnName("calibrated_95%_calendar_date_span");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(255);

                entity.Property(e => e.Conventional14cAgeBp).HasColumnName("conventional_14c_age_BP");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.Foci).HasColumnName("foci");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(255);

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(255);

                entity.Property(e => e.Questions)
                    .HasColumnName("questions")
                    .HasMaxLength(255);

                entity.Property(e => e.RackA).HasColumnName("rack_a");

                entity.Property(e => e.RackB).HasColumnName("rack_b");

                entity.Property(e => e.SizeMl).HasColumnName("size_(ml)");

                entity.Property(e => e.TubeNumber).HasColumnName("tube_number");

                entity.Property(e => e._14cCalendarDate)
                    .HasColumnName("14c_calendar_date")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Cranial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cranial$");

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("basion-bregma_height");

                entity.Property(e => e.BasionNasion).HasColumnName("basion-nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("basion-prosthion_length");

                entity.Property(e => e.BizygomaticDiameter).HasColumnName("bizygomatic_diameter");

                entity.Property(e => e.BodyGender)
                    .HasColumnName("body_gender")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialArtifactDescription)
                    .HasColumnName("burial/artifact_description")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialDepth).HasColumnName("burial_depth");

                entity.Property(e => e.BurialId)
                    .HasColumnName("burial_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialLocationEw)
                    .HasColumnName("burial_location_EW")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialLocationNs)
                    .HasColumnName("burial_location_NS")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialSubplot)
                    .HasColumnName("burial_subplot")
                    .HasMaxLength(255);

                entity.Property(e => e.BuriedWithArtifacts).HasColumnName("buried_with_artifacts");

                entity.Property(e => e.GilesGender)
                    .HasColumnName("giles_gender")
                    .HasMaxLength(255);

                entity.Property(e => e.InterorbitalBreadth).HasColumnName("interorbital_breadth");

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.MaximumCranialBreadth).HasColumnName("maximum_cranial_breadth");

                entity.Property(e => e.MaximumCranialLength).HasColumnName("maximum_cranial_length");

                entity.Property(e => e.MaximumNasalBreadth).HasColumnName("maximum_nasal_breadth");

                entity.Property(e => e.NasionProsthion).HasColumnName("nasion-prosthion");

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");
            });

            modelBuilder.Entity<Main>(entity =>
            {
                entity.HasKey(e => e.BurialId)
                    .HasName("burial_ID");

                entity.ToTable("Main$");

                entity.Property(e => e.BurialId)
                    .HasColumnName("burial_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ArtifactFound).HasColumnName("artifact_found");

                entity.Property(e => e.ArtifactsDescription)
                    .HasColumnName("artifacts_description")
                    .HasMaxLength(255);

                entity.Property(e => e.BasilarSuture)
                    .HasColumnName("basilar_suture")
                    .HasMaxLength(255);

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("basion_bregma_height");

                entity.Property(e => e.BasionNasion).HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("basion_prosthion_length");

                entity.Property(e => e.BizygomaticDiameter).HasColumnName("bizygomatic_diameter");

                entity.Property(e => e.BoneLength)
                    .HasColumnName("bone_length")
                    .HasMaxLength(255);

                entity.Property(e => e.BoneTaken).HasColumnName("bone_taken");

                entity.Property(e => e.BurialDepth).HasColumnName("burial_depth");

                entity.Property(e => e.BurialLocationEw)
                    .HasColumnName("burial_location_EW")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialLocationNs)
                    .HasColumnName("burial_location_NS")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialSituation).HasColumnName("burial_situation");

                entity.Property(e => e.BurialSubplot)
                    .HasColumnName("burial_subplot")
                    .HasMaxLength(255);

                entity.Property(e => e.CranialSuture)
                    .HasColumnName("cranial_suture")
                    .HasMaxLength(255);

                entity.Property(e => e.DayFound)
                    .HasColumnName("day_found")
                    .HasMaxLength(255);

                entity.Property(e => e.DescriptionOfTaken)
                    .HasColumnName("description_of_taken")
                    .HasMaxLength(255);

                entity.Property(e => e.DorsalPitting).HasColumnName("dorsal_pitting");

                entity.Property(e => e.EpiphysealUnion)
                    .HasColumnName("epiphyseal_union")
                    .HasMaxLength(255);

                entity.Property(e => e.EstimateAge)
                    .HasColumnName("estimate_age")
                    .HasMaxLength(255);

                entity.Property(e => e.EstimateLivingStature).HasColumnName("estimate_living_stature");

                entity.Property(e => e.FemurDiameter)
                    .HasColumnName("femur_diameter")
                    .HasMaxLength(255);

                entity.Property(e => e.FemurHead).HasColumnName("femur_head");

                entity.Property(e => e.FemurLength).HasColumnName("femur_length");

                entity.Property(e => e.ForemanMagnum)
                    .HasColumnName("foreman_magnum")
                    .HasMaxLength(255);

                entity.Property(e => e.GeFunctionTotal).HasColumnName("GE_function_total");

                entity.Property(e => e.GenderBodyCol)
                    .HasColumnName("gender_body_col")
                    .HasMaxLength(255);

                entity.Property(e => e.GenderGe)
                    .HasColumnName("gender_GE")
                    .HasMaxLength(255);

                entity.Property(e => e.Gonian).HasColumnName("gonian");

                entity.Property(e => e.HairColor)
                    .HasColumnName("hair_color")
                    .HasMaxLength(255);

                entity.Property(e => e.HairTaken).HasColumnName("hair_taken");

                entity.Property(e => e.HeadDirection)
                    .HasColumnName("head_direction")
                    .HasMaxLength(255);

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_EW");

                entity.Property(e => e.HighPairNs).HasColumnName("high_pair_NS");

                entity.Property(e => e.Humerus)
                    .HasColumnName("humerus")
                    .HasMaxLength(255);

                entity.Property(e => e.HumerusHead).HasColumnName("humerus_head");

                entity.Property(e => e.HumerusLength).HasColumnName("humerus_length");

                entity.Property(e => e.IliacCrest)
                    .HasColumnName("iliac_crest")
                    .HasMaxLength(255);

                entity.Property(e => e.InterorbitalBreadth).HasColumnName("interorbital_breadth");

                entity.Property(e => e.LengthOfRemains).HasColumnName("length_of_remains");

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.MaximumCranialBreadth).HasColumnName("maximum_cranial_breadth");

                entity.Property(e => e.MaximumCranialLength).HasColumnName("maximum_cranial_length");

                entity.Property(e => e.MaximumNasalBreadth).HasColumnName("maximum_nasal_breadth");

                entity.Property(e => e.MedialClavicle)
                    .HasColumnName("medial_clavicle")
                    .HasMaxLength(255);

                entity.Property(e => e.MedialIpRamus).HasColumnName("medial_IP_ramus");

                entity.Property(e => e.MonthFound)
                    .HasColumnName("month_found")
                    .HasMaxLength(255);

                entity.Property(e => e.NasionProsthion).HasColumnName("nasion_prosthion");

                entity.Property(e => e.NuchalCrest).HasColumnName("nuchal_crest");

                entity.Property(e => e.OrbitEdge).HasColumnName("orbit_edge");

                entity.Property(e => e.Osteophytosis)
                    .HasColumnName("osteophytosis")
                    .HasMaxLength(255);

                entity.Property(e => e.ParietalBossing).HasColumnName("parietal_bossing");

                entity.Property(e => e.PathologyAnomalies)
                    .HasColumnName("pathology_anomalies")
                    .HasMaxLength(255);

                entity.Property(e => e.PreaurSulcus).HasColumnName("preaur_sulcus");

                entity.Property(e => e.PreservationIndex)
                    .HasColumnName("preservation_index")
                    .HasMaxLength(255);

                entity.Property(e => e.PubicBone).HasColumnName("pubic_bone");

                entity.Property(e => e.PubicSymphysis)
                    .HasColumnName("pubic_symphysis")
                    .HasMaxLength(255);

                entity.Property(e => e.Robust).HasColumnName("robust");

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");

                entity.Property(e => e.SciaticNotch).HasColumnName("sciatic_notch");

                entity.Property(e => e.SoftTissueTaken).HasColumnName("soft_tissue_taken");

                entity.Property(e => e.SouthToFeet).HasColumnName("south_to_feet");

                entity.Property(e => e.SouthToHead).HasColumnName("south_to_head");

                entity.Property(e => e.SubpubicAngle).HasColumnName("subpubic_angle");

                entity.Property(e => e.SupraorbitalRidges).HasColumnName("supraorbital_ridges");

                entity.Property(e => e.TextileTaken).HasColumnName("textile_taken");

                entity.Property(e => e.TibiaLength).HasColumnName("tibia_length");

                entity.Property(e => e.ToothAttrition)
                    .HasColumnName("tooth_attrition")
                    .HasMaxLength(255);

                entity.Property(e => e.ToothEruption)
                    .HasColumnName("tooth_eruption")
                    .HasMaxLength(255);

                entity.Property(e => e.ToothTaken).HasColumnName("tooth_taken");

                entity.Property(e => e.VentralArc).HasColumnName("ventral_arc");

                entity.Property(e => e.WestToFeet).HasColumnName("west_to_feet");

                entity.Property(e => e.WestToHead).HasColumnName("west_to_head");

                entity.Property(e => e.YearFound)
                    .HasColumnName("year_found")
                    .HasMaxLength(255);

                entity.Property(e => e.ZygomaticCrest).HasColumnName("zygomatic_crest");
            });

            modelBuilder.Entity<Oracle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Oracle$");

                entity.Property(e => e.AgeAtDeath)
                    .HasColumnName("age_at_death")
                    .HasMaxLength(255);

                entity.Property(e => e.AgeMethod)
                    .HasColumnName("age_method")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialIcon)
                    .HasColumnName("burial_icon")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialIcon2)
                    .HasColumnName("burial_icon_2")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialId)
                    .HasColumnName("burial_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialLocationEw)
                    .HasColumnName("burial_location_EW")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialLocationNs)
                    .HasColumnName("burial_location_NS")
                    .HasMaxLength(255);

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialSubplot)
                    .HasColumnName("burial_subplot")
                    .HasMaxLength(255);

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.Gamous).HasColumnName("gamous");

                entity.Property(e => e.HairColor)
                    .HasColumnName("hair_color")
                    .HasMaxLength(255);

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_EW");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_NS");

                entity.Property(e => e.Preservation)
                    .HasColumnName("preservation")
                    .HasMaxLength(255);

                entity.Property(e => e.Sample)
                    .HasColumnName("sample")
                    .HasMaxLength(255);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(255);

                entity.Property(e => e.SexMethod)
                    .HasColumnName("sex_method")
                    .HasMaxLength(255);

                entity.Property(e => e.SouthToFeet).HasColumnName("south_to_feet");

                entity.Property(e => e.SouthToHead).HasColumnName("south_to_head");

                entity.Property(e => e.WestToFeet).HasColumnName("west_to_feet");

                entity.Property(e => e.WestToHead).HasColumnName("west_to_head");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
