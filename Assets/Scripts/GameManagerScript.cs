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

   
    void Start()
    {
        clickUpgradeButton1 = new IdleUpgradeButton(10, upgrade1CostText, 10, upgrade1AmountText, 1);
        clickUpgradeButton2 = new IdleUpgradeButton(10, upgrade2CostText, 10, upgrade2AmountText, 1);
        clickUpgradeButton3 = new IdleUpgradeButton(10, upgrade3CostText, 10, upgrade3AmountText, 1);
        idleUpgradeButton1 = new IdleUpgradeButton(10, idleUpgrade1CostText, 10, idleUpgrade1AmountText, 0.1f);
        idleUpgradeButton2 = new IdleUpgradeButton(10, idleUpgrade2CostText, 10, idleUpgrade2AmountText, 0.5f);
    }

    void FixedUpdate()
    {
        updateUI();
        score += (idleAmount / 60);
    }

    private void updateUI()
    {
        scoreText.text = "Score : " + score.ToString("0.0");
        clickAmountText.text = "Click Amount : " + clickAmount + " per click";
        idleAmountText.text = "Idle Amount : " + idleAmount.ToString("0.0") + " per second";

        clickUpgradeButton1.ButtonUiClick();
        clickUpgradeButton2.ButtonUiClick();
        clickUpgradeButton3.ButtonUiClick();
        idleUpgradeButton1.ButtonUiIdle();
        idleUpgradeButton2.ButtonUiIdle();

    }

    public void onMainButtonPress()
    {
        score += clickAmount;
        clickCounter += 1;
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