using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis.Settings;

namespace NPCVariance
{
    // A class to store the settings for each race and gender
    public class BaseSettings
    {
        
        [SynthesisSettingName("Minimum Male Height")]
        public double MinMaleHeightScale { get; set; } = 0.8;

        [SynthesisSettingName("Maximum Male Height")]
        public double MaxMaleHeightScale { get; set; } = 1.2;
        
        [SynthesisSettingName("Minimum Female Height")]
        public double MinFemaleHeightScale { get; set; } = 0.775;

        [SynthesisSettingName("Maximum Female Height")]
        public double MaxFemaleHeightScale { get; set; } = 1.175;
    }
    public class Settings
    {
        // Your new setting for height randomization seed
        [SynthesisSettingName("Seed")]
        [SynthesisDescription("The seed used for randomizing the height of NPCs.")]
        [SynthesisTooltip("A higher seed value will result in more variation in height.")]
        public int HeightSeed { get; set; } = 100000;

        // A dictionary to store the settings for each race and gender
        // The key is a string of the form "Race", e.g. "NordRace"
        // the "Default" entry is not an actual race but is used as the default if ScaleEverything is toggled on
        // The value is an instance of BaseSettings
        [SynthesisSettingName("Race and Gender Settings")]
        public Dictionary<string, BaseSettings> RaceGenderSettings { get; set; } = new() {
            {"Default", new() {
                    MinMaleHeightScale = 0.9,   MaxMaleHeightScale = 1.2,   MinFemaleHeightScale = 0.775,   MaxFemaleHeightScale = 1.175}},
            {"DefaultRace", new() {
                    MinMaleHeightScale = 0.95,  MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 0.9, MaxFemaleHeightScale = 1.1}},
            {"ElderRace", new() {
                    MinMaleHeightScale = 0.95,  MaxMaleHeightScale = 1.025, MinFemaleHeightScale = 0.95,    MaxFemaleHeightScale = 1.0}},
                    
            {"HighElfRace", new() {
                    MinMaleHeightScale = 1.05,  MaxMaleHeightScale = 1.175, MinFemaleHeightScale = 1.075,   MaxFemaleHeightScale = 1.2}},
            {"HighElfRaceVampire", new() {
                    MinMaleHeightScale = 1.05,  MaxMaleHeightScale = 1.175, MinFemaleHeightScale = 1.075,   MaxFemaleHeightScale = 1.2}},
            {"OrcRace", new() {
                    MinMaleHeightScale = 1.0,   MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 1.05,    MaxFemaleHeightScale = 1.125}},
            {"OrcRaceVampire", new() {
                    MinMaleHeightScale = 1.0,   MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 1.05,    MaxFemaleHeightScale = 1.125}},
            {"NordRace", new() {
                    MinMaleHeightScale = 1.05,  MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 1.0, MaxFemaleHeightScale = 1.15}},
            {"NordRaceVampire", new() {
                    MinMaleHeightScale = 1.05,  MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 1.0, MaxFemaleHeightScale = 1.15}},
            {"NordRaceChild", new() {
                    MinMaleHeightScale = 0.9,   MaxMaleHeightScale = 1.0,   MinFemaleHeightScale = 0.95,    MaxFemaleHeightScale = 1.0}},
            {"ArgonianRace", new() {
                    MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.1,   MinFemaleHeightScale = 1.0, MaxFemaleHeightScale = 1.125}},
            {"ArgonianRaceVampire", new() {
                    MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.1,   MinFemaleHeightScale = 1.0, MaxFemaleHeightScale = 1.125}},
            {"RedguardRace", new() {
                    MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.1,   MinFemaleHeightScale = 0.95,    MaxFemaleHeightScale = 1.1}},
            {"RedguardRaceVampire", new() {
                    MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.1,   MinFemaleHeightScale = 0.95,    MaxFemaleHeightScale = 1.1}},
            {"RedguardRaceChild", new() {
                    MinMaleHeightScale = 0.9,   MaxMaleHeightScale = 0.975, MinFemaleHeightScale = 0.95,    MaxFemaleHeightScale = 1.0}},
            {"WoodElfRace", new() {
                    MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.075, MinFemaleHeightScale = 0.9, MaxFemaleHeightScale = 1.05}},
            {"WoodElfRaceVampire", new() {
                    MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.075, MinFemaleHeightScale = 0.9, MaxFemaleHeightScale = 1.05}},
            {"BretonRace", new() {
                    MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.05,  MinFemaleHeightScale = 0.975,   MaxFemaleHeightScale = 1.025}},
            {"BretonRaceVampire", new() {
                    MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.05,  MinFemaleHeightScale = 0.975,   MaxFemaleHeightScale = 1.025}},
            {"BretonRaceChild", new() {
                    MinMaleHeightScale = 0.9,   MaxMaleHeightScale = 1.0,   MinFemaleHeightScale = 0.975,   MaxFemaleHeightScale = 1.025}},
            {"ImperialRace", new() {
                    MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.05,  MinFemaleHeightScale = 0.975,   MaxFemaleHeightScale = 1.05}},
            {"ImperialRaceVampire", new() {
                    MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.05,  MinFemaleHeightScale = 0.975,   MaxFemaleHeightScale = 1.05}},
            {"ImperialRaceChild", new() {
                    MinMaleHeightScale = 0.95,  MaxMaleHeightScale = 1.025, MinFemaleHeightScale = 0.975,   MaxFemaleHeightScale = 1.075}},
            {"DarkElfRace", new() {
                    MinMaleHeightScale = 0.95,  MaxMaleHeightScale = 1.025, MinFemaleHeightScale = 0.925,   MaxFemaleHeightScale = 1.025}},
            {"DarkElfRaceVampire", new() {
                    MinMaleHeightScale = 0.95,  MaxMaleHeightScale = 1.025, MinFemaleHeightScale = 0.925,   MaxFemaleHeightScale = 1.025}},
            {"KhajiitRace", new() {
                    MinMaleHeightScale = 0.95,  MaxMaleHeightScale = 1.0,   MinFemaleHeightScale = 0.925,   MaxFemaleHeightScale = 1.0}},
            {"KhajiitRaceVampire", new() {
                    MinMaleHeightScale = 0.95,  MaxMaleHeightScale = 1.0,   MinFemaleHeightScale = 0.925,   MaxFemaleHeightScale = 1.0}},
            {"SnowElfRace", new() {
                    MinMaleHeightScale = 1.05,  MaxMaleHeightScale = 1.15,  MinFemaleHeightScale = 1.025,   MaxFemaleHeightScale = 1.175}},
            {"DA13AfflictedRace", new() {
                    MinMaleHeightScale = 0.925, MaxMaleHeightScale = 1.1,   MinFemaleHeightScale = 0.975,   MaxFemaleHeightScale = 1.125}}
        };

