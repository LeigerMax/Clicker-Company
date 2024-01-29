using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is used to store ressources in list. 
/// </summary>
/// <author> Maxou </author>
/// <lastModified>29-01-2024</lastModified>

public class ResourceManager : MonoBehaviour
{
    private List<RessourcesScript> resources = new List<RessourcesScript>();

    public void AddResource(RessourcesScript resource, float amount)
    {
        resource.AddQuantity(amount);
        resources.Add(resource);
    }


    public void DisplayResources()
    {
        foreach (var resource in resources)
        {
            Debug.Log($"Resource: {resource.ResourceName}, Quantity: {resource.Quantity}");
        }
    }

    public RessourcesScript GetResourceByName(string resourceName)
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

}
