using UnityEngine;
using System.Collections.Generic;
using SMercenaries.People;
using SMercenaries.Global;

namespace SMercenaries.SNations
{
    [CreateAssetMenu(fileName = "Facility", menuName = "Scriptable Objects/Nation/Facility/Facility")]
    public class Facility : Technology
    {
        [Header("Facility Basic")]
       
        public int BuildTime { get; private set; } // months
        public int Upkeep { get; private set; } // cost per Month
        public FacilityTier facilityTier;
        public Facility[] UpgradePath { get; private set; }
        public int FacilitySize { get; private set; } // most for ships and space statioons



        [Space]
        [Header("Jobs")]
        public int jobsFullTime; // The number of jobs allowed for full time. Currently that is limited to 4
        
        public Character characterLead; 
        public Job JobLead {  get; private set; }

        public Character characterSecond;
        public Job JobSecond { get; private set; }

        public Character characterThird;
        public Job JobThird { get; private set; }

        public Character characterFourth;
        public Job JobFourth { get; private set; }

        public List<Character> genWorkers;
        public Job JobGeneral { get; private set; }

        //[Space]
        //[Header("Effect")]
        //public FacilitySkill effect; TODO: Create this class like we did for Job Skill


        public enum FacilityTier
        {
            Basic,
            Intermediate,
            Advanced,
            Notable,
            AncientEra
        }
        //public FacilityType facilityBaseType;
        //public enum FacilityType // 
        //{
        //    Research,
        //    Training,
        //    Living,
        //    Medical,
        //    Cloning,
        //    ContractUnique,
        //    Defense
        //}


    }
}