using UnityEngine;
using UnityEditor.UIElements;
using System.Collections.Generic;
using SMercenaries.SNations;
using SMercenaries.Global;
using System.Reflection;
using System;


namespace SMercenaries.People
{
    [CreateAssetMenu(fileName = "CharacterSO", menuName = "Scriptable Objects/People/SOCharacter")]
    public class SOCharacter : ScriptableObject
    {
        [Header("Character Identifiers")]
        public string charName;
        //TODO: Create Date Class and calculate age from that.
        //public MyDateSystem birthDay;
        //TODO: Create Facility Class, move this field to the proper location
        //public Dictionary<MyDateSystem, Facility> timesReborn = new();

        public Nation nationBirth;
        //public Location current_location;

        public Species species;
        public Personality personality;
        public List<Job> priorJobs;




        [Header("Character General")]
        public Job jobExperiencePrimary;
        public Job jobExperienceSecondary;
        public Job jobExperienceTertiary;
        public List<Injury> currentInjuries;
        public List<Injury> previousInjuries;
        public SkillBlock interests;

        public Globals.Handedness handedness;
        public Species.HandType charHandType; // TODO: In initializer create = Species.speciesHandType;
        public Globals.Gravity gravpref;


        [Space]
        public StatBlock Stats;
        public SkillBlock Skills;

        //Working parameters

        [Space]

        [Header("Job Feilds")]
        public bool isHireable;
        public bool isHired;
        public List<Job> jobPreference;


        public List<Job> jobsWorking;
        public int jobSatistfaction;

        // public Dictionary<SOCharacter, int> cohesion;


        [Header("contract length")]
        public int contractLengthMin;
        public int contractLengthMax;
        public int contractLength;

        public int contractEndDate;
        public int contractRenewals;

        [Header("Monthly Pay")]
        public int minSalary;
        public int salary;
        public int bonus;
        public int performanceBonus;

        [Flags]
        public enum JobType // Come back to this after making a bunch of Job
        {
            None = 0,
            Military = 1 << 1,
            Research = 1 << 2,
            Admin = 1 << 3,
            Leader = 1 << 4,
            Civilian = 1 << 5
        }




    }
}