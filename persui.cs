using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class persui : MonoBehaviour
{

    public int apt = 0;
    public int ogon = 0;
    public Text txt1;
    public Text txt2;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        txt1.text = "Аптечка = " + apt;
        txt2.text = " Патроны =  " + ogon;
    }
}


