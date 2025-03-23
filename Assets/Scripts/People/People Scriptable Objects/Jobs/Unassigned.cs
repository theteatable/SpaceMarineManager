using UnityEngine;
using SMercenaries.Global;

namespace SMercenaries.People {

    [CreateAssetMenu(fileName = "Unassigned", menuName = "Scriptable Objects/People/Jobs/Unassigned")]
        public class Unassigned : JobSkill
    {
        public string jobSkillName;

        public override int JobSkillEffect (Character charlie)
        {
            //int e = charlie.charStats.GetStats(Globals.StatList.VitalityCurrent);
            return 0;
        }
    }

}
