using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroyLoad : MonoBehaviour
{

    public GameObject[] objects;

    void Awake()
    {
        foreach (var element in objects) 
        {
            DontDestroyOnLoad(element);
        }
    }


}
