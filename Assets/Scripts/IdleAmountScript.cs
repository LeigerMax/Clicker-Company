using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This classis used for managing the player's idle amount.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>28-01-2024</lastModified>

public class IdleAmountScript : MonoBehaviour
{
    [SerializeField] private float amount;

    public float IdleAmount
    {
        get { return amount; }
        set { amount = value; }
    }

    public void AddAmount(float getIdleAmount){
        amount += getIdleAmount;
    }
  

}
