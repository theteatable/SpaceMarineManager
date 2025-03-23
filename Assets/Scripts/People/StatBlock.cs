using SMercenaries.Global;
using UnityEngine;
using static SMercenaries.People.Species;

namespace SMercenaries.People
{
    //TODO: Split StatBlock into mulitple structs. one for Species, one for personality, one for prior Job.
    public struct StatBlock
    {
            public StatBlock(int VC, int MC, int VT, int RS, int MT, int MRS, int IP, int GCNG, int GCSG, int GCHG, int AGL, int ACC, int MS, int SS, int STAM, int BAL, int AS, int CSM, int CSS, int SLAMC, int SLASC, int JUMP,
                int REACS, int PS, int LTM, int DM, int FOC, int TD, int VERS, int ADAPT, int CP, int COMM, int BT, int RT, int CI, int TLB, int TLE1, int TLE2, int TLE20, int TLE50, int TLE75, int TLELS, int PERC, int MBC, int CA, int CHARM)
        {
            VitalityCurrent = VC;
            MentalCurrent = MC;
            VitalityTotal = VT;
            RecoverySpeed = RS;
            MentalTotal = MT;
            MentalRecoverySpeed = MRS;
            InjuryProne = IP;
            GravComfortNullG = GCNG;
            GravComfortStandardG = GCSG;
            GravComfortHighG = GCHG;
            Agility = AGL;
            Acceleration = ACC;
            MaxSpeed = MS;
            SustainedSpeed = SS;
            Stamina = STAM;
            Balance = BAL;
            ArmStrength = AS;
            CarryStrengthMax = CSM;
            CarryStrengthSustained = CSS;
            SpeedLossAtMaxCarry = SLAMC;
            SpeedLossAtSustainedCarry = SLASC;
            Jump = JUMP;
            ReactionSpeed = REACS;
            ProcessingSpeed = PS;
            LongTermMemory = LTM;
            DeciscionMaking = DM;
            Focus = FOC;
            TrainingDedication = TD;
            Versatility = VERS;
            Adaptability = ADAPT;
            CommandPresence = CP;
            Communication = COMM;
            BoredomTolerance = BT;
            RiskTaking = RT;
            CombatInsticts = CI;
            TeamLossBase = TLB;
            TeamLossEffectFirst = TLE1;
            TeamLossEffectSecond = TLE2;
            TeamLossEffectPerc20 = TLE20;
            TeamLossEffectPerc50 = TLE50;
            TeamLossEffectPerc75 = TLE75;
            TeamLossEffectLastStanding = TLELS;
            Perception = PERC;
            MindBodyConnection = MBC;
            Coordination = CA;
            Charm = CHARM;
        }
        public int
        VitalityCurrent,
        MentalCurrent,
        VitalityTotal,
        RecoverySpeed,
        MentalTotal,
        MentalRecoverySpeed,
        InjuryProne,
        GravComfortNullG,
        GravComfortStandardG,
        GravComfortHighG,
        Agility,
        Acceleration,
        MaxSpeed,
        SustainedSpeed,
        Stamina,
        Balance,
        ArmStrength,
        CarryStrengthMax,
        CarryStrengthSustained,
        SpeedLossAtMaxCarry,
        SpeedLossAtSustainedCarry,
        Jump,
        ReactionSpeed,
        ProcessingSpeed,
        LongTermMemory,
        DeciscionMaking,
        Focus,
        TrainingDedication,
        Versatility,
        Adaptability,
        CommandPresence,
        Communication,
        BoredomTolerance,
        RiskTaking,
        CombatInsticts,
        TeamLossBase,
        TeamLossEffectFirst,
        TeamLossEffectSecond,
        TeamLossEffectPerc20,
        TeamLossEffectPerc50,
        TeamLossEffectPerc75,
        TeamLossEffectLastStanding,
        Perception,
        MindBodyConnection,
        Coordination,
        Charm;
            
    }
}





// Personality Skills
//public int riskTaking;
//public int combatInstincts;
//public Globals.Socialability socialability;
//public int adaptability;
//public int focus;
//public int communication;
//public int boredomTolerance;
//public int stressUnderFire;
//public int commandPresence;

//public int trainingDedication;
//public int injuryProne;




//Species Stats
//public int vitalityMax;
//public int vitalityAvg;
//public int recoverySpeedAverage;
//public int mentalMax;
//public int mentalAvg;
//public int stressResponseAvg;

//public int processingSpeedAvg;
//public int reactionSpeedAvg;


//public int avgToMaxMulitplierSpeed;
//public int avgToMaxMulitplierStrength;

//public int avgToMaxMulitplierGravityEffect;


//public int topSpeed;
//public int avgSpeed;
//public int agilityavg;

////public CharacterSkill[] talents;

//public int armStrengthAvg;
//public int carryStrenghtAvg;

//public CarrySpeedLoss carrySpeedLoss;
//public HandType speciesHandType;
//public Globals.Socialability socialability;
//public int InjuryProne
