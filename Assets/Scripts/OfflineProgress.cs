using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;

public class OfflineProgress : MonoBehaviour
{
    public Text offlineTimeText;
    public Text pointsGainedText;
    public GameObject offlinePanel;
    
    void Start()
    {
        if(PlayerPrefs.HasKey("ExitTime"))
        {
            offlinePanel.SetActive(true);
            DateTime lastExit = DateTime.Parse(PlayerPrefs.GetString("ExitTime"));
            DateTime currentTime = DateTime.Now;

            TimeSpan timeAway = currentTime - lastExit;

            offlineTimeText.text = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds", timeAway.Days, timeAway.Hours, timeAway.Minutes, timeAway.Seconds);
            pointsGainedText.text = (GameObject.FindObjectOfType<GameManagerScript>().idleAmountScript.IdleAmount * timeAway.TotalSeconds).ToString("0.00");

            GameObject.FindObjectOfType<GameManagerScript>().money.Money += (float)(GameObject.FindObjectOfType<GameManagerScript>().idleAmountScript.IdleAmount * timeAway.TotalSeconds);

        }
        else
        {
            offlinePanel.SetActive(false);
        }
    }

    public void CloseOfflinePanel()
    {
        offlinePanel.SetActive(false);
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("ExitTime", DateTime.Now.ToString());
    }

   
 
}
