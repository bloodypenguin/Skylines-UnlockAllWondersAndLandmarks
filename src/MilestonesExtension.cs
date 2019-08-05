using System.Collections.Generic;
using System.Linq;
using ICities;
using UnlockAllWondersAndLandmarks.OptionsFramework;

namespace UnlockAllWondersAndLandmarks
{
    public class MilestonesExtension : MilestonesExtensionBase
    {
        public override void OnRefreshMilestones()
        {
            milestonesManager.UnlockMilestone("Basic Road Created");
            if (managers.application.SupportsExpansion(Expansion.Parks))
            {
                milestonesManager.UnlockMilestone("Park Gate Requirements");
                milestonesManager.UnlockMilestone("City Park Requirements 1");
                milestonesManager.UnlockMilestone("City Park Requirements 2");
                milestonesManager.UnlockMilestone("City Park Requirements 3");
                milestonesManager.UnlockMilestone("City Park Requirements 4");
                milestonesManager.UnlockMilestone("City Park Requirements 5");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 1");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 2");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 3");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 4");
                milestonesManager.UnlockMilestone("Amusement Park Requirements 5");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 1");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 2");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 3");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 4");
                milestonesManager.UnlockMilestone("Nature Reserve Requirements 5");
                milestonesManager.UnlockMilestone("Zoo Requirements 1");
                milestonesManager.UnlockMilestone("Zoo Requirements 2");
                milestonesManager.UnlockMilestone("Zoo Requirements 3");
                milestonesManager.UnlockMilestone("Zoo Requirements 4");
                milestonesManager.UnlockMilestone("Zoo Requirements 5");

                UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockParklifeLandmarks), new[]
                {
                    "City Arch",
                    "Clock Tower",
                    "Old Market Street",
                    "Sea Fortress",
                    "Observation Tower",
                    "Statue Of Colossalus",
                    "Chirpwick Castle",
                });
            }

            if (managers.application.SupportsExpansion(Expansion.Industry))
            {
                milestonesManager.UnlockMilestone("Main Building Requirements");
                milestonesManager.UnlockMilestone("Farming Requirements 1");
                milestonesManager.UnlockMilestone("Farming Requirements 2");
                milestonesManager.UnlockMilestone("Farming Requirements 3");
                milestonesManager.UnlockMilestone("Farming Requirements 4");
                milestonesManager.UnlockMilestone("Farming Requirements 5");
                milestonesManager.UnlockMilestone("Forestry Requirements 1");
                milestonesManager.UnlockMilestone("Forestry Requirements 2");
                milestonesManager.UnlockMilestone("Forestry Requirements 3");
                milestonesManager.UnlockMilestone("Forestry Requirements 4");
                milestonesManager.UnlockMilestone("Forestry Requirements 5");
                milestonesManager.UnlockMilestone("Oil Requirements 1");
                milestonesManager.UnlockMilestone("Oil Requirements 2");
                milestonesManager.UnlockMilestone("Oil Requirements 3");
                milestonesManager.UnlockMilestone("Oil Requirements 4");
                milestonesManager.UnlockMilestone("Oil Requirements 5");
                milestonesManager.UnlockMilestone("Ore Requirements 1");
                milestonesManager.UnlockMilestone("Ore Requirements 2");
                milestonesManager.UnlockMilestone("Ore Requirements 3");
                milestonesManager.UnlockMilestone("Ore Requirements 4");
                milestonesManager.UnlockMilestone("Ore Requirements 5");
            }

            if (managers.application.SupportsExpansion(Expansion.Campuses))
            {
                milestonesManager.UnlockMilestone("Campus Main Building Requirements");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 1");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 2");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 3");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 4");
                milestonesManager.UnlockMilestone("TradeSchool Requirements 5");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 1");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 2");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 3");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 4");
                milestonesManager.UnlockMilestone("LiberalArts Requirements 5");
                milestonesManager.UnlockMilestone("University Requirements 1");
                milestonesManager.UnlockMilestone("University Requirements 2");
                milestonesManager.UnlockMilestone("University Requirements 3");
                milestonesManager.UnlockMilestone("University Requirements 4");
                milestonesManager.UnlockMilestone("University Requirements 5");
            }

            if (managers.application.SupportsExpansion(Expansion.NaturalDisasters))
            {
                UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockNaturalDisastersLandmarks), new[]
                {
                    "Unicorn Park",
                    "Sphinx Of Scenarios",
                    "Pyramid Of Safety",
                    "Doomsday Vault",
                    "Disaster Memorial",
                    "Helicopter Park",
                    "Meteor Park"
                });
            }

            if (managers.application.SupportsExpansion(Expansion.Snowfall))
            {
                UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockSnowfallLandmarks), new[]
                {
                    "Ice Hockey Arena",
                    "Sleigh Ride",
                    "Spa Hotel",
                    "Snowcastle Restaurant",
                    "Ski Resort",
                    "Santa Claus Workshop",
                    "Christmas Tree",
                    "Arena",
                    "Driving Range",
                    "Igloo Hotel",
                });
            }

            if (managers.application.SupportsExpansion(Expansion.AfterDark))
            {
                UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockAfterDarkLandmarks), new[]
                {
                    "Fancy Fountain",
                    "Casino",
                    "Driving Range",
                    "Luxury Hotel",
                    "Zoo",
                });
            }

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockDeluxeLandmarks), new[]
            {
                //Deluxe
                "Eiffel Tower",
                "Statue of Liberty",
                "Grand Central Terminal",
                "Brandenburg Gate",
                "Arc de Triomphe",
            });

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockWonders), new[]
            {
                //Wonders
                "Hadron Collider",
                "Medical Center",
                "Space Elevator",
                "Eden Project",
                "Fusion Power Plant",
            });

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockEuroLandmarks), new[]
            {
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

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockUniqueBuildings), new[]
            {
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

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockUniqueBuildings), new[]
            {
                "Academic Library"
            }, "Prerequisites");

            if (managers.application.SupportsExpansion(Expansion.InMotion))
            {
                UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockMassTransitLandmarks), new[]
                {
                    "Boat Museum",
                    "Traffic Park",
                    "Steam Train"
                });
            }

            if (managers.application.SupportsExpansion(Expansion.GreenCities))
            {
                UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockGreenCitiesLandmarks), new[]
                {
                    "Bird And Bee Haven",
                    "Floating Gardens",
                    "Central Park",
                    "Ziggurat Garden",
                    "Climate Research Station",
                    "Lungs of the City",
                    "Ultimate Recycling Plant"
                });
            }

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockConcertsLandmarks), new[]
            {
                //concerts
                "Festival Fan Zone",
                "Broadcasting Studios",
                "Live Music Venue",
                "Festival Area",
            });
        }

        private void UnlockBuidlingsIfFlagIsSet(string flag, IEnumerable<string> buildingNames, string suffix = "Requirements")
        {
            if (!(bool) typeof(Options).GetProperty(flag).GetValue(OptionsWrapper<Options>.Options, null))
            {
                return;
            }

            foreach (var buildingName in buildingNames)
            {
                UnlockBuilding(buildingName, suffix);
            }
        }


        private void UnlockBuilding(string buildingName, string suffix)
        {
            var milestone = $"{buildingName} {suffix}";

            if (milestonesManager.EnumerateMilestones().Contains(milestone))
            {
                milestonesManager.UnlockMilestone(milestone);
            }
        }

        public override int OnGetPopulationTarget(int originalTarget, int scaledTarget)
        {
            return 0;
        }
    }
}