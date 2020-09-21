using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop1 : MonoBehaviour
{
    
    void Start()
    {
        for (int i = 100; i < 1; i=i/2)
        {
            Debug.Log("Число i = " + i.ToString());       
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
