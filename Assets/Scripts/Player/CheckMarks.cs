using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckMarks : MonoBehaviour
{
    public Text text;
    Check check;
    private void Start()
    {
        check = new Check();
        text.color = Color.black;
        check.A1 = false;
        check.B1 = false;
        check.C1 = false;
        check.D1 = false;
    }
    private void Update()
    {
        if(check.A1 && check.B1 && check.C1 && check.D1)
        {
            text.color = Color.green;
        }
    }
}
