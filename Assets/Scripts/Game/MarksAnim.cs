using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class MarksAnim : MonoBehaviour
{
    public Animator animator;
    public Text text;
    bool check;
    private void Start()
    {
        check = false;
    }
    public void AnimOff()
    {
        if (check == false)
        {
            check = true;
            animator.SetBool("SGMR", true);
            text.text = "ON";
        }
        else
        {
            check = false;
            animator.SetBool("SGMR", false);
            text.text = "OFF";
        }
    }
}
