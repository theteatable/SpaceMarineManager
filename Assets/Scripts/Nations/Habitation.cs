using UnityEngine;
using System.Collections.Generic;
using SMercenaries.People;
using System;

namespace SMercenaries.SNations
{
    public class Habitation : ScriptableObject
    {

        public HabitationType Type;
        public List<Facility> localFacilities;


        public Production primaryProduction; 
        public Production secondaryProduction;

        public List<Production> MinimalProductionOf; //
        public List<Production> zeroProductionOf; //an asteroid might have 0 farmers.


        public bool inContention; // if there is a contract occuring on site.
        

        public enum Production
        {
            Food,
            Resources,
            Industry,
            Urban,
            Pleasure,
            Capital,
            Pirate,
            Training
        }
        public enum HabitationType
        {
            Planet,
            Asteroid,
            SpaceStationLarge,
            SpaceStationSmall,
            Moon,
            DysonRing,
            DysonSphere
            //WorldShip TODO: implement a ship class 
        }

        public List<Facility> GetNotableFacilities()
        {
            List<Facility> facilities = new List<Facility>();
            foreach (Facility facility in localFacilities)
            {
                if (facility.facilityTier == Facility.FacilityTier.Notable || facility.facilityTier == Facility.FacilityTier.AncientEra)
                {
                    facilities.Add(facility);
                }
            }

            return facilities;
        }
    } 
}