using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMangerScript : MonoBehaviour
{
    [SerializeField]private ResourceManager resourceManager;

    void Start()
    {
      resourceManager.InitResource(); 
    }


    void Update()
    {
    

    
    }


}
