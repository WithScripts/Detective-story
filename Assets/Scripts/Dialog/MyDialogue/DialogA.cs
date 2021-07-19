using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class DialogA : MonoBehaviour
{
    public Animator boxAnim;
    public DialogM dm;
    public DialogT dt;
    public void OnTriggerEnter2D(Collider2D other)
    {
        dm.A = false;
        if (Input.GetKey(KeyCode.E))
        {
            dt.TriggerDialog();
        }

    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            dt.TriggerDialog();
        }
    }
    public void OnTriggerExit2D(Collider2D  other)
    {
        boxAnim.SetBool("boxOpen", false);
        dm.EndDialogue();
    }
}
