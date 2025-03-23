using UnityEngine;
using System.Collections.Generic;
using SMercenaries.SNations;

namespace SMercenaries.Global
{
    public class Battalion : MonoBehaviour
    {
        public static Battalion Instance;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
            }
        }


        public string BattalionName;
        //public Image BattalionFlag;;

        public string BattalionDescription;
        public string BattalionColorA;
        public string BattalionColorB;

        public bool headquartersOnShip;
        public Habitation headquarters;
        //public Ship headquartersMobile;


        public Dictionary<Nation, Relationship> relationNation;
        //TODO: These will use Relationship Class to compare numbers. Might just throw those in global?
        public Dictionary<Corporation, Relationship> relationCorp;



        public Relationship GetRelationshipCorp (Corporation corpo)
        {
            if (relationCorp.TryGetValue(corpo, out Relationship tRelation))
            {
                return tRelation;
            }
            else
            {
                Relationship tRelate = new Relationship(0, 0, 0);
                relationCorp.Add(corpo, tRelate);
                return relationCorp[corpo];
            }
        }
        public Relationship GetRelationshipNat (Nation tNation)
        {
            if (relationNation.TryGetValue(tNation, out Relationship tRelation))
            {
                return tRelation;
            }
            else
            {
                Relationship tRelate = new Relationship(0, 0, 0);
                relationNation.Add(tNation, tRelate);
                return relationNation[tNation];
            }
        }


    }
}