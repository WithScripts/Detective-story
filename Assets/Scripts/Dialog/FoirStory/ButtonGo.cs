using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGo : MonoBehaviour
{
    public Button bt;
    public DialogM dm;
    public void Start()
    {
        dm.B = false;
    }
    public void Update()
    {
        if (dm.B)
        {
            bt.gameObject.SetActive(true);
        }
    }
}
