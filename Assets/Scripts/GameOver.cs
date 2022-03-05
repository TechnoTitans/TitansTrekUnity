using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject HelmetPixel;    

    void OnTriggerEnter2D(Collider2D HelmetPixel)
    {
        if (HelmetPixel.CompareTag("Terrain"))
        {
            gameOverMenu.SetActive(true);
            Time.timeScale = 0f;
            Destroy(gameObject);
        }
    }
}
