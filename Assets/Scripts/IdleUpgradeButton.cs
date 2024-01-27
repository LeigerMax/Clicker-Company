using UnityEngine.UI;

/// <summary>
/// This class is used to create an UpgradeButton object.
/// </summary>
public class IdleUpgradeButton 
{
    public int idleUpgradeCost;
    public int upgradeCostUnlock;
    public bool upgradeUnlocked = false;
    private readonly float idleUpgradeAmount;

    public Text idleUpgradeCostText;
    public Text idleUpgradeAmountText;

    public int upgradeLvl = 0;

    public IdleUpgradeButton(int idleUpgradeCost, Text idleUpgradeCostText, int upgradeCostUnlock, Text idleUpgradeAmountText, float idleUpgradeAmount)
    {
        this.idleUpgradeCost = idleUpgradeCost;
        this.idleUpgradeCostText = idleUpgradeCostText;
        this.upgradeCostUnlock = upgradeCostUnlock;
        this.idleUpgradeAmountText = idleUpgradeAmountText;
        this.idleUpgradeAmount = idleUpgradeAmount;
    }

    public void OnIdleUpgradeButtonPress(ref float score, ref float idleAmount)
    {
        if (!upgradeUnlocked && score >= upgradeCostUnlock) //TODO: Au lieu de payer avec le score, on va utiliser le nombre de clicks
        {
            score -= upgradeCostUnlock;
            this.upgradeUnlocked = true;
        }
        else if (score >= idleUpgradeCost)
        {
            score -= idleUpgradeCost;
            idleAmount += idleUpgradeAmount;
            this.idleUpgradeCost += 10;
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
        else if (score >= idleUpgradeCost)
        {
            score -= idleUpgradeCost;
            clickAmount += (int)idleUpgradeAmount;
            this.idleUpgradeCost += 10;
            this.upgradeLvl++;
        }
    }


    public void ButtonUiIdle()
    {
        this.idleUpgradeCostText.text = "Price : " + idleUpgradeCost + "$";
        this.idleUpgradeAmountText.text = "+ " + idleUpgradeAmount.ToString("0.0") + " per second";
    }

    public void ButtonUiClick()
    {
        if(this.idleUpgradeCost < 1000)
        {
            this.idleUpgradeCostText.text = "Price : " + idleUpgradeCost + "$";
        }
        else if(this.idleUpgradeCost >= 1000 && this.idleUpgradeCost < 1000000)
        {
            this.idleUpgradeCostText.text = "Price : " + (idleUpgradeCost / 1000).ToString("0.0") + "K$";
        }
        else if(this.idleUpgradeCost >= 1000000 && this.idleUpgradeCost < 1000000000)
        {
            this.idleUpgradeCostText.text = "Price : " + (idleUpgradeCost / 1000000).ToString("0.0") + "M$";
        }
    
        
        this.idleUpgradeAmountText.text = "+ " + idleUpgradeAmount + " per click";
    }

    public int getUpgradeLvl()
    {
        return this.upgradeLvl;
    }
}


