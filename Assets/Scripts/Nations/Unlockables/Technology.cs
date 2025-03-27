using SMercenaries.Global;
using UnityEngine;
using System;

namespace SMercenaries.SNations
{
    //[CreateAssetMenu(fileName = "Technology", menuName = "Scriptable Objects/Nation/Technology")]
    public class Technology : ScriptableObject
    {
        public string TechName { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        //public Image icon;
        public Location[] SaleLocations { get; set; }
        public int price;



        public int complexity; // how complex is this thing to learn
 
        // Caps Understanding at 150, with a soft cap at 100.
        //TODO: Number Reconfiguring
        [SerializeField] private int _maxUnderstanding = 150;
        [SerializeField] private int _limiterUnderstand = 100;
        [SerializeField] private int _limiterUnderstandingGrowth = 3;
        [SerializeField] private int _understandingChange = 5;
        private int _understanding = 0;
        public int Understanding
        {
            get
            {
                return _understanding;
            }
            private set
            {
                if (value > _maxUnderstanding)
                {
                    _understanding += _limiterUnderstandingGrowth;
                }
                else if (value < 0)
                {
                    _understanding = 0;
                }
                else
                {
                    _understanding = value;
                }
            }
        }
        public void AlterUnderstanding(int amount)
        {
            amount = amount > _understandingChange ? _understandingChange : amount; // limits value to adding to understanding by a max of _understandingchange
            amount = amount < -1 * _understandingChange ? -1 * _understandingChange : amount; // limits decrementing value by a max of negative _understandingchange
            if (_understanding > _maxUnderstanding)
            {
                _understanding = _maxUnderstanding;
            }
            else if (_understanding > _limiterUnderstand && amount > 0)
            {
                _understanding += amount > _limiterUnderstandingGrowth ? _limiterUnderstandingGrowth : amount;
            }
            else
            {
                _understanding += amount;
            }
_understanding = _understanding < 0 ? 0 : _understanding;
        }

        //TODO: Add a monthly decrementer for technology that has not been studied in several months
        public Date DateLastStudied { get; set; }
        public Date DateLastUsed { get; set; }



        /*
        public TechnologyType TechType;
        //how to get said enum values
        public void someMethod ()
        {
            if(TechType == TechnologyType.Defense)
            {
                //do blahblah
            }
            if(TechType == TechnologyType.Weapon)
            {

            }
        }
        //Does bitWise operations to create an enum with multiple values.
        [Flags]
        public enum TechnologyType
        {
            None = 0,
            Weapon = 1<<0,
            Defense = 1<<1,
            Facility = 1<<2,
            Ship = 1<<3
        }

        */


    }
}