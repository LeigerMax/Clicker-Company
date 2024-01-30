using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// This class is used to store ressources in list. 
/// </summary>
/// <author> Maxou </author>
/// <lastModified>29-01-2024</lastModified>

public class ResourceManager : MonoBehaviour
{
    private List<ResourcesScript> resources = new List<ResourcesScript>();

    public void Start()
    {
        //InitRessource();
    }

    public void InitResource(){
        resources.Add(new ResourcesScript("Gold", 0));
        resources.Add(new ResourcesScript("Wheat",0));
        resources.Add(new ResourcesScript("Wood", 0));
        resources.Add(new ResourcesScript("Stone", 0));
        resources.Add(new ResourcesScript("Iron", 0));
        resources.Add(new ResourcesScript("Diamond", 0));
    }

    public void AddResource(ResourcesScript resource, float amount)
    {
        resource.AddQuantity(amount);
        resources.Add(resource);
    }

    public ResourcesScript GetResourceByName(string resourceName)
    {
        foreach (var resource in resources)
        {
            if (resource.ResourceName == resourceName)
            {
                return resource;
            }
        }
        return null;
    }

    public float GetResourceQuantityByName(string resourceName)
    {
        foreach (var resource in resources)
        {
            if (resource.ResourceName == resourceName)
            {
                return resource.Quantity;
            }
        }
        return 0f;
    }

    public void DisplayResources()
    {
        foreach (var resource in resources)
        {
            Debug.Log($"Resource: {resource.ResourceName}, Quantity: {resource.Quantity}");
        }
    }


    public void DisplayResource(string resourceName)
    {
        var resource = resources.FirstOrDefault(r => r.ResourceName == resourceName);

        if (resource != null)
        {
            Debug.Log($"Resource: {resource.ResourceName}, Quantity: {resource.Quantity}");
        }
        else
        {
            Debug.Log($"Resource: {resourceName} not found.");
        }
    }



}
