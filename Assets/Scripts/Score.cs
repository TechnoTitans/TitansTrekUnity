using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int scoreVal;
    public GameObject congratsScene;
    public GameObject Helmet;
    
    void Update()
    {
        scoreText.text = player.position.x.ToString("0") + "m";
        scoreVal = (int)player.position.x;

        if (scoreVal == 1000)
        {
            congratsScene.SetActive(true);
            Destroy(Helmet);

        }
    }
}
