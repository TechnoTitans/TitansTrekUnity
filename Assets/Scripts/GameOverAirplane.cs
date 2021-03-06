using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverAirplane : MonoBehaviour
{
    public GameObject gameOverPanel;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void HomeButton(){
        SceneManager.LoadScene("map");
    }

    public void EndButton(){
        SceneManager.LoadScene("endScene");
    }
}
