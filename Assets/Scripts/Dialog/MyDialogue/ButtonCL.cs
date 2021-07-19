using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonCL : MonoBehaviour
{
    public DialogM dm;
    private void Start()
    {
        dm.A = true;
    }
    private void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            if (dm.A == false)
            {
                dm.A = true;
                KeyCl();
            }        
        }
    }
    void KeyCl()
    {
        dm.DisplayNextSentence();
    }

}
