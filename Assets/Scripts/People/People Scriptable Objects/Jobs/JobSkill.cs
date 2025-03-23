using UnityEngine;

namespace SMercenaries.People
{
    //[CreateAssetMenu(fileName = JobSkillName, menuName = "Scriptable Objects/People/Jobs/" + JobSkillName)]
    
    //TODO: does this require MonoBehavious or ScriptableObject or neither?
    public class JobSkill : ScriptableObject
    {
        public virtual int JobSkillEffect(Character charlie)
        {
            return 0;
        }

    }
}