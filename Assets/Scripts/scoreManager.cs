using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
    public GameObject gameWonPanel;
    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        score += 1 * Time.deltaTime;
        scoreText.text = ((int)score).ToString();

        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            score = ((int)score);
        }

        if(score == 20){
            gameManager.WinLevel();
            gameWonPanel.SetActive(true);
        }

    }
}
