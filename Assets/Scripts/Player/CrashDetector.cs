using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crushParticle;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            crushParticle.Play();
            PlayerController.isAlive = false;
            Invoke("RestartGame", 1f);
        }
    }
    void RestartGame()
    {
        Menu.RestartGame();
    }
}

