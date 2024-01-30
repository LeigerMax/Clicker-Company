using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;


/// <summary>
/// This class is used to manage the BuildingCalculator.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>30-01-2024</lastModified>

public class BuildingCalculatorScript : MonoBehaviour
{
    private float bonus = 0;
    private float prestigeMultiplierInterne = 1.0f;
    

    public (float, int, float, float) CalculateBuildingStats(float production, int level, float upgradeCost, float multiplier)
    {
  
        int lastDigit = level % 10;
        int lastTwoDigits = level % 100;
        int lastThreeDigits = level % 1000;

        if(lastThreeDigits.ToString() == "000"){
            bonus = production * 100;
        }
        else if (lastTwoDigits.ToString() == "00"){
            bonus = production * 10;
        }
        else if (lastTwoDigits.ToString() == "25"){
            bonus = production * 5;
        }
        else if (lastTwoDigits.ToString() == "50"){
            bonus = production * 5;
        }
        else if (lastTwoDigits.ToString() == "75"){
            bonus = production * 5;
        }
        else if (lastDigit.ToString() == "0"){
            bonus = production * 3;
        }
        else {
            bonus = 0;
        }

        if(lastDigit == 1) {
            multiplier = 2;
        }
        else{
            multiplier = multiplier - 0.1f;
        }

        upgradeCost = upgradeCost*2;
        production = ((production*multiplier)+bonus)*prestigeMultiplierInterne;
        
        Debug.Log($"Level: {level}, Production: {production}, Upgrade Cost: {upgradeCost}, Multiplier: {multiplier}");
        return (production, level, upgradeCost, multiplier);
    }
    
    public float NewPrestige(float prestigeMultiplier){
        prestigeMultiplierInterne = prestigeMultiplier*1.001f;
        return prestigeMultiplierInterne;    
    }

    public bool NewLevel(float upgradeCost, float quantityRessource){
        if(quantityRessource >= upgradeCost) {
            return true;
        }
        return false;
    }
}
