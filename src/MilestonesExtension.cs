﻿using System.Collections.Generic;
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

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockNaturalDisastersLandmarks), new[]{
                //Natural Disasters
                "Unicorn Park",
                "Sphinx Of Scenarios",
                "Pyramid Of Safety",
                "Doomsday Vault",
                "Disaster Memorial",
                "Helicopter Park",
                "Meteor Park"
            });


            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockSnowfallLandmarks), new[]{
                //Snowfall
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

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockAfterDarkLandmarks), new[]{
                //After Dark
                "Fancy Fountain",
                "Casino",
                "Driving Range",
                "Luxury Hotel",
                "Zoo",
            });

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockDeluxeLandmarks), new[]{
                //Deluxe
                "Eiffel Tower",
                "Statue of Liberty",
                "Grand Central Terminal",
                "Brandenburg Gate",
                "Arc de Triomphe",
            });

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockWonders), new[]{
                //Wonders
                "Hadron Collider",
                "Medical Center",
                "Space Elevator",
                "Eden Project",
                "Fusion Power Plant",
            });

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockEuroLandmarks), new[]{
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

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockUniqueBuildings), new[]{
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

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockMassTransitLandmarks), new[]
            {
                "Boat Museum",
                "Traffic Park",
                "Steam Train"
            });

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

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockConcertsBuildings), new[]
            {
                "Music Club",
                "Media Broadcast Building"
            });

            UnlockBuidlingsIfFlagIsSet(nameof(Options.unlockParkLifeBuildings), new[]
            {
                //City Park
                "Park Chess Board #1",
                "Park Pier #1",
                "Park Pier #2",
                "Gazebo #1",
                "Gazebo #2",
                "Climbing Fence #1",
                "Trampoline Park #1",
                //Amusement Park
                "Piggy Train",
                "Rotating Tea Cups",
                "Swinging Boat",
                "House Of Horrors",
                "Bumber Cars",
                "Drop Tower Ride",
                "Pendulum Ride",
                "Ferris Wheel",
                "Rollercoaster",
                //Zoo
                "Bison Enclosure",
                "Insect, Amphibian and Reptile House",
                "Flamingo Enclosure",
                "Elephant Enclosure",
                "Sealife Enclosure",
                "Giraffe Enclosure",
                "Monkey Palace",
                "Rhino Enclosure",
                "Lion Enclosure",
                //Nature Reserve
                "Viewing Deck #1",
                "Viewing Deck #2",
                "Tent Camping Site #1",
                "Lean-To Shelter #1",
                "Lean-To Shelter #2",
                "Lookout Tower #1",
                "Lookout Tower #2",
                "Fishing Cabin #1",
                "Fishing Cabin #2",
                "Hunting Cabin #1",
                "Hunting Cabin #2",
                "Bouldering Site #1",
                //Monument
                "Castle Of Lord Chirpwick",
                //UB-III
                "Old Market Street",
                //UB-IV
                "Sea Fortress",
                //UB-VI
                "The Statue of Colossalus"
            });
        }

        private void UnlockBuidlingsIfFlagIsSet(string flag, IEnumerable<string> buildingNames)
        {
            if (!(bool)typeof(Options).GetProperty(flag).GetValue(OptionsWrapper<Options>.Options, null))
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
            var milestone = $"{buildingName} Requirements";

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
