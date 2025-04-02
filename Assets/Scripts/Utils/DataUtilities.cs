using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using Unity.VisualScripting;

namespace SMercenaries.Tooling
{
    public static class DataUtilities
    {
        /// <summary>
        /// Searches through the Asset Database for assets of a specific type and loads them into memory
        /// </summary>
        /// <typeparam name="T">the type of objects to search for in the Asset Database</typeparam>
        /// <returns>Array of objects (T[]) that have been loaded</returns>

        #if UNITY_EDITOR
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
        #endif
    }
}
