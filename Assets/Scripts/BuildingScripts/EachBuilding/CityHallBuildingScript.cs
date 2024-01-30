using UnityEngine;

/// <summary>
/// This class is used to manage the CityHallBuilding.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>30-01-2024</lastModified>

public class CityHallBuildingScript : BuildingScript
{
    public new GameObject level3Building;
    private string nameResource = "Gold";

    protected void Start()
    {
        base.Start();
        level3Building?.SetActive(false);
    }

    public override void OnButtonClick()
    {
        base.OnButtonClick();
        ProduceResource(nameResource,1);
        resourceManager.DisplayResource(nameResource); 

        if (clickCounter >= 2560)
        {
            if (level3Building != null)
            {
                level3Building.SetActive(true);
            }
        }
    }

}