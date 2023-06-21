using Mutagen.Bethesda.Synthesis.Settings;

namespace VariedHeights
{
    public class Settings
    {
        private double _minHeightScale { get; set; } = 0.8f;
        [SynthesisSettingName("Minimum NPC Height")]
        [SynthesisTooltip("Minimum height for NPCs.")]
        public double MinHeightScale { 
            get
            {
                return _minHeightScale;
            }
            set
            {
                _minHeightScale = Math.Max(value, 0.0);
            }
        }


        private double _maxHeightScale { get; set; } = 1.2f;
        [SynthesisSettingName("Maximum NPC Height")]
        [SynthesisTooltip("Maximum height for NPCs.")]
        public double MaxHeightScale {
            get
            {
                return _maxHeightScale;
            }
            set
            {
                _maxHeightScale = Math.Max(value, 0.0);
                if (_maxHeightScale > 0.0)
                    _maxHeightScale = Math.Max(_minHeightScale, _maxHeightScale);
            }
        }

        [SynthesisSettingName("Ignore Player Record")]
public bool IgnorePlayerRecord { get; set; } = true;
    }
}