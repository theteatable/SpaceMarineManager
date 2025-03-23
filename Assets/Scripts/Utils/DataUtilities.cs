using UnityEngine;
using UnityEditor;

namespace SMercenaries.Tooling
{
    public class DataUtilities
    {
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
    }
}