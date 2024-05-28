using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    void Start()
    {
        if (MainCanvas.Instance != null)
        {
            MainCanvas.Instance.SetMoney(0);
            Debug.Log(MainCanvas.Instance.GetMoney());
        }
    }
}