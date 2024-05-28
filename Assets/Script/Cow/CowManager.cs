using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowManager : MonoBehaviour
{
    void Start()
    {
        GameObject mainCanvas = GameObject.Find("MainCanvas");
        Transform homeButtonTransform = mainCanvas.transform.Find("HomeButton");
        homeButtonTransform.gameObject.SetActive(true);
    }
}
