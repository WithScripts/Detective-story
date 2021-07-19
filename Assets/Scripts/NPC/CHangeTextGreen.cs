using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHangeTextGreen : MonoBehaviour
{
    public int a;
    Check check;
    private void Start()
    {
        check = new Check();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (a == 1)
                check.ASet();
            else if (a == 2)
                check.BSet();
            else if (a == 3)
                check.CSet();
            else if (a == 4)
                check.DSet();
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (a == 1)
                check.ASet();
            else if (a == 2)
                check.BSet();
            else if (a == 3)
                check.CSet();
            else if (a == 4)
                check.DSet();
        }
    }
}
