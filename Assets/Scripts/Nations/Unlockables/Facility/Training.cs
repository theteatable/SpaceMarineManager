using UnityEngine;
using SMercenaries.Global;
using System;
using SMercenaries.People;
using System.Collections.Generic;
namespace SMercenaries.SNations
{

    [CreateAssetMenu(fileName = "Training", menuName = "Scriptable Objects/Nation/Facility/Training")]
    public class Training : Technology
    {
        public TrainingType trainingType;
        public TrainingSize trainingSize;
        public TrainingStyle trainingStyle;


        //public List<Globals.StatList> statsAffected;
        //public List<CharacterSkill> skillsAffected;

        private int _jobBonus;

        //public Globals.StatList[] ExtraStatsAffected = new Globals.StatList[5];

        public void SetDefaultSatsSkills()
        {

            if (trainingType == TrainingType.ShootingRange)
            {
                //statsAffected.Add(Globals.StatList.CoordinationAim);
                //skillsAffected.Add()
            }
            
            if (trainingType == TrainingType.Melee)
            {
                //statsAffected.Add(Globals.StatList.CoordinationAim);
                //skillsAffected.Add()
            }
            if (trainingType == TrainingType.Gym)
            {
                //statsAffected.Add(Globals.StatList.CoordinationAim);
                //skillsAffected.Add()
            }
            if (trainingType == TrainingType.Classroom)
            {
                //statsAffected.Add(Globals.StatList.CoordinationAim);
                //skillsAffected.Add()
            }
            if (trainingType == TrainingType.MeditationRoom)
            {
                //statsAffected.Add(Globals.StatList.CoordinationAim);
                //skillsAffected.Add()
            }
            if (trainingType == TrainingType.Recovery)
            {
                //statsAffected.Add(Globals.StatList.CoordinationAim);
                //skillsAffected.Add()
            }
            if (trainingType == TrainingType.SkillFocused)
            {
                //statsAffected.Add(Globals.StatList.CoordinationAim);
                //skillsAffected.Add()
            }
            if (trainingType == TrainingType.StatFocused)
            {
                //statsAffected.Add(Globals.StatList.CoordinationAim);
                //skillsAffected.Add()
            }


        }


        [Flags]
        public enum TrainingType
        {
            None = 0,
            ShootingRange = 1 << 0,
            Melee = 1 << 1,
            Gym = 1 << 2,

            Classroom = 1 << 3,
            MeditationRoom = 1 << 4,
            Recovery = 1 << 5,

            SkillFocused = 1 << 6,
            StatFocused = 1 << 7

        }
        [Flags]
        public enum TrainingSize
        {
            None= 0,
            Individual = 1 << 0,
            SmallTeamExercise = 1 << 1,
            LargeTeamExercise = 1 << 2
        }
        [Flags]
        public enum TrainingStyle
        {
            None = 0,
            TalkThrough = 1 << 0,
            Download = 1 << 1,
            Sim = 1 << 2,
            Real = 1 << 3
        }

    }
}