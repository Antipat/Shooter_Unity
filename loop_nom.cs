using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop_nom : MonoBehaviour
{

    public Transform prefab;
    void Start()
    {
        for (int i = 1; i < 100; i++)
        {
            Instantiate(prefab, transform.position, transform.rotation);


            transform.position = transform.position + new Vector3(5, 0, 0);
        }
    }
}





//Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);