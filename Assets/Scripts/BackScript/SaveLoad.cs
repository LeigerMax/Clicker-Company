using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  This class contains the save and load methods.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>28-01-2024</lastModified>

public class SaveLoad : MonoBehaviour
{

    private PlayerLevel playerLevel;

    void Awake()
    {
        // MoneyScript
        GetComponent<GameManagerScript2>().money.Money = PlayerPrefs.GetFloat("Money",0);

        // IdleAmountScript
        GetComponent<GameManagerScript2>().idleAmountScript.IdleAmount = PlayerPrefs.GetFloat("IdleAmount",.0f);


        // PlayerLevels
        GetComponent<GameManagerScript2>().playerLevel.PlayerXp = PlayerPrefs.GetFloat("PlayerXp",0);
        GetComponent<GameManagerScript2>().playerLevel.PlayerLevelValue = PlayerPrefs.GetInt("PlayerLevelValue",0);
        GetComponent<GameManagerScript2>().playerLevel.PlayerNeededXp = PlayerPrefs.GetFloat("PlayerNeededXp",100);
        GetComponent<GameManagerScript2>().playerLevel.ExperienceMultiplier = PlayerPrefs.GetFloat("ExperienceMultiplier",.50f);


        // GameManagerScript
        GetComponent<GameManagerScript2>().clickCounter = PlayerPrefs.GetInt("ClickCount",0);
     
    }

    public void SaveProfile() 
    {
        // MoneyScript
        PlayerPrefs.SetFloat("Money",  GetComponent<GameManagerScript2>().money.Money);

        // IdleAmountScript
        PlayerPrefs.SetFloat("IdleAmount",  GetComponent<GameManagerScript2>().idleAmountScript.IdleAmount);


        // PlayerLevel
        PlayerPrefs.SetFloat("PlayerXp",  GetComponent<GameManagerScript2>().playerLevel.PlayerXp);
        PlayerPrefs.SetInt("PlayerLevelValue",  GetComponent<GameManagerScript2>().playerLevel.PlayerLevelValue);
        PlayerPrefs.SetFloat("PlayerNeededXp",  GetComponent<GameManagerScript2>().playerLevel.PlayerNeededXp);
        PlayerPrefs.SetFloat("ExperienceMultiplier",  GetComponent<GameManagerScript2>().playerLevel.ExperienceMultiplier);


        // GameManagerScript
        PlayerPrefs.SetInt("ClickCount", GetComponent<GameManagerScript2>().clickCounter);

    }


}