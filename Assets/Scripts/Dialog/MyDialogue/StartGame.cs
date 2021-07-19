using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public DialogT dt;
    public DialogM dm;
    public Animator anim;

    public void InfoAboutWork()
    {
        dt.TriggerDialog();
    }
    public void EndD()
    {
        dm.EndDialogue();
    }
}
