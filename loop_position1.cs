using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop_position1 : MonoBehaviour
{
    
     public GameObject V;

    int j;

    float f;
    
    IEnumerator MoveObject() {

        yield return new WaitForSeconds(1000);
        //for (int i = 0; i < 100; i++)
        //{
          // float m = 1.0f * Time.deltaTime;
            //V.transform.Translate(m, 0, 0);
           // V.transform.position = V.transform.position + new Vector3(m, 0,0);
           // f = V.transform.position.x;
           // Debug.Log(f);
           // yield return new WaitForSeconds(0);
        //}
        //Debug.Log("Цикл пройден!");
        //f1 = f;
    }//
//StartCoroutine(MoveObject());


    void Start()
    {
        
    }

     void B() {
        // Цикл на сто шагов
        for (int i = 0; i < 100; i++)
        {
            // Переменная m со значением завязанным со временем отрисовки кадра
            float m = -0.1f * Time.deltaTime;
            // Установки нового положения объекта 
           // V.transform.position = V.transform.position + new Vector3(m, 0, 0);

            V.transform.Translate(m, 0, 0);
            // Вывод изменённой координаты x игрового объекта
            Debug.Log(V.transform.position.x);
            
        }
        // После завершения цикла вывести текст.
        Debug.Log("Цикл пройден!");
      }
    //  StopCoroutine(StartCoroutine(MoveObject()));/StartCoroutine(MoveObject());
    // Update is called once per frame
    void Update()
    {
        
       if (j >= 200)
       {
         V.transform.position = new Vector3(V.transform.position.x, V.transform.position.y, V.transform.position.z);
       }

       else {            
           B();
        }
       j = j + 1;
               
    }
    
}


