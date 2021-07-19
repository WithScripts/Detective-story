using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Back_to_game : MonoBehaviour
{
    public bool isOpened = false;
    float timer = 1;
    void Update()
    {
        if (GetComponent<Canvas>().enabled != isOpened /*|| GetComponent<Button>.enabled == true*/)
        {

            GetComponent<Canvas>().enabled = isOpened = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape))

            ShowHideMenu();

    }
    public void ShowHideMenu()
    {


        isOpened = !isOpened;
        if (Time.timeScale == 1 && GetComponent<Canvas>().enabled == !isOpened)
        {
            timer = 0;
            Time.timeScale = timer;
        }

        else if (Time.timeScale == 0 && GetComponent<Canvas>().enabled == !isOpened)
        {
            timer = 1;
            Time.timeScale = timer;
        }
        GetComponent<Canvas>().enabled = isOpened;

    }
}