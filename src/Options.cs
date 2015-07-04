using System;
using System.IO;
using System.Xml.Serialization;
using Debug = UnityEngine.Debug;

namespace UnlockAllWondersAndLandmarks
{

    [Flags]
    public enum ModOptions : long
    {
        None = 0,
        UniqueBuildings = 1,
        DeluxeLandmarks = 2,
        EuroLandmarks = 4,
        Wonders = 8
    }

    public struct Options
    {
        public bool unlockUniqueBuildings;
        public bool unlockDeluxeLandmarks;
        public bool unlockEuroLandmarks;
        public bool unlockWonders;
    }

    public static class OptionsLoader
    {
        public static void LoadOptions()
        {
            UnlockAllWondersAndLandmarks.Options = ModOptions.None;
            Options options;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Options));
                using (StreamReader streamReader = new StreamReader("CSL-UnlockAllWondersAndLandmarks.xml"))
                {
                    options = (Options)xmlSerializer.Deserialize(streamReader);
                }
            }
            catch (FileNotFoundException)
            {
                options = new Options
                {
                    unlockUniqueBuildings = true,
                    unlockDeluxeLandmarks = true,
                    unlockEuroLandmarks = true,
                    unlockWonders = true
                };
                // No options file yet
            }
            catch (Exception e)
            {
                Debug.LogError("Unexpected " + e.GetType().Name + " loading options: " + e.Message + "\n" + e.StackTrace);
                return;
            }
            if (options.unlockUniqueBuildings)
                UnlockAllWondersAndLandmarks.Options |= ModOptions.UniqueBuildings;

            if (options.unlockDeluxeLandmarks)
                UnlockAllWondersAndLandmarks.Options |= ModOptions.DeluxeLandmarks;

            if (options.unlockEuroLandmarks)
                UnlockAllWondersAndLandmarks.Options |= ModOptions.EuroLandmarks;

            if (options.unlockWonders)
                UnlockAllWondersAndLandmarks.Options |= ModOptions.Wonders;
        }

        public static void SaveOptions()
        {
            Options options = new Options();
            if ((UnlockAllWondersAndLandmarks.Options & ModOptions.UniqueBuildings) != 0)
            {
                options.unlockUniqueBuildings = true;
            }
            if ((UnlockAllWondersAndLandmarks.Options & ModOptions.DeluxeLandmarks) != 0)
            {
                options.unlockDeluxeLandmarks = true;
            }
            if ((UnlockAllWondersAndLandmarks.Options & ModOptions.EuroLandmarks) != 0)
            {
                options.unlockEuroLandmarks = true;
            }
            if ((UnlockAllWondersAndLandmarks.Options & ModOptions.Wonders) != 0)
            {
                options.unlockWonders = true;
            }

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Options));
                using (StreamWriter streamWriter = new StreamWriter("CSL-UnlockAllWondersAndLandmarks.xml"))
                {
                    xmlSerializer.Serialize(streamWriter, options);
                }
            }
            catch (Exception e)
            {
                Debug.LogError("Unexpected " + e.GetType().Name + " saving options: " + e.Message + "\n" + e.StackTrace);
            }
        }
    }
}