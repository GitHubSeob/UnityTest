using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public GameObject PausePanel;
    private Canvas PlantCanvas;
    private Canvas AnimalCanvas;

    private void Start()
    {
        PlantCanvas = GameObject.Find("PlantCanvas").GetComponent<Canvas>();
        AnimalCanvas = GameObject.Find("AnimalCanvas").GetComponent<Canvas>();
    }

    public void OnClickAnimal()
    {
        PlantCanvas.enabled = false;
        AnimalCanvas.enabled = true;
    }

    public void OnClickPlant()
    {
        PlantCanvas.enabled = true;
        AnimalCanvas.enabled = false;
    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
