using SMercenaries.Global;
using SMercenaries.SNations;
using UnityEngine;
using System.Collections.Generic;
using System;

namespace SMercenaries.People
{
    public class Character : MonoBehaviour
    {
        [Header("Character Identifiers")]
        public SOCharacter characterData;

        [Flags]
        public enum JobType
        {
            None = 0,
            Marine = 1 << 0,
            Officer = 1 << 1,
            Researcher = 1 << 2,
            Trainer = 1 << 3,
            Story = 1 << 4
        }
        public enum Age
        {
            Young, // within +-10% of age of maturity and lifespan
            Prime, //10-30% of age of maturity and lifespan
            MiddleAge, //30-65% age of maturiy and lifespan
            Ancient // 65-95% age of maturity and lifespan
        }
        //Personalities are totally random, the higher the personality score, the more boosts/bonues to actions taken between two SOCharacters.
        public int PersonalityCompatabilityCheck(Character charlie)
        {
            Personality tPersonality = charlie.characterData.personality;
            int charlieCharm = charlie.characterData.Stats.Charm;
            int result = 0;
            result += this.characterData.personality.PersonalityTraitA == tPersonality.PersonalityTraitA ? 1 : 0;

            result += this.characterData.personality.PersonalityTraitB1 == tPersonality.PersonalityTraitB1 ? 1 : 0;
            result += this.characterData.personality.PersonalityTraitB2 == tPersonality.PersonalityTraitB2 ? 1 : 0;
            result += this.characterData.personality.PersonalityTraitB3 == tPersonality.PersonalityTraitB3 ? 1 : 0;

            result += this.characterData.personality.PersonalityTraitC1 == tPersonality.PersonalityTraitC1 ? 1 : 0;
            result += this.characterData.personality.PersonalityTraitC2 == tPersonality.PersonalityTraitC2 ? 1 : 0;
            result += this.characterData.personality.PersonalityTraitC3 == tPersonality.PersonalityTraitC3 ? 1 : 0;

            result += this.characterData.personality.PersonalityTraitD1 == tPersonality.PersonalityTraitD1 ? 1 : 0;
            result += this.characterData.personality.PersonalityTraitD2 == tPersonality.PersonalityTraitD2 ? 1 : 0;
            result += this.characterData.personality.PersonalityTraitD3 == tPersonality.PersonalityTraitD3 ? 1 : 0;

            int charmBonus = Math.Max(charlieCharm, this.characterData.Stats.Charm);
            int charmBonusSameSpecies = charlie.characterData.species == this.characterData.species ? charmBonus : 0;

            charmBonus = (int)((charmBonus - (Globals.MaxStatLimit * 0.65)) / 0.15); // Charm bonus only gives +1/+2 if charm is 80%/95% the max Stat Value

            charmBonusSameSpecies = (int)(charmBonusSameSpecies - ((this.characterData.species.speciesMaxStats.Charm * .65) / .15)); // if SOCharacters are the same species, charmbonus gives +1/+2 depending on their species Max Charm

            charmBonus = Math.Max(charmBonus, charmBonusSameSpecies);
            charmBonus = Math.Max(charmBonus, 0); // No negative impacts of low charm. Sorry IncelMaxxers.
            result = result > 0 ? result + charmBonus : result; //If they hate each other, charm will not make them hate each other less.
            result = Math.Min(result, 10);

            return result switch
            {
                0 => 0,
                1 => 1,
                2 => 2,
                3 => 2,
                4 => 2,
                5 => 5,
                6 => 6,
                7 => 7,
                8 => 7,
                9 => 7,
                10 => 7,
                _ => 7
            };
        }



