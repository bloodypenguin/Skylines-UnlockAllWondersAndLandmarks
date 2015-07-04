using ColossalFramework;
using ICities;

namespace UnlockAllWondersAndLandmarks
{

    public class UnlockAllWondersAndLandmarks : MilestonesExtensionBase, IUserMod
    {

        public static ModOptions Options = ModOptions.None;

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
            if (Options.IsFlagSet(ModOptions.DeluxeLandmarks))
            {
                //Deluxe 
                milestonesManager.UnlockMilestone("Eiffel Tower Requirements");
                milestonesManager.UnlockMilestone("Statue of Liberty Requirements");
                milestonesManager.UnlockMilestone("Grand Central Terminal Requirements");
                milestonesManager.UnlockMilestone("Brandenburg Gate Requirements");
                milestonesManager.UnlockMilestone("Arc de Triomphe Requirements");
            }

            if (Options.IsFlagSet(ModOptions.Wonders))
            {
                //Wonders
                milestonesManager.UnlockMilestone("Hadron Collider Requirements");
                milestonesManager.UnlockMilestone("Medical Center Requirements");
                milestonesManager.UnlockMilestone("Space Elevator Requirements");
                milestonesManager.UnlockMilestone("Eden Project Requirements");
                milestonesManager.UnlockMilestone("Fusion Power Plant Requirements");
            }

            if (Options.IsFlagSet(ModOptions.EuroLandmarks))
            {
                //European
                milestonesManager.UnlockMilestone("Arena Requirements");
                milestonesManager.UnlockMilestone("Shopping Center Requirements");
                milestonesManager.UnlockMilestone("Theatre Requirements");
                milestonesManager.UnlockMilestone("London Eye Requirements");
                milestonesManager.UnlockMilestone("Cinema Requirements");
                milestonesManager.UnlockMilestone("City Hall Requirements");
                milestonesManager.UnlockMilestone("Amsterdam Palace Requirements");
                milestonesManager.UnlockMilestone("Cathedral Requirements");
                milestonesManager.UnlockMilestone("Government Offices Requirements");
                milestonesManager.UnlockMilestone("Hypermarket Requirements");
                milestonesManager.UnlockMilestone("Department Store Requirements");
                milestonesManager.UnlockMilestone("Gherkin Requirements");
            }

            if (Options.IsFlagSet(ModOptions.UniqueBuildings))
            {
                //UB-I
                milestonesManager.UnlockMilestone("Statue of Industry Requirements");
                milestonesManager.UnlockMilestone("Statue of Wealth Requirements");
                milestonesManager.UnlockMilestone("Lazaret Plaza Requirements");
                milestonesManager.UnlockMilestone("Statue of Shopping Requirements");
                milestonesManager.UnlockMilestone("Plaza of the Dead Requirements");

                //UB-II
                milestonesManager.UnlockMilestone("Fountain of LifeDeath Requirements");
                milestonesManager.UnlockMilestone("Friendly Neighborhood Requirements");
                milestonesManager.UnlockMilestone("Transport Tower Requirements");
                milestonesManager.UnlockMilestone("Trash Mall Requirements");
                milestonesManager.UnlockMilestone("Posh Mall Requirements");
                //UB-III
                milestonesManager.UnlockMilestone("Colossal Offices Requirements");
                milestonesManager.UnlockMilestone("Official Park Requirements");
                milestonesManager.UnlockMilestone("CourtHouse Requirements");
                milestonesManager.UnlockMilestone("Grand Mall Requirements");
                milestonesManager.UnlockMilestone("Cityhall Requirements");
                //UB-IV
                milestonesManager.UnlockMilestone("Business Park Requirements");
                milestonesManager.UnlockMilestone("Library Requirements");
                milestonesManager.UnlockMilestone("Observatory Requirements");
                milestonesManager.UnlockMilestone("Opera House Requirements");
                milestonesManager.UnlockMilestone("Oppression Office Requirements");

                //UB-V
                milestonesManager.UnlockMilestone("ScienceCenter Requirements");
                milestonesManager.UnlockMilestone("Servicing Services Requirements");
                milestonesManager.UnlockMilestone("SeaWorld Requirements");
                milestonesManager.UnlockMilestone("Expocenter Requirements");
                milestonesManager.UnlockMilestone("High Interest Tower Requirements");

                //UB-VI
                milestonesManager.UnlockMilestone("Cathedral of Plentitude Requirements");
                milestonesManager.UnlockMilestone("Stadium Requirements");
                milestonesManager.UnlockMilestone("Modern Art Museum Requirements");
                milestonesManager.UnlockMilestone("SeaAndSky Scraper Requirements");
                milestonesManager.UnlockMilestone("Theater of Wonders Requirements");
            }

        }




        public override int OnGetPopulationTarget(int originalTarget, int scaledTarget)
        {
            return 0;
        }

        public void OnSettingsUI(UIHelperBase helper)
        {
            OptionsLoader.LoadOptions();
            UIHelperBase group = helper.AddGroup("Unlock All + Wonders & Landmarks Options");
            group.AddCheckbox("Unlock Unique Buildings (levels I-VI)", (Options & ModOptions.UniqueBuildings) != 0,
                (b) =>
                {
                    if (b)
                    {
                        Options |= ModOptions.UniqueBuildings;
                    }
                    else
                    {
                        Options &= ~ModOptions.UniqueBuildings;
                    }
                    OptionsLoader.SaveOptions();
                });
            group.AddCheckbox("Unlock Deluxe Landmarks (req. Deluxe Edition)", (Options & ModOptions.DeluxeLandmarks) != 0,
                (b) =>
                {
                    if (b)
                    {
                        Options |= ModOptions.DeluxeLandmarks;
                    }
                    else
                    {
                        Options &= ~ModOptions.DeluxeLandmarks;
                    }
                    OptionsLoader.SaveOptions();
                });
            group.AddCheckbox("Unlock European Landmarks (req. European biome or European Buildings Unlocker mod)", (Options & ModOptions.EuroLandmarks) != 0,
                (b) =>
                {
                    if (b)
                    {
                        Options |= ModOptions.EuroLandmarks;
                    }
                    else
                    {
                        Options &= ~ModOptions.EuroLandmarks;
                    }
                    OptionsLoader.SaveOptions();
                });
            group.AddCheckbox("Unlock Wonders (a.k.a Monuments)", (Options & ModOptions.Wonders) != 0,
                (b) =>
                {
                    if (b)
                    {
                        Options |= ModOptions.Wonders;
                    }
                    else
                    {
                        Options &= ~ModOptions.Wonders;
                    }
                    OptionsLoader.SaveOptions();
                });
        }
    }
}
