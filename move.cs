using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public GameObject pers;
    // Скорость движения персонажа
    public float speed = 10;
    // направление движения персонажа по осям X и Z
    Vector2 drive;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // Вычисляем координаты вектора направления 
        drive.x = Input.GetAxis("Horizontal")*speed * Time.deltaTime;
        drive.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        // перемещаем персонажа согласно полученным координатам
        pers.transform.Translate(drive.x, 0, drive.y);

        if (Input.GetKey(KeyCode.Space))
        {
            pers.transform.Translate(0, speed * Time.deltaTime, 0 );
        }

    }
}






