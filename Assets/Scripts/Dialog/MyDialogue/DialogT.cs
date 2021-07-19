using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogT : MonoBehaviour
{
    public Dialog dialog;
    public void TriggerDialog()
    {
        FindObjectOfType<DialogM>().StartDialogue(dialog);
    }
}
