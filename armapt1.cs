using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armapt1 : MonoBehaviour
{
    GameObject player;
    public int o;
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
            // Начисление значения переменной ogon
            player.GetComponent<persui>().ogon += o;
            // уничтожение объекта, если его тригера коснулись
           Destroy(this.gameObject);
        }
   }
}



