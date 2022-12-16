using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManager;

public class UiManager : MonoBehaviour
{
    
    
    void Awake()
    {
        ManageSingleton();

    }
    






    void ManageSingleton()
    
    {
        int instance = FindObjectsofType(GetType()).length;

        if(instance >=1)
        {
            Destroy(gameObject);
        }

    }


    void Play()
    {
        
    }

    void Exit()
    {

    }

}
