using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Invoke("RestartGame", 1f);
        }

    }
    void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

