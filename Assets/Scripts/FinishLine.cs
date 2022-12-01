using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Invoke("MainMenu", 1f);
        }
    }
    void MainMenu()
    {
        //SceneManager.LoadScene("MainMenu");
        SceneManager.LoadScene("SampleScene");
    }
}
