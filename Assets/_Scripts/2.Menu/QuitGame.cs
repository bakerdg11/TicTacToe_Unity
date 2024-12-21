using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void OnClick()
    {
        // This will quit the application when built as a standalone executable
        Application.Quit();

        // If running in the Unity Editor, stop playing
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}