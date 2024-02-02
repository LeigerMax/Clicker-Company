using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is used to manage the FarmBuilding.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>02-02-2024</lastModified>

public class FarmBuilding : BuildingScript
{
    private readonly string nameResource = "Wheat";
    private readonly string buildingType = "Farm";

    private BuildingMenuUI buildingMenu;

    protected void Start()
    {
        base.Start();
        buildingMenu = GameManagerScript.Instance.GetBuildingMenu();
    }

    public override void OnButtonClick()
    {
        base.OnButtonClick();
        
        buildingMenu.ShowMenu(buildingType);
        
        ProduceResource(nameResource);
    }
}
