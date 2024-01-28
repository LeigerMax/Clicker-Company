using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  This class contains the save and load methods.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>27-01-2024</lastModified>

public class SaveLoad : MonoBehaviour
{

    private PlayerLevel playerLevel;

    void Start()
    {
        // MoneyScript
        GetComponent<GameManagerScript>().money.Money = PlayerPrefs.GetFloat("Money",0);


        // PlayerLevels
        GetComponent<GameManagerScript>().playerLevel.PlayerXp = PlayerPrefs.GetFloat("PlayerXp",0);
        GetComponent<GameManagerScript>().playerLevel.PlayerLevelValue = PlayerPrefs.GetInt("PlayerLevelValue",0);
        GetComponent<GameManagerScript>().playerLevel.PlayerNeededXp = PlayerPrefs.GetFloat("PlayerNeededXp",100);
        GetComponent<GameManagerScript>().playerLevel.ExperienceMultiplier = PlayerPrefs.GetFloat("ExperienceMultiplier",.50f);


        // GameManagerScript
        GetComponent<GameManagerScript>().clickCounter = PlayerPrefs.GetInt("ClickCount",0);
     
    }

    public void SaveProfile() 
    {
        // MoneyScript
        PlayerPrefs.SetFloat("Money",  GetComponent<GameManagerScript>().money.Money);


        // PlayerLevel
        PlayerPrefs.SetFloat("PlayerXp",  GetComponent<GameManagerScript>().playerLevel.PlayerXp);
        PlayerPrefs.SetInt("PlayerLevelValue",  GetComponent<GameManagerScript>().playerLevel.PlayerLevelValue);
        PlayerPrefs.SetFloat("PlayerNeededXp",  GetComponent<GameManagerScript>().playerLevel.PlayerNeededXp);
        PlayerPrefs.SetFloat("ExperienceMultiplier",  GetComponent<GameManagerScript>().playerLevel.ExperienceMultiplier);


        // GameManagerScript
        PlayerPrefs.SetInt("ClickCount", GetComponent<GameManagerScript>().clickCounter);
       
       
    }


}