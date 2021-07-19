using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogM : MonoBehaviour
{
    public Text dialogueText;
    public Text nameText;
    public Animator boxAnim;
    private static bool a;
    private static bool b;
    private static bool c;
    public static float speedtext;
    private Queue<string> sentences;
    public bool A
    {
        get { return a; }
        set { a = value; }
    }
    public bool B
    {
        get { return b; }
        set { b = value; }
    }
    public bool C
    {
        get { return c; }
        set { c = value; }
    }
    private void Start()
    {
        sentences = new Queue<string>();
        speedtext = 0.07f;
        c = false;

    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            speedtext = 0.001f;
        }
        else
            speedtext = 0.07f;
    }
    public void StartDialogue(Dialog dialog)
    {

        boxAnim.SetBool("boxOpen", true);
        nameText.text = dialog.name;
        sentences.Clear();
        foreach(string sentance in dialog.sentences)
        {
            sentences.Enqueue(sentance);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentance = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentance));
    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
     
            foreach (char letter in sentence.ToCharArray())
            {
                dialogueText.text += letter;
                yield return null;
                yield return new WaitForSeconds(speedtext);
           }
        b = true;
        a = false;
        c = true;
      
    }
    public void EndDialogue()
    {
   
        boxAnim.SetBool("boxOpen", false);
    }
}
