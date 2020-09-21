using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    GameObject player;
    public Transform prefab;
    public Transform a;
    public Transform b;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
   void Update()
    {
       // Условие, если нажата левая кнопка мыши
            if (Input.GetMouseButtonDown(0))
        {
               if (player.GetComponent<persui>().ogon > 0)
                {
                // Создание пули в точки первой пустышки и с её ориентацией.
                a = Instantiate(prefab, transform.position, transform.rotation);
                // Указываем направление и величину скорости для параметра Rigidbody
                a.GetComponent<Rigidbody>().velocity = new Vector3
                    (a.transform.position.x - b.transform.position.x, a.transform.position.y - b.transform.position.y, a.transform.position.z - b.transform.position.z) * 10;
                
                // Уменьшаем количество патронов на единицу скаждым кликом мышки
                player.GetComponent<persui>().ogon -= 1;
                }

                else if (player.GetComponent<persui>().ogon <= 0)
                {
               player.GetComponent<persui>().ogon = 0;
                }
        }
    }
}

