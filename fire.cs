using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Касание тригера объекта
    void OnTriggerEnter(Collider col)
    {
        // Кто касается тригера
        if (col.tag == "des")
        {
            // уничтожение объекта, если его тригера коснулись
            Destroy(this.gameObject);
        }
    }
}
