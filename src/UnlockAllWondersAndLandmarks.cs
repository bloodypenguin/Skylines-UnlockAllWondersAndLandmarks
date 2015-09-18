using System;
using System.Collections.Generic;
using ColossalFramework;
using ICities;

namespace UnlockAllWondersAndLandmarks
{

    public class UnlockAllWondersAndLandmarks : MilestonesExtensionBase, IUserMod
    {
        public string Name
        {
            get
            {
                OptionsLoader.LoadOptions();
                return "Unlock All + Wonders & Landmarks";
            }
        }

        public string Description
        {
            get { return "Unlock all + Wonders & Landmarks from beginning"; }
        }



        public override void OnRefreshMilestones()
        {
            milestonesManager.UnlockMilestone("Basic Road Created");
            UnlockBuidlingsIfFlagIsSet(ModOption.AfterDarkLandmarks, new[]{
                //After Dark
                "Fancy Fountain",               
                "Casino",
                "Driving Range",
                "Luxury Hotel",
                "Zoo",
            });
             
            UnlockBuidlingsIfFlagIsSet(ModOption.DeluxeLandmarks, new[]{
                //Deluxe
                "Eiffel Tower",
                "Statue of Liberty",
                "Grand Central Terminal",
                "Brandenburg Gate",
                "Arc de Triomphe",
            });

            UnlockBuidlingsIfFlagIsSet(ModOption.Wonders, new[]{
                //Wonders
                "Hadron Collider",
                "Medical Center",
                "Space Elevator",
                "Eden Project",
                "Fusion Power Plant",
            });

            UnlockBuidlingsIfFlagIsSet(ModOption.EuroLandmarks, new[]{
                //European
                "Arena",
                "Shopping Center",
                "Theatre",
                "London Eye",
                "Cinema",
                "City Hall",
                "Amsterdam Palace",
                "Cathedral",
                "Government Offices",
                "Hypermarket",
                "Department Store",
                "Gherkin",
            });

            UnlockBuidlingsIfFlagIsSet(ModOption.UniqueBuildings, new[]{
                //UB-I
                "Statue of Industry",
                "Statue of Wealth",
                "Lazaret Plaza",
                "Statue of Shopping",
                "Plaza of the Dead",
                //UB-II
                "Fountain of LifeDeath",
                "Friendly Neighborhood",
                "Transport Tower",
                "Trash Mall",
                "Posh Mall",
                //UB-III
                "Colossal Offices",
                "Official Park",
                "CourtHouse",
                "Grand Mall",
                "Cityhall",
                //UB-IV
                "Business Park",
                "Library",
                "Observatory",
                "Opera House",
                "Oppression Office",
                //UB-V
                "ScienceCenter",
                "Servicing Services",
                "SeaWorld",
                "Expocenter",
                "High Interest Tower",
                //UB-VI
                "Cathedral of Plentitude",
                "Stadium",
                "Modern Art Museum",
                "SeaAndSky Scraper",
                "Theater of Wonders",
            });

        }

        private void UnlockBuidlingsIfFlagIsSet(ModOption flag, IEnumerable<string> buildingNames)
        {
            if (!OptionsHolder.Options.IsFlagSet(flag))
            {
                return;
            }
            foreach (var buildingName in buildingNames)
            {
                UnlockBuilding(buildingName);
            }
        }


        private void UnlockBuilding(string buildingName)
        {
            milestonesManager.UnlockMilestone(String.Format("{0} Requirements", buildingName));
        }

        public override int OnGetPopulationTarget(int originalTarget, int scaledTarget)
        {
            return 0;
        }

        public void OnSettingsUI(UIHelperBase helper)
        {
            OptionsLoader.LoadOptions();
            var group = helper.AddGroup("Unlock All + Wonders & Landmarks Options");
            AddCheckbox("Unlock Unique Buildings (levels I-VI)", ModOption.UniqueBuildings, group);
            AddCheckbox("Unlock Deluxe Landmarks (req. Deluxe Edition)", ModOption.DeluxeLandmarks, group);
            AddCheckbox("Unlock European Landmarks (req. European biome or European Buildings Unlocker mod)", ModOption.EuroLandmarks, group);
            AddCheckbox("Unlock Wonders (a.k.a Monuments)", ModOption.Wonders, group);
            AddCheckbox("Unlock After Dark Landmarks (a.k.a Tourism & Leisure, req. After Dark DLC)", ModOption.AfterDarkLandmarks, group);
        }

        private static void AddCheckbox(string text, ModOption flag, UIHelperBase group)
        {
            group.AddCheckbox(text, OptionsHolder.Options.IsFlagSet(flag),
                b =>
                {
                    if (b)
                    {
                        OptionsHolder.Options |= flag;
                    }
                    else
                    {
                        OptionsHolder.Options &= ~flag;
                    }
                    OptionsLoader.SaveOptions();
                });
        }
    }
}
