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
        public int HeightSeed { get; set; } = 1000;

        // A dictionary to store the settings for each race and gender
        // The key is a string of the form "Race", e.g. "NordRace"
        // the "Default" entry is not an actual race but is used as the default if ScaleEverything is toggled on
        // The value is an instance of BaseSettings
        [SynthesisSettingName("Race and Gender Settings")]
        public Dictionary<string, BaseSettings> RaceGenderSettings { get; set; } = new()
        {
            { "Default",            new() { MinMaleHeightScale = 0.800, MaxMaleHeightScale = 1.200, MinFemaleHeightScale = 0.775, MaxFemaleHeightScale = 1.175 } },
            { "DefaultRace",        new() { MinMaleHeightScale = 0.800, MaxMaleHeightScale = 1.200, MinFemaleHeightScale = 0.775, MaxFemaleHeightScale = 1.175 } },
            { "ElderRace",          new() { MinMaleHeightScale = 0.800, MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 0.775, MaxFemaleHeightScale = 1.100 } },

            { "HighElfRace",        new() { MinMaleHeightScale = 1.050, MaxMaleHeightScale = 1.300, MinFemaleHeightScale = 1.025, MaxFemaleHeightScale = 1.275 } },
            { "OrcRace",            new() { MinMaleHeightScale = 1.025, MaxMaleHeightScale = 1.275, MinFemaleHeightScale = 1.000, MaxFemaleHeightScale = 1.250 } },
            { "NordRace",           new() { MinMaleHeightScale = 1.000, MaxMaleHeightScale = 1.250, MinFemaleHeightScale = 0.975, MaxFemaleHeightScale = 1.225 } },
            { "NordRaceChild",      new() { MinMaleHeightScale = 1.000, MaxMaleHeightScale = 1.250, MinFemaleHeightScale = 0.975, MaxFemaleHeightScale = 1.225 } },
            { "RedguardRace",       new() { MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.225, MinFemaleHeightScale = 0.950, MaxFemaleHeightScale = 1.200 } },
            { "RedguardRaceChild",  new() { MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.225, MinFemaleHeightScale = 0.950, MaxFemaleHeightScale = 1.200 } },
            { "ArgonianRace",       new() { MinMaleHeightScale = 0.950, MaxMaleHeightScale = 1.200, MinFemaleHeightScale = 0.925, MaxFemaleHeightScale = 1.175 } },
            { "WoodElfRace",        new() { MinMaleHeightScale = 0.925, MaxMaleHeightScale = 1.175, MinFemaleHeightScale = 0.900, MaxFemaleHeightScale = 1.150 } },
            { "BretonRace",         new() { MinMaleHeightScale = 0.900, MaxMaleHeightScale = 1.150, MinFemaleHeightScale = 0.875, MaxFemaleHeightScale = 1.125 } },
            { "BretonRaceChild",    new() { MinMaleHeightScale = 0.900, MaxMaleHeightScale = 1.150, MinFemaleHeightScale = 0.875, MaxFemaleHeightScale = 1.125 } },
            { "ImperialRace",       new() { MinMaleHeightScale = 0.875, MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 0.850, MaxFemaleHeightScale = 1.100 } },
            { "ImperialRaceChild",  new() { MinMaleHeightScale = 0.875, MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 0.850, MaxFemaleHeightScale = 1.100 } },
            { "DarkElfRace",        new() { MinMaleHeightScale = 0.850, MaxMaleHeightScale = 1.100, MinFemaleHeightScale = 0.825, MaxFemaleHeightScale = 1.100 } },
            { "KhajiitRace",        new() { MinMaleHeightScale = 0.825, MaxMaleHeightScale = 1.075, MinFemaleHeightScale = 0.800, MaxFemaleHeightScale = 1.100 } }
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