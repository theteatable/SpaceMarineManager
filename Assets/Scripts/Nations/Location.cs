using UnityEngine;
using System.Collections.Generic;
using SMercenaries.People;
using SMercenaries.Tooling;

namespace SMercenaries.SNations
{
    public class Location : ScriptableObject
    {

        public int xCoords;
        public int yCoords;
        

        //public Image mapLocationImage; TODO: This will connect to Map Manager to create a minture pop up of the locations

        //public Image systemView; TODO: This will connect to a system that will draw the system, whether it just shows the habitations/facilities inside or draws an actual Solar System TBD

        public List<Habitation> localHabitations;
        public List<Species> speciesList;

        //this is so that the game can draw the map without looking for conflicts in nations.
        public List<Nation> locationOwnedBy;

        public Dictionary<Location, int> connectedZones; // int is travel time in days to next location.

        public Species GetRandomSpecies()
        {
            int random = Random.Range(0, speciesList.Count);
            return speciesList[random];
        }
        public Job[] GetLocalJobs()
        {

            return null;
        }

     }
}
