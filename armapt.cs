using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armapt : MonoBehaviour
{
    GameObject player;
    public int a;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    // Касание тригера объекта
    void OnTriggerEnter(Collider col)
    {
        // Кто касается тригера
        if (col.tag == "Player")
        {
            // Начисление значения переменной apt
            player.GetComponent<persui>().apt += a;
            // уничтожение объекта, если его тригера коснулись
           Destroy(this.gameObject);
        }
   }
}



