using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change2 : MonoBehaviour
{
    public int a;
    Check2 check;
    private void Start()
    {
        check = new Check2();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (a == 1)
                check.A2Set();
            else if (a == 2)
                check.B2Set();
            else if (a == 3)
                check.C2Set();
            else if (a == 4)
                check.D2Set();
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (a == 1)
                check.A2Set();
            else if (a == 2)
                check.B2Set();
            else if (a == 3)
                check.C2Set();
            else if (a == 4)
                check.D2Set();
        }
    }
}
