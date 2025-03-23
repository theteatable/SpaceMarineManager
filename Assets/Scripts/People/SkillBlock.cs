using UnityEngine;
namespace SMercenaries.People
{
    public struct SkillBlock
    {

        public int ShortAim,
            MediumAim,
            LongAim,
            ExtremeLongAim,

            WeaponFam_Hand,
            WeaponFam_Sword,
            WeaponFam_Blunt,
            WeaponFam_Hammer,
            WeaponFam_ExoticMelee,
            WeaponFam_MeleeGeneral,

            WeaponFam_Pistol,
            WeaponFam_Rifle,
            WeaponFam_Sniper,
            WeaponFam_Rocket,
            WeaponFam_GunGeneral,

            WeaponType_Kinetic,
            WeaponType_Energy,
            WeaponType_Plasma,
            WeaponType_Explosive,
            WeaponType_Exotic,
            WeaponType_General,

            DefenseFam_Armor,
            DefenseFam_Shield,
            DefenseFam_Stealth,
            DefenseFam_Movement,
            DefenseFam_PDS,
            DefenseFam_General,

            DefenseType_Personal,
            DefenseType_Squad,
            DefenseType_Vehicle,
            DefenseType_Ship,
            DefenseType_Building,
            DefenseType_General,

            //Weapon Management
            Reload,
            Handling,
            RecoilControl,
            Maintenance,

            Movement,
            Movement_Stealth,
            Movement_UnderFire,

            Communication,
            EnemyRecognition,
            VehicleRecognition,

            //Officer Skills
            Communication_Motivation,
            RiskAssessment,
            CritialThinking,
            Coordination,
            Intimidation,
            Adaptability,
            Leadership,
            Charisma, // Stat?
            CommandPresence, // Currently a stat

            //Interests
            StrengthBuilding,
            SpeedBuilding,
            Combat,
            Meditation,
            Dexterity,

            //Medical
            Medicine_Corpsman,
            Medicine_TCCC,
            Medicine_Field,

            Medicine_Doctor,
            Medicine_Mental,
            Medicine_Regrowth,


            Tactic_ZeroG,
            Tactic_Indoors,
            Tactic_ComplexSpace,
            Tactic_OutDoors,
            Tactic_General,

            Strategy_Small,
            Strategy_Outdoor,
            Strategy_Ship,


            //Education
            Learning_Study,
            Learning_Mental,
            Learning_Physical,

            Researching_Weapon,
            Researching_Defense,
            Researching_Facility,
            Researching_Ship,
            Researching_General,

            Teaching_Weapon, // Does teaching just give bonus to referential skill when teaching others?
            Teaching_Defense,
            Teaching_Tactic,
            Teaching_Strategy,
            Teaching_Medicine,
            Teaching_General,

            Teaching_Individual,
            Teaching_Squad,
            Teaching_Group,

            Teaching_Basic,
            Teaching_Advanced,
            Teaching_Expert,

            LanguageLearning,
            ReadingLearning,
            AlienCat_A, // alien groups can be classified in general groups, some are convergent cultures
            AlienCat_B, // A skill in an alien Category gives boosts to its 
            AlienCat_C,
            AlienCat_D,
            AlientCat_E,
            AlienCat_F,
            AlienCat_G,
            AlienCat_AncientAlien,

            Trainer_Strength,
            Trainer_Endurance,
            Trainer_InjuryPrevention,
            Trainer_CombatFitness,
            Trainer_Recovery;

            


    }
}
