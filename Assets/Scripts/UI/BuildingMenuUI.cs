using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class is used to manage the building menu UI.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>02-02-2024</lastModified>

public class BuildingMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject buttonPrefab;

    public void ShowMenu(string buildingType)
    {

        ClearMenu();

        if (buildingType == "CityHall")
        {
            CreateButton("Upgrade", OnUpgradeButtonClick);
            CreateButton("Collect Taxes", OnCollectTaxesButtonClick);
            CreateButton("Info", OnInfoButtonClick);
            CreateButton("Test", OnInfoButtonClick);
        }
        else if (buildingType == "Farm")
        {
            CreateButton("Harvest", OnHarvestButtonClick);
            CreateButton("Upgrade", OnUpgradeButtonClick);
        }
    }

    private void CreateButton(string label, UnityEngine.Events.UnityAction action)
    {
        GameObject button = Instantiate(buttonPrefab, transform);
        button.GetComponentInChildren<Text>().text = label;
        button.GetComponent<Button>().onClick.AddListener(action);
    }

     private void ClearMenu()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    private void OnUpgradeButtonClick()
    {
        Debug.Log("Upgrade clicked");
        
    }

    private void OnCollectTaxesButtonClick()
    {
        Debug.Log("Collect Taxes clicked");
    }

    private void OnInfoButtonClick()
    {
        Debug.Log("Info clicked");
    }

    private void OnHarvestButtonClick()
    {
        Debug.Log("Harvest clicked");
    }

}
