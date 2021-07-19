using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Da : MonoBehaviour
{
    private bool k = true;
    public DialogT dt;
    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (k)
            {
             
                dt.TriggerDialog();
                k = false;
            }
        }
    }

}
