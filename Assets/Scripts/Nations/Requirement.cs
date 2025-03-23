using SMercenaries.SNations;
using UnityEngine;

namespace SMercenaries.Global
{
    [CreateAssetMenu(fileName = "Requirement", menuName = "Scriptable Objects/Requirement")]
    public class Requirement : ScriptableObject
    {
        public bool ReqsMet { get; private set; }
        public Corporation CorporationReq { get; private set; }
        public Relationship CorpRelationshipReq { get; private set; }
        public Nation NationReq { get; private set; }
        public Relationship NationRelationshipReq { get; private set; }
        public Technology[] TechReq { get; private set; }
        public Contract[] ContractReq { get; private set; }
        public Facility[] FacReq { get; private set; }



        /* TODO: Might split up all the requirement checks so that if a player is close to completing
         * the requirments for something they can get knowledge of the item and aim towards completing it 
         * toss up on whether this is more fun
        */

        public bool CheckReqs()
        {
            //Corporation Requirements check
            Relationship tCorpRelate = Company.Instance.GetRelationshipCorp(CorporationReq);
            bool corpRelate = CorpRelationshipReq.CompareRelationships(tCorpRelate);

            //Nation Req check
            Relationship tNationRelate = Company.Instance.GetRelationshipNat(NationReq);
            bool nationRelate = NationRelationshipReq.CompareRelationships(tNationRelate);

            //TODO: Decide how Technology and Contracts and Facilities are stored. 

            //Technology req check

            //Contract req check

            //Factility req check


            //if all checks are passed, return true.
            return corpRelate && nationRelate;


        }



    }
}