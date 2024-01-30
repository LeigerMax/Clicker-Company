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

    protected void Start()
    {
        base.Start();
        ProduceResource("Wheat",0);
    }

    public override void OnButtonClick()
    {
        base.OnButtonClick();
        ProduceResource("Wheat",1);
        resourceManager.DisplayResources(); 

    
    }
}
