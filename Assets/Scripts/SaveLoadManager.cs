using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    private float playerScore;

    void Start()
    {
        LoadName();
    }

    public void SaveName()
    {
        
        PlayerPrefs.SetFloat("PlayerScore", playerScore);
        PlayerPrefs.Save(); 
        Debug.Log("Game saved. Player's score: " + playerScore);
    }

    public void LoadName()
    {
        playerScore = PlayerPrefs.GetFloat("PlayerScore", 0f);
        Debug.Log("Game loaded. Player's score: " + playerScore);
    }
}
