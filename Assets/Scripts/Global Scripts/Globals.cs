using SMercenaries.SNations;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEditor;
using UnityEngine;
using System;
using SMercenaries.People;


namespace SMercenaries.Global {
    public class Globals : MonoBehaviour {
        public static Globals Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Instance = this;
            }
        }
       // private static string VALUE_CHANGE_LIST_FILEPATH = "Assets/Scripts/Editor/Config/valueChangeList.csv";
        //private static Int32 randomSeed;



        public const int hoursInDay = 12; // number of hours
        public const int daysInWeek = 6; // number of days 
        
        public const int weeksInMonth = 6; // number of weeks
        public const int monthsInYear  = 12; // number of months
        public static int InjuryArraySizeDefault { get; private set; } = 8;
        public static int MaxStatLimit { get; private set; } = 5000; //TODO: make a file reader.

        public enum Handedness {
            Left,
            Right,
            Ambi,
            None
        }
        public enum Socialability {
            Low,
            Normal,
            High
        }
        public enum Gravity {
            HighG,
            StandardG,
            NullG
        }

        public System.Random rand = new System.Random(); //TODO: Implement randomSeed into this





    }
}