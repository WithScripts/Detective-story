using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private int k = 0; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (k== 0) {
                    Debug.Log("Hi");
                k++;
                }
            else
            {
                Debug.Log("Hi {0}"+k);
            }
        }
    }

}
