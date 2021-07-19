using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceForContinue : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas cs;
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            cs.gameObject.SetActive(false);
        }
    }
   
}
