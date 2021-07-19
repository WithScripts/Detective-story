using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    private static bool A;
    private static bool B;
    private static bool C;
    private static bool D;
    private void Start()
    {
        A = false;
        B = false;
        C = false;
        D = false;
    }
    public bool A1
    {
        get { return A; }
        set { A = value; }
    }
    public bool B1
    {
        get { return B; }
        set { B = value; }
    }
    public bool C1
    {
        get { return C; }
        set { C = value; }
    }
    public bool D1
    {
        get { return D; }
        set { D = value; }
    }
    public void ASet()
    {
        A = true;
    }
    public void BSet()
    {
        B = true;
    }
    public void CSet()
    {
        C = true;
    }
    public void DSet()
    {
        D = true;
    }
}
