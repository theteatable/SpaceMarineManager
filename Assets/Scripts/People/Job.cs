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

        public bool isFullTime;

        // The calculation should be something like 60% of bonus scaling up to 175% of bonus at cap
        public int monthsMaxBonus;
        public int monthsUnilTrained;
        public int monthsInJob;



        public StatBlock charGenerationStatBase;
        public StatBlock statBonusesLead;
        public StatBlock statBonusesNotLead;
        public StatBlock statBonusesGeneral;

        [Space]
        [Header("Internal Job references")]

        [SerializeField] private JobSkill _jobSkill;

        



        

    }
}
