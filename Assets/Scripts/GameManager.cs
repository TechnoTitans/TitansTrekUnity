using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool GameIsOver;
    
    public string nextLevel = "Level2";
    public int levelToUnlock = 2;

    void Start()
    {
        GameIsOver = false;    
    }

    void EndGame() {
        GameIsOver = true;
    }

    public void WinLevel(){
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
    }
}

