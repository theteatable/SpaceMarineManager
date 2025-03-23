using UnityEngine;
using UnityEditor.UIElements;
using System.Collections.Generic;
using SMercenaries.SNations;
using SMercenaries.Global;
using System.Reflection;
using System;


namespace SMercenaries.People
{
    [CreateAssetMenu(fileName = "CharacterSO", menuName = "Scriptable Objects/People/Character")]
    public class Character : ScriptableObject
    {
        [Header("Character Identifiers")]
        public string char_name;
        //TODO: Create Date Class and calculate age from that.
        //public MyDateSystem birthDay;
        //TODO: Create Facility Class, move this field to the proper location
        //public Dictionary<MyDateSystem, Facility> timesReborn = new();

        public Nation nation_birth;
        //public Location current_location;

        public Species species;
        public Personality personality;


        [Header("Character General")]
        public Dictionary<Job, int> previous_experience = new();
        public Injury[] currentInjuries;
        public Injury[] previousInjuries;
        public List<FieldInfo> interests;

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

        // public Dictionary<Character, int> cohesion;

        
        [Header("contract length")]
        public int contract_length_min;
        public int contract_length_max;
        public int contract_length;

        public int contract_end_date;
        public int contract_renewals;

        [Header("Monthly Pay")]
        public int min_salary;
        public int salary;
        public int bonus;
        public int performance_bonus;






        //Personalities are totally random, the higher the personality score, the more boosts/bonues to actions taken between two characters.
        public int PersonalityCompatabilityCheck(Character charlie)
        {
            Personality tPersonality = charlie.personality;
            int charlieCharm = charlie.Stats.Charm;
            int result = 0;
            result += this.personality.PersonalityTraitA == tPersonality.PersonalityTraitA ? 1 : 0;

            result += this.personality.PersonalityTraitB1 == tPersonality.PersonalityTraitB1 ? 1 : 0;
            result += this.personality.PersonalityTraitB2 == tPersonality.PersonalityTraitB2 ? 1 : 0;
            result += this.personality.PersonalityTraitB3 == tPersonality.PersonalityTraitB3 ? 1 : 0;

            result += this.personality.PersonalityTraitC1 == tPersonality.PersonalityTraitC1 ? 1 : 0;
            result += this.personality.PersonalityTraitC2 == tPersonality.PersonalityTraitC2 ? 1 : 0;
            result += this.personality.PersonalityTraitC3 == tPersonality.PersonalityTraitC3 ? 1 : 0;

            result += this.personality.PersonalityTraitD1 == tPersonality.PersonalityTraitD1 ? 1 : 0;
            result += this.personality.PersonalityTraitD2 == tPersonality.PersonalityTraitD2 ? 1 : 0;
            result += this.personality.PersonalityTraitD3 == tPersonality.PersonalityTraitD3 ? 1 : 0;

            int charmBonus = Math.Max(charlieCharm, this.Stats.Charm);
            int charmBonusSameSpecies = charlie.species == this.species ? charmBonus : 0;

            charmBonus = (int) ((charmBonus - (Globals.MaxStatLimit * 0.65)) / 0.15 ); // Charm bonus only gives +1/+2 if charm is 80%/95% the max Stat Value

            charmBonusSameSpecies = (int)(charmBonusSameSpecies - ((this.species.speciesMaxStats.Charm * .65) / .15)); // if characters are the same species, charmbonus gives +1/+2 depending on their species Max Charm

            charmBonus = Math.Max(charmBonus, charmBonusSameSpecies);
            charmBonus = Math.Max(charmBonus, 0); // No negative impacts of low charm. Sorry IncelMaxxers.
            result = result > 0 ? result + charmBonus : result; //If they hate each other, charm will not make them hate each other less.


            return result switch
            {
                0 => 0,
                1 => 1,
                2 => 2,
                3 => 2,
                4 => 2,
                5 => 5,
                6 => 6,
                7 => 7,
                8 => 7,
                9 => 7,
                10 => 7,
                11 => 7,
                12 => 7,
                _ => 7
            };

        }

        public Character GenerateCharacter (bool isHireable, int somethingprobably, Job jobWanted )
        {
            Character character = ScriptableObject.CreateInstance<Character>();

            return null;
        }

    }
}