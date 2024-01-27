using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This classis used for managing the player's money.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>27-01-2024</lastModified>

public class MoneyScript : MonoBehaviour
{
    [SerializeField] private float money = 0;
    [SerializeField] private Text moneyText;
    private NumberConverter numberConverter = new NumberConverter();

    public float Money
    {
        get { return money; }
        set { money = value; }
    }


    public void AddMoney(float moneyToAdd)
    {
        money += moneyToAdd;
        UpdateMoneyUI();
    }

    public void RemoveMoney(float moneyToRemove)
    {
        money -= moneyToRemove;
        UpdateMoneyUI();
    }

    public void UpdateMoneyUI()
    {
        moneyText.text = "Money :" + numberConverter.UpdateUI(money,"$");
    }    
    
}
