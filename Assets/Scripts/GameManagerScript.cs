using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{

    public float score = 0;
    public Text scoreText;

    public Text clickAmountText;
    public Text idleAmountText;

    public int upgrade1Cost = 25;
    public Text upgrade1CostText;

    public int upgrade2Cost = 100;
    public Text upgrade2CostText;
    public int upgrade2CostUnlock = 150;
    public bool upgrade2Unlocked = false;

    public int upgrade3Cost = 1000;
    public Text upgrade3CostText;


    public int idleUpgrade1Cost = 100;
    public Text idleUpgrade1CostText;

    public int idleUpgrade2Cost = 200;
    public Text idleUpgrade2CostText;


    public Text upgrade1AmountText;
    public Text upgrade2AmountText;
    public Text upgrade3AmountText;

    public Text idleUpgrade1AmountText;
    public Text idleUpgrade2AmountText;

    private int clickAmount = 1;
    private float idleAmount = 0.0f;

    private readonly int upgrade1Amount = 1;
    private readonly int upgrade2Amount = 5;
    private readonly int upgrade3Amount = 10;
    private readonly float idleUpgrade1Amount = 0.1f;
    private readonly float idleUpgrade2Amount = 1.0f;

   
    void Start()
    {
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

        upgrade1AmountText.text = "+ " + upgrade1Amount + " per click";
        upgrade2AmountText.text = "+ " + upgrade2Amount + " per click";
        upgrade3AmountText.text = "+ " + upgrade3Amount + " per click";

        idleUpgrade1AmountText.text = "+ " + idleUpgrade1Amount.ToString("0.0") + " per second";
        idleUpgrade2AmountText.text = "+ " + idleUpgrade2Amount.ToString("0.0") + " per second";

        upgrade1CostText.text = "Price : " + upgrade1Cost +"$";
        upgrade2CostText.text = "Price : " + upgrade2Cost +"$";
        upgrade3CostText.text = "Price : " + upgrade3Cost +"$";

        idleUpgrade1CostText.text = "Price : " + idleUpgrade1Cost + "$";
        idleUpgrade2CostText.text = "Price : " + idleUpgrade2Cost + "$";

    }

    public void onMainButtonPress()
    {
        score += clickAmount;
    }

    public void onUpgrade1ButtonPress()
    {
        if (score >= upgrade1Cost)
        {
            score -= upgrade1Cost;
            clickAmount += upgrade1Amount;
            upgrade1Cost += 10;
        }
    }

    public void onUpgrade2ButtonPress()
    {
        if (!upgrade2Unlocked && score >= upgrade2CostUnlock)
        {
            score -= upgrade2CostUnlock;
            upgrade2Unlocked = true;
        }
        else {
            if (score >= upgrade2Cost)
            {
                score -= upgrade2Cost;
                clickAmount += upgrade2Amount;
                upgrade2Cost += 25;
            }
        }
    }

    public void onUpgrade3ButtonPress()
    {
        if (score >= upgrade3Cost)
        {
            score -= upgrade3Cost;
            clickAmount += upgrade3Amount;
            upgrade3Cost += 50;
        }
    }

    public void onIdleUpgrade1ButtonPress()
    {
        if (score >= idleUpgrade1Cost)
        {
            score -= idleUpgrade1Cost;
            idleAmount += idleUpgrade1Amount;
            idleUpgrade1Cost += 10;
        }
    }

    public void onIdleUpgrade2ButtonPress()
    {
        if (score >= idleUpgrade2Cost)
        {
            score -= idleUpgrade2Cost;
            idleAmount += idleUpgrade2Amount;
            idleUpgrade2Cost += 25;
        }
    }

}