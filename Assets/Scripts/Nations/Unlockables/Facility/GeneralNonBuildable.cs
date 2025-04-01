using NUnit.Framework;
using SMercenaries.People;
using UnityEngine;
using System.Collections.Generic;

namespace SMercenaries.SNations
{
    public class GeneralNonBuildable : Facility
    {
        public int size;

        public LandType type;

        public List<Job> GeneralJobs;

        public enum LandType
        {
            Rural,
            Urban,
            Industrial,
            Commercial
        }


    }
}