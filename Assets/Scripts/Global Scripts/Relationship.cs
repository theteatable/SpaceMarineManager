using UnityEngine;

namespace SMercenaries.Global
{
    public class Relationship : ScriptableObject
    {
        public int Knowledge { get; private set; }
        public int Relation { get; private set; }

        public int TheirKnowledge { get; private set; }


        //TODO adjust set to reasonable amounts.

        public Relationship() : this(0, 0, 0) { }

        public Relationship(int knowledge = 0, int relation = 0, int theirKnowledge = 0)
        {
            Knowledge = knowledge;
            Relation = relation;
            TheirKnowledge = theirKnowledge;

        }

        //TODO: Add method to compare two Relationship DONE?!
        //HACK: Did I do this right
        public bool CompareRelationships(Relationship testingRelationship)
        {
            int minKnow, testKnow, minRelat, testRelat, minTheirKnow, testTheirKnow;
            bool answer;

            minKnow =this.Knowledge;
            testKnow = testingRelationship.Knowledge;
            minRelat = this.Relation;
            testRelat = testingRelationship.Relation;
            minTheirKnow = this.TheirKnowledge;
            testTheirKnow = testingRelationship.TheirKnowledge;

            answer = minKnow <= testKnow && minRelat <= testRelat && minTheirKnow <= testTheirKnow;
            return answer;

        }

        // TODO: Number Determination: this might be 100 or a multiplier like 50.
        private const int scalarInt = 10;
        public enum KnowledgeOfName
        {
            NoKnowledge = 0 * scalarInt,
            RecordOf = 1 * scalarInt,
            BasicKnowledge = 2 * scalarInt,
            Investigated = 4 * scalarInt,
            Researched = 6 * scalarInt,
            Native = 8 * scalarInt,
            WellResearched = 10 * scalarInt,
            SignificantKnowledge = 12 * scalarInt,
            MaxResearch = 15 * scalarInt,
        }

        public enum RelationName
        {
            AtWar = -15 * scalarInt,
            Antagonistic = -11 * scalarInt, //Arrest on sight, may seek contracts against you
            Hated = -8 * scalarInt, // Arrest on Sight, 
            Disliked = -5 * scalarInt,
            NegativeView = -2 * scalarInt,
            Nuetral = 0 * scalarInt,
            Minimal = 2 * scalarInt,
            Recognize = 4 * scalarInt,
            BasicPartner = 7 * scalarInt,
            FirstPartner = 9 * scalarInt,
            Ally = 11 * scalarInt, //Will support contracts
            EsteemedAlly = 13 * scalarInt,
            UndividedAlly = 15 * scalarInt,
            MaxAlly = 20 * scalarInt
        }
        public enum TheirKnowledgeOf
        {
            NoKnowledge = 0 * scalarInt,
            RecordOf = 1 * scalarInt,
            One_TwoContracts = 2 * scalarInt,
            SeveralContracts = 3 * scalarInt,
            ClosePartners = 4 * scalarInt
        }


    }
}