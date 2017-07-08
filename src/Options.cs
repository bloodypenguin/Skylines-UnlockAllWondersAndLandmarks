using UnlockAllWondersAndLandmarks.OptionsFramework.Attibutes;

namespace UnlockAllWondersAndLandmarks
{
    [Options("UnlockAllWondersAndLandmarks.xml", "CSL-UnlockAllWondersAndLandmarks.xml")]
    public class Options
    {
        public Options()
        {
            unlockUniqueBuildings = true;
            unlockDeluxeLandmarks = true;
            unlockEuroLandmarks = true;
            unlockWonders = true;
            unlockAfterDarkLandmarks = false;
            unlockSnowfallLandmarks = false;
            unlockNaturalDisastersLandmarks = false;
        }

        [Checkbox("Unlock Unique Buildings(levels I - VI)")]
        public bool unlockUniqueBuildings { set; get; }
        [Checkbox("Unlock Deluxe Landmarks (req. Deluxe Edition)")]
        public bool unlockDeluxeLandmarks { set; get; }
        [Checkbox("Unlock European Landmarks (req. European biome / European Buildings Unlocker mod)")]
        public bool unlockEuroLandmarks { set; get; }
        [Checkbox("Unlock Wonders (a.k.a Monuments)")]
        public bool unlockWonders { set; get; }
        [Checkbox("Unlock After Dark Landmarks (a.k.a Tourism & Leisure, req. After Dark DLC)")]
        public bool unlockAfterDarkLandmarks { set; get; }
        [Checkbox("Unlock Snowfall Landmarks (req. Snowfall DLC + Winter biome/Winter Buildings Unlocker mod)")]
        public bool unlockSnowfallLandmarks { set; get; }

        [Checkbox("Unlock Natural Disasters Landmarks (req. Natural Disasters DLC)")]
        public bool unlockNaturalDisastersLandmarks { set; get; }
    }
}