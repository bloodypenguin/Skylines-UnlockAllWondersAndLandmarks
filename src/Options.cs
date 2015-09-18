using System;
using System.IO;
using System.Xml.Serialization;
using Debug = UnityEngine.Debug;

namespace UnlockAllWondersAndLandmarks
{

    [Flags]
    public enum ModOption : long
    {
        None = 0,
        UniqueBuildings = 1,
        DeluxeLandmarks = 2,
        EuroLandmarks = 4,
        Wonders = 8,
        AfterDarkLandmarks = 16
    }

    public struct OptionsDTO
    {
        public bool unlockUniqueBuildings;
        public bool unlockDeluxeLandmarks;
        public bool unlockEuroLandmarks;
        public bool unlockWonders;
        public bool unlockAfterDarkLandmarks;
    }

    public static class OptionsHolder
    {
        public static ModOption Options = ModOption.None;
    }

    public static class OptionsLoader
    {
        public const string CONFIG_NAME = "CSL-UnlockAllWondersAndLandmarks.xml";

        public static void LoadOptions()
        {
            OptionsHolder.Options = ModOption.None;
            OptionsDTO options;
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(OptionsDTO));
                using (var streamReader = new StreamReader(CONFIG_NAME))
                {
                    options = (OptionsDTO)xmlSerializer.Deserialize(streamReader);
                }
            }
            catch (FileNotFoundException)
            {
                options = new OptionsDTO
                {
                    unlockUniqueBuildings = true,
                    unlockDeluxeLandmarks = true,
                    unlockEuroLandmarks = true,
                    unlockWonders = true,
                    unlockAfterDarkLandmarks = false
                };
                SaveOptions(options);
                // No options file yet
            }
            catch (Exception e)
            {
                Debug.LogError("Unexpected " + e.GetType().Name + " loading options: " + e.Message + "\n" + e.StackTrace);
                return;
            }
            if (options.unlockUniqueBuildings)
                OptionsHolder.Options |= ModOption.UniqueBuildings;
            if (options.unlockDeluxeLandmarks)
                OptionsHolder.Options |= ModOption.DeluxeLandmarks;
            if (options.unlockEuroLandmarks)
                OptionsHolder.Options |= ModOption.EuroLandmarks;
            if (options.unlockWonders)
                OptionsHolder.Options |= ModOption.Wonders;
            if (options.unlockAfterDarkLandmarks)
                OptionsHolder.Options |= ModOption.AfterDarkLandmarks;
        }

        public static void SaveOptions()
        {
            OptionsDTO options = new OptionsDTO();
            if ((OptionsHolder.Options & ModOption.UniqueBuildings) != 0)
            {
                options.unlockUniqueBuildings = true;
            }
            if ((OptionsHolder.Options & ModOption.DeluxeLandmarks) != 0)
            {
                options.unlockDeluxeLandmarks = true;
            }
            if ((OptionsHolder.Options & ModOption.EuroLandmarks) != 0)
            {
                options.unlockEuroLandmarks = true;
            }
            if ((OptionsHolder.Options & ModOption.Wonders) != 0)
            {
                options.unlockWonders = true;
            }
            if ((OptionsHolder.Options & ModOption.AfterDarkLandmarks) != 0)
            {
                options.unlockAfterDarkLandmarks = true;
            }
            SaveOptions(options);
        }

        public static void SaveOptions(OptionsDTO options)
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(OptionsDTO));
                using (var streamWriter = new StreamWriter(CONFIG_NAME))
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