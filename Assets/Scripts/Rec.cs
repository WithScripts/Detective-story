using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Rec : MonoBehaviour
{
    private int k;
    public Text tx;
    public void Start()
    {
        k = 0;
    }
    public void RightQUesT()
    {
        k += 1;
    }
    public void AfterQuest()
    {
        string a;
        a = k + " из 5";
        tx.text = a;
    }
}
