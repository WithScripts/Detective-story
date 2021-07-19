using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Back", true);
            anim.SetBool("Front", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
            anim.SetBool("AfkBack", false);
            anim.SetBool("AfkFront", false);
            anim.SetBool("AfkLeft", false);
            anim.SetBool("AfkRight", false);
        }
      /*  if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("walk_to_up", true);
        }*/
        else if (Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S))
        {

            anim.SetBool("Back", false);
            anim.SetBool("Front", true);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
            anim.SetBool("AfkBack", false);
            anim.SetBool("AfkFront", false);
            anim.SetBool("AfkLeft", false);
            anim.SetBool("AfkRight", false);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            anim.SetBool("Back", false);
            anim.SetBool("Front", false);
            anim.SetBool("Left", true);
            anim.SetBool("Right", false);
            anim.SetBool("AfkBack", false);
            anim.SetBool("AfkBack", false);
            anim.SetBool("AfkFront", false);
            anim.SetBool("AfkLeft", false);
            anim.SetBool("AfkRight", false);
        }
        else if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D)){
            anim.SetBool("Back", false);
            anim.SetBool("Front", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", true);
            anim.SetBool("AfkBack", false);
            anim.SetBool("AfkBack", false);
            anim.SetBool("AfkFront", false);
            anim.SetBool("AfkLeft", false);
            anim.SetBool("AfkRight", false);
        }
        else {
            if (anim.GetBool("Back")){
            anim.SetBool("Back", false);
            anim.SetBool("Front", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
            anim.SetBool("AfkBack", true);
            anim.SetBool("AfkFront", false);
            anim.SetBool("AfkLeft", false);
            anim.SetBool("AfkRight", false);
            }
            else if (anim.GetBool("Left")){
            anim.SetBool("Back", false);
            anim.SetBool("Front", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
            anim.SetBool("AfkBack", false);
            anim.SetBool("AfkFront", false);
            anim.SetBool("AfkLeft", true);
            anim.SetBool("AfkRight", false);
            }
            else if (anim.GetBool("Right")){
            anim.SetBool("Back", false);
            anim.SetBool("Front", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
            anim.SetBool("AfkBack", false);
            anim.SetBool("AfkFront", false);
            anim.SetBool("AfkLeft", false);
            anim.SetBool("AfkRight", true);
            }
            else if (anim.GetBool("Front")){
            anim.SetBool("Back", false);
            anim.SetBool("Front", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
            anim.SetBool("AfkBack", false);
            anim.SetBool("AfkFront", true);
            anim.SetBool("AfkLeft", false);
            anim.SetBool("AfkRight", false);
            }
        }
    }
}
