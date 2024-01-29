using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class to manage player's level and experience.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>27-01-2024</lastModified>
    
public class PlayerLevel : MonoBehaviour
{
    [SerializeField] private float playerXp = 0;
    [SerializeField] private int playerLevelValue = 1;
    [SerializeField] private float playerNeededXp = 100;
    private float experienceMultiplier = .50f;

    [SerializeField] private Slider xpSlider;
    [SerializeField] private Text playerLvlText;

    public float PlayerXp 
    { 
        get { return playerXp; }
        set { playerXp = value; }
    }

    public int PlayerLevelValue
    {
        get { return playerLevelValue; }
        set { playerLevelValue = value; }
    }

    public float PlayerNeededXp
    {
        get { return playerNeededXp; }
        set { playerNeededXp = value; }
    }

    public float ExperienceMultiplier 
    { 
        get { return experienceMultiplier; }
        set { experienceMultiplier = value; }
    }


    public void AddPlayerExperience(int xp)
    {
        playerXp += xp;
        xpSlider.value = playerXp;
        CheckForLevelUp();
    }

    public void UpdatePlayerLevelUI()
    {
        playerLvlText.text = $"Player Level : {playerLevelValue}";
    }    

    public void UpdateXpSlider()
    {
        xpSlider.value = playerXp;
        xpSlider.maxValue = playerNeededXp;
    }

    public void CheckForLevelUp()
    {
        if (playerXp >= playerNeededXp)
        {
            playerLevelValue++;
            playerXp = 0;
            playerNeededXp += playerNeededXp * experienceMultiplier;
            experienceMultiplier += 0.50f;
            UpdatePlayerLevelUI();
            UpdateXpSlider();
        }
    }
    
}