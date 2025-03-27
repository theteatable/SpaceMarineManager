using SMercenaries.Global;
using UnityEngine;

namespace SMercenaries.People
{
    [CreateAssetMenu(fileName = "JobSO", menuName = "Scriptable Objects/People/Job")]
    public class Job : ScriptableObject
    {
        [Header("Job Details")] 
        
        public string jobName;
        public string jobDescription;
        //public Image icon;

        // The calculation should be something like 60% of bonus scaling up to 175% of bonus at cap
        public bool isFullTime;
        public int monthsUntilTrained;        
        public int monthsUntilMaxBonus;


        [Header("Game Updated Details")]
        public int monthsInJob;
        public Date dateLastWorked;



        [Header("StatBlock Information")]
        public StatBlock charGenerationStatBase;
        
        public StatBlock statBonusesLead;
        public StatBlock statBonusesNotLead;
        public StatBlock statBonusesGeneral;

        public SkillBlock skillExperienceGainedInJob;



        

    }
}
