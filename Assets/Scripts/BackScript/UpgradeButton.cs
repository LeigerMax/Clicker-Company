using UnityEngine.UI;

/// <summary>
/// The class is used for managing the upgrade buttons.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>27-01-2024</lastModified>

public class UgradeButton 
{
    public int upgradeCost;
    public int upgradeCostUnlock;
    public bool upgradeUnlocked = false;
    public float upgradeAmount;
    public int maxUpgradeLevel = 100;

    public Text upgradeCostText;
    public Text upgradeAmountText;
    private NumberConverter numberConverter = new NumberConverter();

    public int upgradeLvl = 0;

    public int UpgradeLvl
    {
        get { return upgradeLvl; }
        set { upgradeLvl = value; }
    }

    public UgradeButton(int upgradeCost, Text upgradeCostText, int upgradeCostUnlock, Text upgradeAmountText, float upgradeAmount)
    {
        this.upgradeCost = upgradeCost;
        this.upgradeCostText = upgradeCostText;
        this.upgradeCostUnlock = upgradeCostUnlock;
        this.upgradeAmountText = upgradeAmountText;
        this.upgradeAmount = upgradeAmount;
    }

    public void OnIdleUpgradeButtonPress(ref float money, ref float idleAmount)
    {
        if (!upgradeUnlocked && money >= upgradeCostUnlock) 
        {
            money -= upgradeCostUnlock;
            this.upgradeUnlocked = true;
        }
        else if (money >= upgradeCost && upgradeLvl < maxUpgradeLevel)
        {
            money -= upgradeCost;
            idleAmount += upgradeAmount;
            this.upgradeCost += 10;
            this.upgradeLvl++;
        }
    }

    public void OnClickUpgradeButtonPress(ref float money, ref float clickAmount)
    {
        if (!upgradeUnlocked && money >= upgradeCostUnlock) 
        {
            money -= upgradeCostUnlock;
            this.upgradeUnlocked = true;
        }
        else if (money >= upgradeCost && upgradeLvl < maxUpgradeLevel)
        {
            money -= upgradeCost;
            clickAmount += (int)upgradeAmount;
            this.upgradeCost += 10;
            this.upgradeLvl++;
        }
    }


    public void ButtonUiIdle()
    {
        this.upgradeCostText.text = "Price :" + numberConverter.UpdateUI(upgradeCost) +"$";
        this.upgradeAmountText.text = "+ " + numberConverter.UpdateUI(upgradeAmount)  + " per second";
    }

    public void ButtonUiClick()
    {
        this.upgradeCostText.text = "Price :" + numberConverter.UpdateUI(upgradeCost) +"$";
        this.upgradeAmountText.text = "+ " + numberConverter.UpdateUI(upgradeAmount)  + " per click";
    }

}


