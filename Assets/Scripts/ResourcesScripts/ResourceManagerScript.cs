using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// This class is used to store ressources in list. 
/// </summary>
/// <author> Maxou </author>
/// <lastModified>02-02-2024</lastModified>

public class ResourceManager : MonoBehaviour
{
    private List<ResourcesScript> resources = new List<ResourcesScript>();
    private readonly NumberConverter numberConverter = new NumberConverter();

    public void InitResource()
    {
        resources.AddRange(new[]
            {
                new ResourcesScript("Gold", 0),
                new ResourcesScript("Wheat", 0),
                new ResourcesScript("Wood", 0),
                new ResourcesScript("Stone", 0),
                new ResourcesScript("Iron", 0),
                new ResourcesScript("Diamond", 0)
            });
    }

    public void AddResource(ResourcesScript resource, float amount)
    {
        resource.AddQuantity(amount);
        resources.Add(resource);
    }

    public ResourcesScript GetResourceByName(string resourceName)
    {
        return resources.FirstOrDefault(resource => resource.ResourceName == resourceName);
    }

    public float GetResourceQuantityByName(string resourceName)
    {
        return GetResourceByName(resourceName)?.Quantity ?? 0f;
    }

    public void DisplayResources()
    {
        foreach (var resource in resources)
        {
            Debug.Log($"Resource: {resource.ResourceName}, Quantity: {numberConverter.UpdateUI(resource.Quantity)}");
        }
    }


    public void DisplayResourceLog(string resourceName)
    {
        var resource = GetResourceByName(resourceName);

        if (resource != null)
        {
            Debug.Log($"Resource: {resource.ResourceName}, Quantity: {resource.Quantity}");
        }
        else
        {
            Debug.Log($"Resource: {resourceName} not found.");
        }
    }

    public string DisplayResource(string resourceName)
    {
        var resource = GetResourceByName(resourceName);

        if (resource != null)
        {
            return $"{resource.ResourceName} : {numberConverter.UpdateUI(resource.Quantity)}";
        }
        else
        {
            return $"{resourceName} : 0";
        }
    }



}
