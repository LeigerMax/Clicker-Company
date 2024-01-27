using UnityEngine;
using UnityEngine.UI;

public class PlayerLevel : MonoBehaviour
{
    [SerializeField] private float playerXp = 0;
    [SerializeField] private int playerLevel = 1;
    [SerializeField] private float playerNeededXp = 100;
    private float experienceMultiplier = .10f;

    [SerializeField] private Slider xpSlider;
    [SerializeField] private Text playerLvlText;


    public int PlayerLevelValue
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }

    public float PlayerNeededXp
    {
        get { return playerNeededXp; }
    }


    public void AddPlayerExperience(int xp)
    {
        playerXp += xp;
        xpSlider.value = playerXp;
        CheckForLevelUp();
    }

    public void UpdatePlayerLevelUI()
    {
        playerLvlText.text = $"Player Level : {playerLevel}";
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
            playerLevel++;
            playerXp = 0;
            playerNeededXp += playerNeededXp * experienceMultiplier;
            experienceMultiplier += 0.10f;
            UpdatePlayerLevelUI();
            UpdateXpSlider();
        }
    }
    
}