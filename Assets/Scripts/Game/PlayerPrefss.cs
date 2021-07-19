using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefss : MonoBehaviour
{
    AudioSource Auso;
    float floatToSave;
     void Start()
    {
        floatToSave = 0.0f;
        Auso = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey("SavedFloat"))
            LoadGame();
        Auso.volume = floatToSave;
    }
    private void Update()
    {
        Auso.volume = floatToSave;
    }
    public void OnGUI()
    {
        floatToSave = Auso.volume;
       // Debug.Log(Auso.volume);
        SaveGame();
    }
    void SaveGame()
    {
        PlayerPrefs.SetFloat("SavedFloat", floatToSave);
        PlayerPrefs.Save();
    }
    void LoadGame()
    {
            floatToSave = PlayerPrefs.GetFloat("SavedFloat");
    }
    public void SetV(float val)
    {
        floatToSave = val;
    }
}