        [SynthesisSettingName("Also patch furniture to disable scaling")]
        [SynthesisDescription("Removes the RaceToScale keyword from furniture")]
        [SynthesisTooltip("NPCs will be visibly changing height otherwise")]
        public bool PatchFurniture { get; set; } = true;

        [SynthesisSettingName("Furniture Blacklist")]
        public List<IFormLinkGetter<IFurnitureGetter>> FurnitureBlacklist { get; set; } = new()
        {
            Skyrim.Furniture.CartFurniturePassenger,
        };

        [SynthesisSettingName("Also patch player record")]
        public bool PatchPlayerRecord { get; set; } = false;

        [SynthesisSettingName("Don't change custom heights")]
        [SynthesisDescription("If an NPC has a height value different from 1, it gets ignored when this is toggled")]
        [SynthesisTooltip("If an NPC has a height value different from 1, it gets ignored when this is toggled")]
        public bool OnlyReplaceDefaulted { get; set; } = false;

        [SynthesisSettingName("Scale everything (Uses 'Default' settings above)")]
        [SynthesisDescription("Uses the 'Default' preset above for every race that doesn't have settings set")]
        [SynthesisTooltip("Uses the 'Default' preset above for every race that doesn't have settings set")]
        public bool ScaleEverything { get; set; } = false;

        [SynthesisSettingName("(Debug) Show unpatched actors in logs")]
        public bool ShowDebugLogs { get; set; } = false;
    }
}