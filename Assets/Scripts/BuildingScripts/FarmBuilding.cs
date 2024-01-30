using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is used to manage the FarmBuilding.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>30-01-2024</lastModified>

public class FarmBuilding : BuildingScript
{
    private string nameResource = "Wheat";

    protected void Start()
    {
        base.Start();
    }

    public override void OnButtonClick()
    {
        base.OnButtonClick();
        ProduceResource(nameResource,1);
        resourceManager.DisplayResource(nameResource); 
    }
}
