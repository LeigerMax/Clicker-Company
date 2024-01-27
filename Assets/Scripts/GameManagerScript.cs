using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{

    public float score = 0;
    public Text scoreText;

    public Text clickAmountText;
    public Text idleAmountText;

    
    private int clickAmount = 1;
    private int clickCounter = 0;
    private float idleAmount = 0.0f;

    private IdleUpgradeButton idleUpgradeButton2;
    public Text idleUpgrade2CostText;
    public Text idleUpgrade2AmountText;


    private IdleUpgradeButton idleUpgradeButton1;
    public Text idleUpgrade1CostText;
    public Text idleUpgrade1AmountText;

    private IdleUpgradeButton clickUpgradeButton1;
    public Text upgrade1CostText;
    public Text upgrade1AmountText;

    private IdleUpgradeButton clickUpgradeButton2;
    public Text upgrade2CostText;
    public Text upgrade2AmountText;

    private IdleUpgradeButton clickUpgradeButton3;
    public Text upgrade3CostText;
    public Text upgrade3AmountText;


    //LEVEL
    public GameObject clickupgrade1Button;
    public GameObject clickupgrade2Button;
    public GameObject clickupgrade3Button;


    public GameObject idleUpgradeButton;

    public Text upgrade1LvlText;
    public Text upgrade2LvlText;
    public Text upgrade3LvlText;

    [SerializeField] public PlayerLevel playerLevel;


    void Start()
    {
        clickUpgradeButton1 = new IdleUpgradeButton(10, upgrade1CostText, 10, upgrade1AmountText, 1);
        clickUpgradeButton2 = new IdleUpgradeButton(10, upgrade2CostText, 10, upgrade2AmountText, 1);
        clickUpgradeButton3 = new IdleUpgradeButton(10, upgrade3CostText, 10, upgrade3AmountText, 1);
        idleUpgradeButton1 = new IdleUpgradeButton(10, idleUpgrade1CostText, 10, idleUpgrade1AmountText, 0.1f);
        idleUpgradeButton2 = new IdleUpgradeButton(10, idleUpgrade2CostText, 10, idleUpgrade2AmountText, 0.5f);


        clickupgrade2Button.SetActive(false);
        clickupgrade3Button.SetActive(false);
        idleUpgradeButton.SetActive(false);
    }

    void FixedUpdate()
    {
        updateUI();
        score += (idleAmount / 60);

        playerLevel.UpdateXpSlider();

        if(clickUpgradeButton1.getUpgradeLvl() >= 10) {
            clickupgrade2Button.SetActive(true);
        }
        if(clickUpgradeButton2.getUpgradeLvl() >= 10) {
            clickupgrade3Button.SetActive(true);
        }
        if(playerLevel.PlayerLevelValue >= 2){
            idleUpgradeButton.SetActive(true);
        }
    }

    private void updateUI()
    {
        scoreText.text = "Score : " + score.ToString("0.0");
        clickAmountText.text = "Click Amount : " + clickAmount + " per click";
        idleAmountText.text = "Idle Amount : " + idleAmount.ToString("0.0") + " per second";

        upgrade1LvlText.text = "Level : " + clickUpgradeButton1.getUpgradeLvl();
        upgrade2LvlText.text = "Level : " + clickUpgradeButton2.getUpgradeLvl();
        upgrade3LvlText.text = "Level : " + clickUpgradeButton3.getUpgradeLvl();

        clickUpgradeButton1.ButtonUiClick();
        clickUpgradeButton2.ButtonUiClick();
        clickUpgradeButton3.ButtonUiClick();
        idleUpgradeButton1.ButtonUiIdle();
        idleUpgradeButton2.ButtonUiIdle();
        
       playerLevel.UpdatePlayerLevelUI();
    }

    public void onMainButtonPress()
    {
        score += clickAmount;
        clickCounter++;
        playerLevel.AddPlayerExperience(1);
    }

    public void onUpgrade1ButtonPress()
    {
        clickUpgradeButton1.OnClickUpgradeButtonPress(ref score, ref clickAmount);
    }

    public void onUpgrade2ButtonPress()
    {
        clickUpgradeButton2.OnClickUpgradeButtonPress(ref score, ref clickAmount);
    }

    public void onUpgrade3ButtonPress()
    {
        clickUpgradeButton3.OnClickUpgradeButtonPress(ref score, ref clickAmount);
    }


    public void onIdleUpgrade1ButtonPress() {
        idleUpgradeButton1.OnIdleUpgradeButtonPress(ref score, ref idleAmount);
    }

    public void onIdleUpgrade2ButtonPress() {
        idleUpgradeButton2.OnIdleUpgradeButtonPress(ref score, ref idleAmount);
    }


}