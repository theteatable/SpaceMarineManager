using UnityEngine;
using System.Collections.Generic;
namespace SMercenaries.SNations
{
    public class Habitation : ScriptableObject
    {


        public List<Facility> localFacilities;

        public bool inContention; // if there is a contract occuring on site.

        public enum HabitationType
        {
            Planet,
            Asteroid,
            SpaceStationLarge,
            SpaceStationSmall,
            Moon,
            DysonRing,
            DysonSphere
            //WorldShip TODO: implement a ship class 
        }
    }
}