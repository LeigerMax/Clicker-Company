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
    private readonly float upgradeAmount;

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

    public void OnIdleUpgradeButtonPress(ref float score, ref float idleAmount)
    {
        if (!upgradeUnlocked && score >= upgradeCostUnlock) //TODO: Au lieu de payer avec le score, on va utiliser le nombre de clicks
        {
            score -= upgradeCostUnlock;
            this.upgradeUnlocked = true;
        }
        else if (score >= upgradeCost)
        {
            score -= upgradeCost;
            idleAmount += upgradeAmount;
            this.upgradeCost += 10;
            this.upgradeLvl++;
        }
    }

    public void OnClickUpgradeButtonPress(ref float score, ref float clickAmount)
    {
        if (!upgradeUnlocked && score >= upgradeCostUnlock) //TODO: Au lieu de payer avec le score, on va utiliser le nombre de clicks
        {
            score -= upgradeCostUnlock;
            this.upgradeUnlocked = true;
        }
        else if (score >= upgradeCost)
        {
            score -= upgradeCost;
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


