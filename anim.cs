using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public Animator an;
    public bool s;
    public bool d;
    public bool f;

    // Start is called before the first frame update
    void Start()
    {
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            d = true;
            s = false;
            f = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            d = true;
            s = false;
            f = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            d = true;
            s = false;
            f = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            d = true;
            s = false;
            f = false;
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            f = true;
            s = false;
            d = false;
        }
        an.SetBool("s", s);
        an.SetBool("d", d);
        an.SetBool("f", f);
    }
}
