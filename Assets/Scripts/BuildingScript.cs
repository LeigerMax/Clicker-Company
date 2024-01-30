using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    public GameObject notBuilding;
    public GameObject level1Building;

    protected int clickCounter = 0;

    protected ResourceManager resourceManager;
    public BuildingCalculatorScript buildingCalculator;

    private string nameResourceProduct = null;


    private float production = 1;
    private int level = 1;
    private float upgradeCost = 5;
    private float multiplier = 2f;
    private int prestige = 0;
    private float prestigeMultiplierInterne = 1.0f;

    protected void Start()
    {

        level1Building.SetActive(false);

        resourceManager = FindObjectOfType<ResourceManager>();
        if (resourceManager == null)
        {
            Debug.LogError("BuildingScript requires referencing to ResourceManager.");
        }
    }

    private void Update(){

    }

    public virtual void OnButtonClick()
    {
        clickCounter++;

        if (clickCounter >= 5)
        {
            notBuilding.SetActive(false);
            level1Building.SetActive(true);
        }

        
        float quantityRessource = resourceManager.GetResourceQuantityByName(nameResourceProduct);
        if(buildingCalculator.NewLevel(upgradeCost, quantityRessource)) {
            level++;
            (production, level, upgradeCost, multiplier) = buildingCalculator.CalculateBuildingStats(production, level, upgradeCost, multiplier);
        }

    }

    public void ProduceResource(string nameResource, float quantity)
    {
        RessourcesScript existingResource = resourceManager.GetResourceByName(nameResource);
        nameResourceProduct = nameResource;

        if (existingResource != null)
        {
            existingResource.AddQuantity(quantity);
        }
        else
        {
            RessourcesScript newResource = new RessourcesScript(nameResource, quantity);
            resourceManager.AddResource(newResource, quantity);
        }
    }


    //Check si nouveau prestige
    //buildingCalculator.NewPrestige(float prestigeMultiplier)

}
