using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    [SerializeField] private GameObject notBuilding = null;
    [SerializeField] private GameObject level1Building = null;

    protected int clickCounter = 0;

    protected ResourceManager resourceManager;
    public BuildingCalculatorScript buildingCalculator;

    private string nameResourceProduct = null;


    private float production = 1;
    private int level = 1;
    private float upgradeCost = 5;
    private float multiplier = 2f;
    //private int prestige = 0;
    //private float prestigeMultiplierInterne = 1.0f;


    protected void Start()
    {
        level1Building.SetActive(false);
        resourceManager = FindObjectOfType<ResourceManager>();
    }


    public virtual void OnButtonClick()
    {
        clickCounter += (int)production;
        Debug.Log($"production: {production}");

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

    public void ProduceResource(string nameRessource)
    {
        ResourcesScript ressource = resourceManager.GetResourceByName(nameRessource);
        nameResourceProduct = nameRessource;
        ressource.AddQuantity(production);

    }


    //TODO : Check si nouveau prestige
    //buildingCalculator.NewPrestige(float prestigeMultiplier)

}
