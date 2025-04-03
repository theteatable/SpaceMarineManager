using UnityEngine;
using System.Collections.Generic;

namespace SMercenaries.People
{
    [CreateAssetMenu(fileName = "AllScriptableObjects", menuName = "Scriptable Objects/AllScriptableObjects")]
    public class AllScriptableObjects : ScriptableObject
    {


        public List<Job> Jobs { get; private set; } = new List<Job>();
        public List<Character> Characters { get; private set; } = new();
        public List<Personality> Personalities { get; private set; } = new();
        public List<Species> Species { get; private set; } = new();
        public List<Injury> Injuries { get; private set; } = new();

        public void AddJob(Job job)
        {
            if (!Jobs.Contains(job))
            {
                Jobs.Add(job);
                Debug.Log("New Scriptable Object {0} added", job);
            }
        }
        public void RemoveJob(Job job)
        {
            Jobs.Remove(job);
            Debug.Log("New Scriptable Object {0} removed", job);

        }
        public void AddCharacter(Character character)
        {
            if (!Characters.Contains(character))
            {
                Characters.Add(character);
                Debug.Log("New Scriptable Object {0} added", character);
            }
        }
        public void RemoveCharacter(Character character) 
        {
            Characters.Remove(character);
            Debug.Log("New Scriptable Object {0} removed", character);
        }

        

        public void AddPersonality(Personality personality)
        {
            if (!Personalities.Contains(personality))
            {
                Personalities.Add(personality);
                Debug.Log("New Scriptable Object {0} added", personality);
            }
        }
        public void RemovePersonality(Personality personality)
        {
            Personalities.Remove(personality);
            Debug.Log("New Scriptable Object {0} removed", personality);
        }


        public void AddSpecies(Species species)
        {
            if (!Species.Contains(species))
            {
                Species.Add(species);
                Debug.Log("New Scriptable Object {0} added", species);
            }
        }
        public void RemoveSpecies(Species species)
        {
            Species.Remove(species);
            Debug.Log("New Scriptable Object {0} removed", species);
        }


        public void AddInjury(Injury injury)
        {
            if (!Injuries.Contains(injury))
            {
                Injuries.Add(injury);
                Debug.Log("New Scriptable Object {0} added", injury);
            }
        }
        public void RemoveInjury(Injury injury)
        {
            Injuries.Remove(injury);
            Debug.Log("New Scriptable Object {0} removed", injury);
        }



    }
}