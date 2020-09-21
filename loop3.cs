using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop3 : MonoBehaviour
{    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        do
            {
                // i++;
                i = i + 1; 
                Debug.Log("Число i = " + i.ToString());

                if (i >= 100)
                {
                    break;
                }
            }

            while (i > 0);

        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
