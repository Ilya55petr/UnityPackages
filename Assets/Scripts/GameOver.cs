using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    

    void Update()
    {
        if (GetComponent<HealthLevel>().healthLevel < 10)
        {
            SceneManager.LoadScene("UI");
        }
    }
}
