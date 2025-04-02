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
        public Dictionary<Job.JobType, int> jobWeights;

        public bool inContention; // if there is a contract occuring on site.
        
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

        //Food,
        //Resources,
        //Military,
        //Industry,
        //Pleasure,
        //Training,
        //Research,
        //Medical,
        //Cloning,
        //Political,
        //Capital,
        //Pirate,
        //Urban,
        //RuralNonFood
        public Dictionary<Job, int> GetHiringJobs()
        {


            return null;
        }

    } 
}