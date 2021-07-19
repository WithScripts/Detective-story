using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
public class PF2 : MonoBehaviour
{
    float floatToSave;
    Slider sl;
    private void Start()
    {
        floatToSave = 0.0f;
        sl = GetComponent<Slider>();
        if (PlayerPrefs.HasKey("SavedFloat"))
            LoadGame();
        sl.value = floatToSave;
    }
    public void OnGUI()
    {
        floatToSave = sl.value;
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

}
