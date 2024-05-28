using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{    

    private void Start()
    {        
        GameObject homeButton = GameObject.Find("HomeButton");
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "GameScene")
        {
           homeButton.SetActive(false);
        }
        
    }
}
