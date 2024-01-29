using UnityEngine;

public class CityHallBuildingScript : BuildingScript
{
    public new GameObject level3Building;

    protected void Start()
    {
        base.Start();
        level3Building?.SetActive(false);
    }

    public override void OnButtonClick()
    {
        base.OnButtonClick();
        ProduceResource("Gold",1);
        resourceManager.DisplayResources(); 

        if (clickCounter >= 30)
        {
            if (level3Building != null)
            {
                level3Building.SetActive(true);
            }
        }
    }

}