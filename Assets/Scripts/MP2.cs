using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP2 : MonoBehaviour
{
    DialogM dm;
    public AudioSource audioSource;
    bool check;
    void Start()
    {
        
        dm = new DialogM();
        check = false;
        dm.C = false;
    }

    public void Clicl()
    {
        check = true;
    }
    public void Clicl2()
    {
        dm.C = false;
        audioSource.gameObject.SetActive(false);
    }
    void Update()
    {
        if (check)
        {
            audioSource.gameObject.SetActive(true);
            audioSource.Play();
            check = false;
        }
        if (dm.C)
            audioSource.Stop();
    }
}
