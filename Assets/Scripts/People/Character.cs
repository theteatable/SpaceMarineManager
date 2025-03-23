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



    //Personalities are totally random, the higher the personality score, the more boosts/bonues to actions taken between two SOCharacters.
    public int PersonalityCompatabilityCheck(SOCharacter charlie)
    {
        Personality tPersonality = charlie.personality;
        int charlieCharm = charlie.Stats.Charm;
        int result = 0;
        result += this.personality.PersonalityTraitA == tPersonality.PersonalityTraitA ? 1 : 0;

        result += this.personality.PersonalityTraitB1 == tPersonality.PersonalityTraitB1 ? 1 : 0;
        result += this.personality.PersonalityTraitB2 == tPersonality.PersonalityTraitB2 ? 1 : 0;
        result += this.personality.PersonalityTraitB3 == tPersonality.PersonalityTraitB3 ? 1 : 0;

        result += this.personality.PersonalityTraitC1 == tPersonality.PersonalityTraitC1 ? 1 : 0;
        result += this.personality.PersonalityTraitC2 == tPersonality.PersonalityTraitC2 ? 1 : 0;
        result += this.personality.PersonalityTraitC3 == tPersonality.PersonalityTraitC3 ? 1 : 0;

        result += this.personality.PersonalityTraitD1 == tPersonality.PersonalityTraitD1 ? 1 : 0;
        result += this.personality.PersonalityTraitD2 == tPersonality.PersonalityTraitD2 ? 1 : 0;
        result += this.personality.PersonalityTraitD3 == tPersonality.PersonalityTraitD3 ? 1 : 0;

        int charmBonus = Math.Max(charlieCharm, this.Stats.Charm);
        int charmBonusSameSpecies = charlie.species == this.species ? charmBonus : 0;

        charmBonus = (int)((charmBonus - (Globals.MaxStatLimit * 0.65)) / 0.15); // Charm bonus only gives +1/+2 if charm is 80%/95% the max Stat Value

        charmBonusSameSpecies = (int)(charmBonusSameSpecies - ((this.species.speciesMaxStats.Charm * .65) / .15)); // if SOCharacters are the same species, charmbonus gives +1/+2 depending on their species Max Charm

        charmBonus = Math.Max(charmBonus, charmBonusSameSpecies);
        charmBonus = Math.Max(charmBonus, 0); // No negative impacts of low charm. Sorry IncelMaxxers.
        result = result > 0 ? result + charmBonus : result; //If they hate each other, charm will not make them hate each other less.


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
            11 => 7,
            12 => 7,
            _ => 7
        };

    }

    public void GenerateCharacter(SOCharacter SOCharlie = null, Location recruitLocation, Job jobType)
        {
            characterData = null;
            if (SOCharlie != null)
            {
                characterData = SOCharlie;
   
            }
            else
            {
                characterData = ScriptableObject.CreateInstance<SOCharacter>();

                characterData.species = recruitLocation.GetSpecies();
            }


        }
    
}
}