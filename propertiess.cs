using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size_Color : MonoBehaviour
{

    public float X;
    public float Y;
    public float Z;
    public GameObject V;

    // Start is called before the first frame update
    void Start()
    {
        //V.transform.position= new Vector3(X,Y,Z);
        //V.transform.localScale = new Vector3(X, Y, Z);
        //V.transform.Rotate(X, Y, Z, Space.Self);
        V.GetComponent<Renderer>().material.color = Color.red;
        V.name = "Self";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
