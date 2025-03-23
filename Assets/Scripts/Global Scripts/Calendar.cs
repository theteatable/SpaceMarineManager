using UnityEngine;

namespace SMercenaries.Global
{
    public class Calendar : Date
    {
        private static int _startingDay = 0;
        private static int _startingWeek = 3;
        private static int _startingMonth = 6;
        private static int _startingYear = 4344;

        
        
        public static Calendar CalInstance = (Calendar) new Date(_startingDay, _startingWeek, _startingMonth,_startingYear);

        private void Awake()
        {
            if (CalInstance != null && CalInstance != this)
            {
                Destroy(this);
            }
            else
            {
                CalInstance = this;
            }
        }


    }
}