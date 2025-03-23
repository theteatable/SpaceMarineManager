using UnityEngine;
using System.Collections.Generic;
using SMercenaries.Global;

namespace SMercenaries.People
{
    [CreateAssetMenu(fileName = "InjurySO", menuName = "Scriptable Objects/People/Injury")]
    public class Injury : ScriptableObject
    {

        //TODO: Change this completely
        // :skull:
        public string injuryName;
        public string injuryDescription;

        
        public int injurySeverityCurrent;



        //Max damage an injury can do, if the severity is lower, then max, damage is scaled down.
        //Will also only look at injury 
        public int injurySeverityMax = 5; //Max size is 8, min is 3

        //Injury Example
        // 

        //TODO: decide if injury effect is percent or flat
        //public Dictionary<Globals.StatList, int> maxInjuryEffect = new();
        public int[] injurySeverityScaling = new int[Globals.InjuryArraySizeDefault]; //Globals.Instance.injuryArraySizeDefault = 8
        // True is percent, False is Flat
        public bool[] injurySeverityisPercent = new bool[Globals.InjuryArraySizeDefault];


        //Without high grade healing/regenerative facilities, permanent damage can occur
        //When creating injuries set each value individually
        public bool[] facilityNeeded = new bool[Globals.InjuryArraySizeDefault];
        public int injurySeverityMin;
       
        public int injurySeveritycurrent;

        // injuries heal according to Character.charStats.recoverySpeed points per month
        // thiis int[] tracks how many points are needed to heal betwen each 
        public int[] injurySeverityPointValues = new int[10];

        public int recoveryPointsToHealTotal;


        public Injury()
        {
;
        }


        // TODO: add bool facilityBadInjuriesHealable into Globals, possibly change this to just setting severity min to 0
        public void SetInjurySeverityMinimum(int i)
        {
            //facilityBadInjuries is declared as a bool and initialized as false
            if (false)
            {
                //injurySeverityMin = 0;
            }
        }


    }
}
