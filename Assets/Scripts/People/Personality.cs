using UnityEngine;
using SMercenaries.Global;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using System.Reflection;
using System.Collections.Generic;

namespace SMercenaries.People
{
    [CreateAssetMenu(fileName = "PersonalitySO", menuName = "Scriptable Objects/People/Personality")]

    public class Personality : ScriptableObject
    {
        public string personalityName;
        public string personalityDescription;

        public SkillBlock personalityInterest;
        public StatBlock personalityStatBonuses;
        public List<Job.JobType> jobTypeInterests;

     
        // Random of x numbers, 5 out of 10 personality Traits match for good chemistry.
        //TODO: initialize all these as random numbers
        public int PersonalityTraitA { get; private set; } // Based on personality Type

        public int PersonalityTraitB1 { get; private set; } // 0, 1
        public int PersonalityTraitB2 { get; private set; } // 0, 1, 2
        public int PersonalityTraitB3 { get; private set; } // 0, 1, 2, 3
        public int PersonalityTraitC1 { get; private set; } // 0, 1,
        public int PersonalityTraitC2 { get; private set; } // 0, 1, 2,
        public int PersonalityTraitC3 { get; private set; } // 0, 1, 2, 3
        public int PersonalityTraitD1 { get; private set; } // 0, 1
        public int PersonalityTraitD2 { get; private set; } // 0, 1, 2,
        public int PersonalityTraitD3 { get; private set; } // 0, 1, 2, 3

        public enum PersSubType
        {
            Aggressive,
            Passive,
            Other //TODO: increase list length after creating several personalities
        }

        public enum PersonalityMatch
        {
            Negative = 0,
            Bad = 1,
            Nuetral = 2,
            Good = 5,
            Great = 6,
            Excellent = 7, //TODO: Fix these names at some point
        }
        public Personality getRandomPersonality(List<Personality> tPersonality)
        {
            int random = UnityEngine.Random.Range(0, tPersonality.Count);
            return tPersonality[random];
        }


    }
}