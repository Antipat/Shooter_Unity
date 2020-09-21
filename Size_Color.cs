using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propertiess : MonoBehaviour
{
    public GameObject V;
    public float X;
    public float Y;
    public float Z;
    public string color1;
        
    void Start()
    {
        V.name = "Кубик";
        V.transform.position= new Vector3(X,Y,Z);
        V.transform.localScale = new Vector3(X, Y, Z);
        V.transform.Rotate(X, Y, Z, Space.Self);

        if (color1 == "red")
        {
            V.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (color1 == "blue")
        {
            V.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (color1 == "green")
        {
            V.GetComponent<Renderer>().material.color = Color.green;
        }
    }
    void Update()
    {
       
    }
}


//
//
        //
        //
        //
       // 