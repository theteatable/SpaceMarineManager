using SMercenaries.Global;
using System.Collections.Generic;
using UnityEngine;

namespace SMercenaries.SNations
        
{
    [CreateAssetMenu(fileName = "Contract", menuName = "Scriptable Objects/Nation/Contract")]

    public class Contract : ScriptableObject
    {
        [Header("Contract details")]
        public string ConName { get; private set; }
        public string ConDescription { get; private set; }

        public Story contractStory; 
        //TODO: create Story class that will determine what happens during contract
        //public Habitation habitation; // Habitation information should already incode location details 
        //public Location location;  //making this redundant TODO: do i need this?
        //TODO: Add the Above to the Story Class

        public bool IsCompleted { get; set; }
        public Date DateCompleted { get; set; }


        public Date DateBegin { get; private set; }
        public int Payout { get; set; } //Credits TODO: Figure out credit scale //TODO: Private set?
        public int Length { get; private set; } //Weeks


        public Nation OriginatingNation { get; private set; }
        //public Location[] originatingLocations; // If I want to limit it to specific locations


 

        //[Space]
        //[Header("Contract Requirements")]

        //TODO: create a boolReq Class to absorb all these requirements into?
        //public List<bool> boolReq;
        //public List<Facility> facReq;
        //public List<Contract> priorContracteReq;
        //public Dictionary<Nation, Relationship> relationshipNationReq;
        //public Dictionary<Corporation, Relationship> relationshipCorporationReq;
        //public List<Technology> techReq;


    }
}