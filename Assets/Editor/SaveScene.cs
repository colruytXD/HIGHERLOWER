using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[InitializeOnLoad]
public class AutosaveOnRun
{
    static AutosaveOnRun()
    {
        EditorApplication.playmodeStateChanged = () =>
        {
            if (EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying)
            {
                Debug.Log("Auto-Saving scene before entering Play mode: " + EditorSceneManager.loadedSceneCount);

                EditorSceneManager.SaveOpenScenes();
                AssetDatabase.SaveAssets();
            }
        };
    }
}
