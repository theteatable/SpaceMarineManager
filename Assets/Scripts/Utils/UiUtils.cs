using System;
using UnityEditor;
using UnityEngine;

namespace SMercenaries.Tooling
{
    public static class UiUtils
    {
        /// <summary>
        /// Wraps a block of UI code in a Horizontal Layout that is JUSTIFIED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.HorizontalLayout(()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="guiCode">the rest of the ui code you want to add inside the horizontal block</param>
        public static void HorizontalLayout(Action guiCode)
        {
            GUILayout.BeginHorizontal();
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// Wraps a block of UI code in a Horizontal Layout that is JUSTIFIED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.HorizontalLayout("myStyleName", ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="guiStyle">The GUIStyle to apply to the layout. Call by string name.</param>
        /// <param name="guiCode">the rest of the ui code you want to add inside the horizontal block</param>
        public static void HorizontalLayout(string guiStyle, Action guiCode)
        {
            if (guiStyle == "" || guiStyle == null)
            {
                GUILayout.BeginHorizontal();
            }
            else
            {
                GUILayout.BeginHorizontal(style: guiStyle);
            }
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// Wraps a block of UI code in a Horizontal Layout that is JUSTIFIED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.HorizontalLayout(myGuiOptions, ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="options">The GUILayoutOption(s) to apply to the layout. Pass array by setting up your own gui layout options object</param>
        /// <param name="guiCode">the rest of the ui code you want to add inside the horizontal block</param>
        public static void HorizontalLayout(GUILayoutOption[] options, Action guiCode)
        {
            GUILayout.BeginHorizontal(options);
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// Wraps a block of UI code in a Horizontal Layout that is LEFT-ALIGNED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.HorizontalLayout(()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="guiCode">the rest of the ui code you want to add inside the horizontal block</param>
        public static void HorizontalLayoutLeft(Action guiCode)
        {
            GUILayout.BeginHorizontal();
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// Wraps a block of UI code in a Horizontal Layout that is LEFT-ALIGNED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.HorizontalLayout("myStyleName", ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="guiStyle">The GUIStyle to apply to the layout. Call by string name.</param>
        /// <param name="guiCode">the rest of the ui code you want to add inside the horizontal block</param>
        public static void HorizontalLayoutLeft(string guiStyle, Action guiCode)
        {
            if (guiStyle == "" || guiStyle == null)
            {
                GUILayout.BeginHorizontal();
            }
            else
            {
                GUILayout.BeginHorizontal(style: guiStyle);
            }
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// Wraps a block of UI code in a Horizontal Layout that is LEFT-ALIGNED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.HorizontalLayout(myGuiOptions, ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="options">The GUILayoutOption(s) to apply to the layout. Pass array by setting up your own gui layout options object</param>
        /// <param name="guiCode">the rest of the ui code you want to add inside the horizontal block</param>
        public static void HorizontalLayoutLeft(GUILayoutOption[] options, Action guiCode)
        {
            GUILayout.BeginHorizontal(options);
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// Wraps a block of UI code in a Horizontal Layout that is CENTERED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.HorizontalLayout(()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="guiCode">the rest of the ui code you want to add inside the horizontal block</param>
        public static void HorizontalLayoutCentered(Action guiCode)
        {
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// Wraps a block of UI code in a Horizontal Layout that is CENTERED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.HorizontalLayout("myStyleName", ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="guiStyle">The GUIStyle to apply to the layout. Call by string name.</param>
        /// <param name="guiCode">the rest of the ui code you want to add inside the horizontal block</param>
        public static void HorizontalLayoutCentered(string guiStyle, Action guiCode)
        {
            if (guiStyle == "" || guiStyle == null)
            {
                GUILayout.BeginHorizontal();
            }
            else
            {
                GUILayout.BeginHorizontal(style: guiStyle);
            }
            GUILayout.FlexibleSpace();
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// Wraps a block of UI code in a Horizontal Layout that is CENTERED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.HorizontalLayout(myGuiOptions, ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="options">The GUILayoutOption(s) to apply to the layout. Pass array by setting up your own gui layout options object</param>
        /// <param name="guiCode">the rest of the ui code you want to add inside the horizontal block</param>
        public static void HorizontalLayoutCentered(GUILayoutOption[] options, Action guiCode)
        {
            GUILayout.BeginHorizontal(options);
            GUILayout.FlexibleSpace();
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// Wraps a block of UI code in a Horizontal Layout that is RIGHT-ALIGNED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.HorizontalLayout(()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="guiCode">the rest of the ui code you want to add inside the horizontal block</param>
        public static void HorizontalLayoutRight(Action guiCode)
        {
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                Debug.LogError(e);
            }
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// Wraps a block of UI code in a Horizontal Layout that is RIGHT-ALIGNED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.HorizontalLayout("myStyleName", ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="guiStyle">The GUIStyle to apply to the layout. Call by string name.</param>
        /// <param name="guiCode">the rest of the ui code you want to add inside the horizontal block</param>
        public static void HorizontalLayoutRight(string guiStyle, Action guiCode)
        {
            if (guiStyle == "" || guiStyle == null)
            {
                GUILayout.BeginHorizontal();
            }
            else
            {
                GUILayout.BeginHorizontal(style: guiStyle);
            }
            GUILayout.FlexibleSpace();
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// Wraps a block of UI code in a Horizontal Layout that is RIGHT-ALIGNED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.HorizontalLayout(myGuiOptions, ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="options">The GUILayoutOption(s) to apply to the layout. Pass array by setting up your own gui layout options object</param>
        /// <param name="guiCode">the rest of the ui code you want to add inside the horizontal block</param>
        public static void HorizontalLayoutRight(GUILayoutOption[] options, Action guiCode)
        {
            GUILayout.BeginHorizontal(options);
            GUILayout.FlexibleSpace();
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.EndHorizontal();
        }

        /// <summary>
        /// Wraps a block of UI code in a Vertical Layout that is JUSTIFIED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.VerticalLayout(()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="guiCode">the rest of the ui code you want to add inside the vertical block</param>
        public static void VerticalLayout(Action guiCode)
        {
            GUILayout.BeginVertical();
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.EndVertical();
        }

        /// <summary>
        /// Wraps a block of UI code in a Vertical Layout that is JUSTIFIED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.VerticalLayout("myStyleName", ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="guiStyle">The GUIStyle to apply to the layout. Call by string name.</param>
        /// <param name="guiCode">the rest of the ui code you want to add inside the vertical block</param>
        public static void VerticalLayout(string guiStyle, Action guiCode)
        {
            if (guiStyle == "" || guiStyle == null)
            {
                GUILayout.BeginVertical();
            }
            else
            {
                GUILayout.BeginVertical(style: guiStyle);
            }
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.EndVertical();
        }

        /// <summary>
        /// Wraps a block of UI code in a Vertical Layout that is JUSTIFIED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.VerticalLayout(myGuiOptions, ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="options">The GUILayoutOption(s) to apply to the layout. Pass array by setting up your own gui layout options object</param>
        /// <param name="guiCode">the rest of the ui code you want to add inside the vertical block</param>
        public static void VerticalLayout(GUILayoutOption[] options, Action guiCode)
        {
            GUILayout.BeginVertical(options);
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.EndVertical();
        }

        /// <summary>
        /// Wraps a block of UI code in a Vertical Layout that is CENTERED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.VerticalLayout(()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="guiCode">the rest of the ui code you want to add inside the vertical block</param>
        public static void VerticalLayoutCentered(Action guiCode)
        {
            GUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
        }

        /// <summary>
        /// Wraps a block of UI code in a Vertical Layout that is CENTERED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.VerticalLayout("myStyleName", ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="guiStyle">The GUIStyle to apply to the layout. Call by string name.</param>
        /// <param name="guiCode">the rest of the ui code you want to add inside the vertical block</param>
        public static void VerticalLayoutCentered(string guiStyle, Action guiCode)
        {
            if (guiStyle == "" || guiStyle == null)
            {
                GUILayout.BeginVertical();
            }
            else
            {
                GUILayout.BeginVertical(style: guiStyle);
            }
            GUILayout.FlexibleSpace();
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
        }

        /// <summary>
        /// Wraps a block of UI code in a Vertical Layout that is CENTERED, visually separating it from the in-line UI code.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.VerticalLayout(myGuiOptions, ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="options">The GUILayoutOption(s) to apply to the layout. Pass array by setting up your own gui layout options object</param>
        /// <param name="guiCode">the rest of the ui code you want to add inside the vertical block</param>
        public static void VerticalLayoutCentered(GUILayoutOption[] options, Action guiCode)
        {
            GUILayout.BeginVertical(options);
            GUILayout.FlexibleSpace();
            try
            {
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
        }

        /// <summary>
        /// Wrapts a block of UI code in a custom-sized Area that can be filled with new UI elements.
        /// To implement it, you can give it a lambda function that contains the rest of your UI code, like this:
        /// DLS_UI_Utils.InternalArea(myVector2Size, ()=>{ ....ui code here.... });
        /// </summary>
        /// <param name="size">The width and height of the desired Area</param>
        /// <param name="guiCode">The rest of the ui code you want to add inside the area</param>
        public static void InternalArea(Vector2 size, Action guiCode)
        {
            Rect rect = new Rect(0, 0, size.x, size.y);
            GUILayout.BeginArea(rect);
            guiCode();
            GUILayout.EndArea();
        }

#if UNITY_EDITOR
        /// <summary>
        /// Wraps EditorGUI.BeginChangeCheck() and EditorGUI.EndChangeCheck() in custom-indented functions to visually separate them from in-line UI code.
        /// To implement it, you can pass both parameters a lambda function that contains the UI code for each, like this:
        /// DLS_UI_Utils.ChangeCheck(guiElementsToWatch: ()=>{ ....ui elements to monitor for change here....}, endChangeAction: ()=> {....code to execute when change is detected....});
        /// I recommend using C# re-orderable parameters declaration to add clarity here, since having two lambdas in a single block can get confusing.
        /// </summary>
        /// <param name="guiElementsToWatch"></param>
        /// <param name="endChangeAction"></param>
        public static void ChangeCheck(Action guiElementsToWatch, Action endChangeAction)
        {
            EditorGUI.BeginChangeCheck();
            guiElementsToWatch();
            if (EditorGUI.EndChangeCheck())
            {
                endChangeAction();
            }
        }

        /// <summary>
        /// Adds a horizontal line to your UI using either the default GUI's "horizontalSlider" visual style is, or a custom visual style given a string name.
        /// </summary>
        /// <param name="guiStyle">(Optional) the name of the GUI Style to apply to the line</param>
        public static void HorizontalLine(string guiStyle = "")
        {
            EditorGUILayout.Space();
            if (guiStyle == "")
            {
                EditorGUILayout.LabelField(label: "", style: GUI.skin.horizontalSlider);
            }
            else
            {
                EditorGUILayout.LabelField(label: "", style: guiStyle);
            }
            EditorGUILayout.Space();
        }
#endif

        /// <summary>
        /// Given a condition, enables or disables a block of UI code for interaction by the user.
        /// To implement it, you can pass the second parameter a lambda function that contains the UI code for each, like this:
        /// DLS_UI_Utils.SetComponentEnabled(myBool, ()=>{....ui code here....});
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="guiCode"></param>
        public static void SetComponentEnabled(bool condition, Action guiCode)
        {
            try
            {
                GUI.enabled = condition;
                guiCode();
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        GUI.enabled = true;
        }

        /// <summary>
        /// Attempts to retrieve a particular Monobehaviour Component from a GameObject, and if it is not present, adds it to the object.
        /// </summary>
        /// <typeparam name="T">the type of the component to retrieve</typeparam>
        /// <param name="go">the GameObject to search for the component on</param>
        /// <returns>The found or created component</returns>
        public static T GetOrAddComponent<T>(this GameObject go) where T : Component
        {
            var comp = go.GetComponent<T>();
            return comp != null ? comp : go.AddComponent<T>();
        }

#if UNITY_EDITOR
        /// <summary>
        /// Searches through the Asset Database for assets of a specific type and loads them into memory
        /// </summary>
        /// <typeparam name="T">the type of objects to search for in the Asset Database</typeparam>
        /// <returns>Array of objects (T[]) that have been loaded</returns>
        public static T[] LoadAssetsOfType<T>() where T : UnityEngine.Object
        {
            var assetsToLoad = AssetDatabase.FindAssets($"t:{typeof(T)}");
            T[] values = new T[assetsToLoad.Length];
            for (int i = 0; i < assetsToLoad.Length; i++)
            {
                var guidToPath = AssetDatabase.GUIDToAssetPath(assetsToLoad[i]);
                values[i] = AssetDatabase.LoadAssetAtPath<T>(guidToPath);
            }
            return values;
        }
#endif
    }
}
