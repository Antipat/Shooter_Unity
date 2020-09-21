using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    // Переменные для капсулы
    public Transform G;
    // вектор для считывания положения мыши
    Vector2 currentMouseLook;
        

    void Start()
    {
        // блокируем курсор 
        Cursor.lockState = CursorLockMode.Locked;
        //получаем положение капсулы
        G = GetComponentInParent<move>().transform;
      }

    void Update()
    {
        // Создаём вектор, образованный от векторного произведения радиус-вектора с координатами положения мыши и единичного вектора
        Vector2 smoothMouseDelta = Vector2.Scale(new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")), Vector2.one);
       
        //Присваиваем новые координаты к положению мыши

        currentMouseLook += smoothMouseDelta;
        // выводим новые координаты мыши
        Debug.Log(currentMouseLook);

        // создаём ограничение по изменению положения мыши вдоль оси Y от -90 до 90
        currentMouseLook.y = Mathf.Clamp(currentMouseLook.y, -90, 90);

        // Поворачиваем камеру по оси X а капсулу по оси Y
        transform.localRotation = Quaternion.AngleAxis(-currentMouseLook.y, Vector3.right);
        G.localRotation = Quaternion.AngleAxis(currentMouseLook.x, Vector3.up);
    }
}
