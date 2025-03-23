using UnityEngine;


namespace SMercenaries.SNations
{
    [CreateAssetMenu(fileName = "Story", menuName = "Scriptable Objects/Story")]
    public class Story : ScriptableObject
    {
        public Location[] locations;
        public Habitation[] habitations;



    }
}