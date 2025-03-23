using UnityEngine;
using System.Collections.Generic;
using SMercenaries.People;
using SMercenaries.Global;

namespace SMercenaries.SNations
{
    public class Nation : ScriptableObject
    {
        [Header("Nation identifiers")]
        public string nationName; 
        public string basicDescription;
        public string researchDescription;
        public string technologyFocusDescription;
        //TODO: Government type?

        [Space]
        [Header("Color, Iconography, Images")]
        //public Image flag;
        public string primaryColorCode;
        public string secondaryColorCode;

        [Space]
        [Header("Nation's Capital")]
        public string capitalName;
        public Location capitalLocation;
        public Habitation capitalHabitation;

        [Header("Locations owned")]
        public List<Location> locationsOwned;
        public List<Habitation> habitationsOwned;

        [Space]
        [Header("General Information")]
        public List<Species> originalSpecies; // for conglomorate or multi-species planet
        public Dictionary<Species, int> speciesAcceptance; // High numbers = more accepted, low numbers = not accepted. really low numbers means banned from space.
        [Space]
        public List<Corporation> corporationList;

        public Dictionary<Nation, Relationship> relationOtherNation;










    }
}