using UnityEngine;

using SMercenaries.Global;

namespace SMercenaries.People
{
    [CreateAssetMenu(fileName = "SpeciesSO", menuName = "Scriptable Objects/People/Species")]
    public class Species : ScriptableObject
    {
        public string speciesName;
        public string speciesDescription;
        // public Image icon;

        public Globals.Gravity speciesNativeGrav;
        public Globals.Gravity[] speciesColonoizedGravs;

        public Personality[] speciesPersonalityTypes;

        public StatBlock speciesMinStats;
        public StatBlock speciesMaxStats;
        public SkillBlock speciesInterests;

        public HandType speciesHandType;
        public Globals.Socialability socialability;

        //public CharacterSkill[] talents;

        public enum CarrySpeedLoss
        {
            Low,
            Medium,
            High
        }

        
        public enum HandType
        {
            Standard,
            NonStandard,
            Tentacle,
            DESIGNSPACE_INCLUDED_HERE
        }


    }
}