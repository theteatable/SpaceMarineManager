using UnityEngine;

namespace SMercenaries.SNations
{
    [CreateAssetMenu(fileName = "Cloning", menuName = "Scriptable Objects/Nation/Facility/Cloning")]
    public class Cloning : ScriptableObject
    {
        public int CloningSpeed {  get; private set; } // How long it takes to make one clone
        public int CloningNumber { get; private set; } // How many clones it can make at once

        public int PermanentStatLoss { get; private set; }
        public int TemporaryStatLoss { get; private set; }
        public int StatRecoveryTime { get; private set; } // in months



        

    }
}