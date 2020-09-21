using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour
{
    public GameObject V;
    // Скорость движения персонажа
    public float speed = 10;

     
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            V.transform.Translate(0,0,speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W)) 
        {
            V.transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            V.transform.Translate(0, 0, -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            V.transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            V.transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            V.transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            V.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            V.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}



