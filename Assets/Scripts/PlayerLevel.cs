using UnityEngine;
using UnityEngine.UI;

public class PlayerLevel : MonoBehaviour
{
    public float playerXp = 0;
    public int playerLevel = 1;
    public float playerNeededXp = 100;

    public Slider xpSlider ;

    public Text playerLvlText;

    public PlayerLevel(Slider xpSlider, Text playerLvlText){
        this.xpSlider = xpSlider;
        this.playerLvlText = playerLvlText;
    }


    public void SetPlayerXp(int xp)
    {
        if (this.xpSlider != null)
        {
            this.playerXp += xp;
            this.xpSlider.value = playerXp;
        }
        LevelUp();
    }

    public void UpdateUI()
    {
        if (this.playerLvlText != null)
        {
            this.playerLvlText.text = "Player Level : " + this.playerLevel;
        }
    }    

    public void XpSliderChanged()
    {
        if (this.xpSlider != null)
        {
            this.xpSlider.value = this.playerXp;
            this.xpSlider.maxValue = this.playerNeededXp;
        }
    }

    public int GetPlayerLevel()
    {
        return this.playerLevel;
    }

    private void LevelUp()
    {
        if (playerXp >= playerNeededXp)
        {
            playerLevel++;
            playerXp = 0;
            playerNeededXp += playerNeededXp * .10f;
            UpdateUI();
            XpSliderChanged();
        }
    }

    
}