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

        public int jobDanger; //Gets this from locations/job details.
                              //The longer you survive, the more experience you get?



        [Header("Game Updated Details")]
        public int monthsInJob;
        public Date dateLastWorked; //Used to calculate skills falling



        [Header("StatBlock Information")]
        public StatBlock charGenerationStatBase;
        
        public StatBlock statBonusesLead;
        public StatBlock statBonusesNotLead;
        public StatBlock statBonusesGeneral;
        
        public SkillBlock skillExpGrowth; // if skills are between 1 and 10, they should gain no more than 2 or 3 levels from a couple years of working this.
                                                      // Faster growth during training, then random spurts over the years?
        public SkillBlock skillLimitereStart;
        public SkillBlock limiterSkillGrowth;

        public enum JobType
        {
            //Military, 
            //Civilian,
            //Research, 
            //Training,
            //The following are taken from production type in the Class Habitation
            Food,
            Resources,
            Military,
            Industry,
            Pleasure,
            Training,
            Research,
            Medical,
            Cloning,
            Political,
            Capital,
            Pirate,
            Urban,
            RuralNonFood
        }



        

    }
}
