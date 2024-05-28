using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class MainCanvas : MonoBehaviour
{
    public TextMeshProUGUI TimeText;
    public static MainCanvas Instance = null;
    private int money;
    public TextMeshProUGUI moneyText;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        SetMoney(GetMoney());
    }

    // Update is called once per frame
    void Update()
    {
        DateTime now = DateTime.Now;
        TimeText.text = now.ToString("MM/dd ddd HH:mm:ss", CultureInfo.InvariantCulture);        
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void SetMoney(int value)
    {
        money += value;
        UpdateMoneyText();
    }

    public int GetMoney()
    {
        return money;
    }


    private void UpdateMoneyText()
    {
        moneyText.text = money.ToString();
    }
}
