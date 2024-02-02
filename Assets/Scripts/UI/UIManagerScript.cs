using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class is used to manage the UI resources.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>02-02-2024</lastModified>

public class UIManager : MonoBehaviour
{
    [SerializeField] private ResourceManager resourceManager;
    [SerializeField] private Text goldText;
    [SerializeField] private Text wheatText;

    private void Start()
    {
        resourceManager = FindObjectOfType<ResourceManager>();
    }

    public void UpdateResourceUI()
    {
        goldText.text = resourceManager.DisplayResource("Gold");
        wheatText.text = resourceManager.DisplayResource("Wheat");
    }

}   
