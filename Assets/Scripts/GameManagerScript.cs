using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField] private ResourceManager resourceManager;
    [SerializeField] private UIManager uIManager;
    [SerializeField] private BuildingMenuUI buildingMenu;

    // Singleton pattern for GameManagerScript
    private static GameManagerScript instance;
    public static GameManagerScript Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManagerScript>();
            }
            return instance;
        }
    }

    void Start()
    {
      resourceManager.InitResource(); 
    }


    void Update()
    {
      uIManager.UpdateResourceUI();
    }


    public BuildingMenuUI GetBuildingMenu()
    {
        return buildingMenu;
    }

}
