using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameENding : MonoBehaviour
{
    public Animator anim;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            anim.SetBool("ActiveGE", true);
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            anim.SetBool("ActiveGE", true);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("ActiveGE", false);
    }
    public void CloseEG()
    {
        anim.SetBool("ActiveGE", false);
    }

}
