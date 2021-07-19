using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicPLAY : MonoBehaviour
{
    DialogM dm;
    public AudioSource audioSource;
    bool check;
    void Start()
    {
        dm = new DialogM();
        check = true;
        dm.C = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&&check)
        {
            audioSource.gameObject.SetActive(true);
            check = false;
            
        }
        if (dm.C)
            audioSource.Stop();
    }
}
