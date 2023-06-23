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

        // A dictionary to store the settings for each race and gender
        // The key is a string of the form "Race_Gender", e.g. "NordRace_Male"
        // The value is an instance of RaceGenderSettings
        [SynthesisSettingName("Race and Gender Settings")]
        public Dictionary<string, BaseSettings> RaceGenderSettings { get; set; } = new()
        {
            { "HighElfRace",    new() { MinMaleHeightScale = 1.050, MaxMaleHeightScale = 1.300, MinFemaleHeightScale = 1.025, MaxFemaleHeightScale = 1.275 } },
            { "OrcRace",        new() { MinMaleHeightScale = 1.025, MaxMaleHeightScale = 1.275, MinFemaleHeightScale = 1.000, MaxFemaleHeightScale = 1.250 } },
            { "NordRace",       new() { MinMaleHeightScale = 1.000, MaxMaleHeightScale = 1.250, MinFemaleHeightScale = 0.975, MaxFemaleHeightScale = 1.225 } },
            { "RedguardRace",   new() { MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.225, MinFemaleHeightScale = 0.950, MaxFemaleHeightScale = 1.200 } },
            { "ArgonianRace",   new() { MinMaleHeightScale = 0.950, MaxMaleHeightScale = 1.200, MinFemaleHeightScale = 0.925, MaxFemaleHeightScale = 1.175 } },
            { "WoodElfRace",    new() { MinMaleHeightScale = 0.925, MaxMaleHeightScale = 1.175, MinFemaleHeightScale = 0.900, MaxFemaleHeightScale = 1.150 } },
            { "BretonRace",     new() { MinMaleHeightScale = 0.900, MaxMaleHeightScale = 1.150, MinFemaleHeightScale = 0.875, MaxFemaleHeightScale = 1.125 } },
            { "ImperialRace",   new() { MinMaleHeightScale = 0.875, MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 0.850, MaxFemaleHeightScale = 1.100 } },
            { "DarkElfRace",    new() { MinMaleHeightScale = 0.850, MaxMaleHeightScale = 1.100, MinFemaleHeightScale = 0.825, MaxFemaleHeightScale = 1.100 } },
            { "KhajiitRace",    new() { MinMaleHeightScale = 0.825, MaxMaleHeightScale = 1.075, MinFemaleHeightScale = 0.800, MaxFemaleHeightScale = 1.100 } },

            { "ElderRace",      new() { MinMaleHeightScale = 0.800, MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 0.775, MaxFemaleHeightScale = 1.100 } },
            { "NordRaceChild",  new() { MinMaleHeightScale = 1.000, MaxMaleHeightScale = 1.250, MinFemaleHeightScale = 0.975, MaxFemaleHeightScale = 1.225 } }
        };

        [SynthesisSettingName("Also patch player record")]
        public bool PatchPlayerRecord { get; set; } = false;

        [SynthesisSettingName("Only change the height where it was set to the default value")]
        [SynthesisDescription("Preserve the intended height for actors who have a non-defaulted height by only changing the ones that have a height of 1")]
        [SynthesisTooltip("Preserve the intended height for actors who have a non-defaulted height by only changing the ones that have a height of 1")]
        public bool OnlyReplaceDefaulted { get; set; } = false;

        [SynthesisSettingName("Scale everything (potentially unstable)")]
        [SynthesisDescription("Uses the ranges underneath to set the height for NPC configurations not defined above")]
        [SynthesisTooltip("Uses the ranges underneath to set the height for NPC configurations not defined above")]
        public bool ScaleEverything { get; set; } = false;
        
        [SynthesisSettingName("Minimum height")]
        public double MinHeightScale { get; set; } = 0.8;

        [SynthesisSettingName("Maximum height")]
        public double MaxHeightScale { get; set; } = 1.2;

        [SynthesisSettingName("(Debug) Show unpatched actors in logs")]
        public bool ShowDebugLogs { get; set; } = false;
    }
}