using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    public GameObject notBuilding;
    public GameObject level1Building;

    protected int clickCounter = 0;

    protected ResourceManager resourceManager;

    protected void Start()
    {

        level1Building.SetActive(false);

        resourceManager = FindObjectOfType<ResourceManager>();
        if (resourceManager == null)
        {
            Debug.LogError("BuildingScript requires referencing to ResourceManager.");
        }
    }

    public virtual void OnButtonClick()
    {
        clickCounter++;

        if (clickCounter >= 10)
        {
            notBuilding.SetActive(false);
            level1Building.SetActive(true);
        }
    }

    public void ProduceResource(string nameResource, float quantity)
    {
        RessourcesScript existingResource = resourceManager.GetResourceByName(nameResource);

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
}
