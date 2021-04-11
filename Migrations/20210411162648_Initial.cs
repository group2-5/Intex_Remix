using Microsoft.EntityFrameworkCore.Migrations;

namespace Intex_Remix.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bio$",
                columns: table => new
                {
                    burial_ID = table.Column<string>(maxLength: 255, nullable: true),
                    burial_location_NS = table.Column<string>(maxLength: 255, nullable: true),
                    low_pair_NS = table.Column<double>(nullable: true),
                    burial_location_EW = table.Column<string>(maxLength: 255, nullable: true),
                    low_pair_EW = table.Column<double>(nullable: true),
                    burial_subplot = table.Column<string>(maxLength: 255, nullable: true),
                    burial_number = table.Column<double>(nullable: true),
                    rack_ = table.Column<double>(name: "rack_#", nullable: true),
                    bag_ = table.Column<string>(name: "bag_#", maxLength: 255, nullable: true),
                    cluster_ = table.Column<string>(name: "cluster_#", maxLength: 255, nullable: true),
                    date = table.Column<string>(maxLength: 255, nullable: true),
                    previously_sampled = table.Column<string>(maxLength: 255, nullable: true),
                    notes = table.Column<string>(maxLength: 255, nullable: true),
                    initials = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Carbon$",
                columns: table => new
                {
                    burial_ID = table.Column<string>(maxLength: 255, nullable: true),
                    rack_a = table.Column<double>(nullable: true),
                    low_pair_NS = table.Column<double>(nullable: true),
                    burial_location_NS = table.Column<string>(maxLength: 255, nullable: true),
                    low_pair_EW = table.Column<double>(nullable: true),
                    burial_location_EW = table.Column<string>(maxLength: 255, nullable: true),
                    burial_subplot = table.Column<string>(maxLength: 255, nullable: true),
                    area = table.Column<string>(maxLength: 255, nullable: true),
                    burial_number = table.Column<double>(nullable: true),
                    rack_b = table.Column<double>(nullable: true),
                    tube_number = table.Column<double>(nullable: true),
                    description = table.Column<string>(maxLength: 255, nullable: true),
                    size_ml = table.Column<double>(name: "size_(ml)", nullable: true),
                    foci = table.Column<double>(nullable: true),
                    c14_sample_2017 = table.Column<double>(nullable: true),
                    location = table.Column<string>(maxLength: 255, nullable: true),
                    questions = table.Column<string>(maxLength: 255, nullable: true),
                    F18 = table.Column<double>(nullable: true),
                    conventional_14c_age_BP = table.Column<double>(nullable: true),
                    _14c_calendar_date = table.Column<string>(name: "14c_calendar_date", maxLength: 255, nullable: true),
                    calibrated_95_calendar_date_max = table.Column<string>(name: "calibrated_95%_calendar_date_max", maxLength: 255, nullable: true),
                    calibrated_95_calendar_date_min = table.Column<string>(name: "calibrated_95%_calendar_date_min", maxLength: 255, nullable: true),
                    calibrated_95_calendar_date_span = table.Column<double>(name: "calibrated_95%_calendar_date_span", nullable: true),
                    calibrated_95_calendar_date_avg = table.Column<string>(name: "calibrated_95%_calendar_date_avg", maxLength: 255, nullable: true),
                    category = table.Column<string>(maxLength: 255, nullable: true),
                    notes = table.Column<string>(maxLength: 255, nullable: true),
                    F27 = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Cranial$",
                columns: table => new
                {
                    burial_ID = table.Column<string>(maxLength: 255, nullable: true),
                    burial_location_NS = table.Column<string>(maxLength: 255, nullable: true),
                    low_pair_NS = table.Column<double>(nullable: true),
                    burial_location_EW = table.Column<string>(maxLength: 255, nullable: true),
                    low_pair_EW = table.Column<double>(nullable: true),
                    burial_subplot = table.Column<string>(maxLength: 255, nullable: true),
                    burial_number = table.Column<double>(nullable: true),
                    sample_number = table.Column<double>(nullable: true),
                    maximum_cranial_length = table.Column<double>(nullable: true),
                    maximum_cranial_breadth = table.Column<double>(nullable: true),
                    basionbregma_height = table.Column<double>(name: "basion-bregma_height", nullable: true),
                    basionnasion = table.Column<double>(name: "basion-nasion", nullable: true),
                    basionprosthion_length = table.Column<double>(name: "basion-prosthion_length", nullable: true),
                    bizygomatic_diameter = table.Column<double>(nullable: true),
                    nasionprosthion = table.Column<double>(name: "nasion-prosthion", nullable: true),
                    maximum_nasal_breadth = table.Column<double>(nullable: true),
                    interorbital_breadth = table.Column<double>(nullable: true),
                    burial_depth = table.Column<double>(nullable: true),
                    burialartifact_description = table.Column<string>(name: "burial/artifact_description", maxLength: 255, nullable: true),
                    buried_with_artifacts = table.Column<bool>(nullable: false),
                    giles_gender = table.Column<string>(maxLength: 255, nullable: true),
                    body_gender = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Main$",
                columns: table => new
                {
                    burial_ID = table.Column<string>(maxLength: 255, nullable: false),
                    burial_location_NS = table.Column<string>(maxLength: 255, nullable: true),
                    burial_location_EW = table.Column<string>(maxLength: 255, nullable: true),
                    low_pair_NS = table.Column<double>(nullable: true),
                    high_pair_NS = table.Column<double>(nullable: true),
                    low_pair_EW = table.Column<double>(nullable: true),
                    high_pair_EW = table.Column<double>(nullable: true),
                    burial_subplot = table.Column<string>(maxLength: 255, nullable: true),
                    burial_depth = table.Column<double>(nullable: true),
                    south_to_head = table.Column<double>(nullable: true),
                    south_to_feet = table.Column<double>(nullable: true),
                    west_to_head = table.Column<double>(nullable: true),
                    west_to_feet = table.Column<double>(nullable: true),
                    burial_situation = table.Column<string>(nullable: true),
                    length_of_remains = table.Column<double>(nullable: true),
                    burial_number = table.Column<double>(nullable: true),
                    sample_number = table.Column<double>(nullable: true),
                    gender_GE = table.Column<string>(maxLength: 255, nullable: true),
                    GE_function_total = table.Column<double>(nullable: true),
                    gender_body_col = table.Column<string>(maxLength: 255, nullable: true),
                    basilar_suture = table.Column<string>(maxLength: 255, nullable: true),
                    ventral_arc = table.Column<double>(nullable: true),
                    subpubic_angle = table.Column<double>(nullable: true),
                    sciatic_notch = table.Column<double>(nullable: true),
                    pubic_bone = table.Column<double>(nullable: true),
                    preaur_sulcus = table.Column<double>(nullable: true),
                    medial_IP_ramus = table.Column<double>(nullable: true),
                    dorsal_pitting = table.Column<double>(nullable: true),
                    foreman_magnum = table.Column<string>(maxLength: 255, nullable: true),
                    femur_head = table.Column<double>(nullable: true),
                    humerus_head = table.Column<double>(nullable: true),
                    osteophytosis = table.Column<string>(maxLength: 255, nullable: true),
                    pubic_symphysis = table.Column<string>(maxLength: 255, nullable: true),
                    bone_length = table.Column<string>(maxLength: 255, nullable: true),
                    medial_clavicle = table.Column<string>(maxLength: 255, nullable: true),
                    iliac_crest = table.Column<string>(maxLength: 255, nullable: true),
                    femur_diameter = table.Column<string>(maxLength: 255, nullable: true),
                    humerus = table.Column<string>(maxLength: 255, nullable: true),
                    femur_length = table.Column<double>(nullable: true),
                    humerus_length = table.Column<double>(nullable: true),
                    tibia_length = table.Column<double>(nullable: true),
                    robust = table.Column<double>(nullable: true),
                    supraorbital_ridges = table.Column<double>(nullable: true),
                    orbit_edge = table.Column<double>(nullable: true),
                    parietal_bossing = table.Column<double>(nullable: true),
                    gonian = table.Column<double>(nullable: true),
                    nuchal_crest = table.Column<double>(nullable: true),
                    zygomatic_crest = table.Column<double>(nullable: true),
                    cranial_suture = table.Column<string>(maxLength: 255, nullable: true),
                    maximum_cranial_length = table.Column<double>(nullable: true),
                    maximum_cranial_breadth = table.Column<double>(nullable: true),
                    basion_bregma_height = table.Column<double>(nullable: true),
                    basion_nasion = table.Column<double>(nullable: true),
                    basion_prosthion_length = table.Column<double>(nullable: true),
                    bizygomatic_diameter = table.Column<double>(nullable: true),
                    nasion_prosthion = table.Column<double>(nullable: true),
                    maximum_nasal_breadth = table.Column<double>(nullable: true),
                    interorbital_breadth = table.Column<double>(nullable: true),
                    artifacts_description = table.Column<string>(maxLength: 255, nullable: true),
                    hair_color = table.Column<string>(maxLength: 255, nullable: true),
                    preservation_index = table.Column<string>(maxLength: 255, nullable: true),
                    hair_taken = table.Column<bool>(nullable: false),
                    soft_tissue_taken = table.Column<bool>(nullable: false),
                    bone_taken = table.Column<bool>(nullable: false),
                    tooth_taken = table.Column<bool>(nullable: false),
                    textile_taken = table.Column<bool>(nullable: false),
                    description_of_taken = table.Column<string>(maxLength: 255, nullable: true),
                    artifact_found = table.Column<bool>(nullable: false),
                    estimate_age = table.Column<string>(maxLength: 255, nullable: true),
                    estimate_living_stature = table.Column<double>(nullable: true),
                    tooth_attrition = table.Column<string>(maxLength: 255, nullable: true),
                    tooth_eruption = table.Column<string>(maxLength: 255, nullable: true),
                    pathology_anomalies = table.Column<string>(maxLength: 255, nullable: true),
                    epiphyseal_union = table.Column<string>(maxLength: 255, nullable: true),
                    year_found = table.Column<string>(maxLength: 255, nullable: true),
                    month_found = table.Column<string>(maxLength: 255, nullable: true),
                    day_found = table.Column<string>(maxLength: 255, nullable: true),
                    head_direction = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("burial_ID", x => x.burial_ID);
                });

            migrationBuilder.CreateTable(
                name: "Oracle$",
                columns: table => new
                {
                    burial_ID = table.Column<string>(maxLength: 255, nullable: true),
                    gamous = table.Column<double>(nullable: true),
                    low_pair_NS = table.Column<double>(nullable: true),
                    burial_location_NS = table.Column<string>(maxLength: 255, nullable: true),
                    low_pair_EW = table.Column<double>(nullable: true),
                    burial_location_EW = table.Column<string>(maxLength: 255, nullable: true),
                    burial_subplot = table.Column<string>(maxLength: 255, nullable: true),
                    burial_number = table.Column<double>(nullable: true),
                    west_to_head = table.Column<double>(nullable: true),
                    west_to_feet = table.Column<double>(nullable: true),
                    south_to_head = table.Column<double>(nullable: true),
                    south_to_feet = table.Column<double>(nullable: true),
                    depth = table.Column<double>(nullable: true),
                    preservation = table.Column<string>(maxLength: 255, nullable: true),
                    burial_icon = table.Column<string>(maxLength: 255, nullable: true),
                    burial_icon_2 = table.Column<string>(maxLength: 255, nullable: true),
                    sex = table.Column<string>(maxLength: 255, nullable: true),
                    sex_method = table.Column<string>(maxLength: 255, nullable: true),
                    age_at_death = table.Column<string>(maxLength: 255, nullable: true),
                    age_method = table.Column<string>(maxLength: 255, nullable: true),
                    hair_color = table.Column<string>(maxLength: 255, nullable: true),
                    sample = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bio$");

            migrationBuilder.DropTable(
                name: "Carbon$");

            migrationBuilder.DropTable(
                name: "Cranial$");

            migrationBuilder.DropTable(
                name: "Main$");

            migrationBuilder.DropTable(
                name: "Oracle$");
        }
    }
}