        public void GenerateCharacter(Location recruitLocation, JobType? jobHiringFor = null, List<Injury> injuriesAllowed = null,
                                        int? salaryMin = null, int? salaryMax = null, List<Job> jobExperiencePrime = null, List<Job> jobExperienceSec = null, List<Job> jobExperienceTert = null, int? fightingSkill = null,
                                        StatBlock? statblock = null, SkillBlock? skillBlock = null, int? cost = null, Species species = null,
                                        List<Personality> tPersonality = null, List<Age> ageList = null, SOCharacter SOCharlie = null)
            // Some of these options will not be available to the player.  
            //Still deciding if I should generate x number of candidates and then only show the ones that fall in their requests, or generate a character within all of their requests.
        {
            characterData = null;
            if (SOCharlie != null)
            {
                characterData = SOCharlie;

            }
            else
            {
                characterData = ScriptableObject.CreateInstance<SOCharacter>();

                // Set species Information
                characterData.species = species != null ? species : recruitLocation.GetRandomSpecies();
                characterData.personality = tPersonality != null ? characterData.personality.getRandomPersonality(tPersonality) : characterData.species.getRandomPersonality();
                
                int monthsOfLife = characterData.species.lifeSpan - characterData.species.ageOfMaturity;
                Age age;
                if (ageList != null)
                {
                    age = ageList[Globals.Instance.rand.Next(ageList.Count - 1)];
                }
                else
                {
                    age = (Age)Globals.Instance.rand.Next(4);
                }
                characterData.initAge = age;
                characterData.birthDay = age switch
                {
                    Age.Young => Calendar.CalInstance.GetPastDate(pastDay: Globals.Instance.rand.Next(0, Globals.daysInWeek),
                                                                    pastWeek: Globals.Instance.rand.Next(0, Globals.weeksInMonth),
                                                                    pastMonth: (int)(monthsOfLife * Globals.Instance.rand.Next(-20, 21) / 200)), // -10% to +10% in steps of 0.5%  (( x * 20 / 200 == x / 10 == 10% of x ))

                    Age.Prime => Calendar.CalInstance.GetPastDate(pastDay: Globals.Instance.rand.Next(0, Globals.daysInWeek),
                                                                    pastWeek: Globals.Instance.rand.Next(0, Globals.weeksInMonth),
                                                                    pastMonth: (int)(monthsOfLife * Globals.Instance.rand.Next(20, 61) / 200)), // 10-30%% in steps of 0.5% 

                    Age.MiddleAge => Calendar.CalInstance.GetPastDate(pastDay: Globals.Instance.rand.Next(0, Globals.daysInWeek),
                                                                    pastWeek: Globals.Instance.rand.Next(0, Globals.weeksInMonth),
                                                                    pastMonth: (int)(monthsOfLife * Globals.Instance.rand.Next(60, 131) / 200)), // 30% to +65% in steps of 0.5% 

                    Age.Ancient => Calendar.CalInstance.GetPastDate(pastDay: Globals.Instance.rand.Next(0, Globals.daysInWeek),
                                                                    pastWeek: Globals.Instance.rand.Next(0, Globals.weeksInMonth),
                                                                    pastMonth: (int)(monthsOfLife * Globals.Instance.rand.Next(130, 191) / 200)), // -65% to +95% in steps of 0.5%                                                                    
                    _ => Calendar.CalInstance.GetPastDate(pastDay: Globals.Instance.rand.Next(0, Globals.daysInWeek),
                                                                    pastWeek: Globals.Instance.rand.Next(0, Globals.weeksInMonth),
                                                                    pastMonth: (int)(monthsOfLife * Globals.Instance.rand.Next(-20, 21) / 200))
                };
                if (jobExperienceTert != null)
                {
                    characterData.jobExperienceTertiary = jobExperienceTert[Globals.Instance.rand.Next(jobExperienceTert.Count)];
                    characterData.jobExperienceSecondary = jobExperienceSec[Globals.Instance.rand.Next(jobExperienceSec.Count)];
                    characterData.jobExperiencePrimary = jobExperiencePrime[Globals.Instance.rand.Next(jobExperiencePrime.Count)];
                }
                else if (jobExperienceSec != null)
                {
                    characterData.jobExperienceSecondary = jobExperienceSec[Globals.Instance.rand.Next(jobExperienceSec.Count)];
                    characterData.jobExperiencePrimary = jobExperiencePrime[Globals.Instance.rand.Next(jobExperiencePrime.Count)];
                }
                else if (jobExperiencePrime != null)
                {
                    characterData.jobExperiencePrimary = jobExperiencePrime[Globals.Instance.rand.Next(jobExperiencePrime.Count)];
                }
                else
                {
                    //Personality, Job hiring for, Location


                }


            }

        }
    }
}