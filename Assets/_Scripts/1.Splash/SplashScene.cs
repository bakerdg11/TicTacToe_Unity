using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScene : MonoBehaviour
{
    public float duration;
    public float timedelta;

    private void Update()
    {
        if (duration <= 0.0f)
        {
            SceneManager.LoadScene("MenuScene");
        }
        else
        {
            duration = duration - Time.deltaTime;
        }
    }
}
