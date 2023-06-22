using Mutagen.Bethesda.Synthesis.Settings;

namespace VariedHeights
{
    // A class to store the settings for each race and gender
    public class RaceGenderSettings
    {
        
        [SynthesisSettingName("Minimum NPC Height")]
        public double MinHeightScale { get; set; } = 0.8f;


        [SynthesisSettingName("Maximum NPC Height")]
        public double MaxHeightScale { get; set; } = 1.2f;
    }
    public class Settings
    {

        [SynthesisSettingName("Ignore Player Record")]
        public bool IgnorePlayerRecord { get; set; } = true;

        // A dictionary to store the settings for each race and gender
        // The key is a string of the form "Race_Gender", e.g. "NordRace_Male"
        // The value is an instance of RaceGenderSettings
        [SynthesisSettingName("Race and Gender Settings")]
        public Dictionary<string, RaceGenderSettings> RaceGenderSettings { get; set; } = new Dictionary<string, RaceGenderSettings>();
    }
}