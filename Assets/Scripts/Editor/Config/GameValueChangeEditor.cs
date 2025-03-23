#if UNITY_EDITOR
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SMercenaries.Tooling
{
    public class GameValueChangeEditor : EditorWindow
    {
        //project paths
        private static string VALUE_CHANGE_LIST_FILEPATH = "Assets/Scripts/Editor/Config/valueChangeList.csv";

        //editor window setup and tracking variables
        private static GameValueChangeEditor _editorWindow;
        private GUISkin _gUISkin;
        private Vector2 _windowScroll = Vector2.zero;
        private string headerName = "Value";
        private string headerValueChange = "Standard Change";
        private string headerMin = "Min";
        private string headerMax = "Max";

        private List<DataValue> valueSheetLines = new List<DataValue>();

        [MenuItem("Mercenary Tools/Value Change Editor _%&v", priority = 10)]
        private static void ShowWindow()
        {
            if (_editorWindow != null)
            {
                _editorWindow.Focus();
            }
            else
            {
                _editorWindow = (GameValueChangeEditor)GetWindow(typeof(GameValueChangeEditor));
                _editorWindow.titleContent = new GUIContent("Game Value Editor");
                _editorWindow._windowScroll = Vector2.zero;
            }
            _editorWindow.valueSheetLines = ReadFromCSV(VALUE_CHANGE_LIST_FILEPATH);
        }

        private struct DataValue
        {
            public string valueName;
            public int valueChangeDefault;
            public int valueMinimum;
            public int valueMaximum;

            public DataValue(string name = "newValue", int change = 1, int min = 0, int max = 1)
            {
                valueName = name;
                valueChangeDefault = change;
                valueMinimum = min;
                valueMaximum = max;
            }
        }

        private void OnGUI()
        {
            _gUISkin = _gUISkin ?? (GUISkin)EditorGUIUtility.Load("Assets/Scripts/Editor/GUISkin_MercenaryTools.guiskin");
            GUI.skin = _gUISkin;
            var dataRemoved = false;
            int datumChangeIndex = -1;
            DataValue dvChange = new DataValue();

            _windowScroll = EditorGUILayout.BeginScrollView(_windowScroll, false, false);

            UiUtils.VerticalLayout(() => { 
                UiUtils.HorizontalLayout(() =>
                {
                    GUILayout.Label(headerName, "header");
                    GUILayout.Label(headerValueChange, "header");
                    GUILayout.Label(headerMin, "header");
                    GUILayout.Label(headerMax, "header");
                });

                for (int i = 0; i < _editorWindow.valueSheetLines.Count; i++)
                {
                    UiUtils.HorizontalLayout(() =>
                    {
                        var dataLine = _editorWindow.valueSheetLines[i];
                        UiUtils.ChangeCheck(() =>
                        {
                            dataLine.valueName = EditorGUILayout.TextField(dataLine.valueName);
                            dataLine.valueChangeDefault = EditorGUILayout.IntField(dataLine.valueChangeDefault, "intFieldSlim");
                            dataLine.valueMinimum = EditorGUILayout.IntField(dataLine.valueMinimum, "intFieldSlim");
                            dataLine.valueMaximum = EditorGUILayout.IntField(dataLine.valueMaximum, "intFieldSlim");
                        }, () =>
                        {
                            dvChange = dataLine;
                            datumChangeIndex = i;
                            EditorUtility.SetDirty(_editorWindow);
                        });
                            if (GUILayout.Button("-", "textSymbolButton"))
                        {
                            datumChangeIndex = i;
                            EditorUtility.SetDirty(_editorWindow);
                            dataRemoved = true;
                        }
                    });
                }
            });
            if (GUILayout.Button("+", "textSymbolButton"))
            {
                var dataAdd = new DataValue();
                _editorWindow.valueSheetLines.Add(dataAdd);
            }

            UiUtils.HorizontalLayoutCentered(() =>
            {
                if (GUILayout.Button("Save Changes"))
                {
                    if (EditorUtility.DisplayDialog("Yay!", "Changes saved!", "fuck yeah"))
                    {
                        WriteCSV(valueSheetLines);
                    }
                }
                if (GUILayout.Button("Revert Changes"))
                {
                    if (EditorUtility.IsDirty(_editorWindow))
                    {
                        if (EditorUtility.DisplayDialog("Revert Changes", "Are you sure?\nThis is a non-recoverable action.", "Okay... and?", "Oh shit wait"))
                        {
                            _editorWindow.valueSheetLines.Clear();
                            _editorWindow.valueSheetLines = ReadFromCSV(VALUE_CHANGE_LIST_FILEPATH);
                        }
                    }
                }
            });

            if (datumChangeIndex != -1)
            {
                if (dataRemoved)
                {
                    _editorWindow.valueSheetLines.RemoveAt(datumChangeIndex);
                }
                else
                {
                    _editorWindow.valueSheetLines[datumChangeIndex] = dvChange;
                }
            }
            EditorGUILayout.EndScrollView();
        }

        private void OnDestroy()
        {

            if (EditorUtility.IsDirty(_editorWindow))
            {
                if (EditorUtility.DisplayDialog("Save Changes?", "Do you want to save your changes before closing?", "I do, actually. My bad", "No, I only click with intention"))
                {
                    WriteCSV(valueSheetLines);
                }
            }
            _editorWindow = null;
        }

        private static List<DataValue> ReadFromCSV(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            if (streamReader == null)
            {
                return null;
            }
            List<DataValue> data = new List<DataValue>();
            string line = streamReader.ReadLine();
            var titleSplit = line.Split(',');
            _editorWindow.headerName = titleSplit[0];
            _editorWindow.headerValueChange = titleSplit[1];
            _editorWindow.headerMin = titleSplit[2];
            _editorWindow.headerMax = titleSplit[3];
            while ((line = streamReader.ReadLine()) != null)
            {
                var lineSplit = line.Split(',');
                var newDatum = new DataValue(lineSplit[0], int.Parse(lineSplit[1]), int.Parse(lineSplit[2]), int.Parse(lineSplit[3]));
                data.Add(newDatum);
            }
            streamReader.Dispose();
            return data;
        }

        private void WriteCSV(List<DataValue> updatedData)
        {
            if (updatedData?.Count < 1)
            {
                return;
            }
            using (StreamWriter csvOut = new StreamWriter(new FileStream(VALUE_CHANGE_LIST_FILEPATH, FileMode.OpenOrCreate, FileAccess.Write)))
            {
                List<string> lines = new List<string>();
                string title = $"{headerName},{headerValueChange},{headerMin},{headerMax}";
                lines.Add(title);
                foreach (var datum in updatedData)
                {
                    string line = $"{datum.valueName},{datum.valueChangeDefault},{datum.valueMinimum},{datum.valueMaximum}";
                    lines.Add(line);
                }
                if (lines?.Count > 0)
                {
                    foreach (var line in lines)
                    {
                        csvOut.WriteLine(line);
                    }
                }
                csvOut.Close();
            }
        }
    }
}
#endif
