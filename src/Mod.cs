using ICities;
using UnlockAllWondersAndLandmarks.OptionsFramework.Extensions;

namespace UnlockAllWondersAndLandmarks
{
    public class Mod : IUserMod
    {
        public string Name => "Unlock All + Wonders & Landmarks";

        public string Description => "Unlock all + Wonders & Landmarks from beginning";

        public void OnSettingsUI(UIHelperBase helper)
        {
            helper.AddOptionsGroup<Options>();
        }
    }
}
