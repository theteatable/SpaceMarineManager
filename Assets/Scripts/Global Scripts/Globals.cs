using SMercenaries.SNations;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEditor;
using UnityEngine;

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

        private static string VALUE_CHANGE_LIST_FILEPATH = "Assets/Scripts/Editor/Config/valueChangeList.csv";

        public const int DayLength = 12; // number of hours
        public const int WeekLength = 6; // number of days 
        
        public const int MonthLength = 6; // number of weeks
        public const int YearLength  = 12; // number of months
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

        //private static List<DataValue> ReadFromCSV(string path)
        //{
        //    StreamReader streamReader = new StreamReader(path);
        //    if (streamReader == null)
        //    {
        //        return null;
        //    }
        //    List<DataValue> data = new List<DataValue>();
        //    string line = streamReader.ReadLine();
        //    var titleSplit = line.Split(',');
        //    _editorWindow.headerName = titleSplit[0];
        //    _editorWindow.headerValueChange = titleSplit[1];
        //    _editorWindow.headerMin = titleSplit[2];
        //    _editorWindow.headerMax = titleSplit[3];
        //    while ((line = streamReader.ReadLine()) != null)
        //    {
        //        var lineSplit = line.Split(',');
        //        var newDatum = new DataValue(lineSplit[0], int.Parse(lineSplit[1]), int.Parse(lineSplit[2]), int.Parse(lineSplit[3]));
        //        data.Add(newDatum);
        //    }
        //    streamReader.Dispose();
        //    return data;
        //}



    }
}