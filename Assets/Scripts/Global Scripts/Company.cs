using UnityEngine;
using System.Collections.Generic;
using SMercenaries.SNations;

namespace SMercenaries.Global
{
    public class Company : MonoBehaviour
    {
        public static Company Instance;

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


        public string companyName;
        //public Image companyFlag;;

        public string companyDescription;
        public string companyColorA;
        public string companyColorB;

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