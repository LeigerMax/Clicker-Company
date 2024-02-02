using UnityEngine;

/// <summary>
/// This class is used to manage the CityHallBuilding.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>02-02-2024</lastModified>

public class CityHallBuildingScript : BuildingScript
{
    [SerializeField] private GameObject level3Building;

    private readonly string nameResource = "Gold";
    private readonly string buildingType = "CityHall";

    private BuildingMenuUI buildingMenu;

    protected void Start()
    {
        base.Start();
        level3Building?.SetActive(false);
        buildingMenu = GameManagerScript.Instance.GetBuildingMenu();
    }

    public override void OnButtonClick()
    {
        base.OnButtonClick();

        buildingMenu.ShowMenu(buildingType);

        ProduceResource(nameResource);

        if (clickCounter >= 2560  && level3Building != null)
        {
            level3Building.SetActive(true);
        }
    }

}