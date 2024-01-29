using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmBuilding : BuildingScript
{

    protected void Start()
    {
        base.Start();
    }

    public override void OnButtonClick()
    {
        base.OnButtonClick();
        ProduceResource("Wheat",1);
        resourceManager.DisplayResources(); 

    
    }
}
