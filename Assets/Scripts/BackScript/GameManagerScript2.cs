using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{

    public Text clickAmountText;
    public Text idleAmountText;
    
    private float clickAmount = 1;
    public int clickCounter = 0;

    private UgradeButton idleUpgradeButton2;
    public Text idleUpgrade2CostText;
    public Text idleUpgrade2AmountText;


    private UgradeButton idleUpgradeButton1;
    public Text idleUpgrade1CostText;
    public Text idleUpgrade1AmountText;

    private UgradeButton clickUpgradeButton1;
    public Text upgrade1CostText;
    public Text upgrade1AmountText;

    private UgradeButton clickUpgradeButton2;
    public Text upgrade2CostText;
    public Text upgrade2AmountText;

    private UgradeButton clickUpgradeButton3;
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
    [SerializeField] public MoneyScript money;
    [SerializeField] public IdleAmountScript idleAmountScript;

    private NumberConverter numberConverter = new NumberConverter();
    

    void Start()
    {
        clickUpgradeButton1 = new UgradeButton(10, upgrade1CostText, 10, upgrade1AmountText, 1);
        clickUpgradeButton2 = new UgradeButton(10, upgrade2CostText, 10, upgrade2AmountText, 1);
        clickUpgradeButton3 = new UgradeButton(10, upgrade3CostText, 10, upgrade3AmountText, 1);
        idleUpgradeButton1 = new UgradeButton(10, idleUpgrade1CostText, 10, idleUpgrade1AmountText, 0.1f);
        idleUpgradeButton2 = new UgradeButton(10, idleUpgrade2CostText, 10, idleUpgrade2AmountText, 0.5f);


        clickupgrade2Button.SetActive(false);
        clickupgrade3Button.SetActive(false);
        idleUpgradeButton.SetActive(false);

    }

    void FixedUpdate()
    {
        updateUI();
        money.AddMoney((idleAmountScript.IdleAmount / 60));

        playerLevel.UpdateXpSlider();

        if(clickUpgradeButton1.UpgradeLvl >= 10) {
            clickupgrade2Button.SetActive(true);
        }
        if(clickUpgradeButton2.UpgradeLvl >= 10) {
            clickupgrade3Button.SetActive(true);
        }
        if(playerLevel.PlayerLevelValue >= 2){
            idleUpgradeButton.SetActive(true);
        }

        GetComponent<SaveLoad>().SaveProfile();
    }

    private void updateUI()
    {
        clickAmountText.text = "Click :" + numberConverter.UpdateUI(clickAmount) +" per click";
        idleAmountText.text = "Idle :" + numberConverter.UpdateUI(idleAmountScript.IdleAmount) + " per second";

        upgrade1LvlText.text = "Level : " + clickUpgradeButton1.UpgradeLvl;
        upgrade2LvlText.text = "Level : " + clickUpgradeButton2.UpgradeLvl;
        upgrade3LvlText.text = "Level : " + clickUpgradeButton3.UpgradeLvl;

        clickUpgradeButton1.ButtonUiClick();
        clickUpgradeButton2.ButtonUiClick();
        clickUpgradeButton3.ButtonUiClick();
        idleUpgradeButton1.ButtonUiIdle();
        idleUpgradeButton2.ButtonUiIdle();
        
       playerLevel.UpdatePlayerLevelUI();
       money.UpdateMoneyUI();
    }

    public void onMainButtonPress()
    {
        money.AddMoney(clickAmount);
        clickCounter++;
        playerLevel.AddPlayerExperience(1);
    }

    public void onUpgrade1ButtonPress()
    {
        float getMoney =  money.Money;
        clickUpgradeButton1.OnClickUpgradeButtonPress(ref getMoney, ref clickAmount);
    }

    public void onUpgrade2ButtonPress()
    {
        float getMoney =  money.Money;
        clickUpgradeButton2.OnClickUpgradeButtonPress(ref getMoney, ref clickAmount);
    }

    public void onUpgrade3ButtonPress()
    {
        float getMoney =  money.Money;
        clickUpgradeButton3.OnClickUpgradeButtonPress(ref getMoney, ref clickAmount);
    }


    public void onIdleUpgrade1ButtonPress() {
        float getMoney =  money.Money;
        float getIdleAmount = idleAmountScript.IdleAmount;
        idleUpgradeButton1.OnIdleUpgradeButtonPress(ref getMoney, ref getIdleAmount);
        idleAmountScript.IdleAmount = getIdleAmount;
    }

    public void onIdleUpgrade2ButtonPress() {
        float getMoney =  money.Money;
        float getIdleAmount = idleAmountScript.IdleAmount;
        idleUpgradeButton2.OnIdleUpgradeButtonPress(ref getMoney, ref getIdleAmount);
        idleAmountScript.IdleAmount = getIdleAmount;
    }


}